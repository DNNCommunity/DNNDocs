using Docfx.Common;
using Octokit;

namespace DNNCommunity.DNNDocs.Plugins.Providers
{
    public class GitHubApi
    {
        private readonly string? token;
        private readonly GitHubClient client;

        private const int RateLimitThreshold = 100; // Start warning if less than this many calls remain for the hour.
        private const int MaxDelayMs = 5000; // Maximum progressive-backoff delay of 5 seconds.
        private const double ExponentialBase = 1.5; // Exponential base for progressive backoff.

        public GitHubApi()
        {
            DotNetEnv.Env.Load(); // Loads .env file if it exists, into environment variables.
            client = new GitHubClient(new ProductHeaderValue("DNNDocsPlugin"));
            // Prevent any single API call from hanging indefinitely.
            client.Connection.SetRequestTimeout(TimeSpan.FromSeconds(30));

            var skip = Environment.GetEnvironmentVariable("SKIP_CONTRIBUTORS") == "true";
            if (!skip)
            {
                // Prefer a PAT (ACCESS_TOKEN) for higher rate limits; fall back to GithubToken (GITHUB_TOKEN in CI).
                this.token = Environment.GetEnvironmentVariable("ACCESS_TOKEN");
                if (string.IsNullOrEmpty(this.token))
                {
                    this.token = Environment.GetEnvironmentVariable("GithubToken");
                }
            }
            else
            {
                Logger.LogInfo("[RepoStats] SKIP_CONTRIBUTORS=true — all GitHub API calls will be skipped.");
            }

            if (!string.IsNullOrEmpty(this.token))
            {
                client.Credentials = new Credentials(this.token);
            }

            try
            {
                var rateLimits = client.RateLimit.GetRateLimits().GetAwaiter().GetResult();
                Logger.LogInfo($"[RepoStats] GitHub API remaining: {rateLimits.Resources.Core.Remaining}/{rateLimits.Resources.Core.Limit}, resets at: {rateLimits.Resources.Core.Reset}");
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"[RepoStats] Could not retrieve GitHub rate limit info: {ex.Message}");
            }
        }

        /// <summary>
        /// Derives contributor stats from commit history, avoiding the GitHub Statistics API
        /// which returns 202 indefinitely for cold repos and cannot be reliably cancelled.
        /// </summary>
        public async Task<IReadOnlyList<Models.Contributor>> GetContributorsAsync()
        {
            if (string.IsNullOrEmpty(this.token))
            {
                Logger.LogWarning("[RepoStats] No GitHub token configured — skipping contributor stats.");
                return new List<Models.Contributor>();
            }

            if (!await this.ThrottleIfNeeded())
            {
                return new List<Models.Contributor>();
            }

            try
            {
                Logger.LogInfo("[RepoStats] Fetching commits to derive contributor stats (10 pages)...");
                var commits = await client.Repository.Commit.GetAll(
                    "DNNCommunity", "DNNDocs",
                    new CommitRequest(),
                    new ApiOptions { PageSize = 100, PageCount = 10 });

                var contributors = commits
                    .Where(c => c.Author != null && !string.IsNullOrEmpty(c.Author.Login))
                    .GroupBy(c => c.Author.Login)
                    .Select(g => new Models.Contributor
                    {
                        Login = g.Key,
                        AvatarUrl = g.First().Author.AvatarUrl,
                        HtmlUrl = g.First().Author.HtmlUrl,
                        Total = g.Count(),
                        LatestCommitDate = g.Max(c => c.Commit.Author.Date),
                    })
                    .ToList();

                Logger.LogInfo($"[RepoStats] Derived {contributors.Count} contributors from {commits.Count} commits.");
                return contributors;
            }
            catch (RateLimitExceededException ex)
            {
                Logger.LogWarning($"[RepoStats] GitHub API rate limit exceeded while fetching contributors. Skipping stats. Reset at: {ex.Reset}");
                return new List<Models.Contributor>();
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"[RepoStats] Failed to fetch contributors: {ex.Message}. Skipping stats.");
                return new List<Models.Contributor>();
            }
        }

        public async Task<IReadOnlyList<GitHubCommit>> GetCommitsAsync(string path = "")
        {
            if (string.IsNullOrEmpty(this.token))
            {
                Logger.LogWarning("[RepoStats] No GitHub token configured — skipping commit stats.");
                return new List<GitHubCommit>();
            }

            if (!await this.ThrottleIfNeeded())
            {
                return new List<GitHubCommit>();
            }

            try
            {
                var request = new CommitRequest();
                if (!string.IsNullOrEmpty(path))
                    request.Path = path;

                // When fetching global commits (for recent-contributors), we only need enough
                // to find 5 unique authors — cap at 3 pages (max 300 commits) to avoid
                // paginating through the entire repo history.
                var options = string.IsNullOrEmpty(path)
                    ? new ApiOptions { PageSize = 100, PageCount = 3 }
                    : new ApiOptions { PageSize = 100 };

                Logger.LogInfo($"[RepoStats] Fetching commits{(string.IsNullOrEmpty(path) ? "" : $" for {path}")}...");
                var commits = await client.Repository.Commit.GetAll("DNNCommunity", "DNNDocs", request, options);
                Logger.LogInfo($"[RepoStats] Fetched {commits.Count} commits{(string.IsNullOrEmpty(path) ? "" : $" for {path}")}");
                return commits;
            }
            catch (RateLimitExceededException ex)
            {
                Logger.LogWarning($"[RepoStats] GitHub API rate limit exceeded while fetching commits. Skipping stats. Reset at: {ex.Reset}");
                return new List<GitHubCommit>();
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"[RepoStats] Failed to fetch commits: {ex.Message}. Skipping stats.");
                return new List<GitHubCommit>();
            }
        }

        /// <summary>
        /// Checks the current rate limit. Returns <c>true</c> if it is safe to proceed with an API call,
        /// or <c>false</c> if the rate limit is exhausted and callers should skip their request.
        /// When nearing (but not at) the limit, a short progressive backoff delay is applied.
        /// </summary>
        private async Task<bool> ThrottleIfNeeded()
        {
            try
            {
                var rateLimits = await client.RateLimit.GetRateLimits();
                var remaining = rateLimits.Resources.Core.Remaining;
                var limit = rateLimits.Resources.Core.Limit;
                var reset = rateLimits.Resources.Core.Reset;

                if (remaining == 0)
                {
                    var waitSeconds = (int)(reset - DateTimeOffset.UtcNow).TotalSeconds + 5;
                    Logger.LogWarning($"[RepoStats] GitHub API rate limit fully exhausted (0/{limit}). Resets at {reset} UTC (~{waitSeconds}s). Skipping stats to avoid blocking the build.");
                    return false;
                }

                if (remaining < RateLimitThreshold)
                {
                    int delayFactor = RateLimitThreshold - remaining;
                    int delayMs = (int)Math.Min(Math.Pow(ExponentialBase, delayFactor), MaxDelayMs);

                    Logger.LogInfo($"[RepoStats] Nearing GitHub API rate limit, applying backoff of {delayMs} ms. Remaining: {remaining}/{limit}, resets at {reset}.");
                    await Task.Delay(delayMs);
                }

                return true;
            }
            catch (RateLimitExceededException ex)
            {
                Logger.LogWarning($"[RepoStats] GitHub API rate limit exceeded during throttle check. Skipping stats. Reset at: {ex.Reset}");
                return false;
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"[RepoStats] Could not check rate limit ({ex.Message}). Proceeding cautiously.");
                return true;
            }
        }
    }
}
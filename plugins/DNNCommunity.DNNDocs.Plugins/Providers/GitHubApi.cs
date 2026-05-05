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

            if (!string.IsNullOrEmpty(this.token))
            {
                client.Credentials = new Credentials(this.token);
            }

            try
            {
                var rateLimits = client.RateLimit.GetRateLimits().GetAwaiter().GetResult();
                Console.WriteLine($"[RepoStats] GitHub API remaining: {rateLimits.Resources.Core.Remaining}/{rateLimits.Resources.Core.Limit}, resets at: {rateLimits.Resources.Core.Reset}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: Could not retrieve GitHub rate limit info: {ex.Message}");
            }
        }

        public async Task<IReadOnlyList<Contributor>> GetContributorsAsync()
        {
            if (string.IsNullOrEmpty(this.token))
            {
                Console.WriteLine("[RepoStats] No GitHub token configured — skipping contributor stats.");
                return new List<Contributor>();
            }

            if (!await this.ThrottleIfNeeded())
            {
                return new List<Contributor>();
            }

            try
            {
                return await client.Repository.Statistics.GetContributors("DNNCommunity", "DNNDocs");
            }
            catch (RateLimitExceededException ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: GitHub API rate limit exceeded while fetching contributors. Skipping stats. Reset at: {ex.Reset}");
                return new List<Contributor>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: Failed to fetch contributors: {ex.Message}. Skipping stats.");
                return new List<Contributor>();
            }
        }

        public async Task<IReadOnlyList<GitHubCommit>> GetCommitsAsync(string path = "")
        {
            if (string.IsNullOrEmpty(this.token))
            {
                Console.WriteLine("[RepoStats] No GitHub token configured — skipping commit stats.");
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

                return await client.Repository.Commit.GetAll("DNNCommunity", "DNNDocs", request);
            }
            catch (RateLimitExceededException ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: GitHub API rate limit exceeded while fetching commits. Skipping stats. Reset at: {ex.Reset}");
                return new List<GitHubCommit>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: Failed to fetch commits: {ex.Message}. Skipping stats.");
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
                    Console.WriteLine($"[RepoStats] WARNING: GitHub API rate limit fully exhausted (0/{limit}). Resets at {reset} UTC (~{waitSeconds}s). Skipping stats to avoid blocking the build.");
                    return false;
                }

                if (remaining < RateLimitThreshold)
                {
                    int delayFactor = RateLimitThreshold - remaining;
                    int delayMs = (int)Math.Min(Math.Pow(ExponentialBase, delayFactor), MaxDelayMs);

                    Console.WriteLine($"[RepoStats] Nearing GitHub API rate limit, applying backoff of {delayMs} ms. Remaining: {remaining}/{limit}, resets at {reset}.");
                    await Task.Delay(delayMs);
                }

                return true;
            }
            catch (RateLimitExceededException ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: GitHub API rate limit exceeded during throttle check. Skipping stats. Reset at: {ex.Reset}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RepoStats] WARNING: Could not check rate limit ({ex.Message}). Proceeding cautiously.");
                return true;
            }
        }
    }
}
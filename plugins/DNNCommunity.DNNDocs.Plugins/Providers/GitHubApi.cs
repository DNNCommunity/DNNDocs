using Octokit;

namespace DNNCommunity.DNNDocs.Plugins.Providers
{
    public class GitHubApi
    {
        private readonly string token;
        private readonly GitHubClient client;

        private const int RateLimitThreshold = 1000; // Starts throtling if less than x calls remaining for the next hour.
        private const int MaxDelayMs = 15000; // Maximum delay of 15 seconds.
        private const double ExponentialBase = 1.5; // Exponential base for progressive backoff.

        public GitHubApi()
        {
            DotNetEnv.Env.Load(); // Loads .env file if it exists, into environment varialbes.
            client = new GitHubClient(new ProductHeaderValue("DNNDocsPlugin"));
           
            // Optionally pull from env if not passed
            var skip = Environment.GetEnvironmentVariable("SKIP_CONTRIBUTORS") == "true";
            if (!skip)
            {
                this.token = Environment.GetEnvironmentVariable("GithubToken") ?? string.Empty;
            }

            if (!string.IsNullOrEmpty(this.token))
            {
                client.Credentials = new Credentials(this.token);
            }

            var rateLimits = client.RateLimit.GetRateLimits().GetAwaiter().GetResult();
            Console.WriteLine($"Remaining: {rateLimits.Resources.Core.Remaining}, Resets at: {rateLimits.Resources.Core.Reset}");
        }

        public async Task<IReadOnlyList<Contributor>> GetContributorsAsync()
        {
            if (string.IsNullOrEmpty(this.token))
            {
                return new List<Contributor>();
            }

            await this.ThrottleIfNeeded();
            return await client.Repository.Statistics.GetContributors("DNNCommunity", "DNNDocs");
        }

        public async Task<IReadOnlyList<GitHubCommit>> GetCommitsAsync(string path = "")
        {
            if (string.IsNullOrEmpty(this.token))
            {
                return new List<GitHubCommit>();
            }

            var request = new CommitRequest();
            if (!string.IsNullOrEmpty(path))
                request.Path = path;

            await this.ThrottleIfNeeded();
            return await client.Repository.Commit.GetAll("DNNCommunity", "DNNDocs", request);
        }

        private async Task ThrottleIfNeeded()
        {
            var rateLimits = await client.RateLimit.GetRateLimits();
            var remaining = rateLimits.Resources.Core.Remaining;
            var limit = rateLimits.Resources.Core.Limit;
            var reset = rateLimits.Resources.Core.Reset;


            if (remaining < RateLimitThreshold)
            {
                int delayFactor = RateLimitThreshold - remaining;
                int delayMs = (int)Math.Pow(ExponentialBase, delayFactor);
                delayMs = Math.Min(delayMs, MaxDelayMs);

                Console.WriteLine($"[Throttle] Nearing rate limit, delaying {delayMs} ms... GitHub API remaining: {remaining}/{limit}, resets at {reset}");
                await Task.Delay(delayMs);
            }
        }
    }
}
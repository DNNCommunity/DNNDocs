using Octokit;

namespace DNNCommunity.DNNDocs.Plugins.Providers
{
    public class GitHubApi
    {
        private readonly string token;
        private readonly GitHubClient client;

        public GitHubApi()
        {
            DotNetEnv.Env.Load(); // Loads .env file if it exists, into environment varialbes.
            client = new GitHubClient(new ProductHeaderValue("DNNDocsPlugin"));
           
            // Optionally pull from env if not passed
            this.token = Environment.GetEnvironmentVariable("GITHUB_TOKEN") ?? string.Empty;
            if (!string.IsNullOrEmpty(this.token))
            {
                client.Credentials = new Credentials(this.token);
            }

            var rateLimits = client.RateLimit.GetRateLimits().GetAwaiter().GetResult();
            Console.WriteLine($"Remaining: {rateLimits.Resources.Core.Remaining}, Resets at: {rateLimits.Resources.Core.Reset}");
            Console.WriteLine($"Search Remaining: {rateLimits.Resources.Search.Remaining}, Resets at: {rateLimits.Resources.Search.Reset}");
            Console.WriteLine($"GraphQL Remaining: {rateLimits.Resources.Graphql.Remaining}, Resets at: {rateLimits.Resources.Graphql.Reset}");
        }

        public async Task<IReadOnlyList<Contributor>> GetContributorsAsync()
        {
            if (string.IsNullOrEmpty(this.token))
            {
                return new List<Contributor>();
            }

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

            return await client.Repository.Commit.GetAll("DNNCommunity", "DNNDocs", request);
        }
    }
}
using Microsoft.DocAsCode.Plugins;
using System.Composition;
using System.Collections.Immutable;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export(nameof(RepoStatsProcessor), typeof(IPostProcessor))]
    public class RepoStatsProcessor : IPostProcessor
    {
        // TODO: implements IPostProcessor

        public ImmutableDictionary<string, object> PrepareMetadata(ImmutableDictionary<string, object> metadata)
        {
            // TODO: add/remove/update property from global metadata
            return metadata;
        }

        public Manifest Process(Manifest manifest, string outputFolder)
        {
            // TODO: add/remove/update all the files included in manifest
            return manifest;
        }
    }
}

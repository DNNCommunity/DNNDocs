using Microsoft.DocAsCode.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;
using System.Collections.Immutable;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats
{
    [Export(nameof(TopContributorsProcessor), typeof(IPostProcessor))]
    public class TopContributorsProcessor : IPostProcessor
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

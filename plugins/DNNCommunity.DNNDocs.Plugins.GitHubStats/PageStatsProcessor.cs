﻿using Microsoft.DocAsCode.Plugins;
using System.Composition;
using System.Collections.Immutable;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats
{
    [Export(nameof(PageStatsProcessor), typeof(IPostProcessor))]
    public class PageStatsProcessor : IPostProcessor
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

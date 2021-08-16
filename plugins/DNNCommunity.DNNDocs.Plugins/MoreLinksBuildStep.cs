using Microsoft.DocAsCode.Build.ConceptualDocuments;
using Microsoft.DocAsCode.Plugins;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export(nameof(ConceptualDocumentProcessor), typeof(IDocumentBuildStep))]
    public class MoreLinksBuildStep : IDocumentBuildStep
    {
        public string Name => nameof(MoreLinksBuildStep);
        public int BuildOrder => 4;

        public class Link
        {
            public string Title { get; set; }
            public string Url { get; set; }
        }

        public void Build(FileModel model, IHostService host)
        {
            if (model.Type == DocumentType.Article)
            {
                var contents = (IDictionary<string, object>)model.Content;
                if (contents.ContainsKey("related-topics"))
                {
                    var newLinks = new List<Link>();
                    var topics = (string)contents["related-topics"];
                    if (topics != null)
                    {
                        foreach (var topic in topics.Split(','))
                        {
                            var found = host.LookupByUid(topic.Trim());
                            if (found != null && found.Count > 0)
                            {
                                var top = found[0];
                                var topContents = (IDictionary<string, object>)top.Content;
                                var url = (string)topContents["path"];
                                url = url.Substring(0, url.Length - 3); // cut off .md
                                newLinks.Add(new Link()
                                {
                                    Title = (string)topContents["title"],
                                    Url = $"/{url}.html"
                                });
                            }
                        }
                        AddLinksDivToContents(contents, "related-topics", newLinks);
                    }
                }
                if (contents.ContainsKey("links"))
                {
                    var linkList = (List<object>)contents["links"];
                    if (linkList != null)
                    {
                        var newLinks = new List<Link>();
                        foreach (string mdLink in linkList)
                        {
                            var m = Regex.Match(mdLink, @"\[([^\]]+)\]\(([^\)]+)\)");
                            if (m.Success)
                            {
                                newLinks.Add(new Link()
                                {
                                    Title = m.Groups[1].Value,
                                    Url = m.Groups[2].Value
                                });
                            }
                        }
                        AddLinksDivToContents(contents, "links", newLinks);
                    }
                }
                model.Content = contents;
            }
        }

        private void AddLinksDivToContents(IDictionary<string, object> contents, string divClass, List<Link> links)
        {
            var docContents = (string)contents["conceptual"];
            docContents += $"<div class=\"{divClass}\" hidden>";
            foreach (var l in links)
            {
                docContents += $"<span><a href=\"{l.Url}\">{l.Title}</a></span>";
            }
            docContents += "</div>";
            contents["conceptual"] = docContents;
        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
        }

        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
    }
}

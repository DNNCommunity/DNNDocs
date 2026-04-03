---
uid: setup-upgrades-suggested-upgrade-path
locale: en
title: DNN Platform Suggested Upgrade Path
dnnversion: 10.02.03
---

# DNN Platform Suggested Upgrade Path
Following is the recommended upgrade path for **DNN Platform** based on the experiences of many DNN Community members.

> [!WARNING]
> While the below has been tested and used successfully, there are no guarantees. Each upgrade scenario can result in unique complexities and challenges. Therefore, each upgrade should be treated with full context in mind. For common best practices, please use [these basic upgrade steps](xref:setup-upgrades) to provide guidance.

The below is, of course, subject to change. If your current version of DNN Platform is between any of the versions listed below, first upgrade to the closest listed version. For instance, if you are starting with version 09.02.00, you should upgrade first to version 09.03.02.

| **FROM Version** | **TO Version** | **Notes** |
|---|---|---|
| [10.02.01] | [10.02.03] | * DNN 10.2.0 introduced a new simplified upgrade process, see [Post-10.2.0 Upgrade Guide](xref:setup-upgrades-post-10.2.0).<br /><br /> * DNN 10.2.3 has an issue with uploading upgrades, if upgrading from 10.2.3, please upload your next version package to `App_Data\Upgrade` folder manually.<br /><br /> |
| [09.13.09] | [10.02.01] | * DNN 10.0.0 is a significant release with both [Breaking Changes and New Features][bc-10], it also introduced minimum requirements for ASP.NET 4.8 and SQL Server 2017. In addition, it will force-remove DNN-Provided Telerik versions.<br /><br /> * DNN 10.1.1 new installs use SHA256 as the default password hashing algorithm. This only affects new installs, if you want to migrate an upgraded site to SHA256, please read [the documentation for membership provider changes](xref:security-membership-providers).<br /><br /> |
| [09.03.02] | [09.13.09] | * DNN 9.4.0 introduced a minimum requirement of ASP.NET 4.7.2.<br /><br /> * DNN 9.8.0 (and above for the 9.x series releases) brings the OPTIONAL (but HIGHLY RECOMMENDED) [Telerik Removal](xref:setup-telerik-removal).<br /><br /> |
| [09.01.01] | [09.03.02] | * DNN 9.2.0 multiple APIs were removed that were marked deprecated in DNN 7 and before. Most of the core modules have been updated since and you can find them at [dnncommunity][dnncommunity-gh].<br /><br /> * If you have other modules installed, please check for updates before upgrading to DNN 9.2.0 or later.<br /><br /> |
| [08.00.04] | [09.01.01] | |
| [07.04.02] | [08.00.04] | |
| [06.02.08] | [07.04.02] | * DNN 7.0.0 has some additional changed pre-requisites, please see the [DNN 7 Developer Quick Start][dnn7qs] for further details.<br /><br /> |
| [05.06.08] | [06.02.08] | |
| [05.04.04] | [05.06.08] | |
| [04.09.05] | [05.04.04] | * DotNetNuke 5.2.0 introduced the requirement for SQL 2005 and ASP.NET 3.5 SP1.<br /><br /> * DNN 5.3.0 upgrading from before 5.3.0 to after 5.3.0, you may encounter this error during the upgrade: "Type 'Web.HttpResponse' is not defined." This primarily occurs if the XML module is already installed.<br /><br /> * To prevent this, check PRIOR to upgrading if the XML module is installed. If so, upgrade it PRIOR to upgrading DotNetNuke to version 4.3.5, available at [DNN.XML Module on GitHub][dnn-xml].<br /><br /> |
| [04.06.02] | [04.09.05] | |
| [04.04.01] | [04.06.02] | * DotNetNuke 4.6.2 **prior to 4.6.2** site admins had to manually merge key fields in web.config such as the machinekey and both connection strings.<br /><br /> * With 4.6.2 DotNetNuke introduced functionality known as xmlmerge which automatically does the web.config merging on your behalf.<br /><br /> |
| [04.03.07] | [04.04.01] | |
| [03.02.02] | [04.03.07] | * Bumped ASP.NET to 2.0, also see [Upgrade to DotNetNuke 4.x chapter][dnn4x].<br /><br /> * This blog post also contains information about upgrading from 3.2.2. to 4.x: [Preparing for an upgrade][prep-upgrade]<br /><br /> |
| [03.01.01] | [03.02.02] | |
| [02.01.02] | [03.01.01] | |
| [02.00.04] | [02.01.02] | |

<!-- Version links (DNN Platform releases) -->
[10.02.03]: https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v10.2.3
[10.02.01]: https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v10.2.1
[09.13.09]: https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.13.9
[09.03.02]: https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.3.2
[09.01.01]: https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.1
[08.00.04]: https://github.com/dnnsoftware/Dnn.Releases.Archive.8x/tree/master/08.00.04
[07.04.02]: https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.02
[06.02.08]: https://github.com/dnnsoftware/Dnn.Releases.Archive.6x/tree/master/06.02.08
[05.06.08]: https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.06.08
[05.04.04]: https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.04.04
[04.09.05]: https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.09.05
[04.06.02]: https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.06.02
[04.04.01]: https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.04.01
[04.03.07]: https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.03.07
[03.02.02]: https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.02.02
[03.01.01]: https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.01.01
[02.01.02]: https://github.com/dnnsoftware/Dnn.Releases.Archive.2x/tree/master/02.01.02
[02.00.04]: https://github.com/dnnsoftware/Dnn.Releases.Archive.2x/tree/master/02.00.04

<!-- Notes links -->
[bc-10]: https://dnncommunity.org/blogs/Post/20257
[dnn7qs]: https://www.dnnsoftware.com/wiki/dotnetnuke-70-developer-quick-start#Pre-requisites_0
[dnn-xml]: https://github.com/DNNCommunity/DNN.XML
[dnn4x]: https://www.dnnsoftware.com/LinkClick.aspx?fileticket=gOZGbvrVKJw%3d&tabid=478&mid=857
[prep-upgrade]: https://www.dnnsoftware.com/community-blog/cid/135317/preparing-for-an-upgrade
[dnncommunity-gh]: https://github.com/dnncommunity

> [!NOTE]
> If you are in a situation where you are unable to make the 09.13.09 -> 10.x upgrade, there is a hot-fix release [09.13.10](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.13.10). This was a special release that contains security patches through the DNN 10.02.00 release and can be used during periods when a 10.x upgrade is not yet possible.  For a successful upgrade, it is NOT necessary to stop at 09.13.10 prior to upgrading to 10.x.  There is NO guarantee that any future 9.13.x releases will be made, therefore it is suggested to try to prepare for a 10.x upgrade as soon as practical.

> [!NOTE]
> If upgrading from DNN 10.02.x and later, it is strongly recommended to follow the new upgrade process outlined in the [Post-10.2.0 Upgrade Guide](xref:setup-upgrades-post-10.2.0)

---
uid: setup-upgrades-suggested-upgrade-path
locale: en
title: DNN Platform Suggested Upgrade Path
dnnversion: 09.08.00
---

# DNN Platform Suggested Upgrade Path
Following is the recommend upgrade path for **DNN Platform** based on experiences of many DNN Community members.

> [!WARNING]
> While the below has been tested and used successfully, there are no guarantees. Each upgrade scenario can result in unique complexities and challenges. Therefore, each upgrade should be treated with full context in mind. For common best-practices, please use [these basic upgrade steps](xref:setup-upgrades) to provide guidance.

The below is, of course, subject to change. If your current version of DNN Platform is between any of the versions listed below, first upgrade to the closest listed version. For instance, if you are starting with version 09.02.00, you should upgrade first to version 09.03.02.

|**FROM Version**|**TO Version**|
|---|---|
|[02.00.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.2x/tree/master/02.00.04)|[02.01.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.2x/tree/master/02.01.02)|
|[02.01.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.2x/tree/master/02.01.02)|[03.01.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.01.01)|
|[03.01.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.01.01)|[03.02.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.02.02)|
|[03.02.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.3x/tree/master/03.02.02)|[04.03.07](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.03.07)|
|[04.03.07](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.03.07)|[04.04.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.04.01)|
|[04.04.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.04.01)|[04.06.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.06.02)|
|[04.06.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.06.02)|[04.09.05](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.09.05)|
|[04.09.05](https://github.com/dnnsoftware/Dnn.Releases.Archive.4x/tree/master/04.09.05)|[05.04.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.04.04)|
|[05.04.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.04.04)|[05.06.08](https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.06.08)|
|[05.06.08](https://github.com/dnnsoftware/Dnn.Releases.Archive.5x/tree/master/05.06.08)|[06.02.08](https://github.com/dnnsoftware/Dnn.Releases.Archive.6x/tree/master/06.02.08)|
|[06.02.08](https://github.com/dnnsoftware/Dnn.Releases.Archive.6x/tree/master/06.02.08)|[07.04.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.02)|
|[07.04.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.02)|[08.00.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.8x/tree/master/08.00.04)|
|[08.00.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.8x/tree/master/08.00.04)|[09.01.01](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.1)|
|[09.01.01](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.1)|[09.03.02](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.3.2)|
|[09.03.02](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.3.2)|[09.09.01](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.9.1)|

> [!TIP]
> **Upgrade Notes:** DotNetNuke has been around since 2002, and in that time has had a number of changes which can complicate matters during the process of upgrading through different versions. These include:

## Requirements Changes & Prerequisites
- The changeover from DNN 3.x to DNN 4.x - DNN 3.x used ASP.NET 1.1, whereas DNN 4.x and above require ASP.NET 2.0.
- Editions prior to 4.6.2 - Prior to 4.6.2 site admins had to manually merge a number of key fields in web.config such as the machinekey and both connection strings. With 4.6.2 DotNetNuke introduced functionality known as xmlmerge which automatically does the web.config merging on your behalf.
- 3.02.02 - 4.03.07 - Please refer to the Detailed installation guide "[Upgrade to DotNetNuke 4.x chapter](https://www.dnnsoftware.com/LinkClick.aspx?fileticket=gOZGbvrVKJw%3d&tabid=478&mid=857)". This blog post also contains information about upgrading from 3.2.2. to 4.x: [Preparing for an upgrade](https://www.dnnsoftware.com/community-blog/cid/135317/preparing-for-an-upgrade)
- DotNetNuke 5.2 - This version introduced the requirement for SQL 2005 and ASP.NET 3.5 SP1.
- When upgrading from a version before 5.3.0 to after 5.3.0, you may encounter this error during the upgrade: “Type 'Web.HttpResponse' is not defined.” This error primarily occurs if an the XML module is already installed. To prevent this, please check PRIOR to upgrading if the XML module is installed in your DotNetNuke version. If it is installed, please upgrade it PRIOR to upgrading DotNetNuke to version 4.3.5, available at [DNN.XML Module on GitHub](https://github.com/DNNCommunity/DNN.XML).
- With the 7.0 release DotNetNuke has some additional changed pre-requisites, please see the [DNN 7 Developer Quick Start](https://www.dnnsoftware.com/wiki/dotnetnuke-70-developer-quick-start#Pre-requisites_0) for further details.
- In DNN 9.2.0, multiple APIs were removed that were marked deprecated in DNN 7 and before. Most of the core modules have been updated since and you can find them at [https://github.com/dnncommunity](https://github.com/dnncommunity). If you have other modules installed, please check for updates before upgrading to DNN 9.2.0 or later.
- DNN 9.4.0 introduced a minimum requirement of ASP.NET 4.7.2.
- DNN 9.8.0 (and above for the 9.x series releases) brings the OPTIONAL (but HIGHLY RECOMMENDED) [Telerik Removal](xref:setup-telerik-removal).


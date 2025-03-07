---
uid: setup-requirements
locale: en
title: DNN Platform Requirements
dnnversion: 10.00.00
related-topics: install-extension,administrators-included-modules-overview,dnn-overview,dnn-overview,control-bar-to-persona-bar,persona-bar-by-role,providers,more-resources,set-up-dnn
---

# DNN Platform Requirements
The following information applies to **DNN Platform** 10.0.0 and later.

## Supported Operating Systems

*   Windows 10
*   Windows 11
*   Windows Server 2016 or Later
*   Microsoft Azure App Service (PaaS)

> [!Note]
> The Microsoft IIS feature must be installed/enabled

## .NET Framework Minimum

*   4.8.0

## Database Server

DNN Platform requires a single Microsoft SQL Server database and supports all current editions of Microsoft SQL Server including.

*   Microsoft SQL Server 2017
*   Microsoft SQL Server 2019
*   Microsoft SQL Server 2022
*   Microsoft Azure SQL Database

> [!Note]
> Although DNN products can utilize any edition of SQL Server production environments should consider possible performance limitations if using Express editions of SQL Server.

## Browsers

*   Chrome
*   Firefox
*   Microsoft Edge
*   Safari for Mac

> [!Note]
> DNN products are tested on the latest browser versions at the time of release. Although untested, older browsers could still work.

## Developer IDEs

For creating extensions:

*   Visual Studio 2022 (including Community Edition with latest updates)

> [!Note]
> Starting with DNN 10.0.0, .NET Framework 4.8.0+ is required, however, it is still possible to use older versions of Visual Studio, and .NET Framework for extension development.  The minimum version for extension development is dependent upon the targeted DNN Minimum Version.

For contributing to DNN Platform:

*   Visual Studio 2022 (including Community Edition with latest updates)
*   Latest `dotnet SDK`
*   Latest `node (LTS)`

Please click the **Improve this Doc** button above to help us improve this page.

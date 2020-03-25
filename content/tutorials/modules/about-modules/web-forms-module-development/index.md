---
uid: web-forms-module-development
locale: en
title: Web Forms Module Development
dnnversion: 09.02.00
related-topics: use-module-creator,providers
links: ["[Module Development: DNN Video Library](https://www.dnnsoftware.com/videos/)"]
---

# Web Forms Module Development

## Web Forms Module Architecture

Web Forms modules follow the standard DNN module architectural pattern and use a traditional server-side rendering model. When a page is requested, DNN will create an instance of the relevant module control as defined in the module definition. The module control inherits from a code-behind class that contains the presentation logic and that makes additional calls to the appropriate business methods in the Business Logic Layer.



![Logical architecture of a Web Forms module](/images/gra-module-architecture-wf.png)



You can include web service endpoints to enable access by mobile applications, if necessary. When accessing the module from a mobile application, the presentation layer moves to the mobile device and the service layer becomes the server-side endpoint that calls the appropriate business methods.



![Accessing Web Forms Module via a Web Service](/images/gra-module-architecture-mobile.png)



## Building Web Forms Modules

In Visual Studio, modules can be created as one of these project types:

*   Web Site Project (WSP)
*   Web Application Project (WAP)

Modules built using the WSP project type include the source code as part of the module package. The source code is compiled at runtime, thereby, allowing you to easily alter code directly on the server. While this approach provides flexibility in making updates, it also decreases startup performance and can complicate module upgrades.

Important: The WSP project type is not recommended for commercial module development, because it requires the distribution of source code with your module.

WSP projects do not have a project file (.csproj or .vbproj). Instead, they rely on files being part of a complete website. When creating a WSP module, all user controls, the associated code-behind files, and other related files are placed in a project folder under the DesktopModules folder. All code files not associated with a user control must be placed in the App_Code folder in the website's root. This disjointed code model complicates module development and packaging.

Modules built using the WAP project type are compiled at development time and do not require you to include the source code with your module. WAP projects have a project file and are created as standalone projects.

Note: Microsoft recommends the WAP project type for ASP.NET development. (See [Web Application Projects Versus Web Site Projects in Visual Studio](https://docs.microsoft.com/en-us/previous-versions/aspnet/dd547590(v=vs.110)).)

Although Visual Studio is recommended for module development, you can create modules using standard text editors or the included DNN Module Creator. However, these tools do not provide .NET compiler support; therefore, they are more suited for developing WSP-based modules.

You can organize your Web Forms project files any way you wish. Many module developers organize project files based on the logical architecture.

## Packaging Web Forms Modules

Modules created using the WAP project type can leverage MS Build scripts to automatically bundle the module files and module manifest. WSP-based modules can be packaged using the package wizard that is available in DNN.

Regardless of project type, Web Forms module packages include the following files:

*   Required
    *   User controls (.ascx) contain the markup needed to render your module UI.
    *   Code files (.cs or .vb) contain business logic, caching logic and data access code (only included for WSP project types).
    *   Manifest file (.dnn) contains the module definition information required for installing the module.
    *   Assemblies (.dll) are the compiled module code and 3rd party reference libraries. WSP projects will not have an assembly for the compiled module, but may still include 3rd party reference libraries.
    *   SQL scripts (.sqldataprovider) are the code required to create or update your module's database objects.
*   Optional
    *   Resource files (.resx) contain localization strings.
    *   JavaScript files (.js) contain code used for client-side logic.
    *   Stylesheets (.css) contain the custom styles needed by your module.
    *   Text files (.txt) include the release.txt and license.txt files that are displayed during module installation.

The DNN Module Creator automatically places files in the appropriate folders (App_Code and DesktopModules) and can be used to package the completed module.

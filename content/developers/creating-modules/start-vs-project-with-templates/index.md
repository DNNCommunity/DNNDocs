---
uid: start-vs-project-with-templates
locale: en
title: Start a Visual Studio Project with Templates
dnnversion: 09.02.00
previous-topic: create-module-using-templates
next-topic: test-module
links: ["[DNN Community Blog: Module Development for Non-Developers, Skinners, & DNN Beginners — Blog Series by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155064/module-development-for-non-developers-skinners-dnn-beginners--blog-series-intro)","[Using the new Module Development Templates for DotNetNuke 7 by Chris Hammond](https://www.chrishammond.com/blog/itemid/2616/using-the-new-module-development-templates-for-dot)"]
---

# Start a Visual Studio Project with Templates

## Prerequisites

*   [A local DNN installation](xref:set-up-dnn) with Host permissions.
*   Visual Studio 2015 is the recommended IDE for developing DNN modules.

## Steps

1.  Download and install the templates.

    For Chris Hammond's templates,

    1.  Run Visual Studio as an administrator.
    2.  Go to Tools \> Extensions and Updates.



        ![Tools > Extensions and Updates](/images/scr-VS2015ExtAndUpdates.png)



    3.  Highlight the Online \> Visual Studio Gallery tree and search for DotNetNuke.



        ![In the Online > Visual Studio Gallery tree, search for DotNetNuke then Download.](/images/scr-VS2015Search4DNN.png)



    4.  Click the Download button for the DotNetNuke Project Templates.

    > [!Note]
    > See [Chris Hammond's instructions](https://www.chrishammond.com/blog/itemid/2616/using-the-new-module-development-templates-for-dot) for other installation methods.

    For the DNN 8 templates,

    1.  [Download the appropriate .vsix file.](https://github.com/dnnsoftware/DNN.Templates/releases)

        Two are included:

        *   Dnn.Mvc.Module.vsix
        *   Dnn.Spa.Module.vsix



        ![Download DNN8 templates from Github.](/images/scr-VS2015DNN8Templates-11.png)



    2.  In your download folder, double-click the .vsix file to install the template in Visual Studio.
2.  Create a new Visual Studio project.
    1.  Run Visual Studio as an administrator.
    2.  File \> New \> Project
    3.  Select the template for the new project.

        For Chris Hammond's templates, go to Installed \> Templates \> Visual C# or Visual Basic \> DotNetNuke.

        ![Visual Studio > New > Project with Chris Hammond's templates](/images/scr-VS2015NewProjectWithTemplates-02.png)



        For the DNN 8 templates, go to Installed \> Templates \> Visual C# \> Dnn.

        ![Visual Studio > New > Project with DNN8 templates](/images/scr-VS2015NewProjectWithTemplates-01.png)



    4.  Fill in the settings.

        *   Name: the name of your new module
        *   Location: a subfolder inside the DesktopModules folder of your DNN installation folder

        >[!Tip]
        >Use your company name or a unique name as the subfolder name to avoid conflicts with other module creators in a production environment.

    5.  Uncheck Create directory for solution.

        The templates expect Visual Studio's solution file (.sln) to be in the same folder as the project file. Checking this option puts the solution file in a different folder, which can cause build errors.

3.  Modify the Visual Studio project to add functionality to your new module.

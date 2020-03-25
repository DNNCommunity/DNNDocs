---
uid: create-module-using-templates
locale: en
title: Create a Module Using Templates
dnnversion: 09.02.00
previous-topic: use-module-creator
next-topic: start-vs-project-with-templates
related-topics: mvc-module-development,spa-module-development,providers
links: ["[DNN API Reference](https://www.dnnsoftware.com/dnn-api/)","[DNN Wiki: Module Development](https://www.dnnsoftware.com/wiki/module-development)","[DNN Community Blog: Module Development series by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155064/module-development-for-non-developers-skinners-dnn-beginners--blog-series-intro)","[Using the new Module Development Templates for DotNetNuke 7 by Chris Hammond](https://www.chrishammond.com/blog/itemid/2616/using-the-new-module-development-templates-for-dot)"]
---

# Create a Module Using Templates

## Prerequisites

*   [A local DNN installation](xref:set-up-dnn) with Host permissions.
*   Visual Studio 2015 is the recommended IDE for developing DNN modules.

## Steps

1.  [Start a Visual Studio project using DNN templates.](xref:start-vs-project-with-templates)
2.  Modify the Visual Studio project to add functionality to your new module.
3.  Build, debug, and package.



    ![Visual Studio build type dropdown](/images/scr-VS2015DebugReleaseBuildOptions.png)



    1.  Build in debug mode.

        This build produces .pdb files that are needed when stepping through your code.

    2.  Debug, if needed.
    3.  Create the [DNN Manifest](xref:dnn-manifest-schema).
    4.  Build in release mode.

        This build creates an installation zip file (your module's package) in the folder Desktop Modules/yourorganization/yourmodule/install.

    5.  Alternatively, you can manually [pack your module](xref:pack-extension).

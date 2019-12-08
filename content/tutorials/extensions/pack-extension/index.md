---
uid: pack-extension
locale: en
title: Pack Your Extension
dnnversion: 09.02.00
previous-topic: test-module,create-doctype-xml
next-topic: install-extension
related-topics: dnn-manifest-schema,module-development,web-forms-module-development,spa-module-development,create-module,mvc-module-development,providers,dnn-manifest-schema
links: ["[DNN Professional Training video: Skinning 5: Packaging](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-5-packaging)"]
---

# Pack Your Extension

For easier distribution and installation, the components of an extension (theme or module) can be bundled into a package. An extension package is simply a zip file that contains all the files required by your extension. The most important part of the process is creating the DNN Manifest, which provides information required by the installer, such as the target locations for the files.

If you use the DNN templates and compile in Visual Studio, the Release build creates the zip file for you.

Note: The package wizard, accessible through the DNN Module Creator or the Extensions page, currently cannot create packages for MVC or SPA modules.

## Steps

1.  Prepare your files in folders.

    *   Files that are common among all packages:
        *   (Optional) `MyLicense.txt` is displayed to the user during package installation.
        *   (Optional) `MyReleaseNotes.txt` lists the changes for the current version of the package and is also provided during installation.
    *   Files included in MVC and SPA module packages:
        *   Required
            *   Views (.cshtml or .vbhtml) contain the markup needed to render your module UI.
            *   Manifest file (.dnn) contains the module definition information required for installing the module.
            *   Assemblies (.dll) are the compiled module code and third party reference libraries. WSP projects will not have an assembly for the compiled module, but may still include third party reference libraries.
            *   SQL scripts (.sqldataprovider) are the code required to create or update your module's database objects.
        *   Optional
            *   Resource files (.resx) contain localization strings.
            *   JavaScript files (.js) contain code used for client-side logic.
            *   Stylesheets (.css) contain the custom styles needed by your module.
            *   Text files (.txt) include the release.txt and license.txt files that are displayed during module installation.

    Tip: The license and release notes are HTML files, so you can include special offers, including a call to action and other details.

    Remember: Include the version number of your extension in the release notes.

2.  Create the [DNN Manifest](xref:dnn-manifest-schema).
3.  Zip up your files, including the DNN Manifest in the root folder.

---
uid: about-evs
locale: en
title: About the Extension Verification Service
dnnversion: 09.02.00
related-topics: test-module,dnn-manifest-schema,module-features,module-architecture,developers-creating-modules-overview
links: ["[DNN Module APIs](https://www.dnnsoftware.com/dnn-api/)","[DNN Community Blog: Extension Verification Service (EVS) by Nathan Rover](https://www.dnnsoftware.com/community-blog/cid/147439/extension-verification-service-evs)","[DNN Community Blog: Extension Verification Service (EVS) Update by Nathan Rover](https://www.dnnsoftware.com/community-blog/cid/154576/extension-verification-service-evs-update%20from%20june%202013)"]
---

# About the Extension Verification Service

The DNN [Extension Verification Service](https://evs.dnnsoftware.com) (EVS) performs compatibility tests in three areas.

*   **Module packaging**. EVS verifies:
    *   That a valid .dnn manifest file exists. EVS throws an error, if a required section is missing, or a warning, if an optional section is missing.
    *   That all files listed in the manifest exist in the package.
    *   That all files included in the package are listed in the manifest.
*   **Data layer**. EVS verifies:
    *   That core database objects were not modified.
    *   That any SQL scripts in the module are compatible with Microsoft Azure SQL Database and can execute without errors. If Azure-incompatible SQL scripts are found, EVS generates Azure-compatible versions of those scripts and makes them available in a zip file; however, you must verify that the converted scripts still behave as expected.
    *   That {databaseOwner} and {objectQualifier} are correctly used.
    *   That the uninstall script completely removes all objects added by the installation script.
*   **Assemblies**. EVS verifies:
    *   That no assembly errors exist.
    *   That every assembly reference points to an assembly that exists either in DNN or in the .NET global assembly cache (GAC). If the assembly is not found, EVS returns an error.



![EVS website](/images/scr-EVS.png)

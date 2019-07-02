---
uid: run-installation-wizard
locale: en
title: Run the DNN Installation Wizard
dnnversion: 09.02.00
previous-topic: set-up-sql
links: ["[DNN Wiki: Setting up Your Module Development Environment](https://www.dnnsoftware.com/wiki/setting-up-your-module-development-environment)","[Setting up your DotNetNuke Module Development Environment by Chris Hammond](https://www.christoc.com/Tutorials/All-Tutorials/aid/1)","[DNN Community Blog: Installing DNN by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155070/installing-dnn)"]
---

# Run the DNN Installation Wizard

## Prerequisites

*   [DNN installed with folder permissions for the user account that will run your website.](xref:set-up-dnn-folder)
*   [IIS enabled and set up.](xref:set-up-iis)
*   [SQL installed and set up.](xref:set-up-sql)

## Steps

1.  Run the DNN Installation Wizard.

    1.  Open your website (`https://www.dnndev.me`) in a browser.
    2.  Under Administrative Information, enter the username, password, and email address for the host / super user account to create. This account will have permissions for all websites created in this DNN installation.

        > [!Note]
        > Remember the host's username and password, which you will need to manage your websites.</div>

    3.  Under Website Information, enter the name, template, and language to use for the first website.
    4.  Set the Database Information options.

        *   Database Setup: Custom
        *   Database Type: SQL Server/SQL Server Express Database
        *   Server Name:

            Developers and Designers: You can use the default value (example: `.\SQLExpress` or `(local)`).

            Administrators: Set the value to `(local)`.

        *   Database Name: Enter the name of the SQL database you created earlier.
        *   Object Qualifier:

            Developers:

            *   If creating modules for your own websites, set objectQualifier to blank.
            *   If creating modules for sale, set objectQualifier to `dnn` to prepend `dnn_` to all DNN-generated objects, such as tables and stored procedures. This practice is recommended in your local development environment, so that you can catch name-matching errors that could occur if the target DNN installation's objectQualifier setting (found in web.config) is not blank.

        *   Security: User Defined
        *   For Database Username / Password, enter the information for the SQL user you created earlier.

    5.  Follow the prompts to the end of the wizard.



    ![DNN Installation Wizard](/images/scr-InstallWizard-7.png)



2.  Test the installation by viewing the first website.
3.  (Optional) To assist with localization, modify the **web.config** file to set `ShowMissingKeys` to `true`.

    ```

            <add key="ShowMissingKeys" value="true" />

    ```

    If set to **TRUE**,

    *   Any localized text in DNN will be displayed with an "L" in front of it to help with translating text in your module.
    *   DNN displays an error if the localized version of a string is missing from the resource files. The resource files are XML files that contain the localized string tables.

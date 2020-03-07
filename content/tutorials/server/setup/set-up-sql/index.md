---
uid: set-up-sql
locale: en
title: Install and Set Up SQL
dnnversion: 09.02.00
previous-topic: set-up-iis
next-topic: run-installation-wizard
links: ["[DNN Wiki: Setting up Your Module Development Environment](https://www.dnnsoftware.com/wiki/setting-up-your-module-development-environment)","[Setting up your DotNetNuke Module Development Environment by Chris Hammond](https://www.christoc.com/Tutorials/All-Tutorials/aid/1)","[DNN Community Blog: Installing DNN by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155070/installing-dnn)"]
---

# Install and Set Up SQL

## Steps

1.  Install SQL.

    1.  [Check compatible versions.](xfref:setup-requirements)
    2.  Choose New SQL Server stand-alone installation....

        ![New SQL Server stand-alone installation](/images/scr-InstallSQL-1.png)

    3.  Include any product updates.
    4.  Accept the defaults in Feature Selection, Instance Configuration, and Server Configuration.
    5.  In Database Engine Configuration, under Authentication Mode, choose Mixed Mode.

        ![Database Engine Conf > Authentication Mode > Mixed Mode](/images/scr-InstallSQL-6.png)

    6.  Accept the defaults in remaining dialogs.
2.  Create a SQL database for your website.

    1.  Start the Microsoft SQL Server Management Studio app.

    2.  In the Object Explorer panel, right-click on Databases, and choose New Database....

       ![In the Object Explorer panel, right-click Databases, choose New Database.](/images/scr-SetupSQL-2.png)

    3.  Enter the name of the new database. Click/Tap OK.

        ![Enter new database name.](/images/scr-SetupSQL-3.png)

        <div class="blue-callout">Note: Remember the database name, because it will be required by the DNN Installation Wizard.</div>

<a name="tsk-set-up-sql__set-up-sql-user"></a>

3.  Create a SQL user account.
    1.  Under Security, right-click on Logins, and choose New Login....

        ![Under Security, right-click Logins, choose New Login.](/images/scr-SetupSQL-4.png)

    2.  Enter the username, choose SQL Server authentication, add a password, uncheck Enforce password policy, and choose the database.

        ![Choose SQL Server authentication. Uncheck Enforce password policy.](/images/scr-SetupSQL-5.png)

    <div class="blue-callout"><strong>Note:</strong> Remember the username and password, because they will be required by the DNN Installation Wizard.</div>

<a name="tsk-set-up-sql__db-owner-access"></a>

4.  Give the new SQL user **db_owner** access to the new database.

    1.  In the Object Explorer panel, under your database \> Security, right-click on Users, and choose New User...

           ![Under your database > Security, right-click Users, choose New User.](/images/scr-SetupSQL-6.png)

    2.  Set User type to SQL user with login.

           ![User type = SQL user with login](/images/scr-SetupSQL-7.png)

    3.  Enter the username of the account you just created, then click/tap Check Names.

           ![Enter the new account's login name, then click/tap Check Names.](/images/scr-SetupSQL-8.png)

    4.  Under Select a page, select Membership, and check the db_owner database role membership.

           ![For Membership page, check db_owner.](/images/scr-SetupSQL-10.png)

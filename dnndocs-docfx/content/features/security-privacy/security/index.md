---
uid: platform-overview-security
topic: platform-overview-security
locale: en
title: DNN Platform Security
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# Security

Security is an integral part of web applications and DNN has many features built into it to allow you to create very advanced applications in this respect. Module developers can leverage this and not be concerned with authentication and/or authorization at all. Instead they can leave this to the framework and focus on their application. In turn DNN devolves this to components that can be switched out. This is a very powerful feature allowing you to use Active Directory authentication or to leverage OAuth providers like Facebook.

## Users

It should come as no surprise that _users_ are individual login accounts in DNN. You&#39;ll find them in the Users table in SQL and on the User Accounts page on the Admin menu. Each user is uniquely identified through a username for authentication purposes. In data, however, users are identified through an auto incrementing integer User ID similar to tabs and portals. Whenever a user account is created, that user will only be able to log in to the portal in which it was created. But the user can be shared between portals (UserPortals table in SQL) although there is no proper UI for that right now.

![User management page](/images/ch03f009.png)

## Roles

_Roles_ are what drive security in the platform. A user can belong to one or more roles and these roles are used throughout the application to set permissions. This is similar to what you&#39;d be used to on your Windows machine. There are several roles that are installed by default: Administrators, Registered Users, Subscribers and Unverified Users. Administrators have access to all aspects of a portal. Registered Users is a role that is assigned automatically to any new account. Subscribers is a role to which users can opt in voluntarily. Finally Unverified Users is used for those users that have enlisted but have not yet verified (through an email link) that they are who they say they are. The thinking behind this last role is that you can accept a registration but exclude those from certain functionalities as the registration would have already given that user the Registered Users role.

![Role management page](/images/ch03f010.png)

These roles are specific to the portal. They have a unique RoleId (again an auto incremented integer) which is used to refer to them throughout the framework. There are two virtual roles that are worth mentioning here. They are virtual in the sense that they do not exist in the Roles table in SQL but are used in the API for specific cases. These virtual roles are All Users and Unauthenticated Users. The first (RoleID = -1) you will use to allow both authenticated and unauthenticated users access to something. The second is to target unauthenticated users only. So you could show a login panel or some explanatory text to those users only, for instance.

You&#39;ll see the roles come back whenever you edit permissions for specific part of the website. Both pages and modules on those pages have permissions. Below is a screenshot from a module&#39;s permission screen. You can add roles and/or users to the grid and set permissions by checking the checkboxes. What these permissions will do depends very much on the module and will be discussed in later chapters.

![A module&#39;s permissions screen](/images/ch03f011.png)

## Host

Upon installation DNN will create a first user account that is the _host_ account. This account has administrative privileges in all portals as well as the ability to access all resources that are common to all portals. _Host_ is synonymous with _Superuser_ in DNN. You can add as many host accounts as you like. These accounts are the only ones able to create and delete portals, install and delete modules, etc. You will immediately notice you&#39;re logged in as superuser by the appearance of the Host menu in the control bar.

## Admin

_Admins_ are regular user accounts that have been added to the Administrators role. Admins will see the Admin menu on the control bar and have the ability to change the portal such as adding and removing pages, creating and deleting users, roles, etc. Admins cannot install components to the system such as modules. Nor can they alter files that run code on the server. Care has been taken to make sure that admins are sandboxed to allow them only the ability to change content and appearance of a portal.

# Summary

In this chapter we&#39;ve looked at DNN from 30000 feet high. We&#39;ve seen the hierarchy of the DNN instance, a portal or site, a tab or page and finally the module. We now have a rough idea of where our data is stored and that DNN uses this to construct the pages that are being served out to the client&#39;s browser. We&#39;ve also seen how DNN organizes security using users and roles. Understanding the above is key to being able to comprehend more in-depth how DNN works and how you can create your own website or web application with it.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

---
uid: administrators-roles-overview
locale: en
title: About Role-Based Access
dnnversion: 09.02.00
related-topics: administrators-user-accounts-overview,administrators-jwt-overview
---

# About Role-Based Access

Administrators can minimize the time required to manage permissions by assigning users to security roles based on their needs. Instead of managing permissions for each individual user, the administrator assigns permissions to the role, and those permissions are automatically extended to every user assigned to the role.

## DNN roles

Roles can be used to assign security permissions to groups of users or to categorize users into social groups. For example, you can use roles to allow only paid subscribers to access your site.

DNN provides the following default roles:

*   Administrators. Have full permissions to manage their specific site, including permissions to add, delete, and edit all pages and modules on the site. Administrators can also authorize other users to access the Site Administration modules, as well as other pages. This role cannot be deleted or modified.
*   Registered Users. All authenticated users (i.e., users who are registered and logged in). These user accounts can be set to Authorized or Unauthorized to access specific pages/modules. This role cannot be deleted or modified.
*   Unverified Users. Anonymous site visitors, including registered users who are unauthenticated (i.e., not logged in). This role could be used to determine whether to display an invitation to log in or sign up. This role cannot be deleted or modified.
*   Subscribers. Users that sign up for subscription to the site. All registered users are added to this role by default. Authenticated users can unsubscribe or re-subscribe to this role under Membership Services on the View Profile module. Administrators can delete or modify this role.
*   Translators. A role for translators is automatically added for the default site language; example, Translators (en-US), if the site's default language is set to English (US). When content localization is enabled, another Translators role is added for each installed language. Registered users must be manually assigned to this role.

Additional roles might be available, depending on the product or the current page.

*   All Users. All site visitors, whether they are authenticated or not.
*   Hosts or Super Users. Have full permissions to manage any site in the entire DNN installation. Super users can only be created by other super users.
*   Content Editors. Users with permissions to edit content on a page.
*   Content Managers. Users with permissions to manage (add/delete/modify/reposition) content within a page.
*   Module Deployers. Users with permissions to add modules to site pages.
*   Module Editors. Users with permissions to edit a module.
*   Page Editors. Users with permissions to edit a page.

When adding a role, only the "Role Name" field is required. The default settings create a private security role.

If a role is private,

*   administrators can add users to it, and
*   users can add themselves, only if they are provided with the RSVP Code or RSVP Link associated with the role.

If a role is public,

*   users can add themselves from their user profile.

A role can be one of three security modes:

*   SecurityRole. Used for assigning site permissions.
*   SocialGroup. Serves as a group that users can join.
*   Both.

Users can be automatically added to a role, either when the role is created or when a user is created.

The role's status determines what can be done with it.

|**Status**|**Administrators/Super Users**|**Users**|
|Disabled|Cannot access.|Cannot join.|
|Pending|Can access.|Cannot join.|
|Approved|Can access.|Can join, if role is public or if role has an RSVP code/link.|

An icon can be associated with the role.

## Role groups

Role groups categorize multiple roles for ease of management. For example, a role group named Staff could include the following security roles:

1.  All Staff
2.  Telemarketing
3.  Marketing
4.  Sales
5.  Information Technology

Note: A role can be a member of only one group. To remove a role from a custom group, assign it to \[Global Roles\].

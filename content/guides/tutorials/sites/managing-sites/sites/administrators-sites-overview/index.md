---

uid: administrators-sites-overview
locale: en
title: About Sites and Site Groups
dnnversion: 09.02.00
---

# About Sites and Site Groups

Each DNN installation can host multiple sites. The superuser/host has access to all sites; administrators have access to one or more specific sites.

DNN sites that share content and users can be combined into a site group. A site can belong to only one group.

When creating a site group, you must also select a master site from the list of ungrouped sites. The master site can perform these tasks:

*   Authentication of users that are shared among the sites in the same group. You can also specify a different domain to handle authentication for the group.
*   Storing content that is reused by sites in the same group. However, the master site cannot reuse content from other member sites.

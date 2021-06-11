---
uid: data-consent-user-management
locale: en
title: Data Consent User Management
dnnversion: 09.04.00
firstappearedinversion: 09.04.00
---

# Data Consent User Management

If Data Consent is switched on for a site, the users management module changes to help site administrators gain insight in the status of users. A user can be in one of the following states:

1. Non consented.
The user has not yet consented to the terms and conditions or has refused to sign them by clicking "Cancel".
2. Consented.
The user has consented to the current terms and conditions.
3. Wishes removal.
The user has indicated that he/she wishes to be removed from the site.

To help site administrators the following changes have been made to user management

## New User Filters

Next to the regular user filters (Authenticated, Deleted, etc) the following are added to show only users with one of the statuses mentioned above:
- Consented to terms
- Has not consented to terms
- Requested removal

![User filters](/images/users-dc-dropdown.png)

## User Status Icon

An icon is shown at the start of each user line in the users table to show that user's status:

![User status icons](/images/users-dc-users.png)

## User Details Enhancement

The status of consent and the date and time the user consented or requested removal are shown in the user's details panel.

![User Details](/images/privacy-dc-user-details.png)

## Remove Deleted Users

Finally the ability to remove deleted users (all, including those that did not request this themselves) is found at the top of the module.

![User Details](/images/privacy-dc-users-remove.png)


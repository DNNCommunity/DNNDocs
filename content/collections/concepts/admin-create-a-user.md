---
title: Admin - Create a User
slug: Admin - creating-a-user
---

# Create a User (Admin)

Users can be created through the API (Developers), Prompt (Admins/Hosts) or from the user interface within DNN (Administrators). 

---
## Prerequisites
* An administrator account for the site

## Steps

1. Go to **Persona Bar > Manage > Users**.

  ![](/img/concepts/admin-create-a-user-pbar.png "Persona bar create a user")	

2. Click/Tap **Add User**.

  ![](/img/concepts/admin-create-a-user-add-user-btn.png "The Add-User screen")

3. Enter the user's information.

  ![](/img/concepts/admin-add-user-user-info-screen.png "The User info screen")


|**Field** | **Description**|
|---|---|
| **Authorized** | If enabled (**On**), the user is immediately subscribed to the **Registered User** role and to other roles that have **Auto Assignment** enabled. If disabled (**Off**), the user account is created but not authorized; an administrator must authorize the user account before the user can access areas of the website that are restricted to **Registered User** members. |
| **Random Password**  | If enabled (**On**), generates a random password. Otherwise, you must provide a password. |
| **Password** | If the site is configured with password rules (i.e., minimum length), the initial password you assign must obey those password rules. |
| **Send an Email to New User** | If checked, the user is notified by email that the account is created. Can be checked at a later time to send the email belatedly. |
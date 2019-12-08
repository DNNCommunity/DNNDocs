---
uid: delete-all-unauthorized-hosts
locale: en
title: Delete All Unauthorized Hosts
dnnversion: 09.02.00
related-topics: create-user-account,authorize-user,assign-user-to-multiple-roles,remove-user-from-multiple-roles,edit-user,manage-user-password,delete-user,delete-all-unauthorized-users,restore-deleted-user-account,purge-user-account,create-host-account,authorize-host,promote-user-to-host,demote-from-host,manage-host-password,delete-host,restore-deleted-host-account,purge-host-account
---

# Delete All Unauthorized Hosts

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to Persona Bar \> Manage \> Users.
    
    ![Persona Bar > Manage > Users](/images/scr-pbar-host-Manage-E91.png)
    
    ➊
    
    ➋
    
2.  Search for the super user account.
    
    1.  From the Show dropdown, choose Superusers to filter the displayed accounts.
    2.  Browse the list for the user account.
    
      
    
    ![User List > Show dropdown > Superusers](/images/scr-UserListShowDropdown-SuperUser-E90.png)
    
      
    
3.  For each user to delete, click/tap the ellipses icon, then choose Delete User.
    
      
    
    ![User List > Show: Superusers > find the user > ellipses icon > Delete User](/images/scr-UserList-hostellipsesmenu-DeleteUser-E90.png)
    
      
    
    Note: Deletion simply makes the account unavailable and revokes user-specific permissions. You must also remove the user from assigned roles to revoke role-based permissions.
    

## What to do next

(Optional) You can purge the user account(s) if you want to permanently delete the user account and its associated information.

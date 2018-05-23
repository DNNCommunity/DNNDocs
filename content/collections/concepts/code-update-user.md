---
title: Updating A User Programmatically
slug: update-user-programmatically
---

# Updating a User Programmatically

###### Related Topics
* [Gettings a User Programmatically](../code-get-user)

Required Assemblies:

* DotNetNuke.dll

The following example contains two classes:
 
* options class (`UpdateUserOptions`) which serves as an example
* update user class (`CodeUpdateUser`) which contains a method that consumes the `UpdateUserOptions`


```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Membership;

namespace dnndocs.users
{

  public class UpdateUserOptions
  {
  
    /// <summary>
    /// Instance of DotNetNuke.Entities.Portals.PortalSettings
    /// </summary>
    public PortalSettings PortalSettings { get; set; }
  
    /// <summary>
    /// The UserID of the user to be updated
    /// </summary>
    public int UserId { get; set; }
  
    /// <summary>
    /// The new display name of the user
    /// </summary>
    public string DisplayName { get; set; }
  
    /// <summary>
    /// The new email of the user
    /// </summary>
    public string Email { get; set; }
  
    /// <summary>
    /// Optionally, a new username
    /// </summary>
    public string Username { get; set; }
  
    /// <summary>
    /// Example profile field for first name
    /// </summary>
    public string FirstName { get; set; }
  
    /// <summary>
    /// Example profile field for last name
    /// </summary>
    public string LastName { get; set; }
  
    /// <summary>
    /// Example of a custom profile property
    /// </summary>
    public string FavoriteFood { get; set; }
  
  }

  public class CodeUpdateUser
  {

    public UserInfo UpdateUser(UpdateUserOptions options)
    {


      var user = UserController.Instance.GetUser(options.PortalSettings.PortalId, options.UserId);
      if (user == null)
      {
        throw new ArgumentException("User not found.");
      }

      // If you're updating the portal administrator account, be sure to clear the portal cache
      if (user.UserID == options.PortalSettings.AdministratorId)
      {
        DataCache.ClearPortalCache(options.PortalSettings.PortalId, true);
      }

      // If you're updating a super user, be sure to clear the host cache
      if (user.IsSuperUser)
      {
        DataCache.ClearHostCache(true);
      }

      // Assign basic changes to user
      user.DisplayName = options.DisplayName;
      user.Email = options.Email;
      

      // If your portal has a display name format set, update the user's display name accordingly
      if (!string.IsNullOrEmpty(options.PortalSettings.Registration.DisplayNameFormat))
      {
        user.UpdateDisplayName(options.PortalSettings.Registration.DisplayNameFormat);
      }

      // If the username is different, we need to update it, but typically should not be done for super user accounts
      if (options.Username != user.Username && !user.IsSuperUser)
      {
        UserController.ChangeUsername(user.UserID, options.Username);
        user.Username = options.Username;
      }

      // Check if unique display name is required
      if (options.PortalSettings.Registration.RequireUniqueDisplayName)
      {
        var usersWithSameDisplayName = (List<UserInfo>) MembershipProvider.Instance()
          .GetUsersBasicSearch(options.PortalSettings.PortalId, 0, 2, "DisplayName", true, "DisplayName",
            user.DisplayName);
        if (usersWithSameDisplayName.Any(u => u.UserID != user.UserID))
        {
          throw new ArgumentException("DisplayNameNotUnique");
        }
      }

      // Update the user
      UserController.UpdateUser(options.PortalSettings.PortalId, user);


      // Optional, if you want to include a check to change username to email based on site settings
      if (options.PortalSettings.Registration.UseEmailAsUserName &&
          (user.Username.ToLowerInvariant() != user.Email.ToLowerInvariant()))
      {
        UserController.ChangeUsername(user.UserID, user.Email);
      }

      // Update the user profile
      user.Profile.InitialiseProfile(options.PortalSettings.PortalId);
      user.Profile.FirstName = options.FirstName;
      user.Profile.LastName = options.LastName;

      // You have access to all the basic properties (i.e. Street, City, Region, etc.)

      // Example of custom profile property
      user.Profile.SetProfileProperty("FavoriteFood", options.FavoriteFood);

      var properties = user.Profile.ProfileProperties;

      user = ProfileController.UpdateUserProfile(user, properties);

      return user;


    }
  }
}

```






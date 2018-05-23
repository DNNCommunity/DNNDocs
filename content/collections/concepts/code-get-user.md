---
title: Getting A User Programmatically
slug: get-user-programmatically
---

# Getting a User Programmatically

###### Related Topics

Required Assemblies:

* DotNetNuke.dll

`DotNetNuke.Entities.Users.UserInfo` is the class that represents a DNN user. There are 
several ways to retrieve a user programmatically. Here are the most common:

```csharp
namespace dnndocs.users
{
  public class CodeGetUser
  {
    
    /// <summary>
    /// Example returns an instance of UserInfo class
    /// </summary>
    /// <param name="portalId">The portal id of the user</param>
    /// <param name="userId">The user id of the user</param>
    /// <returns>DotNetNuke.Entities.Users.UserInfo</returns>
    public UserInfo GetUserById(int portalId, int userId)
    {
      
      var user = UserController.Instance.GetUserById(portalId, userId);

      return user;

    }

    /// <summary>
    /// Example returns an instance of UserInfo class based on the current user 
    /// </summary>
    /// <returns>DotNetNuke.Entities.Users.UserInfo</returns>
    public UserInfo GetCurrentUser()
    {
      var user = UserController.Instance.GetCurrentUserInfo();
      
      return user;
    }

    /// <summary>
    /// Example returns an instance of UserInfo class based on the display name 
    /// </summary>
    /// <param name="portalId">The portal id of the user</param>
    /// <param name="displayName">The display name of the user</param>
    /// <returns>DotNetNuke.Entities.Users.UserInfo</returns>
    public UserInfo GetUserByDisplayName(int portalId, string displayName)
    {
      var user = UserController.Instance.GetUserByDisplayname(portalId, displayName);
      
      return user;
    }   
    

  }
}
```






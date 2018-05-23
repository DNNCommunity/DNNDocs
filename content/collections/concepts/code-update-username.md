---
title: Updating A Username Programmatically
slug: update-username-programmatically
---

# Updating a User Programmatically

###### Related Topics

Required Assemblies:

* DotNetNuke.dll

```csharp
using System;
using DotNetNuke.Entities.Users;

namespace dnndocs.users
{

  

  public class CodeUpdateUsername
  {

    public void UpdateUsername(int portalId, int userId, string username)
    {


      var user = UserController.Instance.GetUser(portalId, userId);
      if (user == null)
      {
        throw new ArgumentException("User not found.");
      }
      
      UserController.ChangeUsername(user.UserID, username);
      
      
    }
  }
}

```






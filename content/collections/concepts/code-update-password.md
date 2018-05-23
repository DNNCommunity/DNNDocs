---
title: Updating A Password Programmatically
slug: update-password-programmatically
---

# Updating a User's Password Programmatically

###### Related Topics

Required Assemblies:

* DotNetNuke.dll

```csharp
using System;
using System.Threading;
using System.Web.Security;
using DotNetNuke.Entities.Users;
using DotNetNuke.Entities.Users.Membership;

namespace dnndocs.users
{
  public class CodeUpdatePassword
  {

    public bool ChangePassword(int portalId, int userId, string newPassword)
    {

      var user = UserController.Instance.GetUserById(portalId, userId);
      if (user == null)
      {
        return false;
      }

      var membershipPasswordController = new MembershipPasswordController();
      var settings = new MembershipPasswordSettings(user.PortalID);

      if (settings.EnableBannedList)
      {
        if (membershipPasswordController.FoundBannedPassword(newPassword) || user.Username == newPassword)
        {
          throw new Exception("Password reset failed");
        }
      }

      if (membershipPasswordController.IsPasswordInHistory(user.UserID, user.PortalID, newPassword, false))
      {
        throw new Exception("You've used this password in the past. Try another one.");
      }

      try
      {
        var passwordChanged = UserController.ResetAndChangePassword(user, newPassword);
        if (!passwordChanged)
        {
          throw new Exception("Password reset failed");
        }

        return true;
      }
      catch (MembershipPasswordException exc)
      {
        throw new Exception("Password is invalid.");
      }
      catch (ThreadAbortException)
      {
        return true;
      }
      catch (Exception exc)
      {
        throw new Exception("Password change failed.");
      }
    }
  }
}

```






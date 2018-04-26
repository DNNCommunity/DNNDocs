#Creating a User

Required Assemblies:

* DotNetNuke.dll

The process of creating a user is fairly simple. However, to properly safegaurd yourself and potential users accessing your application, it’s best to cover multiple scenarios and implement some defensive programming. For example:

* Does the username exist?
* Does the site require a unique display name?
* What about profanity filters?
* What about email notifications?

We’ll get to those items momentarily, but to serve a basic example, creating a user account looks like this:

```csharp
var newUser = new DotNetNuke.Entities.Users.UserInfo
{
  Username = "john",
  PortalID = PortalSettings.PortalID,
  Email = "john@doe.com",
  FirstName = "John",
  LastName = "Doe",
  DisplayName = "John Doe",
  Membership =
  {
    Password = "clintpatterson",
    PasswordConfirm = "clintpatterson",
    Approved = true
  },
  Profile =
  {
    PreferredLocale = new DotNetNuke.Services.Localization.Localization().CurrentUICulture
  }
};


newUser.Profile.InitialiseProfile(PortalSettings.PortalID);
newUser.Profile.PreferredTimeZone = PortalSettings.TimeZone;

// Final creation of the user
var createStatus = UserController.CreateUser(ref newUser);

// Clear cache
if (createStatus == DotNetNuke.Security.Membership.UserCreateStatus.Success)
{
  DotNetNuke.Common.Utilities.DataCache.ClearPortalCache(options.PortalSettings.PortalId, true);
}
else
{
  throw new Exception(UserController.GetUserCreateStatus(createStatus));
}
```

Because the creation of user accounts is somewhat of a fragile process, and to follow good programming practices, let’s walk through a scenario and add a few bells and whistles.

We’re creating an end-point for our application to programmatically create users, and we want to rely on the DNN settings for certain rules. Our end-client may change these settings at any time, and we want to ensure our code behaves accordingly.

Be sure to reference DotNetNuke.dll in your project.

First, let’s create a helper class to hold user creation properties:

```csharp
using DotNetNuke.Entities.Portals;

namespace DnnDocs.Users
{
  
  public class CreateUserOptions
  {
    /// <summary>
    /// Instance of DotNetNuke.Entities.Portals.PortalSettings 
    /// </summary>
    public PortalSettings PortalSettings { get; set; }

    /// <summary>
    /// The first name of the new user
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the new user
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The display name of the new user
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// The email address of the new user
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// The username of the new user
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// The password of the new user
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Whether or not the user should be initially approved
    /// </summary>
    public bool Authorize { get; set; }

    /// <summary>
    /// Whether or not to send email notifications upon creation
    /// </summary>
    public bool Notify { get; set; }

    /// <summary>
    /// Whether or not to generate a random password for the user
    /// </summary>
    public bool RandomPassword { get; set; }

    /// <summary>
    /// Whether or not to ignore the DNN registration mode settings (i.e. public, private)
    /// </summary>
    public bool IgnoreRegistrationMode { get; set; }
  }

}
```

Notice that the first property references an instance of `​DotNetNuke.Entities.Portals.PortalSettings`​. Your development stack of choice (i.e. WebAPI, WebForms, etc.) will determine the preferred method to retrieve the `PortalSettings` instance. See \<link-to-other-docs-page\> for examples.

Next, we’ll create a utility class with some static (i.e. shared) methods. These methods derive from the DNN source code and are, for the most part, used within the PersonaBar logic.

Don’t forget to add the `using` statements:

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security;
using DotNetNuke.Security.Membership;
using DotNetNuke.Security.Roles;
using DotNetNuke.Services.Localization;
using DotNetNuke.Services.Mail;
using DotNetNuke.Services.Social.Notifications;

namespace DnnDocs.Users
{
  
  [+] public class CreateUserOptions [...]
  
  public class UserUtilities
  {

    /// <summary>
    /// Reads settings from our DNN site that are expected to return a Boolean value
    /// </summary>
    public static bool GetBoolSetting(Hashtable settings, string settingKey)
    {
      return settings[settingKey] != null && Convert.ToBoolean(settings[settingKey]);
    }

    /// <summary>
    /// Reads settings from our DNN site that are expected to return a String value
    /// </summary>
    public static string GetStringSetting(Hashtable settings, string settingKey)
    {
      return settings[settingKey] == null ? string.Empty :  settings[settingKey].ToString();
    }

    /// <summary>
    /// If our DNN instance has excluded terms, it will clean them here
    /// </summary>
    public static string GetExcludeTermsRegex(Hashtable settings)
    {
      var excludeTerms = GetStringSetting(settings, "Registration_ExcludeTerms");
      var regex = String.Empty;
      if (!String.IsNullOrEmpty(excludeTerms))
      {
        regex = excludeTerms.Replace(" ", "").Replace(",", "|");
      }
      return regex;
    }

    /// <summary>
    /// This method is used to fetch the localized notification text
    /// </summary>
    public static string LocalizeNotificationText(string text, string locale, UserInfo user, PortalSettings portalSettings)
    {
      return Localization.GetSystemMessage(locale, portalSettings, text, user, Localization.GlobalResourceFile, null, "", portalSettings.AdministratorId);
    }

    /// <summary>
    /// This method is used to fetch the notification subject for new registrations
    /// </summary>
    public static string GetNotificationSubject(string locale, UserInfo newUser, PortalSettings portalSettings)
    {
      const string text = "EMAIL_USER_REGISTRATION_ADMINISTRATOR_SUBJECT";
      return LocalizeNotificationText(text, locale, newUser, portalSettings);
    }

    /// <summary>
    /// This method is used to fetch the notification body for new registrations
    /// </summary>
    public static string GetNotificationBody(string locale, UserInfo newUser, PortalSettings portalSettings)
    {
      const string text = "EMAIL_USER_REGISTRATION_ADMINISTRATOR_BODY";
      return LocalizeNotificationText(text, locale, newUser, portalSettings);
    }

    /// <summary>
    /// Html entities to clean from notification text
    /// </summary>
    public const string HtmlEntitiesPattern = @"&amp;([a-z]{2,10}|#\d{1,10}|#x[0-9a-f]{1,8});";
    public static readonly Regex HtmlEntitiesPatternRegex =
      new Regex(HtmlEntitiesPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(2));

    /// <summary>
    /// Based on the HtmlEntitiesPattern, clean the text
    /// </summary>
    public static string FixDoublEntityEncoding(string document)
    {
      return string.IsNullOrEmpty(document)
        ? document
        : HtmlEntitiesPatternRegex.Replace(document, "&$1;");
    }
    
    /// <summary>
    /// Handles sending admin notifications for new users
    /// </summary>
    public static void SendNewUserAdminNotification(UserInfo newUser, PortalSettings portalSettings)
    {
      var roleController = new RoleController();
      var adminrole = roleController.GetRoleById(portalSettings.PortalId, portalSettings.AdministratorRoleId);
      var roles = new List<RoleInfo> { adminrole };
      SendNewUserNotifications(newUser, portalSettings, roles);
    }

    /// <summary>
    /// Handles notifying the user 
    /// </summary>
    public static void SendNewUserNotifications(UserInfo newUser, PortalSettings portalSettings, List<RoleInfo> roles)
    {
      var notificationType = newUser.Membership.Approved ? "NewUserRegistration" : "NewUnauthorizedUserRegistration";
      var locale = LocaleController.Instance.GetDefaultLocale(portalSettings.PortalId).Code;
      var notification = new Notification
      {
        NotificationTypeID = NotificationsController.Instance.GetNotificationType(notificationType).NotificationTypeId,
        IncludeDismissAction = newUser.Membership.Approved,
        SenderUserID = portalSettings.AdministratorId,
        Subject = Users.UserUtilities.GetNotificationSubject(locale, newUser, portalSettings),
        Body = Users.UserUtilities.GetNotificationBody(locale, newUser, portalSettings),
        Context = newUser.UserID.ToString(CultureInfo.InvariantCulture)
      };

      notification.Body = Users.UserUtilities.FixDoublEntityEncoding(notification.Body);
      NotificationsController.Instance.SendNotification(notification, portalSettings.PortalId, roles, new List<UserInfo>());            
    }
  }

}
```

Feel free to read through the comments on these utilities. We’ll use them in a moment in the creation of an example user account.

Let’s go ahead and create a class and public method for creating user accounts:

```csharp
[+] using [...]

namespace DnnDocs.Users
{
  
  public class UserService
  {
    /// <summary>
    /// Create a DNN user account
    /// </summary>
    public UserInfo CreateUser(CreateUserOptions options)
    {
      // We'll create a user here!
    }
  }
  
  [+] public class CreateUserOptions [...]
  
  [+] public class UserUtilities [...]
  

}
```

We have our `CreateUserOptions` and `UserUtilities`​. Notice in the new `UserService` class, we have a public method called `CreateUser`, which will consume an instance of our `CreateUserOptions` class. This way, we can prevent tight coupling of our code and create user accounts from different entry points quite easily. 

For example, we could do something like this:

```csharp
var options = new CreateUserOptions();
options.Username = "john";
// etc.

var service = new UserService();
var john = service.CreateUser(options);
```

We’re finally ready to handle the full blown creation of our user account. Here is a full example. Be sure to read through the comments carefully:

```csharp
[+] using [...]

namespace DnnDocs.Users
{
  
  public class UserService
  {
    /// <summary>
    /// Create a DNN user account
    /// </summary>
    public UserInfo CreateUser(CreateUserOptions options)
    {
      // Will throw an exception of the email is empty
      Requires.NotNullOrEmpty("email", options.Email);

      // Unless we override the default site settings in our CreateUserOptions
      // If the site does not allow registration, throw an exception
      var disallowRegistration =
        !options.IgnoreRegistrationMode && 
        ((options.PortalSettings.UserRegistration == (int) Globals.PortalRegistrationType.NoRegistration) ||
         (options.PortalSettings.UserRegistration == (int) Globals.PortalRegistrationType.PrivateRegistration));
      
      if (disallowRegistration)
      {
        throw new Exception("Registration not allowed.");
      }

      // Initial creation of the new user object
      // If username was not passed, use email
      var newUser = new UserInfo
      {
        Username = string.IsNullOrEmpty(options.UserName) ? options.Email : options.UserName,
        PortalID = options.PortalSettings.PortalId,
        Email = options.Email,
        FirstName = options.FirstName,
        LastName = options.LastName
      };

      // Check existance of user and throw an error if the user exists
      if (UserController.GetUserByName(newUser.Username) != null)
      {
        throw new Exception("Username not available.");
      }

      // Set password based on our options, or generate a password
      if (!options.RandomPassword && !string.IsNullOrEmpty(options.Password))
      {
        newUser.Membership.Password = options.Password;
      }
      else
      {
        newUser.Membership.Password = UserController.GeneratePassword();
      }

      // Set confirm password to the same
      newUser.Membership.PasswordConfirm = newUser.Membership.Password;

      // Set initial profile properties
      newUser.Profile.PreferredLocale = new Localization().CurrentUICulture;
      newUser.Profile.InitialiseProfile(options.PortalSettings.PortalId);
      newUser.Profile.PreferredTimeZone = options.PortalSettings.TimeZone;

      // Set display name
      if (string.IsNullOrEmpty(options.DisplayName))
      {
        newUser.DisplayName = options.DisplayName;
      }
      else if (!string.IsNullOrEmpty(options.FirstName) && !string.IsNullOrEmpty(options.LastName))
      {
        newUser.DisplayName = $"{options.FirstName} {options.LastName}";
      }
      else
      {
        newUser.DisplayName = newUser.Email.Substring(0, newUser.Email.IndexOf("@", StringComparison.Ordinal));
      }

      // Fetch user settings for portal
      var settings = UserController.GetUserSettings(options.PortalSettings.PortalId);

      //Verify Profanity filter
      if (UserUtilities.GetBoolSetting(settings, "Registration_UseProfanityFilter"))
      {
        var portalSecurity = new PortalSecurity();
        if (!portalSecurity.ValidateInput(newUser.Username, PortalSecurity.FilterFlag.NoProfanity) || !portalSecurity.ValidateInput(newUser.DisplayName, PortalSecurity.FilterFlag.NoProfanity))
        {
          throw new Exception("Username violoates profanity filter.");
        }
      }

      // Validate Email Address
      var emailValidator = UserUtilities.GetStringSetting(settings, "Security_EmailValidation");
      if (!string.IsNullOrEmpty(emailValidator))
      {
        var regExp = RegexUtils.GetCachedRegex(emailValidator, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        var matches = regExp.Matches(newUser.Email);
        if (matches.Count == 0)
        {
          throw new Exception("Email address is invalid.");
        }
      }

      //Excluded Terms Verification
      var excludeRegex = UserUtilities.GetExcludeTermsRegex(settings);
      if (!string.IsNullOrEmpty(excludeRegex))
      {
        var regExp = RegexUtils.GetCachedRegex(excludeRegex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        var matches = regExp.Matches(newUser.Username);
        if (matches.Count > 0)
        {
          throw new Exception("Username has disallowed terms.");
        }
      }

      //User Name Validation
      var userNameValidator = UserUtilities.GetStringSetting(settings, "Security_UserNameValidation");
      if (!string.IsNullOrEmpty(userNameValidator))
      {
        var regExp = RegexUtils.GetCachedRegex(userNameValidator, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        var matches = regExp.Matches(newUser.Username);
        if (matches.Count == 0)
        {
          throw new Exception("Username is not valid.");
        }
      }

      //Ensure unique display name
      if (UserUtilities.GetBoolSetting(settings, "Registration_RequireUniqueDisplayName"))
      {
        var user = UserController.Instance.GetUserByDisplayname(options.PortalSettings.PortalId, newUser.DisplayName);
        if (user != null)
        {
         throw new Exception("Display name is not available.");
        }
      }

      //Update display name format
      var displaynameFormat = UserUtilities.GetStringSetting(settings, "Security_DisplayNameFormat");
      if (!string.IsNullOrEmpty(displaynameFormat)) newUser.UpdateDisplayName(displaynameFormat);

      //membership is approved only for public registration
      newUser.Membership.Approved = 
        (options.IgnoreRegistrationMode || 
         options.PortalSettings.UserRegistration == (int)Globals.PortalRegistrationType.PublicRegistration) &&
        options.Authorize;

      // Final creation of the user
      var createStatus = UserController.CreateUser(ref newUser);

      // Clear cache
      if (createStatus == UserCreateStatus.Success)
      {
        DataCache.ClearPortalCache(options.PortalSettings.PortalId, true);
      }
      else
      {
        throw new Exception(UserController.GetUserCreateStatus(createStatus));
      }

      //send notification to portal administrator of new user registration
      //check the receive notification setting first, but if register type is Private, we will always send the notification email.
      //because the user need administrators to do the approve action so that he can continue use the website.
      if (!options.IgnoreRegistrationMode && 
          (options.PortalSettings.EnableRegisterNotification ||
           options.PortalSettings.UserRegistration == (int) Globals.PortalRegistrationType.PrivateRegistration))
      {
        Mail.SendMail(newUser, MessageType.UserRegistrationAdmin, options.PortalSettings);
        UserUtilities.SendNewUserAdminNotification(newUser, options.PortalSettings);
      }

      //send email to user
      if (!options.Notify) return newUser;

      switch (options.PortalSettings.UserRegistration)
      {
        case (int) Globals.PortalRegistrationType.PrivateRegistration:
          Mail.SendMail(newUser, MessageType.UserRegistrationPrivate, options.PortalSettings);
          break;
        case (int) Globals.PortalRegistrationType.PublicRegistration:
          Mail.SendMail(newUser, MessageType.UserRegistrationPublic, options.PortalSettings);
          break;
        case (int) Globals.PortalRegistrationType.VerifiedRegistration:
          Mail.SendMail(newUser, MessageType.UserRegistrationVerified, options.PortalSettings);
          break;
      }

      // Finally, return our new user to the caller
      return newUser;
    }
  }
  
  [+] public class CreateUserOptions [...]
  
  [+] public class UserUtilities [...]
  

}
```






---
uid: configure-login-persistence
topic: configure-login-persistence
locale: en
title: Configure Login Persistence for Your Site
dnneditions:
dnnversion: 09.02.00
parent-topic: configuring-your-site
related-topics: update-site-info,access-web-config,administrators-extensions-overview
---

## Configure Login Persistence

### Prerequisites

- **An administrator account for the site.** Administrators have full permissions to the specific site.
- **Backup your web.config file.** Any type of error in `web.config` can instantly make .Net application stop working. If anything goes wrong, make sure you know how to restore your `web.config` easily.

### Need to Know

- These settings have existed in DNN since at least version 3.x
- By default DNN
  - shows the "Remember Login" checkbox
  - persists a login session for 60 mins (of inactivity)
  - does **not** extend your login persistence if "Remember Login" is checked
- These settings affect all Portals for this DNN instance
- Values for `timeout` and `PersistentCookieTimeout` are in minutes so 8 days is<br>`8 days x 24 hours x 60 mins = 10080`

### Steps

1.  Edit `web.config` in the website root (usually done via text editor or by accessing web.config in DNN's Settings / Config Manager [Access web.config](xref:access-web-config)).

2.  Update (or add) the following items to whatever values you require. All values are in minutes (i.e. 14 days is `14 x 24 hours x 60 minutes = 20160 minutes`).

    a. Under `<system.web>`, then in `<authentication ...` Look for the `forms` tag and update the `timeout` attribute. Update the value of `timeout` with the desired value in minutes. After your change, the `forms` tag might look like this:

    ```
      <forms name=".DOTNETNUKE" protection="All" timeout="120" cookieless="UseCookies" />
    ```

    b. In `<appSettings>`, update (or add) the key for extended login persistence. After setting it, your entry might look like this:

    ```
      <add key="PersistentCookieTimeout" value="20160" />
    ```

    > [!NOTE]
    > The above sets a) a default 2 hour session expiration and allows for b) a Remember Me option of 2 weeks via your cookie.

### Discussion

To rephrase, the user will create a seesion that stays logged in to the site

- with Remember un-checked (default); for 2 hours
- with Remember checked; for 14 days

Why 2 hours? Why 14 days? These are just examples. The durations you choose should balance the users and usage against the real or perceived security concerns. But that is a much bigger topic for someone else's deep thinking blog article.

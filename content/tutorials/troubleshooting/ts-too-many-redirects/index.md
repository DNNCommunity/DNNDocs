---
uid: ts-too-many-redirects
locale: en
title: "Troubleshooting: Resolving the Too Many Redirects Error"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Resolving the Too Many Redirects Error  

## Symptom  

This usually occurs when moving or migrating a website from one environment to another, but it can happen to brand new installations of DNN as well.  What happens is that when you attempt to view the website in the web browser, you receive the `ERR_TOO_MANY_REDIRECTS` error message in the web browser.  

> [!NOTE]  
> There is sometimes a `NullReferenceException` error that can occur under similar circumstances. These steps can be used to resolve that error as well.  

## Possible Cause

Usually a typo, but sometimes a simple misconfiguration when moving the website. The possible causes are listed below:  

* Typo: Malformed or incorrect values in the `connectionStrings` section of the web.config.  
* Typo: Incorrect website URL in the web.config, `PortalAlias` database table, `DefaultPortalAlias` row in the `PortalSettings` database table, IIS website bindings, and the SSL bindings.  
* Invalid web.config:  Invalid XML in the web.config.  
* Invalid web.config:  Unmerged updates in the web.config.  
* Invalid permissions in the website's folder.  
* Incompatible `urlRewrite` configuration.  
* Incompatible SSL Setup.  

> [!TIP]  
> Often, you can find the cause of the issue by looking at the log files in the `/Portals/_default/logs/` folder.  
> Tools like the Network Tools in the web browser or telerik's Fiddler can help you inspect the response headers to determine where and how to troubleshoot the correct cause above.  If this is a redirect issue, look for `x-redirect-reason` in the response headers.  

## Solutions  
Here are the solutions for the causes found above.  

### Typo  

Go to each area and copy then paste the correct values.  A typo in something like the URL or database username is super-easy to miss by looking at it.  

Be sure to review each of the following areas:  

* `connectionStrings` section of the web.config (includes database server, database name, username, and password)  
* `PortalAlias` database table  
* `DefaultPortalAlias` row in the `PortalSettings` database table  
* `PortalAliasMapping` row in the `PortalSettings` database table (the value usually should be `REDIRECT`, but may need to be changed to `NONE` or `CANONICALURL`)  
* HTTP and HTTPS website bindings in IIS  

This is the most common cause and solution for both the redirect and null errors.  

### Invalid web.config  

When copying and pasting values, it's very easy to accidentally add an unexpected character.  Compare the web.config before and after your change to determine if this is the correct solution.  

This includes the database passwords.  If you're generating the passwords using any security tool, be sure to remove any XML characters from the password.  This creates malformed XML.  

One of the easiest ways to troubleshoot the web.config is to [enable tracing in IIS](https://docs.microsoft.com/en-us/iis/troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis).  

### Invalid Permissions

[Reapply the permissions](xref:set-up-dnn-folder) to the main website folder and ensure that the permissions are propagated to all children folders.  

> [!TIP]  
> You may need to disable the permission inheritance, depending on your environment.  

### Incompatible urlRewrite Configuration  

Some websites may be adding URL rewrite rules in the web.config file itself.  While DNN has robust URL rewrite rules, this feature sometimes is necessary to use instead of DNN's URL rewrite features.  

When this is the case, this section may not be compatible with new locations where the website is being migrated to.  Careful review of each of these rules will need to be performed in order to determine which rule(s) may need to be removed.  

> [!TIP]  
> In development environments where you're restoring a staging or production website into it, you may find it easier to just remove that section entirely.  This is completely dependent on your specific needs.  

### Incompatible SSL Setup  

When you're using HTTPS/SSL and moving the website from one environment to another, you may be using a different Web Application Firewall (WAF) (e.g., Imperva, CloudFlare, etc.) or the WAF may be configured differently.  When this is the case, you might have to adjust how you're configuring SSL in DNN itself.  

For example, in development and/or staging, you may be using the `Enable SSL` and `Enforce SSL` settings to be sure that pages and other website assets are loading over HTTPS.  However, you may need to turn those off in production because both DNN and the WAF are both trying to redirect to the SSL version of the requested URL.  (Or vice versa...)  

---
uid: ts-mixed-content-ssl
locale: en
title: "Troubleshooting: Mixed-Content Warnings When Using SSL Offloading"

dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Mixed-Content Warnings When Using SSL Offloading

## Symptom

Mixed-content warnings, such as:

*   Internet Explorer: Only secure content is displayed.
*   Firefox: Firefox has blocked content that isn't secure.
*   Chrome: This page includes script from unauthenticated sources.

## Possible Cause

A secured page (HTTPS) contains unsecured links (HTTP) to some resources (images, scripts, etc.).

## Solution

1.  Configure the SSL Offload Header Value as required by your load balancers.

    Examples:
    *   [Citrix supports custom headers and recommends using SSL_REQUEST.](https://docs.citrix.com/en-us/netscaler/12/ssl/config-ssloffloading.html)
    *   [Weblogic uses a fixed header of WL-Proxy-SSL.](https://fusionsecurity.blogspot.com/2011/04/ssl-offloading-and-weblogic-server.html)
    *   BigIP/F5 supports custom headers via their iRule rewrite function.
2.  Go to the page to edit.
3.  Go to Persona Bar \> Edit.
4.  In the Edit Bar, click/tap the Page Settings icon.



    ![Page Settings icon](/images/scr-pb-EditBar-PageSettings.png)



5.  Go to the Advanced tab, and then the More subtab.![Advanced > More](/images/scr-pbtabs-all-Content-Pages-Advanced-More-E91.png)
6.  Under Security, enable Secure Connection.



    ![Security > Secure Connection](/images/scr-pb-Page-Advanced-Security.png)

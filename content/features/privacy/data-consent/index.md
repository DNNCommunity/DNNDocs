---
uid: data-consent-overview
locale: en
title: Data Consent
dnnversion: 09.04.00
---

# Data Consent

In DNN 9.4 Data Consent was introduced. This feature addresses the demands made by the EU's [General Data Protection Regulation](https://en.wikipedia.org/wiki/General_Data_Protection_Regulation), or GDPR. This regulation came into effect in 2018 and is aimed at giving users control of their data.

The directive is vast and includes many stipulations, but for websites a few stand out:
1. You need to be transparent about the data you keep about your users
2. You need to ask consent from users to store this data
3. Every time you change the conditions you'll need to ask all users again for their permission
4. A user must be able to request that their data be removed from the site and the site's owners must do so within a reasonable time frame
5. A user can request to see all data being stored about them and the site's owners must  comply within a reasonable time frame

The DNN platform cannot provide complete GDPR compliance out-of-the-box (many aspects will probably not apply to your situation), but it now includes a number of features that help site owners address #2, #3 and #4 above automatically.

## Settings

![Privacy Settings](/images/privacy-dc-settings.png)

### Data Consent Active

This is a "master switch" for all Data Consent features. If switched **off**, all data consent features are inactive and DNN behaves as it did before.

If switched **on** users will need to consent to the terms and conditions of the site. For more details and how this appears to the end user, [see this page](xref:data-consent-user-consent).

### Consent Redirect

This allows the data consent feature to be extended using a 3rd party solution. This setting is a redirection to a page on the site where further handling of consent will occur. If **not specified** then DNN will handle consent.

[More Details](xref:data-consent-redirect)

### User Delete Action

This determines the mechanism used to allow users to remove themselves from the website.

[More Details](xref:data-consent-user-delete)

### Reset Terms and Conditions

When clicked it is assumed the terms and conditions have changed and users will need to consent again to them.

## User Management

The user management module has been enhanced to allow site administrators to see the status of users and take approriate action if needed.

[More Details](xref:data-consent-user-management)

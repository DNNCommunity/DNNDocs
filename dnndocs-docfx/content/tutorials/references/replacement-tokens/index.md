---
uid: replacement-tokens
locale: en
title: DNN Replacement Tokens
_description: "Adding one or more of the below replacement tokens into content enables site or user data to be displayed to site users. An example would be to display the site description as part of the content of an HTML module on the About Us page, or adding a personalized salutation to the beginning of Newsletters."
dnnversion: 09.02.00
---

# Replacement Tokens

Tokens are formatted text which are replaced by real time information such as the site name or the date and time when rendered. For example: The token [DateTime:Now] displays the current date and time on your site. Tokens can be added to DNN skins, language files and the HTML module. Adding one or more of the below replacement tokens into content enables site or user data to be displayed to site users.

An example use would be to display the Site Description as part of the content of an HTML module on the "About Us" page, or adding a personalized salutation to the beginning of Newsletters.

| **Replacement Token** | **Example** | **Replacement Token Description** |
|---|---|---|
| **Culture Tokens** |
| [Culture:EnglishName] | French (Canada) | The name of the culture in english |
| [Culture:Lcid] | 3084 | The id of the culture. |
| [Culture:Name] | fr-CA | The string identifier for the culture. |
| [Culture:NativeName] | Français (Canada) | The name of the culture expressed in the language of that culture.
| [Culture:TwoLetterIsoCode] | fr | The 2 letter ISO code for the language. |
| [Culture:ThreeLetterIsoCode] | fra | The 3 letter ISO code for the language. |
| [Culture:DisplayName] | French (Canada) | The display name of the culture. |
| [Culture:LanguageName] | French | The language portion only of the DisplayName. |
| [Culture:LanguageNativeName] | Français | The language portion only of the NativeName. |
| [Culture:CountryName] | Canada | The region portion only of the DisplayName. |
| [Culture:CountryNativeName] | Canada | The region portion only of the NativeDisplayName. |
| **Portal Tokens** |
| [Portal:Currency] | USD | Displays the site currency type as set on the Site Settings screen. |
| [Portal:Description] | DNNCommunity.org is the Official Home of the DNN Community. | Displays the site description as set on the Site Settings screen. |
| [Portal:Email] | admin@dnncommunity.org | Displays the email address of the primary Administrator as set on the Site Settings screen. |
| [Portal:FooterText] | Copyright 2020 DNN Community | Displays the copyright text entered in the Copyright field on the Site Settings screen. |
| [Portal:HomeDirectory] | /Portals/0 | Relative Path of the Portals Home Directory. |
| [Portal:LogoFile] | logo.gif | Site Path to Logo file. E.g. logo.gif |
| [Portal:PortalName] | DNN Portal's Site Title | The Site Title as set on the Site Settings screen. |
| [Portal:URL] | DNN Portal's URL | The Site URL - `http(s)://` not included. |
| [Portal:FullURL] | DNN Portal's Full URL | The Site URL - `http(s)://` included. |
| [Portal:TimeZoneOffset] | -480 | Difference in minutes between the default site time and UTC. |
| **User Tokens** |
| [User:DisplayName] | George Washington | The display name of the user. |
| [User:Email] | info@DNNCommunity.org | The email address of the user. |
| [User:FirstName] | George | The first name of the user. |
| [User:LastName] | Washington | The last name of the user. |
| [User:Username] | GWashington | The username of the user. |
| **Membership Tokens** |
| [Membership:Approved] | Yes / No | Indicates if the user is approved. |
| [Membership:CreatedDate] | 10/4/2020 1:08 PM | Displays the date and time when the user registered on the site. |
| [Membership:IsOnline] | Yes / No | Indicates if the user is currently online. |
| Page (Tab) Tokens |
| [Tab:Description] | Welcome to Site Name | Displays the description of the current page. |
| [Tab:FullUrl] | https://dnncommunity.org/community/user-groups | Displays the full URL of the current page. |
| [Tab:IconFile] | icon.gif | Page relative path to icon file. |
| [Tab:KeyWords] | DNN, CMS, Content Management, Content Management System, DNNCMS, open source, aspnet, net, net core, web application, website development, microsoft, community, dotnetnuke,DotNetNuke | Displays the keywords for the current page. |
| [Tab:TabName] | Home | Page name |
| [Tab:TabPath] | //Parent//Page | Page relative path (as it is saved within the database with double slash) |
| [Tab:URL] |  | Page URL |
| **Date Tokens** |
| [DateTime:Now] | 10/15/2014 5:39 PM | Current date and time. |
| [DateTime:Now\|f] | Tuesday, October 26, 2014 5:39 PM | Displays long date and short time. |
| [DateTime:Now\|F] | Tuesday, October 26, 2014 5:39:20 PM | Displays long date and long time. |
| [DateTime:Now\|g] | 10/26/2014 5:39 PM | Displays short date and short time. |
| [DateTime:Now\|G] | 10/26/2014 5:39:20 PM | Displays short date and long time. |
| [DateTime:Now\|Y] | October, 2014 | Displays year and month. |
| [DateTime:UTC] | 10/15/2014 5:39 PM | Coordinated Universal Time. |
| [DateTime:UTC\|f] | Tuesday, October 26, 2014 5:39 PM | Coordinated Universal Time - long date and short time. Other appended options are F, g, G and Y; as for DateTime above. |
| [DateTime:System] | 10/15/2014 5:39 PM | Displays date and time as per local settings. |
| [DateTime:System\|f] | Tuesday, October 26, 2014 5:39:20 PM | Displays date and time as per local settings. This example displays long date and short time. Other appended options are F, g, G and Y; as for DateTime above. |
| **Tick Tokens** |
| [Ticks:Now] | 633282985407609550 | CPU tick count for current second. |
| [Ticks:Today] | 633282624000000000 | CPU tick count since midnight. |
| [Ticks:TicksPerDay] | 864000000000 | CPU ticks per day (for calculations) |

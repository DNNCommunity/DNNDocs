---
topic: theme-objects-1
locale: en
title: Theme Objects
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: designer-references
related-topics: persona-bar-style-guide,dnn-manifest-schema,designers-included-modules-overview,requirements,product-versions,dnn-overview,control-bar-to-persona-bar,persona-bar-by-role,dnn-license,DNN-security,more-resources
links: ["[DNN UX Guide](http://uxguide.dnnsoftware.com/)","[DotNetNuke Skinning Guide (Appendix B: Skin Objects) by Timo Breumelhof](http://www.timo-design.nl)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](http://www.10poundgorilla.com)"]
---

# Theme Objects

## Overview

Theme objects (skin objects) are a type of DNN extension used in themes to provide additional functionality for common UI elements on a webpage.

ACTIONBUTTON

Displays an action from the module action menu.

BREADCRUMB

Displays the path to the current tab (`>` is the default separator). Example: `PageName1 > PageName2 > PageName3`

CONTROLPANEL

Displays the DNN control panel. If the CONTROLPANEL theme object is not used in the theme, then DNN inserts a control panel control at the top of the page.

COPYRIGHT

Displays the copyright notice for the website.

CURRENTDATE

Displays the current date on the server.

DDRMENU

Displays a menu using the DDRMenu control.

DNNCSSEXCLUDE

Prevents a stylesheet reference from being included in the page.

DNNCSSINCLUDE

Adds a stylesheet reference to the page.

DNNJSEXCLUDE

Prevents a JavaScript file reference from being included in the page.

DNNJSINCLUDE

Adds a JavaScript file reference to the page.

DOTNETNUKE

Displays the copyright notice for DNN.

DROPDOWNACTIONS

Displays the module action menu as a dropdown list.

HELP

Displays a Help link, which sends an email to the website's administrator, using the user's default email client.

HOSTNAME

Displays the host title linked to the host URL. The host title and host URL are defined on the host settings page.

ICON

Displays the module icon.

JQUERY

Adds jQuery JavaScript reference to the page.

LANGUAGE

Displays the language selector dropdown list or the language flags based on the theme object attribute settings.

LEFTMENU

Displays a vertical menu layout.

LINKS

Displays a flat menu of links associated with the current tab level and the parent node.

LOGIN

Displays Login for anonymous users and Logout for authenticated users.

LOGO

Displays the website's logo.

NAV

Displays a menu according to the type specified in the ProviderName attribute.

PRINTMODULE

Displays a link for the Print action from the module action menu.

PRIVACY

Displays a link to the Privacy Information page for the website.

SEARCH

Displays the search input box.

SIGNIN

Displays the login control.

STYLES

Allows you to add Internet Explorer-specific stylesheets to your theme.

TAGS

Displays the Tag control allowing users to view and edit tags associated with the page or module.

TERMS

Displays a link to the Terms and Conditions page of the website.

TEXT

Displays localized text in your theme and supports the use of token replacement.

TITLE

Displays the module title.

TOAST

Adds the toast notification control to the page. Toast messages will be shown when a new user notification or message is received.

TREEVIEW

Displays a menu, similar to the Windows Explorer menu, using the DNN Treeview Control.

USER

Displays a Register link for anonymous users or the user's name for authenticated users.

VISIBILITY

Displays a visibility control for the module allowing users to show or hide a given module on the page.
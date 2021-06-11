---
uid: ts-error-another-user-has-taken-action-on-the-page
locale: en
title: "Error: Another User Has Taken Action on the Page"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Error: Another User Has Taken Action on the Page and its state has been changed. Please, refresh the page to see the current state.

## Symptom

Error:

Another user has taken action on the page and its state has been changed. Please refresh the page to see the current state.

## Possible Cause

Another user made a change that conflicts with your changes.

## Possible Solution 1

1.  Exit the edit mode and refresh the page.
2.  Enter the edit mode.
3.  Redo your changes, if necessary.
4.  Publish the changes.

## Possible Solution 2

In some circumstances, exiting and re-entering edit mode will not correct the block on editing. In this scenario, other options such as copying modules to another page or duplicating a page may also not function as workarounds. While the records can be cleared within the database, a method of workaround within the DNN interface is as follows:

Use A Page Template To Copy The Page
1.  Select the Persona Bar > Pages screen.
2.  At the top of the screen, use the "Save Page Template" dropdown to select "Evoq Page Template".
3.  Name the temporary Page Template.
4.  Create a new page and at the bottom of the creation form, In the Template Mode section, use the dropdown to select "Evoq Page Template" and choose the recently created template. This generates a new page with the same content.
5.  Delete the old page, clear it from the recycling bin, clear the cache of the site and then rename the new page to the original page name.
6.  After, you may delete the Page Template if desired.

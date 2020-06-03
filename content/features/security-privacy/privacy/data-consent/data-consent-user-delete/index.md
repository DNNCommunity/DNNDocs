---
uid: data-consent-user-delete
locale: en
title: Data Consent User Removal
dnnversion: 09.04.00
firstappearedinversion: 09.04.00
---

# Data Consent User Removal

To make it easier for site administrators to comply with EU GDPR regulations, this feature enables site users to remove themselves from the site. This is irreversable and by its definition leads to loss of data so care must be taken to fully understand the options and consequences.

A central difficulty in implementing a user delete mechanism is that 3rd party extensions may have data that relies on the user data. Deleting the user record from the database may have unintended consequences and/or lead these modules to break. Because the data regulations do not require *immediate* removal, this feature has the following options:

1. Off.

The deletion mechanism is switched off and no "Delete Me" button is showed on the data consent screen.

2. Manual

A user is marked as wishing to be deleted but no further action is taken. It is up to the site administrator to follow up or a 3rd party extension to handle this.

3. Delayed Hard Delete

A user is marked as wishing to be deleted and soft deleted (the user is still in the database but cannot log in and is marked as deleted only). A scheduled task ("Purge Deleted Users") finds these users and deletes them. 

In the settings you can specify how long the "grace period" is for this. I.e. how long the users still have to contact administrators to undo thier action.

> [!Note]
> Users that have been soft-deleted but not marked as wishing to be deleted (this would be possible through some external mechanism) are **not** removed (purged) by this task.

4. Hard Delete

A user is immediately removed from DNN. This is the most radical approach and would mean that immediately after the user requests this, there is no way to recover from this action.

## About user removal in DNN

A central feature of DNN is "site virtualization" meaning you can run many websites (called "portals") off the same DNN instance. When the so-called "asp.net's membership provider" was implemented to take care of user authentication (storing usernames and passwords) in DNN 3, due to its design users would be shared between portals. This has led to some awkwardness such as when a user registers on another portal of a DNN installation where he/she already has an account. In this case a new link is created between the old user and the new portal.

One consequence of this design is that user removal is not straightforward. When the DNN user removal logic kicks in (which is called by the logic described above) a user is only completely removed once that user is no longer present in any other portal. Otherwise only the link between the portal and the user is deleted. So the deletion mechanisms 3 and 4 above cannot guarantee that the user is actually removed from the DNN instance/database.

## User experience

When a user opts to "Delete Me" during data consent or "UnRegister" on the user account management page, a warning is shown explaining the user of the consequence of this action:

![User delete confirm](/images/privacy-dc-user3.png)

This offers the user a last chance to abort the action. If the user continues the action the user is logged off and can no longer use his/her credentials to log in (regardless of the user delete mechanism).

## Customizing

The texts displayed for the various data consent steps are stored in DesktopModules/Admin/Security/App_LocalResources/DataConsent.ascx.resx

> [!NOTE]
> See also [Data Consent User Managent](xref:data-consent-user-management)

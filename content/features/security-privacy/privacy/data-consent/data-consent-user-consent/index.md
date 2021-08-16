---
uid: data-consent-user-consent
locale: en
title: Data Consent User Consent
dnnversion: 09.04.00
firstappearedinversion: 09.04.00
---

# Data Consent User Consent

If the Data Consent master switch is on in DNN, all users will need to consent to the terms and conditions before being fully logged in. In DNN's default setup and theme this works as follows:

1. After the user logs in he/she is presented with the following screen:

![User must agree](/images/privacy-dc-user1.png)

> [!Note]
> The submit button will remain inactive until the user has checked the checkbox. The "terms of use" and "privacy statement" links point to the places defined in DNN.

2. After checking the checkbox the user can click "Submit" to finalize agreement.

![User agrees](/images/privacy-dc-user2.png)

3. The user is now logged in and will not be challenged again until the admin has reset terms and conditions.

If the user **does not agree** and clicks **Cancel** the user is logged off.

If the no user delete mechanism has been specified in the settings, **the "Delete Me" button will not show**.

If the user **clicks "Delete Me"** the [User Delete Mechanism](xref:data-consent-user-delete) kicks in.

> [!NOTE]
> See also [Data Consent User Managent](xref:data-consent-user-management)

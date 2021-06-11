---
uid: data-consent-redirect
locale: en
title: Data Consent Redirect
dnnversion: 09.04.00
firstappearedinversion: 09.04.00
---

# Data Consent Redirect

When specified the user, upon logging in and having been authenticated but found to be needing to consent to the terms and conditions, is redirected. The idea behind this feature is that 3rd party extensions can embed themselves in the consent flow and offer more fine grained consent options.

## Technical Details

A central challenge in extending the data consent flow of DNN is that before data consent a user is not logged in. I.e. after the page redirect the user is not set in DNN and the user will appear to be logged out. To give the 3rd party handler a way to get to the user, a token is passed in the querystring. For this the workflow copies the Password Reset mechanism. The 3rd party extension can use the token (which is valid by default for 60 minutes) to find the user who is trying to log in. It is left to the extension developer to handle this wisely and ensure the extension token doesn't live longer than necessary and the user is logged in at the end of the process.

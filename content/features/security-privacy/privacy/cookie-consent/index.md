---
uid: cookie-consent
locale: en
title: Cookie Consent
dnnversion: 09.03.01
firstappearedinversion: 09.03.00
---

# Cookie Consent

![Privacy Settings](/images/privacy-cc-settings.png)

Cookie Consent allows you to conform to EU law. First required in the ePrivacy Directive in 2002, websites should inform users that they are using cookies to track them from one page request to another. As a website owner you are required to ask consent from users for using cookies.

Given that DNN is a web application and requires users to log on to perform certain functions, it depends heavily on cookies to be able to work correctly. So cookie consent comes in the form of "I inform you that ..." rather than "Can I do ...?" since the user that does not wish to have cookies sent by DNN cannot use the site without them.

Is switched on every user (including unauthenticated users) will be presented by a consent banner informing them the site uses cookies and a general link to get more information about cookies. Upon clicking OK, the site will set a cookie in that browser so that the consent banner is not shown on subsequent requests.

![Cookie Consent](/images/privacy-cc-sample.png)

This means that if a user uses another computer and/or browser, or if the user clears all cookies, the consent banner will be shown again. The DNN site does not store this consent! It is only stored on the client computer.

## Customization


### Link

You can make the "Learn More" link point to another resource on the web. The default link points to [https://cookiesandyou.com/](https://cookiesandyou.com/)

### Localization

The texts displayed on the banner are stored in the App_GlobalResources/GlobalResources.resx file in the following keys:

| Key             | Value                                                                           |
| --------------- | ------------------------------------------------------------------------------- |
| cc_dismiss.Text | Got it!                                                                         |
| cc_link.Text    | Learn More                                                                      |
| cc_message.Text | This website uses cookies to ensure you get the best experience on our website. |

### Look and Feel

The cookie consent implementation in DNN is based on [Insite's freely available Cookie Consent library](https://cookieconsent.insites.com/). If you wish to learn about how you can tweak the look and feel in a skin/theme, go to the documentation of this library.

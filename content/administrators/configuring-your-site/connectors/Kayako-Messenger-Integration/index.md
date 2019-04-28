---
uid: kayako-messenger-integration
locale: en
title: Kayako Messenger Integration
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
---

# Introduction
![Kayako Logo](/images/kayako-messenger.png)

[Kayako](https://www.kayako.com/) is a helpdesk software which comes in two flavors - Kayako Classic (KC) and The New Kayako (TNK). TNK is offered as a SaaS solution, where KC is offered as both SaaS and OnPrem. TNK is the newer version; this integration is about TNK and DNN.

## Kayako Messenger
TNK offers a messenger which can be embedded on any website. It allows a website visitor to directly interact with the helpdesk. The messenger requires visitors to provide their email to initiate conversation with the helpdesk agents. It also shows the online agents and average response times.

The messenger remembers the visitor after the initial conversation and allows the visitor to continue the conversation from any page on the website.

![Kayako Messenger Overview](/images/kayako-messenger-overview.png)

## Having Messenger on DNN
DNN allows it’s website visitors to interact in a variety of ways such as - posting on a forum, filling forms, commenting, liking, social sharing, etc. However, it lacks the live interaction capability that the TNK messenger provides.

The Kayako and DNN integration bridge the gap by providing a simple way to have the messenger deployed on all of DNN’s pages.

## Configuration in Kayako
There isn’t a lot that needs to be done in Kayako. Simply go to the Agent’s area > settings gear icon > Messenger > Configure > Follow the two-step wizard and click ‘Save configuration’ in the ‘Options’ tab.

![Kayako Messenger Settings](/images/kayako-messenger-settings.png)

## Configuration in DNN
Kayako integration is available in Evoq Basic, Evoq Content, and Evoq Engage. Configuration is very simple - Persona Bar > Settings > Connectors > Kayako, and type your brand name, which is the name before .kayako.com in the URL.

As an example, if your Kayako URL is mycompany.kayako.com, you’d enter ‘mycompany’.

![Kayako Messenger Connector](/images/kayako-messenger-connector.png)


As soon as you click save and refresh the page, the messenger icon will appear on the page


![Kayako Messenger Button](/images/kayako-messenger-button.png)


You can click on the icon to open the messenger and start typing your question. It will show you the available agents as well.


![Kayako Messenger Frame](/images/kayako-messenger-frame.png)


Messenger will ask for your email before proceeding


![Kayako Messenger Email](/images/kayako-messenger-email.png)


It will also tell you the time it will take someone to answer your question


![Kayako Messenger Chat](/images/kayako-messenger-chat.png)

### FAQ

**Which version of DNN will have this?**

Version 9.2.2 and above.

**Which editions of DNN will have this?**

Evoq Basic, Evoq Content and Evoq Engage.

**Does the DNN Platform have this?**

No.

**Do I need to be part of Prime to use this feature?**

We recommend that you take advantage of the Prime program. However, you can buy DNN and Kayako separately and still use this feature.

**Will this work in the trial versions of DNN or Kayako?**

Yes

**Once enabled, does the Messenger show on all the pages?**

Almost all. We don’t show the messenger when you are in edit mode or in an admin or host page.

**Can I exclude certain pages, e.g., the Home page?**

No. It’s on the roadmap to give you the option to exclude certain pages.

**Will it make DNN run slower?**

No. The messenger talks directly with Kayako. DNN is responsible for enabling of the Messenger only.

**Is the integration available in Kayako Classic?**

No. It’s not on the roadmap.

---
uid: activate-license-automatically
locale: en
title: Activate Your License Automatically
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
related-topics: activate-license-manually,faq-licensing,troubleshooting-licensing
links: ["[DNN Evoq Licensing](https://dnnsupport.dnnsoftware.com/hc/en-us/articles/360004881714-DNN-Evoq-Licensing)","[DNN Community video: Activating a Development or Production License](https://www.dnnsoftware.com/community/learn/video-library/view-video/video/359/view/details/how-to-activate-a-license-in-dotnetnuke)"]
---

# Activate Your License Automatically

## Prerequisites

To activate a license, you need the invoice number(s) sent to you in an email after your purchase and the email address associated with each invoice. Each license will have its own invoice number (e.g., INV00x-1, INV00x-2, INV00x-3).

If you are unable to find the required information, contact [Customer Support](https://www.dnnsoftware.com/services/customer-support).

Note: You might need to modify your firewall settings to allow a query to the DNN licensing web service: [https://www.dotnetnuke.com/desktopmodules/bring2mind/licenses/licensequery.asmx](https://www.dotnetnuke.com/desktopmodules/bring2mind/licenses/licensequery.asmx).

## Steps

1.  Go to **Persona Bar \> Settings \> About**.

    ![Persona Bar > Settings > About](/images/scr-pbar-host-Settings-E91.png)


2.  Click **Add License**.

    ![Click Add License.](/images/scr-LicensingActivate-E90.png)

3.  Fill in the required information.



    ![Choose License Type, enter Account Email and Invoice Number, then click Automatic Activation.](/images/scr-LicensingAddAuto-E90.png)



    1.  Select the License Type from the list.

        Important: The selected License Type must match the license type of the invoice you are using.

        The license type can be:

        *   Production (default)
        *   Staging
        *   Failover
        *   Test
        *   Development

        The **Web Server** name is prefilled with the server name stored in the WebServers table of the current site's database.

    2.  Enter the **Account Email** and **Invoice Number** associated with your license.
    3.  Click **Automatic Activation**.

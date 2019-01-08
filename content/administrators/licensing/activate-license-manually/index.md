---
uid: activate-license-manually
topic: activate-license-manually
locale: en
title: Activate Your License Manually
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-licensing-overview
related-topics: activate-license-automatically,faq-licensing,troubleshooting-licensing
links: ["[DNN KB: Licensing](http://customers.dnnsoftware.com/KB/c48/licensing.aspx)","[DNN Community video: Activating a Development or Production License](http://www.dnnsoftware.com/community/learn/video-library/view-video/video/359/view/details/how-to-activate-a-license-in-dotnetnuke)"]
---

# Activate Your License Manually

## Prerequisites

To activate a license, you need the invoice number(s) sent to you in an email after your purchase and the email address associated with each invoice. Each license will have its own invoice number (e.g., INV00x-1, INV00x-2, INV00x-3).

If you are unable to find the required information, contact [Customer Support](http://www.dnnsoftware.com/services/customer-support).

Note: You might need to modify your firewall settings to allow a query to be sent to the [DNN licensing web service](http://www.dotnetnuke.com/desktopmodules/bring2mind/licenses/licensequery.asmx).

## Steps

1.  Go to Persona Bar \> Settings \> About.
    
    ![Persona Bar > Settings > About](/images/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Click Add License.
    
      
    
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
        
        The Web Server name is prefilled with the server name stored in the WebServers table of the current site's database.
        
    2.  Enter the Account Email and Invoice Number associated with your license.
    3.  Click Manual Activation.
4.  Get an activation key.
    
      
    
    ![Copy the encoded server ID, paste it in the website to get an activation key, paste the activation key, then click Submit Activation Key.](/images/scr-LicensingManual-E90.png)
    
      
    
    Tip: If your server does not have access to the Internet, you can access the DNN Professional License Request page on dnnsoftware.com from another machine and transfer the keys through a local network or a secure flash drive.
    
    1.  Click Request an activation key on dnnsoftware.com to open [the Professional License Request page](http://www.dnnsoftware.com/services/customer-support/success-network/license-management/ctl/requestlicense/mid/1189).
    2.  Copy the encoded server ID from the Evoq dialog to the dnnsoftware.com License Request form.
    3.  In the License Request form, click Generate Activation Key.
    4.  Copy the generated activation key from the License Request form to the Evoq dialog.
    5.  In Evoq, click Submit Activation Key.
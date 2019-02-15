---
uid: troubleshooting-licensing
topic: troubleshooting-licensing
locale: en
title: "Troubleshooting: Licensing"
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-licensing-overview
related-topics: activate-license-automatically,activate-license-manually,faq-licensing
links: ["[DNN KB: Licensing](http://customers.dnnsoftware.com/KB/c48/licensing.aspx)"]
---

# Troubleshooting: Licensing

Important: If your Evoq instance is hosted on the DNN Cloud, please contact [Evoq Customer Support](http://www.dnnsoftware.com/services/customer-support) directly. The following instructions are not applicable to DNN Cloud instances.

## Trial message still appears after activating license.

Even after a license has been activated, the trial version message still appears.

You are using an unlicensed and unsupported version of .... Please contact your Systems Administrator for information on how to obtain a valid license.

You are using a trial version of Evoq .... You currently have ... days remaining before your trial period expires.

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

*   Verify that your license is activated and that you are using the correct license type.
    
    1.  Go to **Persona Bar \> Settings \> About**.
        
        ![Persona Bar > Settings > About](/images/scr-pbar-host-Settings-E91.png)
        
    2.  Check that the invoice number appears in the list and that a check appears in the Activated column for this license.
    3.  Verify that the correct invoice number, email, and license type are used.
        
        An invoice for one Evoq product cannot be used to license a different Evoq product. Example: An Evoq Content invoice is invalid for Evoq Engage.
        
    
    If the license is not activated,
    
    *   [Activate License Automatically](xref:activate-license-automatically).
    *   If the server does not have Internet access while the license is being activated on it, see [Activate License Manually](xref:activate-license-manually).
    
    If the license type is incorrect, contact [Customer Support](http://www.dnnsoftware.com/services/customer-support).
    
*   Was the site moved from one server to another?
    
    If so, verify that the license is activated at both the server level and the IIS level. The [Licensing FAQ](xref:faq-licensing) contains more details on this and a guide to activating a license correctly.
    
*   [Clear your cache.](xref:clear-cache)
*   Check your web.config.
    
    Additional symptom: You might also see the following error linked to DotNetNuke.Professional.Application.ProApplication.CheckLicense():
    
    String reference not set to an instance of a String.
    
    1.  [Access the web.config file.](xref:access-web-config)
    2.  Verify that the following nodes exist in web.config (The date and license type may differ.):
        
        *   InstallationDate:
            
            ```
            
                <add key="InstallationDate" value="9/2/2009" />
                                                
            ```
            
        *   Two licensing nodes:
            
            ```
            
                <add name="Licensing" type="DotNetNuke.Professional.HttpModules.LicenseValidatorModule, DotNetNuke.Professional" preCondition="managedHandler" />
                <add name="Licensing" type="DotNetNuke.Professional.HttpModules.LicenseValidatorModule, DotNetNuke.Professional" />
                                                
            ```
            
        
*   Are you running the application pool under a custom domain account in Microsoft .NET Framework 4?
    1.  Verify that the Application Pool Identity account / domain user has a valid profile.
    2.  Verify that the profile is not read-only; otherwise, the license key is not decrypted and the trial version message is displayed.
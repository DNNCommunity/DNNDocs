---
topic: ts-how-to-increase-max-upload-file-size
locale: en
title: How to: Increase the Maximum File Size for Upload
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-troubleshooting-overview
related-topics: ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# How to: Increase the Maximum File Size for Upload

The maximum file size must be multiples of 1024.

*   1024 bytes = 1 kilobyte (KB)
*   1024 KB = 1 megabyte (MB)
*   1024 MB = 1 gigabyte (GB)

## Steps

1.  [Access the web.config file.](access-web-config)
2.  Update the `httpRuntime` tag with the maximum file size you want.
    1.  Look for the `httpRuntime` tag.
        
        The default `httpRuntime` tag might look as follows:
        
        ```
        
        <httpRuntime targetFramework="4.5" shutdownTimeout="120" executionTimeout="1200" useFullyQualifiedRedirectUrl="true" maxRequestLength="29296" requestLengthDiskThreshold="81920" maxUrlLength="2048" requestPathInvalidCharacters="&lt;,&gt;,*,%,:,\,?" enableVersionHeader="false" requestValidationMode="2.0" fcnMode="Single" />
                                    
        ```
        
    2.  Replace the value of maxRequestLength with the maximum file size you want.
        
        Note: maxRequestLength is stored as kilobytes. Example: You can use 2097152 KB (equivalent to 2 GB).
        
3.  If you need to upload files that are greater than 28 MB on IIS7+ or on Cloud Services, add a `<system.webServer/>` node to specify the maxAllowedContentLength for requests.
    
    Note: maxAllowedContentLength is stored as bytes. Example: You can use 2147483647 bytes (equivalent to 2 GB).
    
    Add the following node to your web.config:
    
    ```
    
    <system.webServer>
        <security>
          <requestFiltering>
            <requestLimits maxAllowedContentLength="2147483647" />
          </requestFiltering>
        </security>
    </system.webServer>
                        
    ```
    
4.  Save.
5.  [Recycle the application pool](https://technet.microsoft.com/en-us/library/cc770764(v=ws.10).aspx) to allow the changes to take effect.
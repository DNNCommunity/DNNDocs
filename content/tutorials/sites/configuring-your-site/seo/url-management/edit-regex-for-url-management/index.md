---
uid: edit-regex-for-url-management
locale: en
title: Edit RegEx for URL Management
dnnversion: 09.02.00
related-topics: configure-url-rewriter,configure-url-redirects,manage-url-providers,test-url-generation
---

# Edit RegEx for URL Management

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to Persona Bar \> Settings \> SEO.
    
    ![Persona Bar > Settings > SEO](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the URL Management tab, and then the Expressions subtab.
    
    ![URL Management > Expressions](/images/scr-pbtabs-host-Settings-SEO-URLManagement-Expressions-E91.png)
    
3.  Enter the regular expression to define the set for the behavior.
    
      
    
    ![URL Management > Expressions](/images/scr-SEO-URLManagement-Expressions-E91.png)
    
      
    
    |Field|Description|
    |---|---|
    |<strong>Ignore URL Regular Expression</strong>|Defines the set of URLs that should be ignored for rewriting, redirecting, or any other processing by the URL Rewriter. Typically, these would be images, CSS files, PDF files, and other assets.|
    |<strong>Do Not Rewrite URL Regular Expression</strong>|Defines the set of URLs that should be ignored for rewriting.|
    |<strong>Site URLs Only Regular Expression</strong>|Defines the set of URLs that must be first checked against the siteURLs.config file, which contains explicit rewriting and redirect instructions.|
    |<strong>Do Not Redirect URL Regular Expression</strong>|Defines the set of URLs that should not be redirected under any condition.|
    |<strong>Do Not Redirect Https URL Regular Expression</strong>|Defines the set of URLs that should not be redirected if the redirect would go from HTTP to HTTPS or vice versa.|
    |<strong>Prevent Lowercase URL Regular Expression</strong>|Defines the set of URLs that should not be set to lowercase. Use this if the URL contains an encoded character or a case-sensitive code.|
    |<strong>Do Not Use Friendly URLs Regular Expression</strong>|Defines the set of URLs that should be preserved. Typically used for backward compatibility.|
    |<strong>Keep in Querystring Regular Expression</strong>|Defines the part of a generated URL that must be preserved in the query string. Example: If this field contains /key/value and a generated URL is /pagename/key/value, then the generated URL is replaced with /pagename?key=value|
    |<strong>URLs With No Extension Regular Expression</strong>|Defines the set of URLs for pages or resources that are not on the server, are not a DNN page, and can be requested without an extension. These URLs will not return a 404 status even if the page or resource is not found.|
    |<strong>Valid Friendly URL Regular Expression</strong>|Defines the set of characters that are valid for a friendly URL. Characters that do not match the regular expression will be deleted from the generated URL.|
    
4.  Save.

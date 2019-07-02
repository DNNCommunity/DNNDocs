---
uid: security-headers
locale: en
title: Security Headers in DNN
dnnversion: 09.02.00
---

# Introduction to Security Headers  

In our battle against hackers we have a lot of work these days. And as with most topics: perfection is a lot of simple things done right.  

We have instructed our customers to use complex passwords, we got a firewall, login using SSL and added a [content security policy (CSP)](xref:content-security-policy). Another topic would be security headers.  

Like CSP the security headers are aiming to restrict HTTP response headers from running into easily preventable vulnerabilities. The project can be found here:  

* [OWASP > Security Headers](https://www.owasp.org/index.php/OWASP_Secure_Headers_Project)

A pretty good place for more information about [security headers can be found on KeyCDN.com](https://www.keycdn.com/blog/http-security-headers/).  

Okay, I want this. Now what do I do with it?  

Open the `web.config` and find the `customHeaders` section. 

In the example below, you might want to remove the content security policy as this is a seperate topic.

> [!NOTE]
> 
> As always... Remember to backup your `web.config` for easy roll back.  Even a minor mistake can break features or even cause your website to go down.  
> 

## Example of the Code  

```xml
<httpProtocol>
    <customHeaders>
        <add name="X-XSS-Protection" value="1; mode=block" />
        <add name="X-Content-Type-Options" value="nosniff" />
        <add name="Strict-Transport-Security" value="max-age=31536000; includeSubDomains; preload" />
        <add name="Content-Security-Policy" value="default-src * ;" />
        <remove name="X-Powered-By" />
        <remove name="X-AspNet-Version" />
        <remove name="X-AspNet-Version" />
        <remove name="X-AspNetMvc-Version" />
        <remove name="Vary" />
        <add name="Vary" value="Accept-Encoding" />
        <add name="Referrer-Policy" value="no-referrer-when-downgrade" />
    </customHeaders>
</httpProtocol>
```

## Did You Do it Correctly?  

You can check your website on [SecurityHeaders.com](https://securityheaders.com).

> [!NOTE] 
> Check ‘hide results’ to prevent others from gaining information about your vulnerable website.

## Are There Any Reasons to Not Do This?  

First of all, if you include a csp, you might want to check the website below:  

[https://caniuse.com/#feat=contentsecuritypolicy](https://caniuse.com/#feat=contentsecuritypolicy)

Only modern browsers are fully compatible with these configuration updates.  

Furthermore, the `<add name="X-Content-Type-Options" value="nosniff" />` tag has been known to sometimes cause issues in Internet Explorer 11 in instances where images are handled by an imagehandler (resizer).  The tag prevented Internet Explorer 11 from understanding that the images were actually images which made the browser want to interpret the images as HTML.  

It is up to you whether you want to include this tag.  If you desire, wait a bit until Internet Explorer 11 has a usage that is below a threshold that you find acceptable.  

### Related Content

* [Content Security Policy in DNN](xref:content-security-policy)  
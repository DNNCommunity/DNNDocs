---
uid: content-security-policy
locale: en
title: Content Security Policy (CSP) in DNN
dnnversion: 09.02.00
---

# Content Security Policy (CSP) in DNN

Since the internet has existed, people have been trying to deface websites, hack applications, and distribute malware.  Some of the ways we attempt to mitigate this includes using firewalls to keep unwanted visitors out and implementing SSL to secure traffic between admins and the website.  

Of course, there are still other security issues to address.  One of them is cross site scripting (XSS).  An example could be that we have a user profile that offers a biography section with rich text.  Rich text allows users to add some markup to their content (bold, color, etc.) and sometimes even call scripts from other websites.  And of course, these scripts can be hostile.  

In this never-ending battle there is a concept that can help prevent this, referred to as content security policy (CSP).  CSP allows you to define what content can be displayed on your website.  For instance, you may want to allow videos from YouTube or Vimeo (but no other website).  And maybe you want to execute scripts from your CDN but nowhere else.  

More in-depth information about CSP can be found on Mozilla's website below:  

* [https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP](https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP)  

## What Features Can We Use in Our Own CSP?  

There is a lot that we can define.  We have all kinds of resources loading from our websites, but the most common are images, scripts, styles, fonts, and media.  We can set these types to allow our own content and websites that we select.  Mind you, sometimes those websites also use external sources because they use Bootstrap, Open Sans, icons, etc.  It can easily require multiple iterations to have your CSP set correctly and completely.  

Here is a helpful cheat sheet to get you started: 

* [https://scotthelme.co.uk/csp-cheat-sheet/](https://scotthelme.co.uk/csp-cheat-sheet/)

## Do I Need to Create this from Scratch?  

No.  Here are some easy-to-follow-steps:

1. Start with a default version (see below).  
2. Visit your website to see what has been blocked by your CSP.  
3. Import your CSP using: [https://report-uri.com/home/generate](https://report-uri.com/home/generate)  
4. Adjust the items you need and generate a new CSP version.

> [!NOTE]
> 
> As always... Remember to backup your `web.config` for easy roll back.  Even a minor mistake can break features or even cause your website to go down.  
> 

The fastest way to work on this (_besides a staging or UAT environment_) is:

1. Have an FTP app like [Filezilla](https://filezilla-project.org/) ready.  
2. Download the working `web.config` and rename it to something useful, like `web-ORIGINAL.config`.  
3. Download the version again, this will be the one work-in-progress.  

## Now where do I put this CSP?  

The CSP is placed in your `web.config` in the `customHeaders` section. T here is an example below.  

This version has some common items incorporated for when Bootstrap is used, as well as Google Fonts, and some native share buttons.  

```xml
<httpProtocol>
    <customHeaders>
        <add name="Content-Security-Policy" value="default-src 'self' ; script-src 'self' 'unsafe-inline' 'unsafe-eval' https://www.google-analytics.com https://www.googletagmanager.com https://*.twitter.com https://apis.google.com/js/plusone.js https://platform.linkedin.com/in.js https://assets.pinterest.com/js/pinit.js https://static.ak.fbcdn.net https://cdn.syndication.twimg.com connect-src; style-src 'self' 'unsafe-inline' http://fonts.googleapis.com https://maxcdn.bootstrapcdn.com; img-src * data: ; media-src 'none' ; object-src 'self' ; frame-src https://www.youtube.com https://i.s-microsoft.com https://platform.twitter.com  https://syndication.twitter.com/;" />
    </customHeaders>
</httpProtocol>
```

## Are There Any Reasons to Not Implement a CSP?  

Not all browsers fully support CSP.  If you have websites that are being visited by people with older web browsers, you might serve them websites that are not working properly.  

You can check the current status of this using the website below.  

* [https://caniuse.com/#feat=contentsecuritypolicy](https://caniuse.com/#feat=contentsecuritypolicy)

### Related Content

* [Security Headers in DNN](xref:security-headers)  

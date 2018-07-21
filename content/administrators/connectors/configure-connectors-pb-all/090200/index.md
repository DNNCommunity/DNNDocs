---
topic: configure-connectors-pb-all
locale: en
title: Configure Connections to External Service Providers
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-connectors-overview
---

# Configure Connections to External Service Providers

## Steps

1.  Go to Persona Bar \> Settings \> Connectors.
    
    ![Persona Bar > Settings > Connectors](img/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Under Configure Connections, choose the service provider in the list and click/tap Connect or Edit.
    
      
    
    ![Configure Connections expanded tabs](img/scr-pbarSettings-Connectors.gif)
    
      
    
3.  Provide the information required by the service provider.
    
    Tip: Some connectors can be configured further in the Advanced Settings dialog, if available. Simply click/tap Connect, then click/tap the gear icon for that connector.
    
      
    
    ![Connectors gear icon](img/scr-pbarSettings-Connectors-Zendesk-gear.png)
    
      
    
    Provider
    
    Fields
    
    Amazon S3
    
    *   Access Key ID
    *   Secret Access Key
    
    [How to get your Amazon S3 access key ID and secret.](http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSGettingStartedGuide/AWSCredentials.html)
    
    Azure
    
    *   Account Name
    *   Account Key
    *   Container. The type of data that you want to be synchronized with Azure.
        *   backups
        *   portals
        *   wad-iis-logfiles (Azure logfiles)
    
    [How to get your Azure account name and key.](https://azure.microsoft.com/en-us/documentation/articles/storage-create-storage-account/#create-a-storage-account)
    
    Box
    
    *   Client ID
    *   Client Secret
    
    [How to get your Box client ID and secret.](https://app.box.com/developers/services)
    
    Disqus
    
    *   Disqus Shortname
    *   API Key
    
    [How to get your Disqus shortname and API key.](http://disqus.com/api/applications/) Disqus URL is Disqus Shortname; the Public Key is the API Key.
    
    DropBox
    
    *   App Key
    *   App Secret
    
    [How to get your Dropbox app key and secret.](https://www.dropbox.com/developers/support) Scroll down to "Where can I find my app key and secret?"
    
    Facebook
    
    *   App ID
    *   App Secret
    
    [How to get your Facebook app ID and secret.](https://developers.facebook.com/docs/apps/register)
    
    Google Analytics
    
    *   Tracking ID
    
    [How to get your Google Analytics tracking ID.](https://support.google.com/analytics/answer/1032385)
    
    Click/tab the gear icon to create segmentation rules in Advanced Settings. For each rule,
    
    *   Name and Value. The key-and-value pair that defines the criteria for the segmentation. Example: To create a segment that includes the activities of registered users only,
        *   Set Name to Registered User.
        *   Set Value to True.
    *   Page. The pages whose associated activity to analyze.
    *   Role. The roles whose associated activity to analyze.
    
    For more information, see [How to Segment Your Visitors in Google Analytics Using Evoq](http://www.dnnsoftware.com/blog/how-to-segment-your-visitors-in-google-analytics-using-evoq).
    
      
    
    ![Google Analytics Advanced Settings](img/scr-pbarSettings-Connectors-GoogleAnalyticsAdvSettings.png)
    
      
    
    LinkedIn
    
    *   API Key
    *   API Secret
    
    [How to get your LinkedIn API key and secret.](https://developer.linkedin.com/docs/oauth2)
    
    MailChimp
    
    *   API Key
    
    [How to get your MailChimp API key.](http://kb.mailchimp.com/integrations/api-integrations/about-api-keys)
    
    After saving the API Key, click/tab the gear icon to configure user and list associations in Advanced Settings.
    
      
    
    ![MailChimp Advanced Settings](img/scr-pbarSettings-Connectors-MailChimpAdvSettings.png)
    
      
    
    Marketo
    
    *   Munchkin Account ID
    
    [How to get your Marketo Munchkin account ID.](http://docs.marketo.com/display/public/DOCS/Add+Munchkin+Tracking+Code+to+Your+Website)
    
    Optimizely
    
    *   Optimizely Snippet
    
    [How to get your Optimizely snippet.](https://help.optimizely.com/Set_Up_Optimizely/Implement_the_Optimizely_snippet#2._Retrieve_the_snippet)
    
    Twitter
    
    *   API Key
    *   API Secret
    
    [How to get your Twitter API key and secret.](https://dev.twitter.com/oauth/overview)
    
    ZenDesk
    
    *   Zendesk URL
    *   Agent Email
    *   Agent Password
    
    [How to create a ZenDesk agent.](https://support.zendesk.com/hc/en-us/articles/203661986-Adding-end-users-agents-and-administrators)
    
    Click/tab the gear icon to select fields to track in Advanced Settings.
    
    *   Select Additional Fields
    
      
    
    ![Zendesk Advanced Settings](img/scr-pbarSettings-Connectors-ZendeskAdvSettings.png)
    
      
    
4.  Click/tap Save.
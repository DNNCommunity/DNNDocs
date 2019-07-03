---
uid: configure-connectors-pb-all
locale: en
title: Configure Connections to External Service Providers
dnnversion: 09.02.00
---

# Configure Connections to External Service Providers

## Steps

1.  Go to **Persona Bar \> Settings \> Connectors**.

    ![Persona Bar > Settings > Connectors](/images/scr-pbar-host-Settings-E91.png)

2.  Under **Configure Connections**, choose the service provider in the list and click/tap **Connect** or **Edit**.



    ![Configure Connections expanded tabs](/images/scr-pbarSettings-Connectors.gif)



3.  Provide the information required by the service provider.

    > [!Tip]
    > Some connectors can be configured further in the Advanced Settings dialog, if available. Simply click/tap Connect, then click/tap the gear icon for that connector.



    ![Connectors gear icon](/images/scr-pbarSettings-Connectors-Zendesk-gear.png)



    |**Provider**|**Fields**|
    |---|---|
    |<strong>Amazon S3</strong>|<ul><li><strong>Access Key ID</strong></li><li><strong>Secret Access Key</strong></li></ul><br />[How to get your Amazon S3 access key ID and secret.](https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_create.html)|
    |<strong>Azure</strong>|<ul><li><strong>Account Name</strong></li><li><strong>Account Key</strong></li><li><strong>Container</strong>: The type of data that you want to be synchronized with Azure.<ul><li><strong>backups</strong></li><li><strong>portals</strong></li><li><strong>wad-iis-logfiles (Azure logfiles)</strong></li></ul></ul><br />[How to get your Azure account name and key.](https://docs.microsoft.com/en-us/azure/storage/common/storage-quickstart-create-account?tabs=azure-portal#create-a-storage-account-1)|
    |<strong>Box</strong>|<ul><li><strong>Client ID</strong></li><li><strong>Client Secret</strong></li></ul><br />[How to get your Box client ID and secret.](https://developer.box.com/)|
    |<strong>Disqus</strong>|<ul><li><strong>Disqus Shortname</strong></li><li><strong>API Key</strong></li></ul><br />[How to get your Disqus shortname and API key.](https://disqus.com/api/docs/) Disqus URL is Disqus Shortname; the Public Key is the API Key.|
    |<strong>DropBox</strong>|<ul><li><strong>App Key</strong></li><li><strong>App Secret</strong></li></ul><br />[How to get your Dropbox app key and secret.](https://www.dropbox.com/developers/support) Scroll down to "Where can I find my app key and secret?"|
    |<strong>Facebook</strong>|<ul><li><strong>App ID</strong></li><ul><li><strong>App Secret</strong></li></ul><br />[How to get your Facebook app ID and secret.](https://developers.facebook.com/docs/apps#register)|
    |<strong>Google Analytics</strong>|<ul><li><strong>Tracking ID</strong></li></ul><br />[How to get your Google Analytics tracking ID.](https://support.google.com/analytics/answer/1032385)<br /><br />Click/tab the gear icon to create segmentation rules in Advanced Settings. For each rule, <ul><li><strong>Name and Value</strong>: The key-and-value pair that defines the criteria for the segmentation. Example: To create a segment that includes the activities of registered users only,<ul><li>Set Name to `Registered User`</li><li>Set Value to `True`</li></ul><li><strong>Page</strong>:The pages whose associated activity to analyze.</li><li><strong>Role</strong>:The roles whose associated activity to analyze.</li></ul><br />For more information, see <br />[How to Segment Your Visitors in Google Analytics Using Evoq](https://www.dnnsoftware.com/blog/how-to-segment-your-visitors-in-google-analytics-using-evoq).<br /><br />![Google Analytics Advanced Settings](/images/scr-pbarSettings-Connectors-GoogleAnalyticsAdvSettings.png)|
    |<strong>LinkedIn</strong>|<ul><li><strong>API Key</strong></li><li><strong>API Secret</li></ul><br />[How to get your LinkedIn API key and secret.](https://docs.microsoft.com/en-us/linkedin/shared/authentication/authentication)|
    |<strong>MailChimp</strong>|<ul><li><strong>API Key</strong></li></ul><br />[How to get your MailChimp API key.](https://mailchimp.com/help/about-api-keys/)<br />After saving the API Key, click/tab the gear icon to configure user and list associations in Advanced Settings.<br /><br />![MailChimp Advanced Settings](/images/scr-pbarSettings-Connectors-MailChimpAdvSettings.png)|
    |<strong>Marketo</strong>|<ul><li><strong>Munchkin Account ID</strong></li></ul><br />[How to get your Marketo Munchkin account ID.](https://docs.marketo.com/display/public/DOCS/Add+Munchkin+Tracking+Code+to+Your+Website)|
    |<strong>Optimizely</strong>|<ul><li><strong>Optimizely Snippet</strong></li></ul><br />[How to get your Optimizely snippet.](https://help.optimizely.com/Classic/Implement_the_snippet_for_Optimizely_Classic#2._Retrieve_the_snippet)|
    |<strong>Twitter</strong>|<ul><li><strong>API Key</strong></li><li><strong>API Secret</strong></li></ul><br />[How to get your Twitter API key and secret.](https://developer.twitter.com/en/docs/basics/authentication/overview)|
    |<strong>ZenDesk</strong>|<ul><li><strong>Zendesk URL</strong></li><li><strong>Agent Email</strong></li><li><strong>Agent Password</strong></li></ul><br />[How to create a ZenDesk agent.](https://support.zendesk.com/hc/en-us/articles/203661986-Adding-agents-and-administrators)<br /><br />Click/tab the gear icon to select fields to track in Advanced Settings.<ul><li><strong>Select Additional Fields</strong></li></ul><br />![Zendesk Advanced Settings](/images/scr-pbarSettings-Connectors-ZendeskAdvSettings.png)|



4.  Click/tap **Save**.

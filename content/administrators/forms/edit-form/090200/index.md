---
topic: edit-form
locale: en
title: Edit a Form
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-forms-overview
related-topics: create-form,duplicate-form,delete-form,embed-form,view-form-responses,content-fields-versus-form-fields,about-hidden-fields,save-form-responses-to-structured-content
---

# Edit a Form

## Steps

1.  Go to Persona Bar \> Content \> Forms.
    
    ![Persona Bar > Content > Forms](/images/scr-pbar-host-Content-E91.png)
    
    ➊
    
    ➋
    
2.  Click/Tap the ellipses for the form you want, and choose Edit.
    
      
    
    ![Click/Tap the ellipses for the form > Edit](/images/scr-Forms-List-ellipsesmenu-Edit.png)
    
      
    
3.  Manage the fields of the form.
    
    The Submit button is automatically added when the form has one or more fields.
    
    1.  To add a new field, drag and drop a field type to the canvas, then configure its settings.
        
          
        
        ![Drag and drop a field to the canvas](/images/scr-FormField-Add.png)
        
          
        
    2.  To edit a field, click/tap on the field in the canvas, then configure its settings.
        
          
        
        ![Click/Tap a field in the canvas](/images/scr-FormField-Edit.png)
        
          
        
    3.  To duplicate a field, hover over the field in the canvas, click/tap the duplicate icon, then configure the settings of the new copy.
        
          
        
        ![Click/Tap a field in the canvas](/images/scr-FormField-Hover-Dup.png)
        
          
        
    4.  To delete a field, hover over the field in the canvas, and click/tap the trash icon.
        
          
        
        ![Click/Tap a field in the canvas](/images/scr-FormField-Hover-Del.png)
        
          
        
4.  Configure the properties of the form.
    1.  Click/Tap the Configuration tab.
        
          
        
        ![Form > Configuration](/images/scr-Form-ConfigurationTab.png)
        
          
        
    2.  In the General Settings tab.
        
        ![Form Configuration - General Settings](/images/scr-Form-Config-GeneralSettings.png)
        
        Field
        
        Description
        
        Form Name
        
        This value appears at the top of the page.
        
        Tags
        
        A comma-separated list of tags to associate with the form. You can also press Enter after typing each tag.
        
        Campaigns
        
        Choose or create a marketing campaign that you want this form to be part of.
        
        Form Description
        
        Information about the form.
        
    3.  In the Data Collection tab.
        
        ![Form Configuration - Data Collection](/images/scr-Form-Config-DataCollection.png)
        
        Field
        
        Description
        
        Evoq Content Type
        
        If configured, data in form submissions are converted into content items of the specified content type for use as structured content. To configure, choose the content type for the new content items that would be populated with data from the form submissions, then map the form fields to the content type fields. See [Save Form Responses to Structured Content](save-form-responses-to-structured-content).
        
        Custom URL
        
        If connected, data in form submissions are sent to the specified Custom Endpoint URL for processing and storage.
        
        Google Analytics
        
        If connected, the form submissions are tracked using Google Analytics. To connect, click/tap Connect then fill in the information required by Google Analytics.
        
        *   Tracking ID. This is provided by Google Analytics.
        *   Event Category. Leave as Form.
        *   Event Action. Leave as Submit, if you want the event to be logged only when the user submits the form.
        *   Event Label. The name of the event. Default: The name of the form.
        *   Event Value. A value associated with the event. Default: 0.
        
        Hidden Fields
        
        If configured, the specified Field Identifier-Value pairs (max 10) would be returned with the user's completed form. See [About Hidden Fields](about-hidden-fields).
        
    4.  In the Form Submission tab.
        
        ![Form Configuration - Form Submission](/images/scr-Form-Config-FormSubmission.png)
        
        Field
        
        Description
        
        Confirmation Message
        
        If enabled (On), displays the specified message after the user submits the form.
        
        Respondent Email Notification
        
        If enabled (On), an email is sent to the user after submitting the form. If the form includes an email address field, the addressee (To:) would be prepopulated with the email address entered in that field.
        
        Provide a Download
        
        If enabled (On), allows the user to download the specified file(s) after the user submits the form.
        
        Redirect URL
        
        If enabled (On), the user is redirected to the specified URL after the user submits the form. You can optionally specify a delay.
        
    5.  In the Notifications tab.
        
        ![Form Configuration - Notifications](/images/scr-Form-Config-Notifications.png)
        
        Field
        
        Description
        
        Receive Self Notifications
        
        If enabled (On), you can configure a custom email to be sent to the specified address(es) whenever a completed form is submitted.
---
topic: save-form-responses-to-structured-content
locale: en
title: Save Form Responses to Structured Content
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-forms-overview
related-topics: create-form,edit-form,duplicate-form,view-form-responses,about-hidden-fields
---

# Save Form Responses to Structured Content

DNN provides a connector that links the Form Builder microservice with the Structured Content microservice. With this connector, you can save pieces of a response to a form as a structured content, which you can then reuse. Example: If your website uses a form to collect reviews and ratings from your readers, you can save those reviews and ratings in the Structured Content microservice to be published in another page in your website.

## Prerequisites

**Both the Form Builder and the Structured Content microservices must be enabled for your site.**

## Steps

1.  Go to Persona Bar \> Content \> Forms.
    
    ![Persona Bar > Content > Forms](img/scr-pbar-host-Content-E91.png)
    
    ➊
    
    ➋
    
2.  Create or edit a form.
    *   [Create a form.](create-form)
    *   [Edit a form.](edit-form)
3.  Click/Tap the Configuration tab.
    
      
    
    ![Form > Configuration](img/scr-Form-ConfigurationTab.png)
    
      
    
4.  Go to the Data Collection tab.
    
      
    
    ![Form Configuration - Data Collection](img/scr-Form-Config-DataCollection.png)
    
      
    
5.  Click/Tap the Configure button for Evoq Content Type.
6.  Choose the content type for the new content items that will hold data from the form submissions. Then click/tap Save & Configure.
    
      
    
    ![Form Configuration - Data Collection - Evoq Content Type - Content Type, then Save & Configure](img/scr-Form-Config-DataCollection-EvoqContentType-ContentType.png)
    
      
    
7.  Fill in the content item information.
    
      
    
    ![Form Configuration - Data Collection - Evoq Content Type - Fill in the content item information.](img/scr-Form-Config-DataCollection-EvoqContentType-ContentItemInfo.png)
    
      
    
    Field
    
    Description
    
    Content Item Name
    
    Choose the form field to use as the content item name.
    
    Content Item Tags
    
    Tags to associate with the created content items.
    
    Content Item Description
    
    The description for each content item created.
    
8.  Under Configure Content Type Fields from Form (Mapping), choose the equivalent form field for every content type field.
    
      
    
    ![Form Configuration - Data Collection - Evoq Content Type - Map the fields of the form to the fields of the content type.](img/scr-Form-Config-DataCollection-EvoqContentType-Mapping.png)
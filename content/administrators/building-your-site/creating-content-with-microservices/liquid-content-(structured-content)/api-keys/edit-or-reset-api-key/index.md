---
uid: edit-or-reset-api-key
locale: en
title: Edit or Reset the API Key
dnneditions: Evoq Engage
dnnversion: 09.02.00
related-topics: create-api-key,get-existing-api-key,delete-api-key
---

# Edit or Reset the API Key

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.
*   **Microservices must be enabled for your site.**

## Steps

1.  Go to **Persona Bar \> Content \> Content Library**.
    
    ![Persona Bar > Content > Content Library](/images/scr-pbar-host-Content-E91.png)
    
2.  Go to the **API Keys** tab.
    
    ![API Keys](/images/scr-pbtabs-host-Content-ContentLibrary-APIKeys-E91.png)
    
3.  Search for the API key in the list.
    
      
    
    ![API key list](/images/scr-APIKey-list-E91.png)
    
      
    
4.  Click/Tap the pencil icon for the API key.
    
      
    
    ![API key list > pencil icon](/images/scr-APIKey-list-pencil-icon-E91.png)
    
      
    
5.  Update the properties of the API key.
    
      
    
    ![API key name and permissions](/images/scr-APIKey-properties-existing-E91.png)
    
      
    
    1.  Update a human-friendly name for the API key.
    2.  Change the permissions associated with the API key.
        
        > [!NOTE]
        > An API key is associated with the content items of a specific site; i.e., the site that was current when the key was created.
        
    3.  (Optional) To copy the API key to your clipboard, click/tap the Copy Key.
        
        > [!NOTE]
        > The Copy Key does the same thing as the clipboard icon in the list.
        
    4.  (Optional) To reset the API key, click/tap the Reset Key.
        
        > [!WARNING]
        > This action cannot be undone, whether other changes are saved or not. Reset Key immediately deletes the old key and replaces it with a new one. Third-party apps that use the old key will no longer be able to access your content items unless you provide them with the new key.
        
6.  Save.

---
uid: use-module-creator
locale: en
title: Use the Module Creator
dnnversion: 09.02.00
next-topic: create-module-using-templates
related-topics: module-module-creator,web-forms-module-development,spa-module-development,mvc-module-development
---

# Use the Module Creator

## Overview

The DNN Module Creator enables developers to quickly build modules without a full-blown IDE, like Visual Studio. It automates many of the initial module creation tasks so that module developers can focus on writing code. In addition, the Module Creator can be extended with custom templates to further streamline development.

The DNN Module Creator is generally recommended only for simple modules. For more complex modules, you can create a Web Forms module using templates.

## Prerequisites

*   [A local DNN installation](xref:set-up-dnn) with Host permissions.

## Steps

1.  Create, copy, or edit a page.
    *   [Create a page.](xref:obsolete)
    *   [Copy a page.](xref:obsolete)
    *   [Edit a page.](xref:obsolete)
2.  Within a pane, click/tap on the module icon.
    
      
    
    ![Pane with content icons](/images/scr-pane-with-content-icons-module.png)
    
      
    
3.  Search for the Module Creator among the installed modules.
    
      
    
    ![Search for Module Creator.](/images/scr-menuModulesList04ModuleCreator.png)
    
      
    
4.  Drag the Module Creator module to any pane in the webpage.
    
      
    
    ![Drag to a pane.](/images/scr-menuModulesModuleCreatorDrag.png)
    
      
    
5.  Fill in the Module Creation form.
    
      
    
    ![Module Creation form](/images/scr-ModuleCreatorForm.png)
    
      
    |**Field**|**Description**|
    |---|---|
    |**Owner Name**|Name of your organization. Must contain only alphanumeric characters. Used to create a folder to distinguish your modules from those created by other module creators. Also used as the namespace for your code.|
    |**Module Name**|Must contain only alphanumeric characters. Used to create the module's friendly name and full name. The full name is \[OwnerName\].\[ModuleName\] with space characters removed.|
    |**Language**|The selected language (C#, VB, or Web) determines which templates become available.|  
    |**Template**|For **C#** and **VB**, choose among:<ul><li>**Inline Script**. Code is embedded. Also uses user controls.</li><li>**Razor**. Uses Razor scripts to render views.</li><li>**User Control**. Code is stored in separate files. Most commonly used.</li></ul>For **Web**, the **HTML** template allows you to use HTML, CSS, and JavaScript.|
    |**Control Name**|Name of the primary module control that is registered with DNN.|
    
    The new module replaces the Module Creator form in the pane.
    
      
    
    ![Module created.](/images/scr-ModuleCreatorModuleCreated.png)
    
      
    
6.  Customize the module.
    1.  From the gear icon, choose **Develop**.
        
          
        
        ![Settings (gear icon) > Develop](/images/scr-ModuleGearMenuDevelop.png)
        
          
        
    2.  In the View.ascx file, delete all the lines of code, except the first one.
        
          
        
        ![In View.ascx, delete all except first line.](/images/scr-ModuleViewAscx.png)
        
          
        
    3.  Add markup to customize the module. Then click **Update**    to save your changes.
        
          
        
        ![Customize the module.](/images/scr-ModuleCustomize.png)
        
          
        
        Example:
        
        ```
         
            <h1>Hello, <%: UserInfo.DisplayName %></h1>
                                    
        ```
        
    4.  From the **Select File** dropdown, choose the View.ascx.cs file.
        
          
        
        ![Select View.ascx.cs.](/images/scr-ModuleViewAscxCs.png)
        
          
        
    5.  Remove all the code in the **Event Handlers** region and click **Update** to save your changes.
        
          
        
        ![Remove Event Handlers.](/images/scr-ModuleDeleteEventHandlers.png)

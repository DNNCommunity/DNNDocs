---
uid: content-managers-create-visualizer
topic: create-visualizer
locale: en
title: Create a Visualizer
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: content-managers-structured-content-overview
related-topics: edit-visualizer,delete-visualizer,import-visualizer,export-visualizer
---

# Create a Visualizer

## Prerequisites

*   **Microservices must be enabled for your site.**

## Steps

1.  Go to **Persona Bar \> Content \> Content Library**.
    
    ![Persona Bar > Content > Content Library](/images/scr-pbar-cmg-Content-E91.png)
    
2.  Go to the **Visualizers** tab.
    
    ![Visualizers](/images/scr-pbtabs-all-Content-ContentLibrary-Visualizers-E91.png)
    
3.  Click/Tap **Create Visualizer**.
    
      
    
    ![Content Library > Visualizers tab > Create Visualizer > New Visualizer](/images/scr-Visualizers-CreateBtn-New-E91.png)
    
      
    
4.  Configure the properties of the visualizer.
    
      
    
    ![Visualizer Details tab](/images/scr-Visualizers-Details-E91.png)
    
    > [!Tip]
    > Include the name of the content type in the visualizer's name to make it easy to find all visualizers associated with the content type. If you plan to have multiple visualizers for the same content type, add a short phrase that briefly describes its function to distinguish it from other visualizers.
      
    
    |**Field**|**Description**|
    |---|---|
    |**Name**|The name of the visualizer.|
    |**Description**|A short description of the visualizer.|
    |**Icon**|The icon for the visualizer.|
    |**Content Type**|The content type to associate with this visualizer.|
    
    > [!Warning]
    > Changing the content type will replace any existing HTML code in the Editor \> Template editor.
    
5.  In the **Editor** tab, design the visualizer.
    1.  In the **Template** editor, enter the HTML code for the visualizer.
        
        *   Enter HTML code in **Header** and **Footer** to enclose the entire list of content items.
        *   Enter HTML code in **Template** to enclose the individual content items in the list.
        
        Example: If you want the content items to be displayed as bullets in an unordered list,
        
        *   **Header** can contain the opening `<ul>` tag.
        *   **Template** can contain `<ul>{{itemname}}</ul>`
        *   **Footer** can contain the closing `</ul>` tag.
        
        Each placeholder is the reformatted name of the content field enclosed in double curly brackets. Example: The placeholder for a field called Recipe Name is `{{recipeName}}`.
        
        If the field has multiple values (e.g., multiple choice fields), the values are comma-separated.
        > [!Tip]
        > Choose the content type in the **Details** tab before editing the visualizer HTML code. The fields of the selected content type are added to the **Template** editor as placeholders for the field value(s). They are also displayed in a dropdown that appears when you press Ctrl+Space.
        
          
        
        ![Content > Visualizers tab > Editor > Template with field placeholders](/images/scr-Visualizers-Editor-Template-E91.gif)
        
          
        > [!Tip]
        > Because the placeholders hide the inner tags, such as `</images/>` or `<p/>`, you can wrap the placeholders with `<div/>` tags with `class` names or `id` names that you can refer to in the CSS code. Example: `<div class="myimgdiv">{{ myImg }}</div>`
        
    2.  In the **Style** editor, enter CSS code for the visualizer.
        
          
        
        ![Content > Visualizers tab > Editor > Style](/images/scr-Visualizers-Editor-Style-E91.png)
        
          
        > [!Tip]
        > If you wrapped a placeholder, you can access the inner tag if you wrapped them in a named `<div/>` tag. Example: `.myimgdiv img { width: 50px }`
        
    3.  In the Script editor, enter JavaScript code for the visualizer, if needed.
        
          
        
        ![Content > Visualizers tab > Editor > Style](/images/scr-Visualizers-Editor-Script-E91.png)
        
          
        
6.  Save.
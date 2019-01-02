---
topic: example-recipes
locale: en
title: Example: Recipes as Structured Content
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: content-managers-structured-content-overview
related-topics: visualizer-templates
links: ["[Photo source: Adobo photo by dbgg1979, CC BY 2.0, Wikimedia Commons.](https://commons.wikimedia.org/wiki/File%3AChicken_adobo.jpg)","[Photo source: Ribs photo by Marcelo Teson (Asado de centro, Happening), CC BY 2.0, Wikimedia.org.](https://commons.wikimedia.org/w/index.php?curid=3708190)"]
---

# Example: Recipes as Structured Content

This example walks you through creating a content type for recipes, two visualizers for that content type (one for the list of recipes, another for the individual recipe page), and two recipe content items. Then you'll create one page to display the list of recipe summaries and another page to display an entire recipe.

## Steps

1.  [Create a content type](create-content-type) for recipes, named Recipe Content Type.
    
      
    
    ![Create a content type for recipes.](/images/scr-ContentTypes-Example-Recipe.gif)
    
      
    
    Field
    
    Content field
    
    Custom settings
    
    Recipe Name
    
    Single-Line Text
    
    *   Validation \> Required: On
    
    Picture(s) of Dish
    
    Assets
    
    *   Appearance: Image
    *   Maximum Number Of Assets: 3
    *   Validation \> Required: On
    
    Description
    
    Multi-Line Text
    
    *   Appearance: Text Editor
    *   Description: On
    *   Description text box: Say something about your recipe.
    
    Preparation Time
    
    Date / Time
    
    *   Appearance: Time
    *   Time Format: 00:00 - 24 HR
    *   Include Timezone: Off
    *   Validation \> Required: On
    
    Servings
    
    Number
    
    *   Default Value: 2
    
    Ingredients
    
    Multi-Line Text
    
    *   Appearance: Text Editor
    *   Validation \> Required: On
    
    Steps
    
    Multi-Line Text
    
    *   Appearance: Text Editor
    *   Validation \> Required: On
    
2.  [Create a visualizer](create-visualizer) for Recipe Content Type for displaying recipes in a list.
    
      
    
    ![Create a visualizer for displaying recipes in a list.](/images/scr-Visualizers-Example-RecipeShort.gif)
    
      
    
    1.  Fill in the details of the visualizer.
        
        Field
        
        Description
        
        Name
        
        My Recipe Summary Visualizer
        
        Description
        
        This recipe visualizer is for lists of recipes.
        
        Content Type
        
        Recipe Content Type
        
    2.  Enter the HTML code in the Template editor using the provided tokens for the recipe name, picture, and description.
        
        ```
        
            <div class="recipe-short-visualizer">
                <h3>{{recipeName}}</h3>
                <div class="picturecol">{{picturesofDish}}</div>
                <div class="descriptioncol">{{description}}</div>
            </div>
                                    
        ```
        
    3.  Enter CSS code to style the images and text.
        
        ```
        
            .recipe-short-visualizer {
                background-color: LightBlue;
                width: 100%;
                height: 200px;
            }
        
            .picturecol {
                width: 30%;
                float: left;
            }
        
            .picturecol img {
                width: 100%;
                max-width: 200px;
            }
        
            .descriptioncol {
                width: 70%;
                float: right;
            }
        
            .descriptioncol p {
                width: 70%;
            }
                                    
        ```
        
3.  [Create a visualizer](create-visualizer) for Recipe Content Type for displaying a complete recipe.
    
      
    
    ![Create a visualizer for displaying the entire recipe.](/images/scr-Visualizers-Example-RecipeFull.gif)
    
      
    
    1.  Fill in the details of the visualizer.
        
        Field
        
        Description
        
        Name
        
        My Recipe Full Visualizer
        
        Description
        
        This recipe visualizer displays the entire recipe in one page.
        
        Content Type
        
        Recipe Content Type
        
    2.  Enter the HTML code in the Template editor using the provided tokens for all the fields.
        
        ```
        
            <div class="recipe-full-visualizer">
                <h1>{{recipeName}}</h1>
                <div class="picturecol">{{picturesofDish}}</div>
                <div class="descriptioncol">{{description}}</div>
                <p class="prepsection">Preparation time: {{preparationTime}}</p>
                <p class="servessection">Serves: {{servings}}</p>
                <div class="ingredientstext">{{ingredients}}</div>
                <div class="stepstext">{{steps}}</div>
            </div>
                                    
        ```
        
    3.  Enter CSS code to style the images and text.
        
        ```
        
            .recipe-full-visualizer {
                background-color: lightskyblue;
                width: 80%;
                height: 100%;
                text-align: center;
                padding: 20px;
                margin-left: 10%;
            }
        
            .picturecol,
            .descriptioncol,
            .prepsection,
            .servessection,
            .ingredientstext {
                width: 70%;
                margin-left: 15%;
                text-align: center;
            }
        
            .picturecol img,
            .descriptioncol p {
                width: 100%;
                padding: 20px;
            }
        
            .ingredientstext {
                background-color: white;
                padding: 20px;
            }
        
            .stepstext {
                width: 70%;
                margin-left: 15%;
                text-align: left;
                background-color: white;
                padding: 20px;
            }
                                    
        ```
        
4.  [Create content items](create-content-item) of the type Recipe Content Type.
    1.  In the Content tab, click/tap Create Content and choose the Recipe Content Type.
        
          
        
        ![Create content item (Content Type = Recipe Content Type).](/images/scr-Visualizers-Example-CreateContent.png)
        
          
        
    2.  Enter the recipe by filling in the fields of the content type.
        
          
        
        ![Fill in the fields of the content.](/images/scr-Visualizers-Example-FillInFields.png)
        
          
        
5.  [Create a new page](create-single-page-standard) in which to display the details of a single recipe.
    1.  Enter the details for the page.
        
          
        
        ![Create the page - Details tab.](/images/scr-Visualizers-Example-RecipeFullPage-Details.png)
        
          
        
        Field
        
        Description
        
        Name
        
        Chicken Adobo Recipe
        
        Display in Menu
        
        Off. Depending on how you design your site, you might not want to display every recipe page in the navigation.
        
    2.  Set the permissions to allow your registered users to view the page.
        
          
        
        ![Create the page - Permissions tab.](/images/scr-Visualizers-Example-RecipeFullPage-Permissions.png)
        
          
        
    3.  Click/Tap Create.
    4.  Choose a content pane then add a module.
        
          
        
        ![Create the page - Choose pane and click/tap module icon.](/images/scr-Visualizers-Example-RecipeFullPage-NewPage.png)
        
          
        
    5.  Choose the Visualizer module.
        
          
        
        ![Choose the Visualizer module.](/images/scr-Visualizers-Example-RecipeFullPage-AddModuleVisualizer.png)
        
          
        
    6.  Select the Recipe Content Type.
        
          
        
        ![Select the Recipe Content Type.](/images/scr-Visualizers-Example-RecipeFullPage-SelectContentType.png)
        
          
        
    7.  Select the My Recipe Full Visualizer.
        
        Note: Only the visualizers associated with the selected content type are displayed.
        
          
        
        ![Choose the My Recipe Full Visualizer.](/images/scr-Visualizers-Example-RecipeFullPage-SelectVisualizer.png)
        
          
        
    8.  Select one content item from the list.
        
          
        
        ![Select one content item from the list.](/images/scr-Visualizers-Example-RecipeFullPage-SelectContentItem.png)
        
          
        
    9.  Review and publish.
        
          
        
        ![Review that the content item is displayed correctly, then publish.](/images/scr-Visualizers-Example-RecipeFullPage-ReviewAndPublish.png)
        
          
        
6.  [Create a new page](create-single-page-standard) in which to display the list of recipes with their names, pictures, and short descriptions.
    1.  Enter the details for the page.
        
        Field
        
        Description
        
        Name
        
        All Recipes
        
        Display in Menu
        
        On. Turn this On if you want your users to easily access this page in the navigation.
        
    2.  Set the permissions to allow your registered users to view the page.
        
          
        
        ![Create the page - Permissions tab.](/images/scr-Visualizers-Example-RecipeFullPage-Permissions.png)
        
          
        
    3.  Click/Tap Create.
    4.  Choose a content pane then add a module.
        
          
        
        ![Create the page - Choose pane and click/tap module icon.](/images/scr-Visualizers-Example-RecipeFullPage-NewPage.png)
        
          
        
    5.  Choose the Visualizer module.
        
          
        
        ![Choose the Visualizer module.](/images/scr-Visualizers-Example-RecipeFullPage-AddModuleVisualizer.png)
        
          
        
    6.  Select the Recipe Content Type.
        
          
        
        ![Select the Recipe Content Type.](/images/scr-Visualizers-Example-RecipeFullPage-SelectContentType.png)
        
          
        
    7.  Select the My Recipe Summary.
        
        Note: Only the visualizers associated with the selected content type are displayed.
        
          
        
        ![Choose the My Recipe Summary.](/images/scr-Visualizers-Example-RecipeShortPage-SelectVisualizer.png)
        
          
        
    8.  Select one or more content items from the list.
        
          
        
        ![Select one content item from the list.](/images/scr-Visualizers-Example-RecipeShortPage-SelectContentItem.png)
        
          
        
    9.  Review and publish.
        
          
        
        ![Review that the content item is displayed correctly, then publish.](/images/scr-Visualizers-Example-RecipeShortPage-ReviewAndPublish.png)
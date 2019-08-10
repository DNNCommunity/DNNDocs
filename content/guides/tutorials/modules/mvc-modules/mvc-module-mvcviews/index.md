---
uid: mvc-module-mvcviews
locale: en
title: MVC Views
dnnversion: 09.02.00
related-topics: mvc-module-project-overview,mvc-module-mvccontroller,mvc-module-unittest,unsupported-mvc-features
---

# MVC Views

## The _ViewStart.cshtml

In ASP.NET MVC3 and later versions, you can define a Razor view named _ViewStart.cshtml (or _ViewStart.vbhtml for VB) in the root of the Views folder. This optional file defines the common view code that executes when each view starts to render. Example: Code within _ViewStart.cshtml can programmatically set each View's Layout property to Views/Shared/_Layout.cshtml by default.

Example: In Views/_ViewStart.cshtml:

```

	@{
		Layout = "~/DesktopModules/MVC/CompanyName_MyMvcModule/Views/Shared/_Layout.cshtml";
	}
			
```

Example: In Views/Shared/_Layout.cshtml:

```

	<div id="mvcContainer-@Dnn.ActiveModule.ModuleID">
		@RenderBody()
	</div>
			
```

The above files, which are generated from the MVC project template, ensure that all views returned by a controller action will always have a wrapper <div> with an id that includes the current module's ID. If you choose to exclude the _ViewStart.cshtml in your project, your individual action views will simply render without a common wrapping.

## View Naming Conventions

According to MVC pattern conventions, views reside in folders within the Views folder. Each controller must have a View folder named after it. For example, the template-generated project created two MVC controllers: ItemController and SettingsController with their respective controllers: Views/Item and Views/Settings.

Note: View folders typically the name of their corresponding controllers, but without the word "Controller".

Likewise, your Razor view files must be named according to the action method names in their associated controller. Example: We have two C# Razor views in the Views/Item folder called Index.cshtml and Edit.cshtml, which correspond to the ItemController.Index() and ItemController.Edit() action methods.

## Binding Data in Your View

Aside from HTML and javascript, the following server objects can be used to populate your view:

*   Model The model object that is returned in the action is bound to the view in the generic declaration inside the @inherits statement at the top of the view.
    
    ```
    
        @inherits DotNetNuke.Web.Mvc.Framework.DnnWebViewPage<Dnn.Modules.CompanyName.MyMvcModule.Models.Item<
    					
    ```
    
    The above line will make the Item class available for access in the Razor view via the Model property. Then you can inject the model attributes into the html:
    
    ```
    
        <span>@Model.ItemName</span>
    					
    ```
    
*   ViewBag ViewBag attributes are available from the Razor view.
    
    ```
    
        <span class="@ViewBag.TitleClass">@Model.Name</span>
    					
    ```
    
*   HTML Helper Helpers are classes that generate HTML elements using the model class. ASP.NET MVC includes an @HTML helper class, which constructs form elements, such as dropdown lists, text boxes, and labels.
    
    ```
    
        @Html.TextBoxFor(m => m.Description)
    					
    ```
    
*   DNN Helper DNN's own helper class (@Dnn) provides DNN core objects that you can use in your Razor view. PortalSettings, ModuleContext, User and other objects provide access to the underlying CMS structure of your page.
    
    ```
    
        <div id="Items-@Dnn.ModuleContext.ModuleId">
    					
    ```
    

## View Navigation

To navigate to another view or another controller action, you can use the action method of the @Url helper to create a URL action method that you can place in an anchor tag or button. Example, in the template-generated Item Index view, a hyperlink in each item can lead the user to the single item's Edit view.

```

	<a href="@Url.Action("Edit", "Item", new {ctl = "Edit", itemId = item.ItemId})">@Dnn.LocalizeString("EditItem")</a>
			
```

## Client Scripting

The mechanisms used in registering scripts, stylesheets, or Javascript libraries in a DNN module have been modified to work with MVC modules.

Registering a stylesheet or script using the Client Resource Manager, or register a Javascript Library Extension:

```

	@using DotNetNuke.Web.Client.ClientResourceManagement
	@using DotNetNuke.Framework.JavaScriptLibraries
	@{
		// Register a stylesheet
		ClientResourceManager.RegisterStyleSheet(Dnn.DnnPage, "~/DesktopModules/MVC/CompanyName_MyMvcModule/Resources/css/module.css");

		// Register a custom javascript
		ClientResourceManager.RegisterScript(Dnn.DnnPage, "~/DesktopModules/MVC/CompanyName_MyMvcModule/Resources/js/module.js", 101);

		// Register an existing Javascript Library Extension
		JavaScript.RequestRegistration("Knockout");
	}
			
```

## Localization

One of the base methods on the @Dnn MVC helper is LocalizeString(). The resource files for Views are organized at the controller level in the App_LocalResources folder in the root of the module project. By convention, the ItemController should have a resource file named App_LocalResources/Item.resx. If there was a resource key called "lblName.Text", you can pull that content into your view using the following code:

```

	<label for="itemName">@Dnn.LocalizeString("lblName")</label>
			
```

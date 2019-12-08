---
uid: mvc-module-mvccontroller
locale: en
title: MVC Controller
dnnversion: 09.02.00
related-topics: create-module-using-templates,mvc-module-project-overview,mvc-module-mvcviews,mvc-module-unittest,unsupported-mvc-features
---

# MVC Controller

## Overview

In a Web Forms module, the module is controlled by `.ascx` user controls, which are rendered on the page. However, in an MVC module, the module is controlled by MVC controller action methods that return an MVC view, which is rendered on the page.

## Action Methods

To render an MVC module control, DNN uses the module's control source definition. If your project was created from the DNN MVC template, the manifest defines a default view with the following control source:

```

    <moduleControl>
        <controlKey />
        <controlSrc>Dnn.Modules.CompanyName.MyMvcModule.Controllers/Item/Index.mvc</controlSrc>
        ...
    </moduleControl>
			
```

> [!Note]
> The `controlSrc` value is not a file path. In an MVC module, the control sources are specified using the format: `{Controller Namespace}/{Controller Name}Controller/{Action Method Name}.mvc`.

The above control source looks for the method Index() in the class Dnn.Modules.CompanyName.MyMvcModule.Controllers.ItemController, which implements the abstract base class DotNetNuke.Web.Mvc.Framework.Controllers.DnnController.

Example: In the following code, the action method asks the data layer (ItemManager) for the list of all item objects for that module instance.

```

    public class ItemController : DnnController
    {
        public ActionResult Index()
        {
            var items = ItemManager.Instance.GetItems(ModuleContext.ModuleId);
            return View(items);
        }
    }
                
```

The resulting list is the Model data, which is then passed to the View component and returned.

## Module Action Menu

  

![Module action menu](/images/scr-actionmenu-edit-icons.png)

  

The module action menu can be customized for your MVC module by adding DotNetNuke.Web.Mvc.Framework.ActionFilters.ModuleActionAttribute to the default view's action method.

The following code excerpt is found above the ItemController.Index() method in the example provided by the MVC template project.

```

    [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
    public ActionResult Index()
    {
        ...
    }
			
```

The ModuleActionAttribute properties include the following:

*   ControlKey. The name of the module view control's key, used to specify the controller action that is invoked when the user clicks the menu item.
*   Icon. The image to be used as the icon next to the menu item text. The default is the pencil icon.
*   SecurityAccessLevel. The access level needed in order to access the menu item. One of the enumerated values in DotNetNuke.Security.SecurityAccessLevel.
*   Title. The menu item text.
*   TitleKey. The menu item key. If getting the text from a resource file, use this instead of the Title attribute. In the above example, it expects a resource named `AddItem.Text` in the Item.resx file.

## Returning the ActionResult

The main purpose of the MVC controller action methods is to populate a view with the model data. The return type of the action methods is the abstract System.Web.Mvc.ActionResult, which has many possible subtypes, including the two return types that are most commonly used for a DNN MVC module: ViewResult and RedirectToRouteResult.

ViewResult returns a rendered view that is named after the action method. RedirectToRouteResult redirects to another controller action. Likewise, the DnnController.RedirectToDefaultRoute() is typically called to redirect to the default module view.

Note: See [Unsupported MVC Features](xref:unsupported-mvc-features) for the list of unsupported ActionResult types.

## Passing Data to the View

The two constructs typically used to pass data into the view are the Model and the ViewBag.

*   Model
    
    The Model is a "plain old CLR object" (POCO). When using your module's data layer, it is common to use a DAL2 entity class as your model. From the template-generated code, the ItemManager is a DAL2 data repository class that populates an IEnumerable list of Item objects. The list is passed to the View, where the Razor code generates the HTML code.
    
    ```
    
        public ActionResult Index()
        {
            var items = ItemManager.Instance.GetItems(ModuleContext.ModuleId);
            return View(items);
        }
    					
    ```
    
*   ViewBag
    
    MVC views are built to render a specific model. Occasionally, passing extra data to the view outside of the model's scope can be helpful; e.g., to pass the module's relative path to avoid hardcoding a stylesheet in the view. Because the ViewBag allows dynamic properties, you can define a new dynamic property (e.g., ModulePath) for the action method and use that property in your view.
    
    Example: In ItemController.cs:
    
    ```
    
        public ActionResult Index()
        {
            var items = ItemManager.Instance.GetItems(ModuleContext.ModuleId);
            ViewBag.ModulePath = $"~/DesktopModules/MVC/{ModuleContext.Configuration.DesktopModule.FolderName}";
            return View(items);
        }
    					
    ```
    
    In Index.cshtml:
    
    ```
    
        @{
            ClientResourceManager.RegisterStyleSheet(Dnn.DnnPage, ViewBag.ModulePath + "/Resources/bootstrap/css/bootstrap.min.css");
        }
    					
    ```

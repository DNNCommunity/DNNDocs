---
uid: mvc-module-development
locale: en
title: MVC Module Development
dnnversion: 09.02.00
related-topics: create-module-using-templates,use-module-creator,providers
links: ["[Wikipedia: Model-View-Controller](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller)"]
---

# MVC Module Development

## Overview

The MVC module type integrates ASP.NET MVC 5 with the DNN platform.

> [!Note]
> Incompatibilities between ASP.NET MVC and ASP.NET Web Forms cause conflicts with pre-existing Web Forms features in the DNN platform. Therefore, DNN implementations of some ASP.NET features, such as MVC routing, are limited.

MVC modules can use any of the standard DNN module features. All DNN module types can co-exist on a single page, and the user should not be able to distinguish which framework was used to build the module.

## MVC Module Architecture

The MVC module type implements the model-view-controller pattern, which separates an application into three main components:

*   **Models** implement the domain logic and often store and retrieve data from the database.
*   **Views** render the module's user interface (UI). Typically, views are created based on data provided by the model.

    ```

        @model IEnumerable<Dnn.Modules.DnnMvcModule.Models.Item>

        <div id="Items-@Dnn.ModuleContext.ModuleId">
            @if (Model.Count() == 0)
            {
                <p>No items defined.</p>
            }
            else
            {
                <ul class="tm_tl">
                    @foreach (var item in Model)
                    {
                        <li class="tm_t">
                            <h3>@item.ItemName</h3>
                            <div class="tm_td">@item.ItemDescription</div>
                            @{
                                if (Dnn.ModuleContext.IsEditable)
                                {
                                    <div>
                                        <a href="@Url.Action("Edit", "Item", new {ctl = "Edit", itemId = item.ItemId})">@Dnn.LocalizeString("EditItem")</a>
                                        <a href="@Url.Action("Delete", "Item", new {itemId = item.ItemId})">@Dnn.LocalizeString("DeleteItem")</a>
                                    </div>
                                }
                            }
                        </li>
                    }
                </ul>
            }
        </div>

    ```

*   **Controllers** handle user interaction, retrieve and update the model, and select the view to use.

    Although the composition of the presentation layer is different, the logical architecture of an MVC module is similar to that of a Web Forms module.



    ![Logical architecture of an MVC module](/images/gra-module-architecture-mvc.png)



    When a DNN page is requested, the framework looks up the requested module control in the module definition. In an MVC module, the module control identifies a specific namespace, controller, and action. The output from the controller action is stored in a string, which is injected into the page.


## Building MVC modules

Visual Studio supports only one project type for MVC projects. However, the Visual Studio MVC project type includes additional scaffolding for creating new controllers and views. The additional scaffolding speeds up development and ensures that controllers and views follow the standard MVC conventions.

> [!Note]
> Visual Studio is currently the only tool available for creating MVC modules.

The ASP.NET MVC framework relies on the [convention over configuration](https://en.wikipedia.org/wiki/Convention_over_configuration) paradigm to simplify development. DNN modules follow all ASP.NET MVC conventions, as well as DNN-specific conventions. MVC module conventions include:

*   File name conventions

    |**File Type**|**Convention**|
    |---|---|
    |Controller|Name must include the "controller" suffix.|
    |Default View|Name must be the same as the associated action. Example: The default view for an **index** action must be named **index.cshtml**.|
    |Shared layout|Name must be prefixed with an underscore (_).|

*   File location conventions

    |**File Type**|**Convention**|
    |---|---|
    |View|The **Views** folder that matches the controller name. Example: A view for the **Home** controller should be in the **Views/Home** folder.|
    |Shared layout|The **Views/Shared** folder|
    |MVC module|The **DesktopModules/MVC** folder|
    |Controller|The **Controllers** folder (optional)|
    |Model|The **Models** folder (optional)|
    |Static content file (e.g., stylesheets and images)|The **Content** folder|
    |JavaScript file|The **Scripts** folder|

*   Miscellaneous conventions
    *   Bound HTML form fields must have the same name as the corresponding model property.

## Accessing DNN features

Common DNN features are made available to MVC developers through DNN APIs, such as:

*   **Localization**. The DNN helper object includes a **LocalizeString** method. This helper object can be used in your view when localizing your module.
*   **Module actions**. DNN includes the **ModuleAction** and **ModuleActionItems** attributes to identify custom module actions. These attributes can only be used with controller action methods.
*   **Base controller class**. MVC controllers must inherit from the **DnnController** class. Similar to the **PortalModuleBase** class for Web Forms module developers, this class provides access to the DNN module and portal context objects.

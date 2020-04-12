---
uid: mod-dev-modules-vs-tabmodules
topic: mod-dev-modules-vs-tabmodules
locale: en
title: About Modules, TabModules, Module Definitions
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# About Modules, TabModules, Module Definitions

Your module needs to be properly embedded in DNN for it to work. A surprising number of concepts come into play to make this happen. I find the best way to understand how this works is to look at what is stored in SQL. After all, that is where the registration of a module is stored. To get an idea of how the module is embedded in DNN we&#39;ll open up the following tables in turn and I&#39;ll try to walk you through the wiring. We&#39;ll start at the very top where your module has been announced to the system and drill down to find out how DNN knows which ascx to put where on the page.

## Packages

Packages are what you upload into DNN. The zip files. They contain the manifest and this table stores this manifest, the license (if it was included), owner details etc. Note the column PackageType (fig. 7). You&#39;ll see the various package types that are known in DNN. For the purpose of this chapter we are only interested in _Module_ package types. It&#39;s the entry point of all extensions and for our purpose it&#39;s the least interesting table.

![Figure 7: Packages table.](/images/ch13f007.png)

## DesktopModules

This is the data root for any module. Every module has a unique record in this table (fig. 8). You&#39;ll notice it refers back to Packages through PackageId and that the version is duplicated in this row (it was also present in the Packages table). This is because the Packages table is a recent addition. Most importantly this table tells DNN where the module is found (FolderName) and what it&#39;s called (ModuleName). Note that you should keep the latter unique to avoid clashes. This is because DNN uses this name to determine during installation whether it has already been installed. So choosing a name that is the same as an existing one will lead to a huge mess when people install your module and the other one is present as well. So stick to some convention like MyCompany\_MyModule for the name. You won&#39;t see it in the UI as FriendlyName is used for that. Other aspects of note: IsPremium will tell DNN whether it is only reserved for some portals or whether all portals can use this. IsAdmin tells DNN whether it should only be available for administrators to instantiate and use.

![Figure 8: DesktopModules table.](/images/ch13f008.png)

## ModuleDefinitions

Next up is the module definition (fig. 9). It links to the DesktopModules table. So any module can contain one or more definitions. Each definition shows up as a blob on the page when you instantiate the module (i.e. drop it on the page). Most modules have just one definition. Multiple definitions falls outside the scope of this chapter (and I&#39;m not a big fan of it to be honest). The Module Definition has a DefinitionName. Like the ModuleName this is best kept unique and stable. If you change the name of this, DNN will create a new definition next time you upgrade and then you&#39;ll have a module with multiple definitions and hence multiple blobs on screen (probably showing the same thing). It can get very messy if you start fidgeting with this value so choose it well right at the start along the same conventions mentioned above.

![Figure 9: ModuleDefinitions table.](/images/ch13f009.png)

## ModuleControls

The Module Definition is basically a container for one or more module controls. The module control (fig. 10) tells DNN which ascx to show (yes, we&#39;re finally getting to your work) when the module is shown on a page. The ControlSrc is the relative path to the ascx to show. This ascx has to either inherit from DotNetNuke.Entities.Modules.DesktopModuleBase or implement DotNetNuke.UI.Modules.IModuleControl. You can actually use a type reference in this field if you wanted to. So how does DNN know which module control to load for a definition? That depends on the ControlKey. This key is used in the query string of the request to switch controls. So adding ctl=Edit would tell DNN to load the control where ControlKey equals &quot;Edit&quot;.

![Figure 10: ModuleControls table.](/images/ch13f010.png)

That has brought us to your control. We now know how DNN knows which ascx to load based on your module&#39;s registration in the framework. We&#39;ll now see what parts are involved when a module is instantiated on a page. Again we&#39;ll walk through the data to get an idea of how this is done.

## Modules

This is the root of every module in your site. Every module instantiation has a single record in this table (fig. 11). Note it does not tell DNN yet where it is placed on your site. Just that it exists (or is deleted etc). Most importantly this is where the ModuleId is generated. That is the unique key that you&#39;ll use throughout your code to keep stuff from one module separate from another.

![Figure 11: Modules table.](/images/ch13f011.png)

## TabModules

The TabModule is where the module meets the page (Tab). It tells DNN where the module should go. As you can understand you can have multiple tabmodules per module. That is: you can stick a module on multiple pages. The idea behind this is that you can share content across pages. To see this in action you can try the following. Open up your DNN, log in as admin and go to the Modules menu at the top. Now, instead of selecting &quot;Add New Module&quot; select &quot;Add Existing Module&quot;. You&#39;ll now need to select a page from where to copy the module from and select the module. If you do not select &quot;Make a Copy&quot;, only a new TabModule record will be created for that module so it will show exactly the same content as on the other page.

![Figure 12: TabModules table.](/images/ch13f012.png)

You&#39;ll notice in the TabModules table (fig. 12) the column PaneName and ModuleOrder. This tells DNN where to stick it on the current page given the skin you&#39;ve used when you added the module. This explains why when you switch skins your modules are sometimes all stacked in the default pane. This is because DNN will try to find the pane on the selected skin, but if it isn&#39;t found (because the other skin had different pane names) the module will be added to the (mandatory) ContentPane.

There are many more columns in this table that I will not elaborate on here. You&#39;ll probably notice they are closely linked to settings you see when you go to a module&#39;s settings popup. But now you should understand how DNN knows which control to stick were when it loads a page.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

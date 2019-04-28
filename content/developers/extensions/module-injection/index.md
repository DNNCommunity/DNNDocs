---
uid: module-injection-filter
locale: en
title: Module Injection Filter
dnnversion: 09.02.00
related-topics: module-features,developers-creating-modules-overview
links: ["[DNN Community Blog: Discover DNN Module Injection Filters](https://www.dnnsoftware.com/community-blog/cid/155402/discover-dnn-module-injection-filters)","[GitHub Injection Filter Samples](https://github.com/dnnsoftware/Dnn.InjectionFilter.Sample)"]
---

# Module Injection Filters

Module Injection Filters are a mechanism in DNN that allows you to specify if a module should be displayed or hidden. When DNN is displaying a page, for every module on the page, it asks all of the Module Injection Filters whether it should add the module or not. If there is _any_ module injection filter that excludes the module, then it won't be included on the page.  This is a fairly low-level extension point that can be used to enable some scenarios that are otherwise difficult to achieve.

## When Not to Use

DNN's [`StandardModuleInjectionFilter`](xref:DotNetNuke.UI.Modules.StandardModuleInjectionFilter) takes care of hiding modules that are deleted, expired, or excluded via permissions. Much of the time, you'll want to use one of these mechanisms, rather than implementing a custom Module Injection Filter. For instance, if you are trying to dynamically show or hide content on a page based on a user's role, you should use the module's permissions setting instead.  If you just want to show/hide content _within_ a custom module, it is usually more appropriate to place that logic inside the module.

## When to Use

There are a number of scenarios that are not easily handled by any existing mechanism that DNN provides. If the criteria for hiding/showing a module cannot be tied to permissions (e.g. geolocation, cookie values, complex date/time rules, last visit date, etc.) then a custom Module Injection Filter may be a good avenue to consider. One good use case is A/B testing, the initial reason for development of the feature. Another reason to choose a custom Module Injection Filter is to apply one uniform hide/show rule to a variety of types of modules, or to modules that your team did not develop (whether built-in or third party).

One method you can use when hiding arbitrary modules is to leverage the Tags module setting to indicate modules which should be hidden in a certain scenario. For example, you could [create two terms](xref:add-term-to-vocabulary), _Hide A_ and _Hide B_ to exclude content based on an A/B testing cookie value. Then when those terms are applied as a tag to a module, you can use a custom Module Injection Filter to show or hide the content appropriately. See the linked [GitHub Injection Filter Samples](https://github.com/dnnsoftware/Dnn.InjectionFilter.Sample) for a starting point for a tag-based filter.

## How to Add a Module Injection Filter?

DNN simply includes any class that implements [`StandardModuleInjectionFilter`](xref:DotNetNuke.UI.Modules.IModuleInjectionFilter) in the collection of filters to ask. To implement the interface, a class only needs to implement one method, `CanInjectModule`, which takes the relevant `ModuleInfo` and `PortalSettings` objects, and returns either True or False.

```csharp
    using DotNetNuke.Collections;
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.Entities.Portals;
    using DotNetNuke.UI.Modules;

    public class ExampleModuleInjectionFilter : IModuleInjectionFilter
    {
        public bool CanInjectModule(ModuleInfo module, PortalSettings portalSettings)
        {
            var hide = module.ModuleSettings.GetValueOrDefault("HideOnTuesday", false);
            return hide && DateTime.Today.DayOfWeek == DayOfWeek.Tuesday;
        }
    }
```

## How to Deploy a Module Injection Filter?

If you are already deploying custom code (e.g. a custom module), you may want to include the class implementing your Module Injection Filter in the assembly containing your other code.  If you do not have other custom code or you do not want to combine the Module Injection Filter with existing code, you can compile the class into its own assembly and package it separately.  In the [manifest file](xref:dnn-manifest-schema), choose `Library` for the package type, and use the `Assembly` component to install the assembly file into the `bin` folder.

```xml
<dotnetnuke type="Package" version="5.0">
    <packages>
        <package name="YourCompany.ExampleModuleInjectionFilter" type="Library" version="1.0.0">
            <friendlyName>Example Module Injection Filter</friendlyName>
            <description>Hides modules on Tuesdays based on a module setting.</description>
            <owner>
                <name>Your Name</name>
                <organization>YourCompany</organization>
                <url>www.example.com</url>
                <email>support@example.com</email>
            </owner>
            <license src="License.txt" />
            <releaseNotes src="ReleaseNotes.txt" />
            <azureCompatible>true</azureCompatible>
            <components>
                <component type="Assembly">
                    <assemblies>
                        <assembly>
                            <path>bin</path>
                            <name>YourCompany.ExampleModuleInjectionFilter.dll</name>
                            <version>1.0.0</version>
                        </assembly>
                    </assemblies>
                </component>
            </components>
        </package>
    </packages>
</dotnetnuke>
```

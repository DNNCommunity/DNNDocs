---
uid: module-injection-filter
topic: module-injection-filter
locale: en
title: Module Injection Filter
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-about-modules-overview
related-topics: module-features,developers-creating-modules-overview
links: ["[DNN Community Blog: Discover DNN Module Injection Filters](https://www.dnnsoftware.com/community-blog/cid/155402/discover-dnn-module-injection-filters)","[GitHub Injection Filter Samples](https://github.com/dnnsoftware/Dnn.InjectionFilter.Sample)"]
---

# Module Injection Filters

When DNN is displaying a page, for every module on the page, it asks all of the Module Injection Filters whether it should add the module or not.  If there's any module injection filter that excludes the module, then it won't be included on the page.  This is a fairly low level extension point that can be used to enable some scenarios that are otherwise difficult to achieve.

## How do I add a Module Injection Filter?

DNN simply include any class that implements [`IModuleInjectionFilter`](xref:DotNetNuke.UI.Modules.IModuleInjectionFilter) in the collection of filters to ask.  To implement the interface, a class only needs to implement one method, `CanInjectModule`, which takes the relevant `ModuleInfo` and `PortalSettings` objects, and returns either True or False.

## Which scenarios may not be good candidates for using a Module Injection Filter?

DNN's [`StandardModuleInjectionFilter`](xref:DotNetNuke.UI.Modules.StandardModuleInjectionFilter) takes care of hiding modules that are deleted, expired, or excluded via permissions.  Much of the time, you'll want to use one of these mechanisms, rather than implementing a custom Module Injection Filter, if you're trying to dynamically show/hide content on a page (e.g. make sure a user is in the correct role, and use that role to control view permissions).  Furthermore, if you are wanting to show/hide content in a custom module, you may just want to put your logic inside of that module.

## Which scenarios might be good candidates for using a Module Injection Filter?

There are a number of scenarios that are not easily handled by any existing mechanism that DNN provides.  This feature was initially implemented with A/B testing in mind.  If the criteria for hiding/showing a module are not easily tied to permissions, for example geolocation, cookie values, complex date/time rules, or last visit date, then a custom Module Injection Filter may be a good avenue to consider.  Another reason to choose a custom Module Injection Filter is to apply one uniform hide/show rule to a variety of types of modules, or to modules that your team did not develop (whether built-in or third party).

One option when hiding arbitrary modules is to use the Tags module setting to indicate modules which should be hidden in a certain scenario.  For example, you could [create two terms](xref:add-term-to-vocabulary), _Hide A_ and _Hide B_ to exclude content based on an A/B testing cookie value.  Then when those terms are applied as a tag to a module, you can use a custom Module Injection Filter to show or hide the content appropriately.  See the linked [GitHub Injection Filter Samples](https://github.com/dnnsoftware/Dnn.InjectionFilter.Sample) for a starting point for a tag-based filter.

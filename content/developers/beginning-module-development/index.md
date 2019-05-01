---
uid: beginning-module-development-overview
topic: beginning-module-development-overview
locale: en
title: Beginning Module Development
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# Beginning Module Development

This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

## Introduction

The number 1 feature of the DNN Platform is its extensibility, notably the ability to easily install and manage modules. A module comes as a zip file. You upload this zip file into the platform and DNN takes care of the rest. Whether it&#39;s the first time you&#39;ve uploaded it or whether it&#39;s an upgrade. The part of the platform that takes care of this is aptly named the _Installer_ and is discussed in more detail later. The takeaway here is that you can leverage this technology to create your own modules that are highly transportable. And just like Apple&#39;s App Store, DNN also has its App Store (http://store.dnnsoftware.com/, see fig below) and maybe one day you, too, will sell your module there. But first you&#39;ll need to master module development. And although it&#39;s not trivial, there are different ways to do this requiring different skill levels. So you can get something working in a relatively short timeframe. In this chapter I hope to give you the background you need to know _where_ to start and _how_ to create your first module.

![Figure 1: The DNN Store.](/images/ch13f001.png)

As we&#39;ll see there are many ways to do this. The permutation of tools and technologies available to us makes it impossible for me to tell you how you should develop a module. It has become for a large part a matter of personal taste. What I intend to do in this chapter is two give you the background necessary to make those decisions. We&#39;ll see what a module is in technical terms, how a module is embedded in DNN and what is involved in packaging. With several examples I hope to show how this can be done in different ways to give you a start in this exciting technology.


1. [A Guided Tour of Your Work Environment](xref:mod-dev-work-environment)
2. [Your Toolbox](xref:mod-dev-toolbox)
3. [The Environment](xref:mod-dev-environment)
4. [Organizing Your Project](xref:mod-dev-organizing-project)
5. [Module Design Considerations](xref:mod-dev-design)
6. [About Modules, TabModules, Module Definitions](xref:mod-dev-modules-vs-tabmodules)
7. [A Guestbook Module](xref:mod-dev-example)
8. [Wrapping it up](xref:mod-dev-wrapping-up)

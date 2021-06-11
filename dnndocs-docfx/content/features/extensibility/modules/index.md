---
uid: modules
locale: en
title: About Modules
dnnversion: 09.02.00
related-topics: module-architecture,module-development,module-features
---

# About Modules

## What is a module?

A typical web page includes page elements and content blocks. Page elements, such as the site menu, the login control, and the search bar, are included with the theme. Content blocks are managed by modules.

![Modules manage and display content on the page.](/images/gra-module-overview.png)

The module is one of the basic building blocks that extend DNN to enable users to view, create, and edit content. All DNN administrative features are implemented as modules.

> [!Tip]
> The DNN platform source code includes numerous example modules to help you build your own modules.

Due to the modular nature of page composition in DNN, modules are usually built to manage and display a single content type.

Tip: Consider creating multiple modules when managing complex content types, or include rich templating support so that administrators can control the layout of the content on the page.

Module development involves selecting the development framework and then the development approach.

*   These frameworks can be used with DNN:
    *   Web Forms. This traditional framework creates DNN modules that use controls based on ASP.NET Web Forms.
    *   MVC. This framework (introduced in DNN 8) uses the ASP.NET MVC framework.
    *   SPA. This family of frameworks builds modules using plain HTML, JavaScript, and CSS. You can use any SPA framework.
*   You can choose a manual development approach, where the entire module is built by hand, or a more automated approach, where the basic module foundation is created using a template or other automation tool.

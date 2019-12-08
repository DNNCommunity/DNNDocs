---
uid: mvc-module-project-overview
locale: en
title: MVC Module Project Overview
dnnversion: 09.02.00
related-topics: create-module-using-templates
---

# MVC Module Project Overview

## Overview of an MVC Module Project

After creating your MVC module project from a template, the following project structure is scaffolded in your Visual Studio project:

![Visual Studio MVC project](/images/scr-mvc-project-vssolution.png)

*   Models, Views, Controllers folders and sample code
*   Components folder with skeleton module business controller and DAL class
*   Sample module packaging files: DNN manifest file, release notes and license text, and SQL scripts for installation and uninstallation
*   MSBuild module packaging process to build the .zip executable file

## Initial Project Code from Template

After creating the module and building the package, go to Host \> Extensions to install the package. After installation, you can add the module to a page for testing. The initial code created by the template should look like this:

![Initial MVC DNN Module](/images/scr-mvc-module-template-view.png)

Whether you use the DNN 8 MVC template or a similar MVC template, the generated code produces a fully functioning application that allows you to add items to a list. The default view is the item list. Each model data or item consists of a title, content description, and user. The template generates the MVC controllers, views, and model entities, as well as a data controller class. If your module will perform CRUD (Create, Read, Update, Delete) data operations, you can customize this code. Otherwise, you can remove what you don't need.

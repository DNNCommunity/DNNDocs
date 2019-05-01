---
uid: mod-dev-work-environment
topic: mod-dev-work-environment
locale: en
title: Guided Tour of Your Work Environment
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# A Guided Tour of Your Work Environment

We&#39;ll first go for a stroll to discover your new playground. Allow me to guide you around as we look at asp.net applications, the DNN Framework and DNN modules. I think it&#39;s a good way to get started if you understand how these various bits are built and relate to each other.

## ASP.NET Web Forms

If you already know how to program an asp.net Web Forms application you can skip this section. Asp.net web forms was introduced back in 2001 with the first release of asp.net. Microsoft aimed to provide programmers with a programming model that resembled Windows programming on the web. For that they needed to resolve the web&#39;s stateless nature. This means: the server is not connected to the client outside of simply delivering some files and every time a browser makes a request it is seen in total isolation. The server does not &quot;know&quot; you made a request just two seconds before. This was not an issue in the old days of the static web. After all, all the server did was just serve out files that were on its hard disk to the client browser. But now Microsoft wanted to make it appear to programmers as if there was some kind of continuous connection between the browser and the server. And they solved this by passing a whole lot of hidden data back and forth between the browser and the server. Basically every time the browser would make a request it would send enough information to the server so it would know what happened previously. And although this mechanism has come under increased attack due to the volume of data being sent back and forth (read: slower response times), it remains a very powerful paradigm for web programming and very easy for developers to understand.

So web forms behaves a lot like Win Forms in that you have a surface onto which you drop components (text boxes, buttons, dropdowns, etc) and in the so-called _Code Behind_ files of these forms you catch Events that are triggered when a user interacts with those components (e.g. the clicking of a button, filling of a text box, etc). The aforementioned form is essentially a template where html is intermingled with blocks that the web forms processor recognizes and turns into what you need it to be. These templates are easily spotted on your server&#39;s hard disk as they have either the .aspx or the .ascx extension. An .aspx is a standalone web form, intended to be served as a complete page to the browser. An .ascx is a partial file called a _User Control_. I.e. it is embedded in either an .aspx or another .ascx (you can nest them) and is similar to the other components like text boxes and buttons that you add. The code behind files are either .vb or .cs depending on the development language (Visual Basic or C#).

If you now go to your installed DNN application you&#39;ll understand what the majority of files are about. Other files we find are mostly static files (i.e. they are meant to be served &quot;as is&quot; by the server to the browser) such as images, css and js files. But there remain some others that are not served and are only meaningful to the asp.net engine. The first I want to call out is the _web.config_. There can be only one in the entire application and it sits in the root directory. It is an XML file that tells IIS various details about the application. Most importantly it tells IIS which components to hand requests to (routing). It is also the place where some application level settings are stored such as the connection string to the database for instance. This is extensible and various bits of the application can use the web.config to store settings as well (DNN stores information about its configuration in this file as well). Note that you should not use this file trivially. Although it&#39;s perfectly legal for you to use the web.config to store settings for your module, you must keep in mind that in many installations the web.config may have been changed by the owner and your settings may be tampered with inadvertently. As a general rule you should try to avoid tampering with this file as you can easily break the entire application if something goes wrong.

Finally you should pay attention to the bin folder. That is where the .dll files reside. Dlls are compiled libraries of code. There are two ways to run code on the server in asp.net. You can have code files on the server that are compiled on-the-fly. That is: when a request comes in. Or you can precompile code into libraries and drop those in the bin folder. There are several advantages with the latter approach. For a start it means that the server doesn&#39;t need to compile as it has already been compiled. This is offset by the fact that the server will only compile if it finds that any of the code files has been altered. But still the compiled library offers a performance advantage. Secondly the compiled library hides the code from prying eyes. This may be important if you deliver a commercial solution and you don&#39;t want to hand over your source code. It also shields the code from tampering. This might be useful in cases where others have access to the server and you want to make sure no one tampers with the code. Finally it makes it simpler to manage versions of your work. A dll can be labeled with a version nr. Code files, too. But needing to check if any code files may have been updated or not can be a cumbersome task and having all code in a single dll is just that much simpler.

Many of the dlls in the bin folder are interdependent. So you can&#39;t remove or replace them without risk of breaking the application. In .net the dependencies between dlls is recorded when they are created. For instance the DotNetNuke.Web.dll version 7.3.4 is dependent among (many) others on DotNetNuke.HttpModules.dll version 7.3.4, DotNetNuke.Instrumentation.dll version 7.3.4, DotNetNuke.dll version 7.3.4, DotNetNuke.Web.Client.dll version 7.3.4 and DotNetNuke.WebUtility.dll version 4.2.1. If any of those dlls would be replaced by one with a lower version nr or removed altogether, the DotNetNuke.Web.dll will throw an exception and halt all its work, breaking the entire application. So tampering with dlls is not for the faint of heart. You really need to know what you&#39;re doing.

This concludes the brief overview of some of the critical parts of a .net web forms application. You should be aware of the above in case you wish to change things or if you need to debug some erroneous behavior.

## The DNN Platform

As a Web Forms application, DNN too has a bin folder, a web.config file and many of those .aspx and .ascx files. DNN (or DotNetNuke as it was called at the time) came right on the heels of the emergence of ASP.NET and was a continuation of one of the bigger sample projects in the first wave of ASP.NET. In many ways DNN has been a trail blazer for Web Forms and at times Microsoft has adjusted what it was doing based on what was happening in the DNN eco-system. And for those of us that have been around since that time we can see that history reflected in the various files and folders of the application. For newcomers it can be puzzling why you&#39;d have /admin and /DesktopModules/Admin. Or /js vs. /Resources/Shared/scripts. Over time many developers have worked on the solution and like binary stars DNN and ASP.NET Web Forms have evolved in each other&#39;s gravity, sometimes changing the other&#39;s course. So at times the anatomy of DNN may feel somewhat quirky. So with that out of the way let&#39;s look at what you have on your hard disk after installing DNN. Table 1 shows a rundown of the most important folders in the application.

Table 1: Major directories in a new DNN installation

| Path | Description |
| --- | --- |
| /admin | Various bits of functionality that can/are used throughout the framework, like the login button, the control panel or the module&#39;s settings panel. |
| /App\_Browsers | Configuration files that allow DNN to know what a browser&#39;s capabilities are. |
| /App\_Data | This is the standard [ASP.NET](http://ASP.NET) folder to which an application&#39;s database will be written if you don&#39;t specify otherwise. |
| /App\_Data/Search | DNN uses Lucene to index its contents. Lucene stores its files here. |
| /App\_GlobalResources | You&#39;ll find DNN&#39;s common resource files here. These files store the most common texts used in the application (like &quot;Cancel&quot; or &quot;Submit&quot;). |
| /bin | See previous section |
| /Components | This is mostly empty. It used to be the place where the source version stored its source code. |
| /Config | Configuration files for various aspects of the application. These files remove the need to put everything in the web.config file. |
| /controls | Reusable controls. You can use these in your own modules as well. Controls like the Url Control (choose a url or a page in DNN) will save you a lot of work. |
| /DesktopModules | This is where modules are stored |
| /DesktopModules/Admin | Administrative modules like the SQL module or the Extensions module. You&#39;ll see these modules in action on the various admin pages. |
| /Documentation | Licenses and a quick guide to installing DNN |
| /Icons | You guessed it: icon image files that are used in the application |
| /images | Various images consisting mostly of the icons that were used in older versions of DNN |
| /Install | When DNN first installs it uses these folders to create the system. The default modules are found here as well as default skins and languages for instance. If you&#39;d create a distribution based on DNN you&#39;d put all your own stuff in this place so it installs by default. |
| /js | Various Javascripts |
| /Licenses | More licenses of components used in DNN |
| /Portals | Data directories that hold the files for the various portals |
| /Portals/\_default | Data directory for the host. This is where you&#39;ll find the portal templates (the files that determine what pages to create for a new portal) for instance. |
| /Providers | Directories dedicated to extensible bits of DNN. You can override the default providers with your own if you want. |
| /Providers/DataProviders/SqlDataProvider | The default Data Provider is the SQL Data Provider. This means: we use SQL server by default. This directory contains all of the scripts DNN uses to get the data schema installed correctly and fill it with the first necessary data. |
| /Resources | Various shared files that can be served depending on the context. Modules may request jQuery to be sent to the client. The jQuery scripts are found under this folder. The folder has grown significantly since version 5 of DNN as more logic has been transferred to the client side. And the folder structure reflects the strong growth in that not everything is organized 100% logically. |

There is a certain analogy between the DNN folder structure and a typical Windows machine&#39;s folder structure. The DesktopModules folder is like the Programs folder on your Windows machine. It stores the various installed programs. The Portals folder is like the Users folder. It stores the user&#39;s files and makes sure some level of isolation is used to prevent one looking into the files of another (portal folders). Finally, the bin folder is like the System32 folder in that the dlls that are shared across the whole application go there.

## Anatomy of a DNN module

Now that we know what an asp.net web forms application and specifically DNN consists of, let&#39;s examine the constituent parts of a DNN module. As was mentioned before, a module is delivered as a zip file. But what&#39;s in the zip file and how does this fit into DNN? To better understand this we begin by dividing our application into the age old split of data and code. The code comes as .net web forms files such as .ascx, .js, .dll or code files (.cs, .vb). And these files are almost without exception stored in a subfolder of _DesktopModules_ in your DNN installation and the bin folder in case of a dll. The user&#39;s data comes in two forms: files and relational data (i.e. tables of data). File-based data is stored in the portal home directory (default Portals/[PortalID]/) and SQL data in the SQL Server database. For the former you won&#39;t need to do anything (the portal home directory already exists) but for the latter you will need to create the necessary tables, procedures, etc. yourself through a set of scripts. These scripts create or update the schema your application needs in SQL. That&#39;s it. What you create is a bunch of files that either are copied to the DesktopModules folder, the bin folder or are used to generate the schema in SQL that the application will use.

Let&#39;s look at the HTML module to see what this looks like in practice. In your installation you should find the following directory: /DesktopModules/HTML (fig. 2). In that directory you&#39;ll find 4 .ascx files and one .css file.

![Figure 2: Html module directory.](/images/ch13f002.png)

So these files are actually used to render to the client what the developer wanted (there are also a bunch of .txt files and a .manifest file in this folder that we&#39;ll ignore for now). Then there is an App\_LocalResources folder. Like the App\_GlobalResources this holds resource files that contain the text snippets that are used in the application (more information about this in the section on localization). And then under Providers/DataProviders/SqlDataProvider you&#39;ll find all the SQL script files that the module uses. These script files are only used during installation, so if you tamper with them now nothing will change. They remain on disk as a record of what has been done.

The only file you&#39;re missing from the module is the one that was written to the bin folder: DotNetNuke.Modules.Html.dll. That file is the compiled version of all the source code that came with the module. In the source code version of DNN you&#39;ll find this source code under DNN Platform\Modules\HTML. This directory holds the entire HTML module project and is used to generate the zip file that is used to install it.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

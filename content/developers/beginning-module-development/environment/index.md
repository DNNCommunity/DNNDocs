---
uid: mod-dev-environment
topic: mod-dev-environment
locale: en
title: The Environment
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# The Environment

It&#39;s time to set up the environment in which we&#39;ll create our module. This means having a DNN instance up and running which we can access directly using Visual Studio.

## DNN

For our environment we&#39;ll use the regular DNN Platform distribution as you can find this through the download link on http://www.dnnsoftware.com or directly on Codeplex or GitHub. Note you&#39;ll typically find several distributions: the _New Install_ version, the _Version Upgrade_ version, the _Source Code_ version and the _Web Platform Installer_ version. The only difference between the first two is that the upgrade version comes without a few files that are typically tuned to your specific setting (like the web.config). So you can safely unzip and drop all files from an upgrade version over an existing version of DNN and the first time you go to the site, it will upgrade the application internally. The web platform version is, you guessed it, meant to work in conjunction with Microsoft&#39;s Web Platform Installer.

For our development environment we&#39;ll be using the regular version. This is because we don&#39;t need to run the source version of DNN in order to develop a module. When developing our module we treat DNN as a black box and only use its API. Unless you want to find out how DNN works internally you don&#39;t need to develop inside the source version of DNN. Another good reason to use the non-source version is that it is faster. The source version requires a bit more work from the .net compiler and it quickly will become tedious if every time you want to test a code change you need to wait a minute before the site fires up. And finally another reason for steering clear of the source version is that you&#39;ll want your module to work in a production environment somewhere. And that is where the non-source version will be running. So you&#39;ll mimic as closely as possible the end result while developing your application.

Now which DNN version number should you choose? This depends largely on whether you intend to distribute your work for a wider audience or whether this is a one off module where you already know the environment where it&#39;s supposed to run. Obviously for the latter you would choose the version that it&#39;s intended to run on. But if you wish to distribute your module for sale or for free, keep in mind that not everyone is running the latest version of DNN. So you might want to backtrack a little. The downside of course is that older versions have fewer features. It requires some level of experience in module development and good familiarity with the DNN API to make this call.

The numbering of DNN versions follows the pattern of other .net applications in a familiar x.y.z pattern, where x, y and z are integers. By convention we write this with double digits, so 7.3.4 becomes 07.03.04. The first digit is the _major_ version number, the second the _minor_ version and the final digit is called the _revision_. The idea is that the risk of breakage (i.e. methods in the API no longer working the same as before or changes in the SQL schema) is higher for changes in the major version nr and smallest for the revisions. The latter are sometimes referred to as _bugfix releases_ as they intend to not add or change any features but rather make repairs to new features that were added in the .0 version. So 7.3.4 is the fourth bugfix release of the 7.3 release. You&#39;ll find that commonly the .0 releases are rarely used in production environments as administrators wait to see if any bugs were introduced with the new features. .0 releases are more frequently used by developers to begin using the new features. Keep this in mind when choosing your version to develop on.

Table 2 shows a list of highlights of releases since version 6.0. This may help you determine which version is the best for you to target if you aim to redistribute your work.

Table 2: Major DNN releases between 2011 and 2014

| DNN Version | Release Date | Highlights |
| --- | --- | --- |
| 6.0 | July 2011 | Conversion from VB to C#New UI with PopupsAzure CompatibilityIntegration with DNN Store |
| 6.1 | November 2011 | Client Resource Management(Mobile) Device Capability APISite Redirection (target Mobile)Site Groups (Pro Edition) |
| 6.2 | May 2012 | Social API (Groups, Journal, Authentication etc)MVC Services Support (later pulled in favor of WebAPI) |
| 7.0 | November 2012 | New (simplified) installerNew UI and control barContent Sharing (Pro)Version Comparison (Pro)Support for WebAPI |
| 7.1 | July 2013 | New Search APINew Url ManagerChanged to Hashed Passwords |
| 7.2 | December 2013 | Inclusion of Bootstrap into default skinJavascript Library ManagementSubscriptions and Digest Notifications |
| 7.3 | June 2014 | Performance EnhancementsRemote Portal Home Directories |

## SQL Server

Just as with Visual Studio, SQL comes in commercial and free (labeled &quot;Express&quot;) flavors. And just like with Visual Studio the free version suffices for our task at hand. In a nutshell the SQL Express versions are fully compatible with the full versions of SQL but just have some size and performance limitations that don&#39;t really concern us. As we&#39;re developing we want to see our code run and know it will run well in production.

As to the version (i.e. 2005, 2008, etc) it is wise to stick to the version that DNN requires. This ensures you won&#39;t be doing anything that won&#39;t run on someone else&#39;s installation. The dependency was moved up to 2008 in version 7 of DNN. If you&#39;re just using tables, views, simple procedures and functions then it doesn&#39;t really matter whether you use 2008 or 2012. But you should be aware that some of your future users might be on 2008.

## IIS

We&#39;ll need to run our site so we need Microsoft&#39;s web server IIS. There are two flavors of this: a developer version called IIS Express and the full blown regular IIS. If you have a professional version of Windows you have access to a full version of IIS. Choosing the right one is not trivial and it has implications for your project, notably regarding debugging. In order to debug Visual Studio has to somehow be able to piggyback onto the process that is running your application so that it can monitor what is going on. So let&#39;s look at the differences.

The regular IIS is integrated into your Windows environment and runs as a service. The obvious advantage is that it is exactly the same product as you&#39;ll find on a Windows Server edition, so you have peace of mind that what you observe you&#39;d also observe in production. The downside is that Visual Studio doesn&#39;t really penetrate this. It can&#39;t go through the front door so to speak and ask to piggyback on the so-called _worker process_ (the process that runs your DNN and module is called the worker process and has the executable name w3wp.exe). Actually, if it could do this it would constitute a grave breach of security. So to be able to debug your module, Visual Studio has to jump through some hoops. Instead it needs to ask Windows to be able to latch onto the worker process. But this is only possible if you are running Visual Studio with administrator privileges. So either you turn off UAC on your machine or you tweak your Visual Studio shortcut to run as Administrator by default.

IIS Express was introduced with Visual Studio 2010 and replaced the older IIS developer edition called Cassini which really didn&#39;t compare with IIS. The new IIS Express was made to behave much more like its big brother. The biggest difference is that IIS Express is a standalone application so it does not run as a service on your machine. Instead it&#39;s Visual Studio which boots it into action when you hit F5 in your web project. Your project&#39;s settings will configure IIS Express to serve up the site you&#39;re working on and the process remains active until you stop debugging. Obviously Visual Studio has no issue latching onto the process here as it starts it up itself. There is also no issue with UAC as you run the process in your own account on the machine. So there are no hoops to jump through. The downside, however, is that all this only works when firing up a website. So to do this for a module project we need to at least also include the website project DNN (still you don&#39;t need the source version!) in your solution and set it as startup project. There is another complication in that when you start your project this way, it will fire up your default browser using localhost:[some portal number]. Under normal circumstances this will then add itself to the aliases of the running portal. But it becomes impossible/very complex to create new portals in the running instance as you&#39;d need to register new urls and IIS Express can&#39;t do that. Finally, the moment you stop debugging you kill the process. This means you cannot make any code changes while the site is running. You don&#39;t have that limitation if you run the regular IIS.

In conclusion: IIS Express is a great tool and a big step forwards since the old Cassini days, but it was really designed for monolithic website projects (i.e. where you&#39;re creating a whole website). For our purpose of developing a module inside a website that we don&#39;t want to touch, it is too limiting and it is preferable to use the full blown IIS if you have access to it.

## To VM or Not To VM

You can go one step further to emulate the situation where the module will end up: by creating a virtual machine with a complete Windows Server edition on it. If you are an MSDN member this comes at no cost to you at all. The upside is that there are no more differences possible between your development environment and the production environment. Another benefit is that your development environment becomes trivially easy to move to another machine and to back up. Naturally it also comes at a cost. There&#39;s some performance loss as your PC will be running two operating systems side-by-side. Plus you&#39;ll need to install your development tools inside the VM. Personally I&#39;m running my entire development environment on a VM on a Mac so I enjoy some of the aforementioned benefits.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

---
uid: mod-dev-wrapping-up
topic: mod-dev-wrapping-up
locale: en
title: Wrapping it up
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# Wrapping it up

Once you&#39;re happy with how the module is working it&#39;s time to consider packaging. I&#39;ve mentioned a few times that modules come as zip files. But there is a bit more to this.

## The Manifest

By far the most crucial part of the module&#39;s package is the manifest. The manifest is an XML file with a .dnn extension that will tell the DNN installer how to install this module. It tells DNN the following:

- What it&#39;s about to install. Is this a module, a skin or some other type of extension?
- Who is the maker? Name, url, etc. You can also include a license blurb, here.
- In case it&#39;s a module: the definition of the module.
- SQL scripts to run.
- Where to put the files that are in the zip file.

There are many options for the manifest but we don&#39;t need to go through them exhaustively at this stage. Let&#39;s look at the manifest for our Guestbook module to get an idea.

Listing 16: Guestbook module manifest

``` xml
<dotnetnuke type="Package" version="5.0">
 <packages>
  <package name="WROX_Guestbook" type="Module" version="01.00.00">
   <friendlyName>Guestbook</friendlyName>
   <description>WROX.com Guestbook module</description>
   <owner>
    <name>WROX.com</name>
    <organization>WROX.com</organization>
    <url>http://www.wrox.com</url>
    <email>modules@wrox.com</email>
   </owner>
   <license src="License.txt"/>
   <releaseNotes src="ReleaseNotes.txt"/>
   <dependencies>
    <dependency type="CoreVersion">07.01.02</dependency>
   </dependencies>
   <components>
    <component type="Script">
     <scripts>
      <basePath>DesktopModules\WROX\Guestbook</basePath>
      <script type="Install">
       <path>Providers\DataProviders\SqlDataProvider</path>
       <name>01.00.00.SqlDataProvider</name>
       <version>01.00.00</version>
      </script>
      <script type="UnInstall">
       <path>Providers\DataProviders\SqlDataProvider</path>
       <name>Uninstall.SqlDataProvider</name>
       <version>01.00.00</version>
      </script>
     </scripts>
    </component>
    <component type="ResourceFile">
     <resourceFiles>
      <basePath>DesktopModules\WROX\Guestbook</basePath>
      <resourceFile>
       <name>Resources.zip</name>
      </resourceFile>
     </resourceFiles>
    </component>
    <component type="Module">
     <desktopModule>
      <moduleName>WROX_Guestbook</moduleName>
      <foldername>WROX/Guestbook</foldername>
      <moduleDefinitions>
       <moduleDefinition>
        <friendlyName>Guestbook</friendlyName>
        <defaultCacheTime>0</defaultCacheTime>
        <moduleControls>
         <moduleControl>
          <controlKey/>
          <controlSrc>DesktopModules/WROX/Guestbook/View.ascx</controlSrc>
          <supportsPartialRendering>False</supportsPartialRendering>
          <controlTitle/>
          <controlType>View</controlType>
          <viewOrder>0</viewOrder>
         </moduleControl>
         <moduleControl>
          <controlKey>Edit</controlKey>
          <controlSrc>DesktopModules/WROX/Guestbook/Edit.ascx</controlSrc>
          <supportsPartialRendering>False</supportsPartialRendering>
          <controlTitle>Edit Content</controlTitle>
          <controlType>View</controlType>
          <viewOrder>0</viewOrder>
          <supportsPopUps>False</supportsPopUps>
         </moduleControl>
         <moduleControl>
          <controlKey>Settings</controlKey>
          <controlSrc>DesktopModules/WROX/Guestbook/Settings.ascx</controlSrc>
          <supportsPartialRendering>False</supportsPartialRendering>
          <controlTitle>Guestbook Settings</controlTitle>
          <controlType>Edit</controlType>
          <viewOrder>0</viewOrder>
         </moduleControl>
        </moduleControls>
       </moduleDefinition>
      </moduleDefinitions>
     </desktopModule>
    </component>
    <component type="Assembly">
     <assemblies>
      <assembly>
       <name>WROX.Modules.Guestbook.dll</name>
       <path>bin</path>
      </assembly>
     </assemblies>
    </component>
   </components>
  </package>
 </packages>
</dotnetnuke>
```

#### Preamble

The package node begins by telling DNN it&#39;s a module and which version this is. DNN uses this and the name attribute (WROX\_Guestbook) to determine if the package has already been installed or not. So you should never ever change this name attribute or you will break your upgrade sequence!

The opening tag is followed by a number of tags that have a vanity role. The friendly name is what is shown in the UI as name for the module and the description is shown on the Extensions page. The owner information and license/release notes are shown during installation.

The dependency node you see makes sure that users who try to install this on a version older than DNN 7.1.2 will not be able to. DNN will inform them and stop the installation procedure. As I&#39;ve pointed out earlier, if it would install it&#39;d lead to a big mess with .net as a dependency on a higher version nr of a component will break our module entirely.

So how about other dependencies? In our module we&#39;ve also used a dependency on DotNetNuke.WebUtility. But since this ships with DNN, we can safely assume that that will work out fine. In other words: you only need to worry about dependencies on components that do not ship with DNN.

#### SQL Scripts

The node \&lt;component type=&quot;Script&quot;\&gt; enumerates all SQL scripts. These are incremental and DNN uses the module name and the version number to figure out which scripts it should run. It should be clear that you should have a solid version numbering strategy if you are going to distribute the module. Errors in scripts are non-recoverable! If DNN somehow trips on one of those scripts the whole installation fails and you are stuck with a situation where some (parts of) scripts may have run and others have not. This is potentially catastrophic, so the only safe way to install modules is to back up your DNN installation first. Make sure to mention this to your audience when releasing an upgrade. It is up to you to make these upgrade scripts as solid as you can.

The scripts are named xx.yy.zz.SqlDataProvider by convention. You can opt to make new installs start somewhere down the script history by adding a Install.xx.yy.zz.SqlDataProvider script. This is not uncommon for long-lived modules. If you examine the manifest of the Blog module 6.0.x you&#39;ll notice this is done at version 6. So there is a Install.06.00.00.SqlDataProvider script which makes new installs start there and continue up. If it&#39;s an upgrade all Install.\* scripts are ignored.

You should also include the UnInstall script. Obviously there is no version nr for this. During each upgrade the latest version is written over what was there. DNN then uses this script during the removal of the module if the user decides to uninstall. Again, if you&#39;re distributing to a wider audience spend some time perfecting these scripts. Make sure you make these scripts robust so there is little chance they fail. For instance: test if a procedure is there before you drop it. It may seem redundant, but a failure in the script can leave the uninstall hanging in midair and users will bombard you with (angry) emails.

#### Resource File

A very common technique to deliver a bunch of files to the target DNN installation is to use a resources file. This is a zip file containing the whole tree of folders and files you wish to distribute. DNN will unpack it to the module folder. It saves you a lot of work announcing each individual file to install. Instead your approach changes to: which files can go into the resource file and which ones must be kept outside. The answer is that all dlls, SQL scripts and cleanup files must stay outside as they are not simply unzipped to the destination. Everything else can be zipped up.

#### Module Definition

Earlier in this chapter we looked at how modules are embedded in DNN. It will come as no surprise then, that in the manifest we have a reflection of that. It is in the \&lt;component type=&quot;Module&quot;\&gt; node of the manifest. Walking through that you will recognize most of the fields of the relevant tables. This is where you tell DNN what your module is called, where it should go, which features it supports, the definition(s) and their controls, etc.

There is an element in the definition we have not touched on: eventMessage. This tells DNN to have the module notified of some events. Typically you&#39;ll see an entry here to listen to &quot;upgrade&quot; as is the case here. It is quite possible you can&#39;t do all your upgrade processing with SQL scripts (like manipulation of files for instance). What this does is that DNN will run the upgrade method on the type supplied under businessControllerClass based on the list of versions in upgradeVersionsList. With this method you can embed logic in your module to do upgrades internally that require code to run.

#### Assemblies

The node \&lt;component type=&quot;Assembly&quot;\&gt; lists all dlls to be installed. You actually need to specify the bin folder as there are scenarios where dlls can go elsewhere. Using the version attribute you can make sure DNN keeps track of versions of your dlls. This can be leveraged with shared dlls. Let&#39;s say you use Acme.dll and have compiled your module using version 1.1.0 from this company, then using the version code will prevent another module developer using the same Acme.dll but with version 1.0.0 to get that dll installed over yours as that might break your code. Note we are assuming that shared dlls always support backwards compatibility which is kind of an industry standard.

## Packing up our guestbook module

To wrap it all up now all we need to do is zip up our work:

1. Create a zip file called &quot;resources.zip&quot;. In it we put:

- the three ascx files (View, Edit, Settings),
- module.css
- App\_LocalResources\*.resx (preserve the folder in the zip file!)

2. Create a second zip file which incorporates:

- The resources.zip file you just created
- License.txt and ReleaseNotes.txt
- The manifest (Guestbook.dnn)
- Bin\Guestbook.dll
- Providers\DataProviders\SqlDataProvider\*.SqlDataProvider

This second zip file is your module. The convention is to give it a name along these lines: [ModuleName]\_[Version]\_[Install/Source].zip, so in the above case Guestbook\_01.00.00\_Install.zip. That immediately makes it clear to anyone familiar with DNN what the zip file is.

#### Creating a Source version

It is fairly easy to create a source code distribution of the module using the same method as above. The only difference is that you&#39;d include all necessary source code files in the resources.zip. The manifest would not need to be changed as the resources file is simply unpacked. But it would already prime the receiving DNN installation with SQL scripts and the module definition so that anyone wishing to work on the source would just need to fire up Visual Studio, load up your project and recompile to the site&#39;s bin folder when needed. This makes it incredibly easy for someone else to work with your source code.

## Build Automation

At this point you may think that all the packing and manifest creation described above is quite a bit of work. The good news is that this is very repetitive and that all other module developers go through the same process. As a result various mechanisms have surfaced to automate this process. The most common way is to use MSBuild tasks to do this. MSBuild is responsible for what happens when you click &quot;Build&quot; in Visual Studio. But it&#39;s not just about invoking the compiler. It can be extended to do all kinds of things, both before and after compilation. This is modelled after Ant and NAnt (the .net version of Ant). So like NAnt it, too, uses XML files to tell it what to do. Since MSBuild comes with .net it is very tightly integrated with your whole environment which many see as a bonus. Personally I use NAnt as it can be kept totally isolated from the project. But it&#39;s a matter of taste which build automation technology you use. Just know that once you have this tuned correctly, making a distributable module becomes trivially easy.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

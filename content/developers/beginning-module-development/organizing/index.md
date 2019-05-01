---
uid: mod-dev-organizing-project
topic: mod-dev-organizing-project
locale: en
title: Organizing Your Project
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# Organizing Your Project

The various options there are to develop a module for DNN can be overwhelming. There are so many different ways to do this that it&#39;s easy to get lost. As ASP.NET and DNN have progressed new methods evolved over the course of the last decade to make things easier for you and to give you more options. And similarly to the toolbox you use, many of the decisions will come down to personal preference.

## Inline vs External Module Creation

You&#39;d be surprised what you can do without any tools. DNN includes a number of ways in which you can create a module inline in the application. As modules are &quot;active components&quot; you need to be logged in as superuser. If you switch to Edit mode and you hover over any module&#39;s menu, you&#39;ll see the &quot;Develop&quot; menu item. This allows you to edit any of the module&#39;s controls directly inside your browser. DNN includes a powerful code highlighter called CodeMirror to help you. Combined with the ability to create modules from scratch on the Extensions page (through the &quot;Create New Module&quot; button) this means you can create an entire module without ever going to the files directly. Let me demonstrate this.

#### Hello World

1. Open up your DNN site, log in as host and go to Host \&gt; Extensions

2. From the buttons at the top click on &quot;Create New Module&quot;

3. Select &quot;New&quot; in the dropdown labeled &quot;Create Module From&quot;

4. Use the &quot;Add Folder&quot; buttons to create an owner folder &quot;WROX&quot; and a module folder &quot;HelloWorld&quot;

5. Select C# and enter &quot;HelloWorld.ascx&quot; as file name and &quot;HelloWorld&quot; as module name. You should have something like fig 3.

![Figure 3: Creating a new module.](/images/ch13f003.png)

1. Select &quot;Add Test Page&quot; and click &quot;Create Module&quot;. You should now have a screen like fig 4.

![Figure 4: Our Hello World module page.](/images/ch13f004.png)

1. Change to edit mode using the control bar&#39;s menu at the top right. You&#39;ll see the module gets its menu shown. Select &quot;Develop&quot; from the gear menu (fig 5).

![Figure 5: Develop using DNN.](/images/ch13f005.png)

1. You will see a popup screen appear with two tabs and on the first tab a dropdown with our HelloWorld.ascx selected. Now delete all but the first line and insert the following on the second line, update and close the dialog

``` html
<h1>Hello <%= UserInfo.DisplayName %></h1>
```

2. You&#39;ll now see &quot;Hello SuperUser Account&quot; displayed in the module. SuperUser Account is the DisplayName of the currently logged in user. If you&#39;d log off you&#39;ll just see &quot;Hello&quot; as there is no more user logged in.

Congratulations. You&#39;ve now successfully created your first bit of active content! Now let&#39;s take this up a notch. Go back into development mode and copy the following underneath the title:

LISTING 1: Hello World Web Forms example

``` html
<table>
<%
foreach (var tab in GetTabs()) {
%>
 <tr>
  <td><%= tab.TabID %></td>
  <td><a href="<%= DotNetNuke.Common.Globals.NavigateURL(tab.TabID) %>"><%= tab.TabPath %></a></td>
 </tr>
<%
}
%>
</table>
  
<script runat="server">
public List<DotNetNuke.Entities.Tabs.TabInfo> GetTabs()
{
return DotNetNuke.Entities.Tabs.TabController.GetPortalTabs(PortalId, -1, true, true);
}
</script>
```

What you should see is a list of pages with their path as a hyperlink to those pages in DNN. In the above there is a code block inside script runat=&quot;server&quot; that runs solely on the server (you won&#39;t discover it in the HTML output of the page). This method is then used in the ASP.NET code above to fill an HTML table. Finally you&#39;ll note that we&#39;ve used several methods from the DNN API (NavigateURL, GetPortalTabs). Finding your way around the DNN API will take some time but the more modules you make the more you&#39;ll find yourself using the same familiar bits of the framework.

#### The Razor Host Module

Over the years a lot of criticism has been levelled at Microsoft for its Web Forms implementation. In part because it was bulky and in part because Web Forms does not allow the programmer much control over the HTML that is emitted by the server. To address these issues we&#39;ve seen the emergence of MVC and its associated view engine _Razor_. A Razor file is not unlike a Web Forms ascx/aspx in that it is basically a template telling the engine what HTML to render. Most significantly you&#39;ll find that the `<%` `%>`; way of separating code from markup has been replaced with a single @ symbol. So `<%= Math.Sqrt(81) %>`; is simply `@Math.Sqrt(81)`. But that is just a slight advantage in brevity. Razor files no longer support the Web Forms drag and drop interface in Visual Studio. You&#39;ll need to craft the HTML yourself. Many, including myself, see this as a step forward.

A lot of Razor&#39;s features are related to using MVC as a development approach. Although DNN will probably support that in the future, for now DNN still assumes you are rendering controls to a Web Forms page. To benefit from the Razor hype, DNN includes (since version 5.6.1) the so-called _Razor Host_ module. It will allow you to create a razor script and the module will render this script on a DNN page. To access certain DNN features it includes three Helper Objects: DnnHelper, HtmlHelper and UrlHelper. DnnHelper allows access to details about the current module, tab, portal and user. The HtmlHelper makes accessing localized texts easy. And finally the UrlHelper allows for easy construction of DNN urls.

Using this feature we will now redo the Hello World example in the Razor Host module.

#### Hello World in Razor

1. Create a new page and add the &quot;Razor Host&quot; module to this page.

2. Switch to Edit Mode and from the module&#39;s pencil menu select &quot;Edit Script&quot;

3. Click to add a new script file and give it a meaningful name like HelloWorld or something. Click to add the file.

4. Now select the file from the dropdown and replace the contents with this:

``` html
<h1>Hello @Dnn.User.DisplayName</h1>
```

5. Select the checkbox to make the script active and click to save and return to the page.

You will now see what we had before; a welcome message for the logged in user. Again we&#39;ll add a list of pages in our current portal with links to each of them:

LISTING 2: Hello World Razor example

``` html
@functions { 
 public List<DotNetNuke.Entities.Tabs.TabInfo> GetTabs()
 {
  return DotNetNuke.Entities.Tabs.TabController.GetPortalTabs(Dnn.Portal.PortalId, -1, true, true);
 }
}

<table>
@foreach (var tab in GetTabs())
{
 <tr>
  <td>@tab.TabID</td>
  <td><a href="@(DotNetNuke.Common.Globals.NavigateURL(tab.TabID))">@tab.TabPath</a></td>
 </tr>
}
</table>
```

You can see the result in figure 6. As you can see from the above, Razor bears a lot of resemblance to Web Forms in the way it does the templating of your data. But there are some neat features that Web Forms doesn&#39;t have and vice versa. A fuller discussion of Razor falls outside the scope of this chapter, however.

![Figure 6: Our Hello World example using Razor.](/images/ch13f006.png)

#### Final Remarks

Although it&#39;s perfectly valid to develop your module inline in DNN, you&#39;ll obviously miss out on the smoother experience of using a full IDE. Plus you won&#39;t be able to compile your code either. It&#39;s fine for a half-day quickie. But for anything more elaborate you&#39;ll want to use Visual Studio. For the remainder of the chapter we&#39;ll assume you are using Visual Studio to develop your module.

## WAP vs. WSP

Now you&#39;ll face one of the oldest dichotomies in module development. When DNN was first created, Visual Studio (2003) included a so-called Web Application Project (_WAP_) template. This template assumed that you were developing a number of user controls inside a larger Web Forms application and that you would compile the code behind to a dll in the bin folder. That is exactly the route DNN took with modules. So to many it came as a nasty surprise that in Visual Studio 2005 this option was deprecated in favor of Web Site Projects (_WSP_) which took a very different approach. Microsoft later corrected this with a service pack, but it was an illustration of how we can be left behind by developments in Redmond.

In a WAP project you only load your controls and refer to the rest of the project by including the dlls as references in your project. The result of your work will be the ascx files plus a dll that is the compiled code of your project. With WSP you load the entire web site (i.e. DNN) and add code files to the App\_Code folder which will then get compiled dynamically when your application first loads. WSP was obviously meant to speed up development as you could change code and just hit refresh in your browser. But having template (.ascx) files under DesktopModules and the code files &quot;far away&quot; under App\_Code was a change that was not conducive to larger, more complicated modules. Plus it made creating a distributable module significantly more complex. And it also meant installing the source code on the client&#39;s server which ruled out all commercial module developers.

To this day you can create a module using either WAP or WSP approaches. But most developers use the WAP approach as it totally isolates your work from DNN and that is seen as a bonus. The WSP approach actually only makes sense when faced with a &quot;quick and dirty&quot; task for a single site.

## Inside vs Outside the root

If you have downloaded and unpacked the source version of DNN, you may have noticed something odd. The modules are not under \Website\DesktopModules\etc where you might have expected to find them. Instead they are under \Dnn Platform\Modules. So how does this work? The way that the project has been set up is with the module projects outside the root of the website (i.e. outside the DesktopModules folder). The site is running under \Website, so how do developers work on the module and see their changes? Inevitably this means that if you make a change in one of the ascx files it won&#39;t be visible when you refresh your browser.

The clue is in MSBuild tasks. What you need to do is to click Rebuild in Visual Studio. What will happen is that some extra (MSBuild) tasks will run at the end of the regular compilation of the module which copies over all the files to the Website\DesktopModules folder. This is a very clever way of leveraging build automation. The upside of this way of organizing your project is that it is even more isolated from the website. And I presume that for such a large project as the DNN Platform this makes good sense. But it remains rare for module developers to use this approach. Plus: we don&#39;t work on the DNN site itself simultaneously. So we are not expected to interfere at all with the DNN files. That already provides enough isolation.

In short: it is possible to develop your module in total isolation in some directory far away from your test DNN site. But it requires quite a bit more jumping through hoops and the benefits are limited. So in the remainder we will assume to be developing inside the test DNN installation.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

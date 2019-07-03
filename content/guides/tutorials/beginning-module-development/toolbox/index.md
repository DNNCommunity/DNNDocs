---
uid: mod-dev-toolbox
topic: mod-dev-toolbox
locale: en
title: Your Toolbox
dnneditions: DNN Platform
dnnversion: 07.00.00
---

# Your Toolbox

There is probably nothing more personal in programming than your toolbox. Every time I exchange ideas with another developer there is some moment in the conversation that will slip into a &quot;you should use X for that&quot; type of discussion. I don&#39;t think I&#39;ve ever encountered someone with exactly the same toolbox as myself. So whatever I mention in this chapter: there are always alternatives and some will never even use a similar tool and I&#39;m sorry if I didn&#39;t mention product X. So I will just mention a few tools that I believe just about everyone in my zone is using and then you can figure out what else you want to use. Note that there are excellent resources out there to find out more about tooling. I should mention Scott Hanselman at this point. He is a very well-known .net technology evangelist and hugely influential in the .net ecosystem. Next to blog posts, pod casts and the like, he maintains a very useful &quot;Ultimate Developer and Power Users Tool List&quot;. If you want to find new ideas for your toolbox, I suggest you find the latest version of said list and check out the developer section.

Your primary tool for development will be your IDE (Integrated Development Environment). And the default .net IDE is Microsoft&#39;s Visual Studio. Visual Studio comes in various flavors, some commercial and some free. As this book was being written Microsoft has launched a new free version of Visual Studio called &quot;Community&quot; which replaces the previous &quot;Express&quot; labeled versions. From what we&#39;ve been able to see there is now a completely free and unbeatable IDE for all of us, whether beginner or advanced programmer. You can also go open source with SharpDevelop or you can go totally bare knuckled with your text editor of choice, but in this book we&#39;ll be using Visual Studio.

Then you&#39;ll need some way to access and manipulate the database. You can run scripts in DNN using the Host \&gt; SQL module, but it doesn&#39;t replace the ability to craft queries in an editor and run them instantly. For that you&#39;ll need SQL Management Studio. There are probably alternatives out there, but it comes for free with SQL Server (Express) so I never looked further.

Finally, there are many tools available that you can add to make your life easier, but it really depends on your level of module development. To start with the above is fine. But as you advance you may want to look at source control (Git and SourceTree are my favorites) and Http debugging (Fiddler). The latter allows you to examine the HTML traffic between the server and the browser. This is extremely useful when debugging Ajax calls for instance. In fact it&#39;s the only way I know to effectively debug this scenario.

> [!Note]
> This is an extract from the Wrox book  [Professional DNN 7](https://www.amazon.com/Professional-DNN7-Open-Source-Platform/dp/111885084X) by Shaun Walker et al. Copyright remains with P.A. Donker and Wiley Publishers.

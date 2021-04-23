---
uid: event-system
locale: en
title: Event System
dnnversion: 
---

# Event System

## What is the Event System?

Using the core event system, you can attach custom C# or VB code, called Event Listeners/Event Handlers, to hook into various core events that happen throughout DNN Platform.

The areas within DNN that you can hook into are:

- Theme (Skin) Events
- Container Events 
- Page (Tab) Events
- Module Events
- User Events
- User Relationship Events
- File Events
- Folder Events
- Role Events
- Portal Events

## Skin (Theme) Events

Skin Events happen during the server-side skin load lifecycle of any page when it is being accessed.

You can attach Skin Event Listeners to the following Skin Events: 

- OnSkinInit
- OnSkinLoad
- OnSkinPreload
- OnSkinUnload

For each type of Skin Event Listener, there are a minimum of two parts:
 1. Registering the Skin Event Listener
 2. Implementing the Skin Event Listener

The following example shows how to create an Event Listener for the OnSkinLoad event. 

Note: The steps to create the other Skin Event Listeners are the same except your will change the SkinEventType in the sample code below.

To attach code to the Skin Event, you must first register your Skin Event Listener. In this example we will register our Skin Event Listener when DNN starts loading for the first time. 

There are several ways to accomplish this, the following example registers the events within a Web API route mapper since that code loads when DNN starts up.

    using DotNetNuke.Application;
    using DotNetNuke.UI.Skins.EventListeners;
    using DotNetNuke.Web.Api;
    
    namespace SampleProject.DnnEvents.SkinEvents
    {
        class RouteMapper : IServiceRouteMapper
        {
    
            public void RegisterRoutes(IMapRoute mapRouteManager)
            {
    
                // Add Your Web API Routes Here
    
                // Register Your Skin Events
    
                DotNetNukeContext.Current.SkinEventListeners.Add(new DotNetNuke.UI.Skins.EventListeners.SkinEventListener(SkinEventType.OnSkinLoad, SampleSkinEventListener.OnSkinLoad));
    
            }
    
        }
    }


In the above example, we are registering a Skin Event Listener called **SampleSkinEventListener.OnSkinLoad**. This is a static class and method that defines what code will run when the Skin OnLoad event triggers. 

Since all pages in a DNN website have a skin/theme, we can assume that this code will run on page load for every page within a DNN website.

The following code is the Skin Event Listener implementation.   


    using System;
    using DotNetNuke.Services.Exceptions;
    using DotNetNuke.UI.Skins.EventListeners;
    
    namespace SampleProject.DnnEvents.SkinEvents
    {
        public static class SampleSkinEventListener
        {
            public static void OnSkinLoad(object sender, SkinEventArgs e)
            {
                try
                {
                   // Your Code Here
             
                }
                catch (Exception exception)
                {
                    Exceptions.LogException(exception);
                }
            }
        }
    }


## Container Events

Container Events happen during the container load lifecycle of every container on a page when a page is being accessed.

You can attach code to the following Container events: 

-	OnContainerInit
-	OnContainerLoad
-	OnContainerPreRender
-	OnContainerUnLoad

For each type of Container Event Listener, there are a minimum of two parts:
 1. Registering the Container Event Listener
 2. Implementing the Container Event Listener

The following example shows how to create an Event Listener for the OnContainer Load event. 

Note: The steps to create the other Container Event Listeners are the same except your will change the ContainerEventType in the sample code below.

To attach code to the Container Event, you must first register your Container Event Listener. In this example we will register our Container Event Listener when DNN starts loading for the first time. 

There are several ways to accomplish this, the following example registers the events within a Web API route mapper since that code loads when DNN starts up.

    using DotNetNuke.Application;
    using DotNetNuke.UI.Containers.EventListeners;
    using DotNetNuke.Web.Api;
    
    namespace SampleProject.DnnEvents.ContainerEvents
    {
        class RouteMapper : IServiceRouteMapper
        {
    
            public void RegisterRoutes(IMapRoute mapRouteManager)
            {
    
                // Add Your Web API Routes Here
    
                // Register Your Skin Events
    
                DotNetNukeContext.Current.ContainerEventListeners.Add(new DotNetNuke.UI.Containers.EventListeners.ContainerEventListener(ContainerEventType.OnContainerLoad, SampleContainerEventListener.OnContainerLoad));
    
    
            }
    
        }
    }


In the above example, we are registering a Skin Event Listener called **SampleContainerEventListener.OnContainerLoad**. This is a static class and method that defines what code will run when the Container OnLoad event triggers. 

Since all modules on a page in a DNN website are wrapped in a container, we can assume that this code will run when every container loads on every page within a DNN website.

The following code is the Container Event Listener implementation.   


    using System;
    using DotNetNuke.Services.Exceptions;
    using DotNetNuke.UI.Containers.EventListeners;
    
    namespace SampleProject.DnnEvents.ContainerEvents
    {
    
        public static class SampleContainerEventListener
        {
    
            public static void OnContainerLoad(object sender, ContainerEventArgs e)
            {
    
                try
                {
    
                    // Your Code Here
    
                    
                }
                catch (Exception exception)
                {
    
                    Exceptions.LogException(exception);
    
                }
    
            }
    
        }
    
    }

## Portal Events

Coming soon.

## Page (Tab) Events

Tab events happen during various times within the lifecycle of a Tab/Page within a DNN website.

You can attach code to the following Tab events: 

 - TabCreated
 - TabUpdated 
 - TabRemoved (deleted from page manager) 
 - TabDeleted (deleted from page recycle bin) 
 - TabRestored (restored from the page recycle bin)
 - TabMarkedAsPublished

Tab Events are registered by decorating a class with `[Export(typeof(ITabEventHandler))]` and implementing the [`ITabEventHandler`](xref:DotNetNuke.Entities.Tabs.Actions.ITabEventHandler) interface.

DNN will automatically register your Tab Event Handler when the DNN website loads.

The following example implements a complete Tab Event Handler with the event options stubbed out.

        using System.ComponentModel.Composition;
        using DotNetNuke.Entities.Tabs.Actions;
        
        
       namespace SampleProject.DnnEvents.TabEvents
        {
        
            [Export(typeof(ITabEventHandler))]
            public class SampleTabEventHandler : ITabEventHandler
            {
                public void TabCreated(object sender, TabEventArgs args)
                {
                    
                }
                
                public void TabUpdated(object sender, TabEventArgs args)
                {
                    
                }
        
                public void TabRemoved(object sender, TabEventArgs args)
                {
        
                }
        
                public void TabDeleted(object sender, TabEventArgs args)
                {
                   
                }
        
                public void TabRestored(object sender, TabEventArgs args)
                {
                    
                }
        
                public void TabMarkedAsPublished(object sender, TabEventArgs args)
                {
        
                }
        
            }
        
        }

## User Events

User Events happen during various times within the lifecycle of a User account within a DNN website.

You can attach code to the following User events: 

 - UserAuthenticated
 - UserCreated 
 - UsserRemoved (deleted from user manager) 
 - UserDeleted (deleted from recycle bin) 
 - UserApproved (restored from the page recycle bin)
 - UserUpdated

User Events are registered by decorating a class with `[Export(typeof(IUserEventHandlers))]` and implementing the [`IUserEventHandlers`](xref:DotNetNuke.Entities.Users.IUserEventHandlers) interface.

DNN will automatically register your Tab Event Handler when the DNN website loads.

The following example implements a complete Tab Event Handler with the event options stubbed out.


    using System.ComponentModel.Composition;
    using DotNetNuke.Entities.Users;
    
    namespace SampleProject.DnnEvents.UserEvents
    {
    
        [Export(typeof(IUserEventHandlers))]
        public class SampleUserEventHandler : IUserEventHandlers
        {
        
            public void UserAuthenticated(object sender, UserEventArgs args)
            {
    
            }
    
            public void UserCreated(object sender, UserEventArgs args)
            {
    
            }
    
            public void UserRemoved(object sender, UserEventArgs args)
            {
                
            }
    
            public void UserDeleted(object sender, UserEventArgs args)
            {
            
            }
    
            public void UserApproved(object sender, UserEventArgs args)
            {
    
            }
    
            public void UserUpdated(object sender, UpdateUserEventArgs args)
            {
            
            }
        }
    
    }


## Module Events

Coming soon.

## User Relationship Events

Coming soon.

## File Events

Coming soon.

## Folder Events

Coming soon.

## Role Events

Coming soon.

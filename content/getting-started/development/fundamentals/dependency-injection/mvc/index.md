﻿---
uid: getting-started-development-fundamentals-dependency-injection-mvc
locale: en
title: Dependency Injection - MVC Modules
dnnversion: 09.04.00
links: ["[Andrew Hoefling: DNN Dependency Injection: MVC Modules](https://www.andrewhoefling.com/Blog/Post/dnn-dependency-injection-mvc-modules-constructor-injection)"]
---

# Dependency Injection: MVC Modules

> [!NOTE]
> This article was originally a blog post by Andrew Hoefling as he implemented the initial dependency injection pattern in DNN. Some details may have changed in the meantime.

Dependency Injection is a new feature coming to DNN in 9.4 that allows you to inject abstractions or other objects into your MVC Module Controllers. This has been a common practice in both ASP.NET MVC and ASP.NET Core MVC application development. Removing the tight coupling between your controller code and business layer of your module.

Heading into the weekend following Microsoft Build 2019 (5 days after .NET 5 was announced) I submited a noteworthy [Pull Request](https://github.com/dnnsoftware/Dnn.Platform/pull/2774) to DNN that adds Dependency Injection into the platform, a feature accessible in any 3rd-party library or module. If you are not familliar with Dependency Injection and want to learn what this means for the platform you should read my first blog in the series [DNN Dependency Injection: .NET Core](xref:getting-started-development-fundamentals-dependency-injection-history).

### Getting Started

Getting started with Dependency Injection in a DNN MVC Module requires minimal changes from your existing code. We will cover a step-by-step guide on how to add Dependency Injection with sample code so you can immediately start taking advantage of the new features in your project.

#### Clone the Sample Code

I created a [sample project](https://github.com/ahoefling/DNN.DependencyInjection.Samples/tree/mvc_clean) on GitHub that let's you start with a clean MVC Module and follow along in the Dependency Injection Guide.

Go ahead and clone the repo or use your own.

```pwsh
git clone --branch mvc_clean https://github.com/ahoefling/DNN.DependencyInjection.Samples
```

Open the Solution file: `DNN.DependencyInjection.Samples.sln`

#### Building and Packaging

The sample project simplifies the building and packaging. To create the installer build the solution in **Release Mode**.

You will find the installer file in

```
.\src\Dnn.DependencyInjection.Samples.Mvc\packages\Dnn.DependencyInjection.Samples.Mvc_00.00.01_Install.zip
```

Try to build your module and install it. You will get a screen that looks like this
![Screenshot of a DNN site with "Hello World" displayed in the content pane](https://www.andrewhoefling.com/Portals/2/adam/Image%20&%20Lightbox/yT6zrKP0Dk-aOv4lsQqkOQ/Image/dnn-mvc.JPG)

## Add NuGets

Add the Dependency Injection NuGet package

- `DotNetNuke.DependencyInjection`

## Create Service to Inject

Create an interface and implementation that will be injected into our `HomeController`. We will be building a simple `MessageService` that implements `IMessageService`.

##### IMessageService

```csharp
public interface IMessageService
{
    string GetMessage();
}
```

##### MessageService

```csharp
public class MessageService : IMessageService
{
    public string GetMessage()
    {
        return "Hello from Dependency Injection World!!";
    }
}
```

## Add Startup Code

Before we can use our new `IMessageService` and implementation we need to register the service. Create a `Startup.cs` in the root of the project. The `Startup` class will inherit the `IDnnStartup` which provides the configuration method where services can be registered into the Dependency Injection container.

### Implement Interface

```csharp
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public class Startup : IDnnStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // add service registration
    }
}

The interface contains a method named `ConfigureServices` which includes a parameter of `IServiceCollection` which is the object that allows the code to register services. **The `IServiceCollection` is the same object used in ASP.NET Core applications which will help your module be ready for a .NET Core version of DNN**

### Register IMessageService

```csharp
public class Startup : IDnnStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IMessageService, MessageService>();
    }
}
```

There is nothing else you need to do with `Startup` code, **DNN will automatically invoke the code and register your services**.

## Add Constructor Injection

The `IMessageService` has been correctly registered with the DNN Dependency Injection Provider. The MVC Module is ready to start using Constructor Injection, this is where the services are included in the constructor with minimal work from the module developer.

```csharp
public class HomeController : DnnController
{
    protected IMessageService MessageService { get; }

    public HomeController(IMessageService messageService)
    {
        MessageService = messageService;
    }

    // omitted code
}
```

**Yes, all you need to do is add the abstractions to the constructor parameters.**

### Use the MessageService

Update the `Index` action to use the injected `IMessageService`

```csharp
public ActionResult Index()
{
    var model = new HelloWorld
    {
        Message = "Hello World"
    };
    return View(model);
}
```

### Complete HomeController Code

```csharp
[DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Anonymous)]
[DnnHandleError]
public class HomeController : DnnController
{
    protected IMessageService MessageService { get; }

    public HomeController(IMessageService messageService)
    {
        MessageService = messageService;
    }

    public ActionResult Index()
    {
        var model = new HelloWorld
        {
            Message = "Hello World"
        };
        return View(model);
    }
}
```

## Final Result

Now that our module is complete you can install it into your DNN 9.4 or greater website and see Dependency Injection working in practice. Your module will look something like this.

![Screenshot of a DNN site with "Hello from Dependency Injection World!!" displayed in the content pane](https://www.andrewhoefling.com/Portals/2/adam/Image%20&%20Lightbox/rZPp0YgQnkeZvU9s8F0FSg/Image/dnn-mvc-di.JPG)

### Sample Code

If you had trouble getting this working take a look at the completed sample code

- [Sample Code](https://github.com/ahoefling/DNN.DependencyInjection.Samples/tree/mvc_di)

## Next Steps

You should now have a successfully building installer file that you can deploy to your DNN 9.4 or greater website that uses Dependency Injection. This new feature provides power and simplicity to module development.

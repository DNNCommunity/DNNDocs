﻿---
uid: getting-started-development-fundamentals-dependency-injection-razor3
locale: en
title: Dependency Injection - Razor3 Modules
dnnversion: 09.04.00
links: ["[Andrew Hoefling: DNN Dependency Injection: Razor3 Modules](https://www.andrewhoefling.com/Blog/Post/dnn-dependency-injection-razor3-modules-constructor-injection)"]
---

# Dependency Injection: Razor3 Modules

> [!NOTE]
> This article was originally a blog post by Andrew Hoefling as he implemented the initial dependency injection pattern in DNN. Some details may have changed in the meantime.

Dependency Injection is a new feature coming to DNN in 9.4 that allows you to inject abstractions or other objects into your Razor3 Module. This has been a common practice in both ASP.NET and ASP.NET Core application development. Removing the tight coupling between your controller code and business layer of your module.

Heading into the weekend following Microsoft Build 2019 (5 days after .NET 5 was announced) I submited a noteworthy [Pull Request](https://github.com/dnnsoftware/Dnn.Platform/pull/2774) to DNN that adds Dependency Injection into the platform, a feature accessible in any 3rd-party library or module. If you are not familliar with Dependency Injection and want to learn what this means for the platform you should read my first blog in the series [DNN Dependency Injection: .NET Core](xref:getting-started-development-fundamentals-dependency-injection-history).

### Getting Started

Getting started with Dependency Injection in a DNN Razor3 Module requires minimal changes from your existing code. We will cover a step-by-step guide on how to add Dependency Injection with sample code so you can immediately start taking advantage of the new features in your project.

#### Clone the Sample Code

I created a [sample project](https://github.com/ahoefling/DNN.DependencyInjection.Samples/tree/razor3_clean) on GitHub that let's you start with a clean Razor3 Module and follow along in the Dependency Injection Guide.

Go ahead and clone the repo or use your own.

```pwsh
git clone --branch razor3_clean https://github.com/ahoefling/DNN.DependencyInjection.Samples
```

Open the Solution file: `DNN.DependencyInjection.Samples.sln`

#### Building and Packaging

The sample project simplifies the building and packaging. To create the installer build the solution in **Release Mode**.

You will find the installer file in

```
.\Module_Installers\Dnn.DependencyInjection.Samples.Razor3_00.00.01_Install.zip
```

Try to build your module and install it. You will get a screen that looks like this
![Screenshot of a DNN site with "Hello World" displayed in the content pane](https://www.andrewhoefling.com/Portals/2/adam/Image%20&%20Lightbox/wbLralYJ_0uRI2HRDxM2GQ/Image/dnn-razor3.JPG)

## Add NuGets

Add the Dependency Injection NuGet which currently lives in your local NuGet feed

- `NuGetFeed\DotNetNuke.DependencyInjection.9.4.0.156-alpha.nupkg`

Once DNN 9.4 is released it will be available on the public NuGet Feed.

## Create Service to Inject

Create an interface and implementation that will be injected into our `IndexModel`. We will be building a simple `MessageService` that implements `IMessageService`.

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
        return "Hello from the Dependency Injection World!!";
    }
}
```

## Add Startup Code

Before we can use our new `IMessageService` and implementation we need to register the service. Create a `Startup.cs` in the root of the project. The `Startup` class will inherit the `IDnnStartup` which provides the configuration method where services can be registered into the Dependency Injection container.

If you have been following along in other tutorials there is a major difference in the registration code. **The startup code is required to register any model that needs Constructor Injection.** In our example the `IndexModel` is registered with the provider.

### Implement Interface

```csharp
public class Startup : IDnnStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // add service registration
    }
}
```

The interface contains a method named `ConfigureServices` which includes a parameter of `IServiceCollection` which is the object that allows the code to register services. **The `IServiceCollection` is the same object used in ASP.NET Core applications which will help your module be ready for a .NET Core version of DNN**

### Register IMessageService

```csharp
public class Startup : IDnnStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IMessageService, MessageService>();

        // IndexModel registration is required for
        // constructor injection to work
        services.AddScoped<IndexModel>();
    }
}
```

There is nothing else you need to do with `Startup` code, **DNN will automatically invoke the code and register your services**.

## Add Constructor Injection

The `IMessageService` has been correctly registered with the DNN Dependency Injection Provider. The Razor3 Module is ready to start using Constructor Injection, this is where the services are included in the constructor with minimal work from the module developer.

```csharp
public class IndexModel
{
    protected IMessageService MessageService { get; }

    public IndexModel(IMessageService messageService)
    {
        MessageService = messageService;
    }

    // omitted code
}
```

**Yes, all you need to do is add the abstractions to the constructor parameters.**

### Use the MessageService

Update the `Title` property to use the injected `IMessageService`

```csharp
public string Title => MessageService.GetMessage();
```

### Complete IndexModel Code

```csharp
public class IndexModel
{
    protected IMessageService MessageService { get; }

    public IndexModel(IMessageService messageService)
    {
        MessageService = messageService;
    }

    public string Title => MessageService.GetMessage();
}
```

## Final Result

Now that our module is complete you can install it into your DNN 9.4 or greater website and see Dependency Injection working in practice. Your module will look something like this.

![Screenshot of a DNN site with "Hello from Dependency Injection World!!" displayed in the content pane](https://www.andrewhoefling.com/Portals/2/adam/Image%20&%20Lightbox/pcc69z1H80K51rip6wmy_w/Image/dnn-razor3-DI.JPG)

### Sample Code

If you had trouble getting this working take a look at the completed sample code

- [Sample Code](https://github.com/ahoefling/DNN.DependencyInjection.Samples/tree/razor3_di)

## Next Steps

You should now have a successfully building installer file that you can deploy to your DNN 9.4 or greater website that uses Dependency Injection. This new feature provides power and simplicity to module development.

---
uid: getting-started-development-fundamentals-dependency-injection-history
locale: en
title: Dependency Injection - History/Background
dnnversion: 09.04.00
links: ["[Andrew Hoefling: DNN Dependency Injection](https://www.andrewhoefling.com/Blog/Post/dnn-dependency-injection)","[Southern Fried DNN: DNN Dependency Injection and .NET Core](https://www.andrewhoefling.com/Blog/Post/dnn-dependency-injection)"]
---

# Dependency Injection: History/Background

> [!NOTE]
> This article was originally a blog post by Andrew Hoefling as he implemented the initial dependency injection pattern in DNN. Some details may have changed in the meantime.

Dependency Injection is used in many modern applications, it is ubiquitous across .NET application development. In .NET Core it has been built into the platform as a core feature that gets configured during the App Startup code. DNN was built before Dependency Injection became so popular in .NET, and in-lieu of Dependency Injection the Factory Pattern was heavily used. Adding Dependency Injection in DNN will be the first major step towards migrating to .NET Core.


- [.NET 5 and the Future](https://www.andrewhoefling.com/Blog/Post/net-5-and-the-future-of-net-framework-and-net-core)

5 days after the announcement of .NET 5 I created a Pull Request which added Dependency Injection into DNN adding the first major **ASP.NET Core** improvement to the platform. This is a statement that the community leaders are committed to modernizing the platform.

- [Added Dependency Injection to all Module Patterns and Removed Circular Dependencies in Module Pipeline](https://github.com/dnnsoftware/Dnn.Platform/pull/2774)

The new code uses the **exact** same library that is used by ASP.NET Core. By modernizing the architecture of DNN I am helping prepare the platform for migrating to modern .NET technologies.

## What is Dependency Injection?

The S.O.L.I.D. Principles of Object Oriented Programming are taught to many developers which stand for:

- **S**ingle Responsibility Principle
- **O**pen Closed Principle
- **L**iskov Substitution Principle
- **I**nterface Segregation Principle
- **D**ependency Inversion Principle

S.O.L.I.D. Principles were made famous by **Robert C. Martin** also known as "Uncle Bob"

Dependency Injection is a form of **Inversion of Control** which is an implementation of the last principle **Dependency Inversion**.

**This principle states that your code should depend on abstractions and not concrete implementations.**

In .NET that is best re-phased as your code should depend on interfaces and not concrete classes. This allows the implementation to be swapped out without other modules being dependent on the new implementation. As long as it still implements the exact same contract or interface.

### Dependency Injection Example

Let's look at how the Inversion of Control works in practice. Suppose you have a simple C# class that gets a message that can be used for displaying text on a screen. Let's call our class the `MessageService` and the code looks like this.

```csharp
public class MessageService
{
    public string GetMessage()
    {
        return "Hello World!";
    }
}
```

Now there is a class that takes the data from `MessageService` and prints it to the console. This class will be called `Program`.

```csharp
public class Program
{
    public void Display()
    {
        MessageService service = new MessageService();
        string message = service.GetMessage();
        Console.WriteLine(message);
    }
}
```

After this application has gone to production, there is a need to change how `MessageService` works. Now the `MessageService` needs to be changed to `CloudMessageService` and use several cloud based resources to return the data.

**Every place where `MessageService` was referenced needs to updated.**

Instead if you use an **Inversion of Control** implementation such as **Dependency Injection** you will be safe and only need to update your registration of `MessageService` to `CloudMessageService`.

Create an interface that will make the methods of `MessageService`, we will call this interface `IMessageService`.

```csharp
public interface IMessageService
{
    string GetMessage();
}
```

Once you create the interface, we can make sure both our `MessageService` and `CloudMessageService` implement the same interface.

```csharp
public class MessageService : IMessageService
{
    public string GetMessage()
    {
        return "Hello World!";
    }
}

public class CloudMessageService : IMessageService
{
    public string GetMessage()
    {
        // Omitted invocations to cloud resources
        return "Hello World from the Cloud!";
    }
}
```

Once we have the necessary abstraction (interface) in place and the different concrete implementations that implement the abstraction you can write your application code to depend on the abstraction. This is by definition **Inversion of Control**. Using **Dependency Injection** your code would look like this.

```csharp
public class Program
{
    private IMessageService _messageService;

    public Program(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Display()
    {
        string message = _messageService.GetMessage();
        Console.WriteLine(message);
    }
}
```

No matter what implementation of `IMessageService` that needs to be created, this code will always remain the same. This is the power of **Dependency Injection** and why it is used in many applications built by developers all over the world.

### DNN and The Factory Pattern

When DNN was built Dependency Injection wasn't used as much and the Factory Pattern was heavily used. A simple explanation of a Factory is a static class that creates objects for you. There is no convention or rule that states the object needs to be an abstraction or concrete class.

In the case of DNN the factories that currently exist create concrete classes which tightly couples dependencies.

**There is no easy way to split up business rules from 1 library to the next.**

## .NET Core

ASP.NET Core built Dependency Injection right into the framework and runtime, there is no 3rd party library needed to get it to work. In .NET Framework you would need to include different 3rd Party Libraries and create your custom configuration objects and methods that would configure the Dependency Injection. The App Startup code in .NET Core has been simplified and there is a convenient method that allows the developer to register any dependent services.

Consider this example which registers our `IMessageService` from above in a .NET Core Application.

```csharp
public IServiceProvider ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IMessageService, MessageService>();

    // omitted code
    return services.BuildServiceProvider();
}
```

If DNN supported a similar technology, the tightly coupled dependencies in the platform could start being built into abstractions (interfaces).

## DNN's Migration

DNN and .NET Core were once a big topic in the Technology Advisory Group especially since the announcement from Microsoft about [.NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/). As part of the migration to .NET Core DNN would need to make small incremental changes. Some major changes would include:

- Stabilizing a .NET Standard 2.0 compliant library and API
- Creating a module pattern that is .NET Standard 2.0 compliant

Consider that DNN is built using the WebForms technology of `System.Web`. This technology is not compliant as a .NET Standard 2.0 project, however much of the platform can be built into abstractions (interfaces) that are **NOT** dependent on `System.Web`. Once the platform libraries and APIs are abstracted to that point, changes can be made to the code that will make it .NET Standard 2.0 complaint. At that point more and more libraries can be converted to ASP.NET Core.

**Creating these abstractions is Inversion of Control**

This is a text book example of **Inversion of Control** and is the secret answer to migrating the platform to .NET Core.

## How Do I Get Started?

Once the **Pull Request** is accepted which should be for DNN 9.4 you can start using **Dependency Injection** immediately. Anyone that upgrades their site to DNN 9.4 will be using it even though they may not realize it. As part of the change I increased performance in the Module Pipeline by leveraging **Dependency Injection** (There will be another blog dedicated to that).

**Dependency Injection** in DNN 9.4 is going to be very easy to use and will be supported in the following module types:

- MVC
- SPA
- Razor3
- Web Forms
- Anywhere in DNN

You can use **Dependency Injection** anywhere in DNN, not just in module code. If you built a 3rd-party library that needs it, you can create your registrations and that 3rd-party library will just work.

### Startup File

In your custom 3rd-party library or module create a new file called `Startup` and you will register all of your dependencies in this file. Let's register our `IMessageService` and `CloudMessageService` from earlier.

```csharp
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public class Startup : IDnnStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IMessageService, CloudMessageService>();
    }
}
```

As long as the `Startup` file implements the `IDnnStartup` interface from `DotNetNuke.DependencyInjection` it will run automatically at Application Start. There is nothing else you need to do to register your dependencies.

### Injecting Objects

**Constructor Injection is the recommended** way to use **Dependency Injection**. In your module code just add the abstraction (interface) to the constructor.

```csharp
public class HomeController : DnnController
{
    protected IMessageService MessageService { get; }
    public HomeController(IMessageService messageService)
    {
        MessageService = messageService;
    }

    public ActionResult Index()
    {
        var model = new HelloWorldModel
        {
            Message = MessageService.GetMessage()
        };
        return View(model);
    }
}
```

### Service Locator Pattern

The **Service Locator Pattern** is manually requesting the object instead of using Constructor Injection. It is commonly referred to as an **anti-pattern** and should be **avoided** at all costs. Web Forms Modules are the **only** modules that don't support Constructor Injection and have a **Service Locator** in the parent class.

To access the Service Locator the code will need to implement one of the following classes:

- `PortalModuleBase`
- `ModuleSettingsBase`
- `AuthenticationConfigBase`
- `AuthenticationLogoffBase`
- `AuthenticationLoginBase`

Each of these base classes have a `DependencyProvider` which gives the code easy access to resolve any registered service in the container.

**This is an anti-pattern but a suitable workaround while abstractions are built.**

#### Supported Modules

Modules supporting Constructor Injection

- MVC
- SPA/Web API
- Razor3

Modules not supporting Constructor Injection

- WebForms

WebForms modules will **NOT** support Dependency Injection and you must use the Service Locator Pattern to access any registered services.

## Next Steps

This week (5/14/2019) there will be a new blog posted every day with an explanation on how to use DNN Dependency Injection with a different module pattern, including code samples. **With a presentation at [Southern Fried DNN](https://www.youtube.com/watch?v=GKZXBN8sMNE) showcasing the new features.**

**Exciting times ahead for DNN**

---
uid: module-architecture
locale: en
title: Module Architecture
dnnversion: 09.02.00
related-topics: dnn-manifest-schema,module-features,developers-creating-modules-overview,about-evs
links: ["[DNN Module APIs](https://www.dnnsoftware.com/dnn-api/)"]
---

# Module Architecture

Although every module provides a different set of features and functionality, some architectural elements are common among modules. Most DNN modules are developed using an n-tier architecture. Whether you build a Web Forms module, an MVC module, or a SPA module, you implement most of these layers in your module.



![Module architecture](/images/gra-module-architecture.png)



## Data Access Layer

DNN supports three Data Access Layer (DAL) frameworks: DAL, DAL+, and DAL2. All three are based on the same underlying provider model, which enables DNN to be used with different database management systems.

Note: DNN ships with a SQL Server database provider. Other third-party database providers are available for Oracle, MySQL, and MS Access; however, MySQL and MS Access providers are no longer maintained or supported.

DAL is a fully abstracted implementation that requires the following:

*   An abstract data provider class that defines your data layer API.
*   A concrete implementation of this abstract class for every database type you wish to support (typically just SQL Server).
*   Database scripts to create the stored procedures, tables, and views required by your module.

DAL+ adds generic data access methods to the core platform to eliminate the need for the abstract and concrete data provider classes. You can still use alternate databases, and you must still provide the necessary database scripts.

DAL2 uses the PetaPOCO Micro-ORM, which eliminates the need for writing stored procedures. DAL2 provides additional features, including integrated cache management, which further simplifies your code.

You can use any data access method, even those not directly supported by DNN. You can also use more than one DAL technology within a single module.

Tip: Use DAL2 for most of your standard CRUD queries, and use DAL+ for more complex queries that may require performance tuning. This approach simplifies development and lets you focus your performance-tuning efforts.

## Caching Layer

Database access is one of the slowest actions performed by a web application. In many systems, the data is stored in a format that is different from the format in which it will be used. Applications often perform complex queries to filter the dataset and then alter the format of the results prior to use. If the database is not local, the query takes longer, depending on network speed. Database queries are orders of magnitude slower than using an in-memory cache.

Caching is ideal for:

*   Any data that is expensive to compute and yields the same results for a period of time.
*   Any data segment that is invariant for a subset of users or for a specific URL.

DNN provides built-in caching with the Cache API. If you use DNN's DAL or DAL+ APIs, implement the [Cache-Aside Pattern](https://docs.microsoft.com/en-us/azure/architecture/patterns/cache-aside) for optimum performance. You can configure DAL2's built-in caching by using attributes in your code.

The Cache API can be extended to use different cache stores. The abstraction provided by the Cache API ensures that modules perform seamlessly, regardless of the caching provider installed by the site administrator.

> [!Tip]
> If a class would be stored in the cache, mark it `[Serializable]` to ensure that it is stored correctly by out-of-process caching providers.

```

    [Serializable]
    public class MyInfoClass
    {
        // Property declarations...
    }

```

## Business Logic Layer

Most business rules are implemented in the business logic layer. These rules can be as simple as validating data or as complex as orchestrating workflows across multiple back-end systems. This layer is also responsible for coordinating calls to the caching and data access layers.

DNN provides APIs for handling common tasks, such as application security, file storage, list management, event logging, and full-text search. These APIs are fully abstracted and extensible so you can focus on just the business rules that are specific to your module.

## Service Layer

DNN provides the Service Framework, which you can use for quickly defining web services. The Service Framework provides integrated access to common DNN entities within your service methods, so that your service can determine which site is being called, the user making the request, and the module facilitating the request. You can also secure your web services by specifying which applications and which users can access your service endpoints.

## Presentation Layer

The core component in the presentation layer is the module control. Every unique view of a module is registered as a module control in the [DNN Manifest](xref:dnn-manifest-schema).

DNN APIs make it easy to access any module control, thus simplifying view management within your module.

Alternatively, modules can implement their own view dispatch methods to control when specific views are shown or how the module appears on the page.

For Web Forms modules, the primary view component is an ASP.NET user control, called a module control in DNN. For MVC and SPA modules, DNN expanded the definition of module controls to accommodate their alternative view-rendering pipelines.

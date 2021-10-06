---
uid: developers-create-a-web-api-with-jwt
locale: en
title: Create a Web API with JWT
dnnversion: 09.02.00
related-topics: 
---

# Create a Web API with JWT

When creating a Web API in DNN, you can specify an authentication method to be used with your web service. To do so, you simply need to add the `[DnnAuthorize]` attribute in your code.

A template for a DNN Web API using JWT authentication:

```csharp
    [DnnAuthorize(AuthTypes = "JWT")]
    public class MyJwtTestController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult MyGetMethod()
        {
            // Add your API logic here.
            // Remember to check for authorization.
        }
    }
```
`MyGetMethod` is called, only if the client was authenticated through the JWT authentication handler, which must be enabled in the web.config file.
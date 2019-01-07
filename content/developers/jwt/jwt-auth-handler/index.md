---
topic: jwt-auth-handler
locale: en
title: JWT Authentication Handler
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-jwt-overview
related-topics: setup-jwt-for-auth,setup-jwt-for-auth,jwt-user-credentials,jwt-server-response,jwt-access-token,jwt-page-request,about-jwt
links: ["[IETF RFC 7519](https://tools.ietf.org/html/rfc7519)","[DNN Presentation: How Evoq Helps You Build Modern Web Applications by Will Morgenweck](http://www.slideshare.net/dnnsoftware/how-evoq-helps-you-build-modern-web-applications)","[jwt.io](https://jwt.io/introduction/)"]
---

# JWT Authentication Handler

After the JWT Authentication Handler is installed in DNN, the web.config file is updated with a line similar to the following:

```

    <authServices>
        <messageHandlers>
            <!-- other message handlers -->
            <add name="JWTAuth" type="Dnn.AuthServices.Jwt.Auth.JwtAuthMessageHandler, Dnn.AuthServices.Jwt" enabled="false" defaultInclude="false" forceSSL="true"/>
        </messageHandlers>
    </authServices>
        
```

Parameter

Allowed Values

Description

name

string

Name of the authentication provider. Must be unique within the `messageHandlers` section.

enabled

`true` or `false`

If `true`, an instance of the provider is created and added to the chain of providers when the application starts. Otherwise, the provider is not instantiated.

defaultInclude

`true` or `false`

If `true`, the API controller uses the authentication type included in each Web API request by default; if `false`, the API controller uses the authentication type specified in its own `DnnAuthorize` attribute. Example: If the API controller’s attribute is set to `[DnnAuthorize(AuthTypes = "JWT")]`, then the API controller will respond only to requests that use JWT authentication.

forceSSL

`true` or `false`

If `true`, SSL mode (HTTPS) is required for API requests; otherwise, all requests are accepted.

Important: To prevent unauthorized access to the site, enforce SSL so that tokens are treated the same way as cookies in a web request.
---
topic: jwt-user-credentials
locale: en
title: JWT User Credentials
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-jwt-overview
related-topics: setup-jwt-for-auth,setup-jwt-for-auth,jwt-server-response,jwt-access-token,jwt-page-request,jwt-auth-handler,about-jwt
---

# JWT User Credentials

For DNN, the user credentials must be in a JSON object with the user name (key: `"u"`) and password (key: `"p"`).

A sample POST request with the user name `sitemanager` and password `dnnhost`:

```

    POST http://testsitece.lvh.me/DesktopModules/JwtAuth/API/mobile/login HTTP/1.1
    Content-Type: application/json; charset=utf-8
    Host: testsitece.lvh.me
    Content-Length: 33

    {"u":"sitemanager","p":"dnnhost"}
                
```
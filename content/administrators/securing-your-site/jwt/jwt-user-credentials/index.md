---
uid: administrators-jwt-user-credentials
locale: en
title: JWT User Credentials
dnnversion: 09.02.00
related-topics: 
---

# JWT User Credentials

For DNN, the user credentials must be in a JSON object with the user name (key: `"u"`) and password (key: `"p"`).

A sample POST request with the user name `sitemanager` and password `dnnhost`:

```

    POST https://testsitece.lvh.me/DesktopModules/JwtAuth/API/mobile/login HTTP/1.1
    Content-Type: application/json; charset=utf-8
    Host: testsitece.lvh.me
    Content-Length: 33

    {"u":"sitemanager","p":"dnnhost"}

```

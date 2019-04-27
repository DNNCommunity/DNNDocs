﻿---
uid: administrators-jwt-page-request
topic: jwt-page-request
locale: en
title: Page Request with JWT
dnneditions: DNN Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-jwt-overview
related-topics: setup-jwt-for-auth,setup-jwt-for-auth,jwt-user-credentials,jwt-server-response,jwt-access-token,jwt-auth-handler,about-jwt
---

# Page Request with JWT

The header of a subsequent request must include the token in this format:

```

    Authorization: Bearer [token]

```

A sample GET request with JWT:

```

    GET https://testsitece.lvh.me/DesktopModules/JwtAuth/API/mobile/testget HTTP/1.1
    Host: testsitece.lvh.me
    Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzaWQiOiJkYmViMjlhYTMyYjg0MTMxYTA0NjY4MDAyNzAxNWEwZSIsInJvbGUiOlsiQWRtaW5pc3RyYXRvcnMiLCJSZWdpc3RlcmVkIFVzZXJzIiwiU3Vic2NyaWJlcnMiXSwiaXNzIjoidGVzdHNpdGVjZS5sdmgubWUiLCJleHAiOjE0NTA4MzU2ODMsIm5iZiI6MTQ1MDgzMTc4M30.Yf3mmBJ8nV_IozqvvLc8L34dDklU2J7z0uXn3jsICp0

```

---
uid: developers-renew-a-jwt-token
locale: en
title: Renew a JWT Token
dnnversion: 09.02.00
related-topics: 
---

# Renew a JWT Token

When an access token expires, the client can request a new one by sending a POST with a JSON object containing the renewalToken.

```json
{
    "rtoken":[renewalToken]
}
```

A sample request for a new token:

```
POST http://testsitece.lvh.me/DesktopModules/JwtAuth/API/mobile/extendtoken HTTP/1.1
Host: testsitece.lvh.me
Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzaWQiOiIwNGIxZWUyZmMxNzk0NzRlODQwMzNiYmJhN2MwZGMzYSIsInJvbGUiOlsiQWRtaW5pc3RyYXRvcnMiLCJSZWdpc3RlcmVkIFVzZXJzIiwiU3Vic2NyaWJlcnMiXSwiaXNzIjoidGVzdHNpdGVjZS5sdmgubWUiLCJleHAiOjE0NTA4Mzg0MDAsIm5iZiI6MTQ1MDgzNDUwMH0.ly3OKNpSIHCfDQLhz8J_h4fb0fxjnt71D2dYWcF45ig
Content-Type: application/json; charset=utf-8
Content-Length: 77

{"rtoken":"0UKc7UX7nCCT+KJYgAgCB7GAtxggzeHj5j4ZYkb9Z/ZurXcigLjhVSkwpzOYBTPi"}
```

> [!IMPORTANT]
> After this request, both the old access token and the old renewal token are invalidated.

The new access token is valid for one hour. The renewal token is valid for 14 days.
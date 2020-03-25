---
uid: administrators-jwt-server-response
locale: en
title: Server Response with JWT
dnnversion: 09.02.00
related-topics: 
---

# Server Response with JWT

When the server responds to the user's browser, the JSON object that is returned contains three properties.

|**Property name**|**Description**|
|---|---|
|<em>displayName</em>|The display name of the user.|
|<em>accessToken</em>|A JWT that must be included with each subsequent request to the various Web API endpoints for servers. The server obtains the user information from the access token itself, which is faster than retrieving the information from the database again. The access token is valid for 60 minutes and must be renewed using the renewal token.|
|<em>renewalToken</em>|A JWT that is required to renew the access token when expired. The renewal token becomes invalid after 14 days, after the user logs out, or when the user changes their credentials, such as the login password for the web site.|

A sample JSON object sent to the browser after validating a user named "Site Manager":

```

    HTTP/1.1 200 OK
    Cache-Control: no-cache
    Pragma: no-cache
    Content-Type: application/json; charset=utf-8
    Expires: -1
    Date: Wed, 23 Dec 2015 00:54:43 GMT
    Content-Length: 425

    {
     "displayName":"Site Manager",
     "accessToken":"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzaWQiOiJkYmViMjlhYTMyYjg0MTMxYTA0NjY4MDAyNzAxNWEwZSIsInJvbGUiOlsiQWRtaW5pc3RyYXRvcnMiLCJSZWdpc3RlcmVkIFVzZXJzIiwiU3Vic2NyaWJlcnMiXSwiaXNzIjoidGVzdHNpdGVjZS5sdmgubWUiLCJleHAiOjE0NTA4MzU2ODMsIm5iZiI6MTQ1MDgzMTc4M30.Yf3mmBJ8nV_IozqvvLc8L34dDklU2J7z0uXn3jsICp0",
     "renewalToken":"qjjd1vmgbtWb23fPK4J9ttUQBKpgC6k1yFmnteU+9mlFxcHeC3rJlly8oGBBAIzw"
     }
                
```

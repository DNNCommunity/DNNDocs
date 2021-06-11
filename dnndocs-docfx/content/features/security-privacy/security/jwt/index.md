---
uid: jwt
locale: en
title: About JWT Authentication
dnnversion: 09.02.00
links: ["[IETF RFC 7519](https://tools.ietf.org/html/rfc7519)","[DNN Presentation: How Evoq Helps You Build Modern Web Applications by Will Morgenweck](https://www.slideshare.net/dnnsoftware/how-evoq-helps-you-build-modern-web-applications)","[jwt.io](https://jwt.io/introduction/)","[Unix time](https://en.wikipedia.org/wiki/Unix_time)"]
---

# About JWT Authentication

## Overview

The JSON Web Token (JWT) is an open standard (IETF RFC 7519) data format that is compact, self-contained, and secure. It is intended for passing information where space is limited, such as HTTP headers and URI queries.

*   Compact. Because the JWT is comprised of encoded JavaScript Object Notation (JSON) objects, it is compact enough to be sent through a URL query, a POST parameter, or an HTTP header. JSON objects are simpler and more compact than Security Assertion Markup Language (SAML) assertions, which use XML. Due to its smaller size, it can also be transmitted faster.
*   Self-contained. The JWT can contain all the required information about the user and therefore avoids querying the database more than once.
*   Secure. The JWT can be digitally signed with one of the following methods:
    *   HMAC algorithm, using a secret
    *   RSA algorithm, using a public/private key pair

JWT is ideal for applications that can not or do not want to use cookies, such as mobile native apps and desktop apps. In a standard web-forms application, the user logs into a web site and receives a session/token cookie that the browser sends back with each subsequent request to the site, in order to avoid checking the user's credentials with each request. JWT simply replaces the cookie with a token that is smaller and faster to transmit.

## JWT Authentication

> [!Note]
> The JWT Authentication Provider is available in DNN products; however, it must be installed and enabled separately. DNN uses JWT for authentication only.

![JWT process](/images/gra-JWTprocess.png)

1.  The user logs in with their username and password or other security credentials. The browser or the client app sends a POST request with the user credentials, which are sent over an HTTPS connection.
2.  The user's credentials are checked against the login database. If valid, the server creates and encrypts an access JWT, which is stored in the body of the response.
3.  When the user requests a page, the browser or client app stores the access JWT inside the `Authorization` section of the request.
4.  The server verifies the JWT signature and extracts the user information from the JWT payload.
5.  The requested page or resource is sent to the client.

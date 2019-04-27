﻿---
uid: administrators-jwt-access-token
topic: jwt-access-token
locale: en
title: JWT Access Token
dnneditions: DNN Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-jwt-overview
related-topics: setup-jwt-for-auth,setup-jwt-for-auth,jwt-user-credentials,jwt-server-response,jwt-page-request,jwt-auth-handler,about-jwt
---

# JWT Access Token

The decoded access token is comprised of three parts separated by dots.

```

    header.payload.signature
            
```


<table>
    <tr>
        <th>
        Component
        </th>
        <th>
        Description
        </th>
    </tr>

<tr>
    <td>
        JWT header
    </td>
    <td>
    A JSON object containing the JWT protocol identifier and the signature scheme. The header is converted to a JavaScript Object Signing and Encryption (JOSE) header as UTF-8 octets and then encoded as a Base64 string. <br />Example:
        <pre>
          {
            "typ":"JWT",
            "alg":"HS256"
          }
        </pre>
    </td>
</tr>

<tr>
    <td>JWT payload</td>
    <td>A JSON object that contains the JWT claims set (asserted information about the user) or other information. Encoded as a Base64 string. The DNN JWT claims set includes the following:<ul><li>sid is the session id, which is fixed for the lifetime of the renewal token.</li><li>role is the list of roles assigned to the user. Used in authorization to determine which areas of the site the user can access.</li><li>iss is the portal alias of the site that issued the token.</li><li>exp is the expiration time of the access token. The token is rejected after this time (plus a small grace period). Expressed as Unix time.</li><li>nbf is the "not-before" time. The token is rejected before this time. Expressed as Unix time.</li><br />Example:
        <pre>
        {
        "sid":"eecb9bf34bbb4c8eb87dbba3aa1523c6",
        "role":["Administrators","Registered Users","Subscribers"],
        "iss":"testsitece.lvh.me",
        "exp":1450834762,
        "nbf":1450830862
        }
        </pre>
    </td>
</tr>
<tr>
    <td>JWT signature</td>
    <td>The hash/encryption of the header and payload. The encryption method is stated in the header. Encoded as a Base64 string.</td>
</tr>
</table>


The new access token is valid for one hour.

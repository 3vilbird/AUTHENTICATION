# API Documentation for AUTHENTICATION

This document describes the API endpoints and authentication mechanism for the AUTHENTICATION project (`auth-audence` branch).

## Overview

This project is a .NET Web API that uses JWT (JSON Web Token) based authentication. It demonstrates how to protect API endpoints using JWT Bearer tokens and how to validate the `aud` (audience) claim.

---

## Authentication

- **Scheme:** Bearer JWT
- **Audience:** The API expects the `aud` claim in the JWT to match one of the allowed audiences (see below).
- **Issuer:** The JWT must be issued by a trusted issuer.

### Valid Audiences
- http://localhost:53679
- https://localhost:44381
- http://localhost:5027
- https://localhost:7129

### Valid Issuer
- dotnet-user-jwts

---

## Endpoints

### 1. Weather Forecast (Public)
- **GET** `/weatherforecast`
- **Description:** Returns a list of weather forecasts. No authentication required.
- **Response Example:**
  ```json
  [
    {
      "date": "2025-06-01",
      "temperatureC": 25,
      "summary": "Warm",
      "temperatureF": 77
    },
    ...
  ]
  ```

### 2. Protected Route (Requires Authentication)
- **GET** `/api/ProtectedRout/secret`
- **Description:** Returns a message if the request is authenticated with a valid JWT.
- **Authentication:** Requires a valid Bearer JWT in the `Authorization` header.
- **Response Example:**
  ```json
  {
    "message": "This is a protected route. You are authenticated!"
  }
  ```

---

## How to Authenticate

1. **Obtain a JWT:**
   - You can generate a JWT using the .NET CLI:
     ```sh
     dotnet user-jwts create
     ```
   - The output will include a token and its claims. Ensure the `aud` claim matches one of the valid audiences above.

2. **Make an Authenticated Request:**
   - Add the JWT to the `Authorization` header:
     ```http
     Authorization: Bearer {your_token}
     ```

---

## JWT Claims

- **iss**: Issuer (who issued the token)
- **sub**: Subject (the user)
- **aud**: Audience (the intended recipient, must match one of the valid audiences)

If the `aud` claim does not match, the API will return an unauthorized error.

---

## References
- [Configure JWT Bearer Authentication (Microsoft Docs)](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/configure-jwt-bearer-authentication?view=aspnetcore-9.0)
- [JSON Web Token (Wikipedia)](https://en.wikipedia.org/wiki/JSON_Web_Token)

---

*Generated on 2025-06-01*

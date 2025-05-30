# AUTHENTICATION

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/configure-jwt-bearer-authentication?view=aspnetcore-9.0
https://en.wikipedia.org/wiki/JSON_Web_Token


JWT BASED authentication

create JWT with cli 

```sh
dotnet user-jwts create

```

out put 

```sh
New JWT saved with ID '844e834a'.
Name: ganaa

Token: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImdhbmFhIiwic3ViIjoiZ2FuYWEiLCJqdGkiOiI4NDRlODM0YSIsImF1ZCI6WyJodHRwOi8vbG9jYWxob3N0OjM2MzcxIiwiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMTYiLCJodHRwOi8vbG9jYWxob3N0OjUwNzYiLCJodHRwczovL2xvY2FsaG9zdDo3Mjk1Il0sIm5iZiI6MTc0ODYyMDUxNSwiZXhwIjoxNzU2NTY5MzE1LCJpYXQiOjE3NDg2MjA1MTUsImlzcyI6ImRvdG5ldC11c2VyLWp3dHMifQ.s35rsTUydYdyauX65IkeAzc_dyErd6ZWP4IUtHGVIlo

```

The structure of the jwt
![Screenshot from 2025-05-30 22-08-00](https://github.com/user-attachments/assets/c165864a-2b71-4888-931f-85cdaf003a04)

so we have the below stuff

1. Header
2. Payload
3. Signiture

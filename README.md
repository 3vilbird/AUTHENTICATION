# AUTHENTICATION

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/configure-jwt-bearer-authentication?view=aspnetcore-9.0
https://en.wikipedia.org/wiki/JSON_Web_Token


JWT with dotnet cli :- https://learn.microsoft.com/en-us/aspnet/core/security/authentication/jwt-authn?view=aspnetcore-9.0&tabs=linux


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

Read more here abput the claims (we have 7 std claims)
https://en.wikipedia.org/wiki/JSON_Web_Token#Standard_fields

### Main claims

iss 	--> Issuer -->	Identifies principal that issued the JWT. 
<br/>

sub 	--> Subject -->	Identifies the subject of the JWT. 
 
<br/>
aud 	--> Audience --> Identifies the recipients that the JWT is intended for. Each principal intended to process the JWT must identify itself with a value in the audience claim. 
                       If the principal processing the claim does not identify itself with a value in the aud claim when this claim is present, then the JWT must be rejected.  



## Audence

the evaluator will check itseft is it present in the aud list or not if not it will say that unautorized.


exmaple
![Screenshot from 2025-05-31 11-38-04](https://github.com/user-attachments/assets/d91ad9b2-8546-4fb2-9296-c66edd7f6d93)

here my aud is the local host on which the sysytem is running.

and let me generate the token which has no above mentioned aud
![Screenshot from 2025-05-31 11-37-21](https://github.com/user-attachments/assets/2daf4f07-c77a-4af5-95d5-c2c8c983c1e3)
![Screenshot from 2025-05-31 11-37-40](https://github.com/user-attachments/assets/1861abb4-a15a-40be-850c-e20d9e46a9a7)

and if i use that i will get the below error.

![Screenshot from 2025-05-31 11-38-17](https://github.com/user-attachments/assets/9fa8169c-9fa3-4dc5-9475-be8e6e268d6f)





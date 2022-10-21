# Coach's Guide - Day 1 - Challenge 03 - Deploy your Web Application to Azure

 [< Previous Solution](./Solution_D1_02.md) - **[Home](../README.md)** - [Next Solution >](./Solution_D1_04.md)

## Introduction

In this challenge students will deploy the sample ASP.Net Core web application used in previous challenge to Azure.

Encourage users to use the script provided to deploy the application to save time,

Ensure that users configured the following parameters in the script.

```powershell
# Deployment Parameters
$subscription = "[Enter your Subscription Id]"
$AzureAdDomain = "[Enter your Tenant Domain i.e xxxx.onmicrosoft.com]"
$HomeTenantId = "[Enter your Tenant Id]"
$AzureAdClientId = "[Enter your Client ID]"
$AzureAdClientSecret = "[Enter your Client Secret]"
```

The script uses the Azure CLI and executes the following steps:

- Login to Azure
- Set subscription to use in current context
- Create Resource group if not exists
- Create App Service Plan
- Create Web Application
- Configure the application setting on the web application
  - WEBSITE_RUN_FROM_PACKAGE="1"
  - AzureAd:Instance='https://login.microsoftonline.com/
  - AzureAd:TenantId=$HomeTenantId
  - AzureAd:CallbackPath='/signin-oidc'
  - AzureAd:ClientId=$AzureAdClientId
  - AzureAd:Domain=$AzureAdDomain
  - AzureAd:ClientSecret=$AzureAdClientSecret  
- Build .Net Web application
- Publish the application to a local folder
- Compress the publish folder to a zip file
- Deploy the application to the web app (uses the published zip file)

[Deploy files to App Service](https://learn.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)

## Answers for Challenge

### 1. Explain what are the Redirect URIs and why they are used

A redirect URI, or reply URL, is the location where the authorization server sends the user once the app has been successfully authorized and granted an authorization code or access token. The authorization server sends the code or token to the redirect URI, so it's important you register the correct location as part of the app registration process.

[Redirect URI (reply URL)](https://learn.microsoft.com/en-us/azure/active-directory/develop/reply-url)

### 2. Explain the differences between access token, ID token and refresh token

The Microsoft identity platform authenticates users and provides security tokens, such as [access tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#access-token), [refresh tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#refresh-token), and [ID tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#id-token). Security tokens allow a [client application](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#client-application) to access protected resources on a [resource server](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#resource-server).

**Access token**: An access token is a security token that's issued by an [authorization server](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#authorization-server) as part of an [OAuth 2.0](https://learn.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols) flow. It contains information about the user and the resource for which the token is intended. The information can be used to access web APIs and other protected resources. Access tokens are validated by resources to grant access to a client app. To learn more about how the Microsoft identity platform issues access tokens, see [Access tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/access-tokens).

**Refresh token**: Because access tokens are valid for only a short period of time, authorization servers will sometimes issue a refresh token at the same time the access token is issued. The client application can then exchange this refresh token for a new access token when needed. To learn more about how the Microsoft identity platform uses refresh tokens to revoke permissions, see [Refresh tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/refresh-tokens).

**ID token**: ID tokens are sent to the client application as part of an [OpenID Connect](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-protocols-oidc) flow. They can be sent alongside or instead of an access token. ID tokens are used by the client to authenticate the user. To learn more about how the Microsoft identity platform issues ID tokens, see [ID tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/id-tokens).

[Security tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/security-tokens)

### 3. Explain how the Validation of security tokens works

It's up to the app for which the token was generated, the web app that signed in the user, or the web API being called to validate the token. The token is signed by the authorization server with a private key. The authorization server publishes the corresponding public key. To validate a token, the app verifies the signature by using the authorization server public key to validate that the signature was created using the private key.

Tokens are valid for only a limited amount of time. Usually, the authorization server provides a pair of tokens, such as:

- An access token, which accesses the application or protected resource.
- A refresh token, which is used to refresh the access token when the access token is close to expiring.

Access tokens are passed to a web API as the bearer token in the `Authorization` header. An app can provide a refresh token to the authorization server. If the user access to the app wasn't revoked, it will get back a new access token and a new refresh token. This is how the scenario of someone leaving the enterprise is handled. When the authorization server receives the refresh token, it won't issue another valid access token if the user is no longer authorized.

[Validate security tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/security-tokens#validate-security-tokens)

### 4. Explain the usage of JSON Web Tokens and claims

The Microsoft identity platform implements security tokens as JSON Web Tokens (JWTs) that contain *claims*. Since JWTs are used as security tokens, this form of authentication is sometimes called *JWT authentication*.

A [claim](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#claim) provides assertions about one entity, such as a client application or [resource owner](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#resource-owner), to another entity, such as a resource server. A claim might also be referred to as a JWT claim or a JSON Web Token claim.

Claims are name or value pairs that relay facts about the token subject. For example, a claim might contain facts about the security principal that was authenticated by the authorization server. The claims present in a specific token depend on many things, such as the type of token, the type of credential used to authenticate the subject, and the application configuration.

Applications can use claims for various tasks, such as to:

- Validate the token.
- Identify the token subject's [tenant](https://learn.microsoft.com/en-us/azure/active-directory/develop/developer-glossary#tenant).
- Display user information.
- Determine the subject's authorization.

A claim consists of key-value pairs that provide information such as the:

- Security Token Server that generated the token.
- Date when the token was generated.
- Subject (such as the user--except for daemons).
- Audience, which is the app for which the token was generated.
- App (the client) that asked for the token. In the case of web apps, this app might be the same as the audience.

To learn more about how the Microsoft identity platform implements tokens and claim information, see [Access tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/access-tokens) and [ID tokens](https://learn.microsoft.com/en-us/azure/active-directory/develop/id-tokens)

[JSON Web Tokens and claims](https://learn.microsoft.com/en-us/azure/active-directory/develop/security-tokens#json-web-tokens-and-claims)
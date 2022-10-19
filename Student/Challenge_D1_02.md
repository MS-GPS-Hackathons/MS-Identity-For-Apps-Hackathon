# Day 1 - Challenge 02 - Add sign-in with Azure AD Identity to an ASP.NET Core web app

 [< Previous Challenge](./Challenge_D1_01.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_03.md)

## Introduction

As mentioned in the previous challenge, the Product Owner is willing to use a cloud identity solution for their internal web applications. Now it’s the time to continue you investigation and run a Proof of Concept (POC).

## Description

In the previous challenge you have completed the setup of your tenant and you figured out that you have to create an Azure AD Application registration in order to proceed with the PoC. You found a very good QuickStart reference with a sample ASP.Net Core web application which will help you speed up the process. The link to the QuickStart can be found in the Learning Resources below.

Remember, the scope of the PoC is to allow your corporate users to login in to your application.

## Success Criteria

- Demonstrate that you have configured the Application which has as an audience all the accounts in your directory only.
- Demonstrate that you can login with HomeUserA account in your web application locally.
- Briefly explain the differences between Single Tenant and Multi-tenant app types.
- Explain the Application types options (SPA, web app, desktop app, daemon app) by specifying what authentication flow you will use for every option.
- Explain what is User Consent and Admin Consent.
- Explain what is the usage of scopes.
- Explain the differences between access token, ID token and refresh token.
- Explain how the Validation of security tokens works
- Explain the usage of JSON Web Tokens and claims.

## Tips

You should configure the Application Registration in your “HomeTenant”

You can configure the Redirect URIs after deploying your application

## Learning Resources

[Quickstart: Sign in users in web apps using the auth code flow - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/develop/web-app-quickstart?pivots=devlang-aspnet-core)

[Single and multi-tenant apps](https://docs.microsoft.com/en-us/azure/active-directory/develop/single-and-multi-tenant-apps)

[Application Type Options](https://docs.microsoft.com/en-us/azure/active-directory/develop/authentication-flows-app-scenarios#scenarios-and-supported-authentication-flows)

[Consent Types](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#consent-types)

[Scopes and Permissions](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#scopes-and-permissions)

[Security tokens](https://docs.microsoft.com/en-us/azure/active-directory/develop/security-tokens)

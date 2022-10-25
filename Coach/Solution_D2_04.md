# Coach's Guide - Day 2 - Challenge 04 - Login with External Identity Providers

 [< Previous Solution](./Solution_D2_03.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D2_05.md)

## Introduction

In this challenge students should add an external identity provider (Google or Facebook) to their AAD B2C tenant and configure it with the sign-in and sign-up user flow.

With this feature you allow users to sign in to your application with credentials from external social or enterprise identity providers (IdP). Azure AD B2C supports external identity providers like Facebook, Microsoft account, Google, Twitter, and any identity provider that supports OAuth 1.0, OAuth 2.0, OpenID Connect, and SAML protocols.

With the external identity provider federation, you can offer your consumers the ability to sign in with their existing social or enterprise accounts, without having to create a new account just for your application.

On the sign-up or sign-in page, Azure AD B2C presents a list of external identity providers the user can choose for sign-in. Once they select one of the external identity providers, they're taken (redirected) to the selected provider's website to complete the sign in process. After the user successfully signs in, they're returned to Azure AD B2C for authentication of the account in your application.

[Add an identity provider](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-identity-provider)

For adding Google as an identity provider please reference the document below
[Set up sign-up and sign-in with a Google account](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-google?WT.mc_id=Portal-Microsoft_AAD_B2CAdmin&pivots=b2c-user-flow)

For adding Facebook as an identity provider please reference the document below
[Set up sign-up and sign-in with a Facebook account](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-facebook?pivots=b2c-user-flow)

### Pass an identity provider access token to your app

Azure AD B2C supports passing the access token of OAuth 2.0 identity providers, which include Facebook and Google.

A user flow in Azure Active Directory B2C (Azure AD B2C) provides users of your application an opportunity to sign up or sign in with an identity provider. When the journey starts, Azure AD B2C receives an access token from the identity provider. Azure AD B2C uses that token to retrieve information about the user. You enable a claim in your user flow to pass the token through to the applications that you register in Azure AD B2C.

For all other identity providers, the claim is returned blank.

You’ll be able to use this access token when you call the identity provider’s API, such as the Facebook Graph API.

[Pass an identity provider access token to your app](https://learn.microsoft.com/en-us/azure/active-directory-b2c/idp-pass-through-user-flow?pivots=b2c-user-flow)

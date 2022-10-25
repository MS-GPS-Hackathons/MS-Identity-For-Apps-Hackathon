# Coach's Guide - Day 2 - Challenge 02 - Add Azure AD B2C sign-in, sign-up to an ASP.NET Core web app

 [< Previous Solution](./Solution_D2_01.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D2_03.md)

## Introduction

In this challenge students will use a sample ASP.Net web application and integrate Azure AD B2C into the web application.

They can follow the procedure in the How-To guide provided. The guide includes the following steps

- Configure your user flows
  - Sign in and sign up
  - Profile editing
  - Profile editing
- Register a web application
- Get the web app sample
- Configure the sample web app
- Build and run the application with Visual Studio or Visual Studio Code locally

[How-to Configure authentication in a sample web application by using Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/configure-authentication-sample-web-app?tabs=visual-studio)

Students should also configure the following properties (in this order) of the sign in users:

- Given Name (required)
- Surname (required)
- Display Name (required)
- Job Title (optional)
- City (optional)

These properties should be shown in the corerct order.

[Customize the user interface - Order input fields](https://learn.microsoft.com/en-us/azure/active-directory-b2c/customize-ui?pivots=b2c-user-flow#re-order-input-fields-in-the-sign-up-form)

They should also be included in the token claims.
The web application has a Claims link in top navigation bar which displays all the claims of the logged-in user.

You can reference this link [Set up a sign-up and sign-in flow](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-sign-up-and-sign-in-policy?pivots=b2c-user-flow) to collect the attributes and retain them in claims.

Students should not deploy the web app to Azure in this challenge. The deployment is covered on the next challenge.

## Answers for Challenge

### 1. Explain the differences between User Flows and Custom Policies

In Azure AD B2C, you can define the business logic that users follow to gain access to your application. For example, you can determine the sequence of steps users follow when they sign in, sign up, edit a profile, or reset a password. After completing the sequence, the user acquires a token and gains access to your application.

In Azure AD B2C, there are two ways to provide identity user experiences:

- **User flows** are predefined, built-in, configurable policies that we provide so you can create sign-up, sign-in, and policy editing experiences in minutes.

- **Custom policies** enable you to create your own user journeys for complex identity experience scenarios.

## User flows

To set up the most common identity tasks, the Azure portal includes several predefined and configurable policies called *user flows*.

You can configure user flow settings like these to control identity experience behaviors in your applications:

- Account types used for sign-in, such as social accounts like a Facebook, or local accounts that use an email address and password for sign-in
- Attributes to be collected from the consumer, such as first name, postal code, or country/region of residency
- Azure AD Multi-Factor Authentication (MFA)
- Customization of the user interface
- Set of claims in a token that your application receives after the user completes the user flow
- Session management
- ...and more

Most of the common identity scenarios for apps can be defined and implemented effectively with user flows. We recommend that you use the built-in user flows, unless you have complex user journey scenarios that require the full flexibility of custom policies.

## Custom policies

Custom policies are configuration files that define the behavior of your Azure AD B2C tenant user experience. While user flows are predefined in the Azure AD B2C portal for the most common identity tasks, custom policies can be fully edited by an identity developer to complete many different tasks.

A custom policy is fully configurable and policy-driven. It orchestrates trust between entities in standard protocols. For example, OpenID Connect, OAuth, SAML, and a few non-standard ones, for example REST API-based system-to-system claims exchanges. The framework creates user-friendly, white-labeled experiences.

The custom policy gives you the ability to construct user journeys with any combination of steps. For example:

- Federate with other identity providers
- First- and third-party multifactor authentication (MFA) challenges
- Collect any user input
- Integrate with external systems using REST API communication

A custom policy is defined by several XML files that refer to each other in a hierarchical chain. The XML elements define the claims schema, claims transformations, content definitions, claims providers, technical profiles, user journey orchestration steps, and other aspects of the identity experience.

The powerful flexibility of custom policies is most appropriate for when you need to build complex identity scenarios. Developers configuring custom policies must define the trusted relationships in careful detail to include metadata endpoints, exact claims exchange definitions, and configure secrets, keys, and certificates as needed by each identity provider.

## Comparing user flows and custom policies

The following table gives a detailed comparison of the scenarios you can enable with Azure AD B2C user flows and custom policies.

| Context                      | User flows                                                                                                                                                                                                                                                                                                                                                                                                                         | Custom policies                                                                                                                                                                                                                                                                                                                              |
| ---------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Target users                 | All application developers with or without identity expertise.                                                                                                                                                                                                                                                                                                                                                                     | Identity pros, systems integrators, consultants, and in-house identity teams. They are comfortable with OpenID Connect flows and understand identity providers and claims-based authentication.                                                                                                                                              |
| Configuration method         | Azure portal with a user-friendly user-interface (UI).                                                                                                                                                                                                                                                                                                                                                                             | Directly editing XML files and then uploading to the Azure portal.                                                                                                                                                                                                                                                                           |
| UI customization             | [Full UI customization](https://learn.microsoft.com/en-us/azure/active-directory-b2c/customize-ui-with-html) including HTML, CSS and, [JavaScript](https://learn.microsoft.com/en-us/azure/active-directory-b2c/javascript-and-page-layout).[Multilanguage support](https://learn.microsoft.com/en-us/azure/active-directory-b2c/language-customization) with Custom strings.                                                      | Same as User flows                                                                                                                                                                                                                                                                                                                           |
| Attribute customization      | Standard and custom attributes.                                                                                                                                                                                                                                                                                                                                                                                                    | Same as User flows                                                                                                                                                                                                                                                                                                                           |
| Token and session management | [Customize tokens](https://learn.microsoft.com/en-us/azure/active-directory-b2c/configure-tokens) and [sessions behavior](https://learn.microsoft.com/en-us/azure/active-directory-b2c/session-behavior).                                                                                                                                                                                                                          | Same as User flows                                                                                                                                                                                                                                                                                                                           |
| Identity Providers           | [Predefined local](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-local) or [social provider](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-identity-provider), such as federation with Azure Active Directory tenants.                                                                                                                                                         | Standards-based OIDC, OAUTH, and SAML. Authentication is also possible by using integration with REST APIs.                                                                                                                                                                                                                                  |
| Identity Tasks               | [Sign-up or sign-in](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-sign-up-and-sign-in-policy) with local or many social accounts.[Self-service password reset](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-password-reset-policy).[Profile edit](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-profile-editing-policy).Multi-Factor Authentication.Access token flows. | Complete the same tasks as user flows using custom identity providers or use custom scopes.Provision a user account in another system at the time of registration.Send a welcome email using your own email service provider.Use a user store outside Azure AD B2C.Validate user provided information with a trusted system by using an API. |

[User flows and custom policies in Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview)

### 3. Explain the available User Flow types

User flows in Azure Active Directory B2C (Azure AD B2C) help you to set up common [policies](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview) that fully describe customer identity experiences. These experiences include sign-up, sign-in, password reset, or profile editing. The tables below describe the user flows that are available in Azure AD B2C.

| User flow           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Password reset      | Enables a user to choose a new password after verifying their email. Using this user flow, you can configure:- [Multi-factor authentication](https://learn.microsoft.com/en-us/azure/active-directory-b2c/multi-factor-authentication)- Token compatibility settings- [Age gating](https://learn.microsoft.com/en-us/azure/active-directory-b2c/age-gating)- [password complexity requirements](https://learn.microsoft.com/en-us/azure/active-directory-b2c/password-complexity)                                                                                   |
| Profile editing     | Enables a user to configure their user attributes. Using this user flow, you can configure:- [Token lifetime](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tokens-overview)- Token compatibility settings- Session behavior                                                                                                                                                                                                                                                                                                                         |
| Sign in             | Enables a user to sign in to their account. Using this user flow, you can configure:- [Multi-factor authentication](https://learn.microsoft.com/en-us/azure/active-directory-b2c/multi-factor-authentication)- [Token lifetime](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tokens-overview)- Token compatibility settings- Session behavior- [Age gating](https://learn.microsoft.com/en-us/azure/active-directory-b2c/age-gating)- Sign-in page customization                                                                                    |
| Sign up             | Enables a user to create an account. Using this user flow, you can configure:- [Multi-factor authentication](https://learn.microsoft.com/en-us/azure/active-directory-b2c/multi-factor-authentication)- [Token lifetime](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tokens-overview)- Token compatibility settings- Session behavior- [Age gating](https://learn.microsoft.com/en-us/azure/active-directory-b2c/age-gating)- [Password complexity requirements](https://learn.microsoft.com/en-us/azure/active-directory-b2c/password-complexity) |
| Sign up and sign in | Enables a user to create an account or sign in their account. Using this user flow, you can configure:- [Multi-factor authentication](https://learn.microsoft.com/en-us/azure/active-directory-b2c/multi-factor-authentication)- [Age gating](https://learn.microsoft.com/en-us/azure/active-directory-b2c/age-gating)- [Password complexity requirements](https://learn.microsoft.com/en-us/azure/active-directory-b2c/password-complexity)                                                                                                                        |

[User flow versions in Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-versions#recommended-user-flows)
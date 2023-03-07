# Day 2 - Challenge 02 - Add Azure AD B2C sign-in, sign-up to an ASP.NET Core web app

 [< Previous Challenge](./Challenge_D2_01.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D2_03.md)

## Introduction

As mentioned in the previous challenge, the Product Team is willing to investigate Azure AD B2C for the customer-facing web applications. Now it’s the time to continue by running a Proof of Concept (POC) and get familiar with the service.

## Description

In the previous challenge you have completed the setup of your B2C tenant. You found a How-to guide with a sample ASP.Net Core web application which will  help you speed up the process. The link to the How to guide can be found in the learning resources below.

When users try to sign in to your app, the app starts an authentication request to the authorization endpoint via a user flow. The user flow defines and controls the user experience. After users complete the user flow, Azure AD B2C generates a token and then redirects users back to your application.

You should create three separate user flows as follows:

- A combined Sign in and sign up user flow, such as susi. This user flow also supports the Forgot your password experience.
- A Profile editing user flow, such as edit_profile.
- A Password reset user flow, such as reset_password.

You should collect the following properties (in this order) of the sign in users:

- Given Name (required)
- Surname (required)
- Display Name (required)
- Job Title (optional)
- City (optional)

The above attributes should be returned when the user successfully logs in, along with the Identity Provider name.

## Success Criteria

- Demonstrate that you can sign in with Sign-in with a newly created account locally.
- Demonstrate that you have configured “Sign in and sign up”, “Profile Editing” and “Password Reset” user flows.
- Demonstrate that you can edit the user profile and change the above user properties in the right order.
- Demonstrate that you can retrieve the above properties in the token claims.
- Verify that the user created, exists in the Users of “B2C Tenant”.
- Explain the differences between User Flows and Custom Policies.
- Explain the available User Flow types.

## Tips

You can run your application locally. In the next challenge you will deploy the application in Azure.

When you create users, please set passwords that you feel comfortable sharing with your team.

## Learning Resources

[How-to Configure authentication in a sample web application by using Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/configure-authentication-sample-web-app?tabs=visual-studio)

[Set up a sign-up and sign-in flow - Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-sign-up-and-sign-in-policy?pivots=b2c-user-flow)

[Set up a profile editing flow - Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-profile-editing-policy?pivots=b2c-user-flow)

[User flows and custom policies in Azure Active Directory B2C - Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview)

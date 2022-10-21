# (Optional) Coach's Guide - Day 1 - Advanced Challenge 09 - Login with a Microsoft (outlook.com), Google or Facebook account

 [< Previous Advanced Solution](./Solution_D1_08.md) - **[Home](../README.md)** - [Next Advanced Solution (Optional)>](./Solution_D1_10.md)

## Introduction

In this challenge, students will allow external users to login with Google, Facebook or Microsoft(outlook) accounts.

Recommend to proceed with Google, or let them choose the way to go.

### Google accounts

By setting up federation with Google, you can allow invited users to sign in to your shared apps and resources with their own Gmail accounts, without having to create Microsoft accounts. After you've added Google as one of your application's sign-in options, on the Sign in page, a user can simply enter the Gmail address they use to sign in to Google.

[Add Google as an identity provider for B2B](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/google-federation)

### Microsoft(outlook) accounts

Your B2B guest users can use their own personal Microsoft accounts for B2B collaboration without further configuration. Guest users can redeem your B2B collaboration invitations or complete your sign-up user flows using their personal Microsoft account.

Microsoft accounts are set up by a user to get access to consumer-oriented Microsoft products and cloud services, such as Outlook, OneDrive, Xbox LIVE, or Microsoft 365. The account is created and stored in the Microsoft consumer identity account system, run by Microsoft.

[Microsoft account (MSA) identity provider in Azure AD](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/microsoft-account)

### Facebook Accounts

You can add Facebook to your self-service sign-up user flows so that users can sign in to your applications using their own Facebook accounts. To allow users to sign in using Facebook, you'll first need to enable self-service sign-up for your tenant. After you add Facebook as an identity provider, set up a user flow for the application and select Facebook as one of the sign-in options.

After you've added Facebook as one of your application's sign-in options, on the Sign in page, a user can simply enter the email they use to sign in to Facebook, or they can select Sign-in options and choose Sign in with Facebook. In either case, they'll be redirected to the Facebook login page for authentication.

[Add Facebook as an identity provider](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/facebook-federation)

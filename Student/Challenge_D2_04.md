# Day 2 - Challenge 04 - Login with External Identity Providers

 [< Previous Challenge](./Challenge_D2_03.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D2_05.md)

## Introduction

Product team decided they want to make life easier for users and let them log in with their existing external accounts like Facebook, Google, or Twitter. As a first step, you need to build PoC using one chosen external identity provider and get familiar with the process.

## Description

In the previous challenges you set user flows to enable sign-up and sign-in with email and deployed your application to Azure. In this step, your task is to add external identity provider (Google or Facebook) to you AAD B2C tenant and configure it accordingly to be used in the user flow for sign-in and sign-up.

## Success Criteria

To complete this challenge successfully, you should be able to:

- Demonstrate that you correctly configured sign-in/sign-up user flow and added external identity provider to it.
- Demonstrate that you can successfully log in with external identity provider
- Show that you can pass the access token returned by the OAuth identity provider as a claim – how can it be used?
- Verify that the created user exists in the Users of “B2C Tenant”.

## Learning Resources

[Add an identity provider](https://learn.microsoft.com/en-us/azure/active-directory-b2c/add-identity-provider)

[Set up sign-up and sign-in with a Google account](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-google?WT.mc_id=Portal-Microsoft_AAD_B2CAdmin&pivots=b2c-user-flow)

[Set up sign-up and sign-in with a Facebook account](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-facebook?pivots=b2c-user-flow)

[Pass an identity provider access token to your app](https://learn.microsoft.com/en-us/azure/active-directory-b2c/idp-pass-through-user-flow?pivots=b2c-user-flow)


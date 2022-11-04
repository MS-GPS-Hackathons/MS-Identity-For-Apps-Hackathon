# Day 1 - Challenge 05 - Control who can authenticate in your app

 [< Previous Challenge](./Challenge_D1_04.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_06.md)

## Introduction

After enabling the external identities, you thought about controlling which users can authenticate to the Web Application.

## Description

In the previous challenge you successfully enable external identities. You are now investigating how to control which users can log into your application.

Currently, all internal or external users invited to the Tenant can sign in, but you realize that more control is needed for the users who have access to the application. 

You should allow access to the application only for “HomeUserA” and “ExternalUserA”.

## Success Criteria

- Demonstrate that you can login with HomeUserA account in your web application.
- Demonstrate that you can login with ExternalUserA account in your web application.
- Demonstrate that you can NOT login with HomeUserB account in your web application.

## Tips

You can limit the logins by using incognito mode and private browsing by logging in with different user accounts

## Learning Resources

[Assignment Required property](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/application-properties?source=recommendations#assignment-required)

[Configure enterprise application properties](https://learn.microsoft.com/en-us/azure/active-directory/manage-apps/add-application-portal-configure#configure-application-properties)

[Quickstart: Create and assign a user account - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/add-application-portal-assign-users#assign-a-user-account-to-an-enterprise-application)

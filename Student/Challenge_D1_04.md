# Day 1 - Challenge 04 - Enable External Identities

 [< Previous Challenge](./Challenge_D1_03.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_05.md)

## Introduction

The Product Owner was excited about the results of the PoC and asked you to find a way to allow partners to authenticate to the Web Application with their identities.

## Description

In the previous challenge you were able to integrate Azure AD as an identity solution to a web application by enabling users in your Azure AD directory to login to the application.

Now you’re investigating the Product Owner’s request to allow partners to authenticate to the web app with their identities in “ExternalTenant” by enabling Azure AD B2B collaboration and invite users in your “HomeTenant”.

As a first step you should login to the Azure Portal and create a new tenant, which will be used as your “ExternalTenant”. Then you should create an admin user account with the name ExternalAdmin and assign “Global Administrator” rights. Additionally you will create a  user ExternalUserA, in “ExternalTenant” which will be invited as guest user in your “HomeTenant”.

## Success Criteria

- Demonstrate that you can switch directory and access “ExternalTenant” with Global Administrator rights with ExternalAdmin account.
- Demonstrate that you created  ExternalUserA in the “ExternalTenant”
- Ensure that only users assigned to specific admin roles can invite guest users.
- Ensure that you Allow invitations only to the specified domain of the “ExternalTenant”.
- Demonstrate that you can login to your web application you recently deployed with ExternalUserA account (user exists in “ExternalTenant”) invited in your home directory.
- Briefly explain what are “B2B Collaboration”, “B2B direct connect” and “Azure AD B2C” capabilities

## Learning Resources

[Quickstart - Access & create new tenant - Azure AD - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-access-create-new-tenant)

[Enable B2B external collaboration settings](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-collaboration-settings-configure)

[Allow or block invites to specific organizations](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/allow-deny-list)

[Invite External Users](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/add-users-administrator)

[B2B Collaboration, B2B direct connect and Azure AD B2C capabilities](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview)

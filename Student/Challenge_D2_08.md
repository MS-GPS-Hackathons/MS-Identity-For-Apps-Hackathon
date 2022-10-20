# (Optional) Day 2 - Advanced Challenge 08 - Identity Experience Framework, get ready for custom policies

 [< Previous Challenge](./Challenge_D2_07.md) - **[Home](../README.md)** - [Next Advanced Challenge (Optional) >](./Challenge_D2_09.md)

## Introduction

The Product team wants to explore some scenarios that cannot be covered with the predefined User Flows. You can leverage custom policies in Identity Experience Framework to cover these scenarios. 

You should prepare your environment for Custom Policies by deploying the Trust Framework into your B2C tenant.

## Description

Custom policies are configuration files that defines the behaviour of your AAD B2C tenant. You should enable your tenant to allow custom policies to be used in the future. These may be used to allow different types of user interactions other than the pre-set User Flows defined in the Azure portal. 

Custom policies are a set of XML files that define technical profiles and user journeys in your AAD B2C tenant. Microsoft provides a starter pack of custom policies, you can find the tutorial in the learning resources section below.

NOTE: Most of the common identity scenarios for apps can be defined and implemented effectively with user flows. The recommendation is to you use the built-in user flows, unless you have complex user journey scenarios that require the full flexibility of custom policies.

## Success Criteria

- Verify that you have added IdentityExperienceFramework, ProxyIdentityExperienceFramework, and that you set the proper permissions from the starter pack.
- Verify that you have set the proper Application IDs in your IdentityExperienceFramework and ProxyIdentityExperienceFramework.
- Demonstrate that you are able to SignUp and SignIn using the sample Sign-Up Sign-In custom policy.

## Tips

You don’t have to integrate the sample Sign-Up Sign-In policy into your application - you can test and run this policy via the Azure AD B2C portal.

## Learning Resources

[Azure Active Directory B2C custom policy overview](https://learn.microsoft.com/en-us/azure/active-directory-b2c/custom-policy-overview)

[User flows and custom policies in Azure Active Directory B2C - Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview)

[Tutorial Starter Pack - Create user flows and custom policies](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-user-flows?pivots=b2c-custom-policy)

[Starter Pack Repository](https://github.com/Azure-Samples/active-directory-b2c-custom-policy-starterpack)

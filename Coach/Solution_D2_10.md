# (Optional) Coach's Guide - Day 2 - Advanced Challenge 10 - Conditional Access and MFA

 [< Previous Advanced Solution (Optional)](./Solution_D2_09.md) - **[Home](./README.md)**

 ## Introduction

 In this advanced challenge, attendees will understand Conditional Access policies when a user is detected as at risk. Conditional Access policies are "if-then" statements - if a user wants to access a resource, then they must complete an action. Organizations can use identity-driven signals as part of their access control decisions.

 Many organizations have common access concerns that Conditional Access policies can help with such as:

- Requiring multi-factor authentication for users with administrative roles
- Requiring multi-factor authentication for Azure management tasks
- Blocking sign-ins for users attempting to use legacy authentication protocols
- Requiring trusted locations for Azure AD Multi-Factor Authentication registration
- Blocking or granting access from specific locations
- Blocking risky sign-in behaviors
- Requiring organization-managed devices for specific applications

These are the components that enable Conditional Access in Azure AD B2C:

- User flow or custom policy that guides the user through the sign-in and sign-up process.
- Conditional Access policy that brings signals together to make decisions and enforce organizational policies. When a user signs into your application via an Azure AD B2C policy, the Conditional Access policy uses Azure AD Identity Protection signals to identify risky sign-ins and presents the appropriate remediation action.
- Registered application that directs users to the appropriate Azure AD B2C user flow or custom policy.
- TOR Browser to simulate a risky sign-in.


## Answers for Challenge

### Demonstrate how to you've implemented a Conditional Access policy that prompts for an MFA challenge for high or medium risk users.



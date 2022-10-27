# (Optional) Day 2 - Advanced Challenge 10 - Conditional Access and MFA

 [< Previous Advanced Challenge (Optional)](./Challenge_D2_09.md) - **[Home](../README.md)**

## Introduction

Congratulations! You are now familiar with how you can deploy your own custom policies and the Product team has one final request. In case there is an unusual user behaviour, the Product team needs to act quickly and request from the user to perform multifactor authentication to prove that they are really who they say they are or alternatively they must be blocked.

Additionally, when a user is detected as at risk, the product team investigates how to require that they securely change their password to remediate the risk and gain access to their account.

## Description

The expectations of the product team’s request are:

- Enable a sign-in risk-based Conditional Access policy requiring MFA and password change when the sign-in risk is medium or high.

## Success Criteria

- Demonstrate how to you've implemented a Conditional Access policy that prompts for an MFA challenge for high or medium risk users.
- Demonstrate how you modify your Conditional Access policy to require a password change alongside an MFA challenge when a user risk is medium or high.

## Learning Resources

[Identity Protection and Conditional Access in Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/conditional-access-identity-protection-overview)

[What is Conditional Access in Azure Active Directory?](https://learn.microsoft.com/en-us/azure/active-directory/conditional-access/overview)

[Add Conditional Access to user flows in Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/conditional-access-user-flow?pivots=b2c-user-flow)
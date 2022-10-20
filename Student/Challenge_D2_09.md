# (Optional) Day 2 - Advanced Challenge 09 - Create Custom Policies

 [< Previous Advanced Challenge (Optional)](./Challenge_D2_08.md) - **[Home](../README.md)** - [Next Advanced Challenge (Optional) >](./Challenge_D2_10.md)

## Introduction

In the previous challenge you manage to complete the Identity Experience Framework configuration with your B2C Tenant. Now you are ready to deploy your own custom policies.

The Product team has a request to create a custom policy, which will require users to accept the Terms Of Use during Sign up.

## Description

The expectations of the product team’s request is:

- During sign up the user should accept the Terms Of Use before creating an account
- During sign in the user should accept the updated Term of Use before logging in to the system.

NOTE: You can reference the existing Microsoft samples and use these policies as a starting point. You don’t have to reinvent the wheel by creating a custom policy from scratch. For this challenge the "Sign Up and Sign In with dynamic Terms of Use prompt" sample covers totally the Product Team’s requirements.

## Success Criteria

- Verify that you have deployed and configured correctly the "Sign Up and Sign In with dynamic Terms of Use prompt" sample policy in your tenant.
- Demonstrate that users will be prompted to consent during Sign Up with Terms of Use.
- Demonstrate that users will be prompted to re-consent when the Terms of Use changes.
- Examine the structure of the custom policy "Sign Up and Sign In with dynamic Terms of Use prompt" sample in xml files.

## Learning Resources

[Azure Active Directory B2C custom policy overview](https://learn.microsoft.com/en-us/azure/active-directory-b2c/custom-policy-overview)

[Azure AD B2C custom policy solutions and samples. (github.com)](https://github.com/azure-ad-b2c/samples)

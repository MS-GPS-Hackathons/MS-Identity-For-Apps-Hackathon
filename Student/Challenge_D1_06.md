# Challenge 06 - Enable Conditional Access and enforce Multifactor Authentication

 [< Previous Challenge](./Challenge_D1_05.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_07.md)

## Introduction

You demonstrated the Web application to the Product Team and they were very excited about the results.

You have a recommendation for the Product Team that you can enable Multifactor authentication through Conditional Access policies.

The Product Owner agreed with your recommendation and asked you to proceed.

## Description

In the previous challenge you successfully configured and controlled who can access your app.

During your investigation you found out that you can easily configure a conditional access policy and enforce multifactor authentication for you app.

## Success Criteria

- Demonstrate that you can login with HomeUserA account in your web application with Multifactor authentication.

## Tips

Security defaults must be disabled to enable Conditional Access policy.

When configuring the MFA security verification for user HomeUserA, select the “Mobile App” option.

## Learning Resources

[Enable Azure AD Multi-Factor Authentication - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/authentication/tutorial-enable-azure-mfa?toc=%2Fazure%2Factive-directory%2Fconditional-access%2Ftoc.json&bc=%2Fazure%2Factive-directory%2Fconditional-access%2Fbreadcrumb%2Ftoc.json)

[Tutorial: Manage application access and security - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/tutorial-manage-access-security#create-a-conditional-access-policy)

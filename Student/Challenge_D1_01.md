# Day 1 - Challenge 01 - Getting Started

 [< Previous Challenge](./Challenge_D1_00.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_02.md)

## Introduction

You are a
Cloud Solution Architect at Contoso. Recently, the product team and more specifically the Product Owner showed interest in using Microsoft’s cloud identity solution for their internal web applications.

## Description

As an architect, you have done your research and discovered that you can achieve this by leveraging Azure AD as an identity solution, but it is not clear yet, what are the differences between Azure AD B2B and Azure AD B2C and which service you should use.

You have decided to start a Proof of Concept to integrate Azure AD with your internal applications by allowing your corporate users to login in to your application. You need to prepare and explain to the product team what service you will use to meet the requirements (Azure AD B2B or Azure AD B2C).

As a first step you have decided to login to the Azure Portal and configure your tenant by creating two users HomeUserA and HomeUserB and assign them the “Azure AD Premium P2” license.

Then you have to set Owner rights on subscription level for the HomeAdmin account.

## Success Criteria

- Demonstrate that HomeAdmin account has Owner rights (Azure Role) on subscription level.
- Demonstrate that you created  HomeUserA and HomeUserB in “HomeTenant”
- Demonstrate that you assigned the “Azure AD Premium P2” license to all users created in your tenant.
- Explain the differences between “Azure roles” and “Azure AD roles”.
- Explain what is role-based access control (Azure RBAC), security principal, role definition, role assignment and scope.
- Explain the differences between Azure AD B2B Collaboration and Azure AD B2C (focus on “primary scenarios” and “intended for in [this document](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#comparing-external-identities-feature-sets)” ).

## Tips

Azure AD Premium P2 will be used later when enabling Conditional Access Policies and Multifactor authentication.

When you create users, please set passwords that you feel comfortable sharing with your team.

Instead of Azure portal, you can use a new Microsoft Entra admin center. Microsoft Entra is our new product family that encompasses all of Microsoft’s identity and access capabilities. The Entra family includes Microsoft Azure Active Directory (Azure AD), as well as two new product categories: Cloud Infrastructure Entitlement Management (CIEM) and decentralized identity. The products in the Entra family will help provide secure access to everything for everyone, by providing identity and access management, cloud infrastructure entitlement management, and identity verification.

## Learning Resources

[Add or delete users - Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/add-users-azure-active-directory)

[Assign Azure roles using the Azure portal](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal?tabs=current)

[Azure roles and Azure AD roles](https://docs.microsoft.com/en-us/azure/role-based-access-control/rbac-and-directory-admin-roles#differences-between-azure-roles-and-azure-ad-roles)

[Assign or remove licenses - Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/license-users-groups#assign-licenses-to-users-or-groups)

[What is Azure role-based access control (Azure RBAC)?](https://docs.microsoft.com/en-us/azure/role-based-access-control/overview)

[Azure AD B2B and B2C feature sets](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#comparing-external-identities-feature-sets)

[Microsoft Entra](https://www.microsoft.com/en-us/security/business/microsoft-entra)

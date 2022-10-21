# Coach's Guide - Day 1 - Getting Started

 [< Previous Solution](./Solution_D1_00.md) - **[Home](../README.md)** - [Next Solution >](./Solution_D1_02.md)

## Introduction

In this challenge the students should create two accounts "HomeUserA" and "HomeUserB" in “HomeTenant” and assign “Azure AD Premium P2” licence to the users.

[Add or delete users](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/add-users-azure-active-directory)

[Assign or remove licenses](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/license-users-groups#assign-licenses-to-users-or-groups)

They should also assign Owner permissions to HomeAdmin user on the subscription level.

[Assign Azure roles](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal?tabs=current)

## Answers for Challenge

### 1. Explain the differences between “Azure roles” and “Azure AD roles”

Azure roles control permissions to manage Azure resources, while Azure AD roles control permissions to manage Azure Active Directory resources. The following table compares some of the differences.

| Azure roles                                                                                                               | Azure AD roles                                                                                                                                                                                                                                |
| ------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Manage access to Azure resources                                                                                          | Manage access to Azure Active Directory resources                                                                                                                                                                                             |
| Supports custom roles                                                                                                     | Supports custom roles                                                                                                                                                                                                                         |
| Scope can be specified at multiple levels (management group, subscription, resource group, resource)                      | [Scope](https://learn.microsoft.com/en-us/azure/active-directory/roles/custom-overview#scope) can be specified at the tenant level (organization-wide), administrative unit, or on an individual object (for example, a specific application) |
| Role information can be accessed in Azure portal, Azure CLI, Azure PowerShell, Azure Resource Manager templates, REST API | Role information can be accessed in Azure admin portal, Microsoft 365 admin center, Microsoft Graph, AzureAD PowerShell                                                                                                                       |

[Azure roles and Azure AD roles](https://docs.microsoft.com/en-us/azure/role-based-access-control/rbac-and-directory-admin-roles#differences-between-azure-roles-and-azure-ad-roles)

### 2. Explain what is role-based access control (Azure RBAC), security principal, role definition,  role assignment and scope

Azure role-based access control (Azure RBAC) helps you manage who has access to Azure resources, what they can do with those resources, and what areas they have access to.

Azure RBAC is an authorization system built on Azure Resource Manager that provides fine-grained access management to Azure resources.

A role assignment consists of three elements: security principal, role definition, and scope.

#### Security Principal

A security principal is an object that represents a user, group, service principal, or managed identity that is requesting access to Azure resources. You can assign a role to any of these security principals.

#### Role Definition

A role definition is a collection of permissions. It's typically just called a role. A role definition lists the actions that can be performed, such as read, write, and delete. Roles can be high-level, like owner, or specific, like virtual machine reader.

Azure includes several built-in roles that you can use. For example, the Virtual Machine Contributor role allows a user to create and manage virtual machines. If the built-in roles don't meet the specific needs of your organization, you can create your own Azure custom roles.

#### Scope

Scope is the set of resources that the access applies to. When you assign a role, you can further limit the actions allowed by defining a scope. This is helpful if you want to make someone a Website Contributor, but only for one resource group.

In Azure, you can specify a scope at four levels: management group, subscription, resource group, or resource. Scopes are structured in a parent-child relationship. You can assign roles at any of these levels of scope.

#### Role assignments

A role assignment is the process of attaching a role definition to a user, group, service principal, or managed identity at a particular scope for the purpose of granting access. Access is granted by creating a role assignment, and access is revoked by removing a role assignment.

[What is Azure role-based access control (Azure RBAC)?](https://docs.microsoft.com/en-us/azure/role-based-access-control/overview)

### 3. Explain the differences between Azure AD B2B Collaboration and Azure AD B2C (focus on “primary scenarios” and “intended for in [this  document](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#comparing-external-identities-feature-sets)”)

Compare External Identities feature sets.

The following table gives a detailed comparison of the scenarios you can enable with Azure AD External Identities. In the B2B scenarios, an external user is anyone who isn't homed in your Azure AD organization.

|                      | **B2B collaboration**                                                                                                                                                                                                                                                                                                                                     | **B2B collaboration**                                                                                                                                                                                           |
| -------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Primary Scenario** | Collaborate with external users by letting them use their preferred identity to sign in to resources in your Azure AD organization. Provides access to Microsoft applications or your own applications (SaaS apps, custom-developed apps, etc.).  *Example:* Invite an external user to sign in to your Microsoft apps or become a guest member in Teams. | Publish apps to consumers and customers using Azure AD B2C for identity experiences. Provides identity and access management for modern SaaS or custom-developed applications (not first-party Microsoft apps). |
| **Intended for**     | Collaborating with business partners from external organizations like suppliers, partners, vendors. These users may or may not have Azure AD or managed IT.                                                                                                                                                                                               | Customers of your product. These users are managed in a separate Azure AD directory.                                                                                                                            |

[Azure AD B2B and B2C feature sets](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#comparing-external-identities-feature-sets)

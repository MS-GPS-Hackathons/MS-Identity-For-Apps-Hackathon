# (Optional) Coach's Guide - Day 1 - Advanced Challenge 10 - Configure App Roles

 [< Previous Advanced Solution (Optional)](./Solution_D1_09.md) - **[Home](./README.md)**

## Introduction

In this challenge Students will leverage the functionality of App Roles, which is a very popular mechanism to enforce authorization in applications. 

RBAC allows administrators to grant permissions to roles rather than to specific users or groups. The administrator can then assign roles to different users and groups to control who has access to what content and functionality.

Students should use this [GitHub sample](https://github.com/Azure-Samples/active-directory-aspnetcore-webapp-openidconnect-v2/blob/master/5-WebApp-AuthZ/5-1-Roles/README.md) to configure the App Roles.

This sample shows how a .NET Core MVC Web app that uses OpenID Connect to sign in users and use Azure AD App Roles for authorization. App Roles, along with Security groups are popular means to implement authorization.

Another approach is to use Azure AD Groups and Group Claims. Azure AD Groups and App Roles are by no means mutually exclusive; they can be used in tandem to provide even finer grained access control.

Using RBAC with App roles and Role Claims, developers can securely enforce authorization policies with minimal effort on the application code.

## Answers for Challenge

### 1. Explain the differences between the two permission types “Delegated permissions” and “Application permissions“

The Microsoft identity platform supports two types of permissions: *delegated permissions* and *application permissions*.

- **Delegated permissions** are used by apps that have a signed-in user present. For these apps, either the user or an administrator consents to the permissions that the app requests. The app is delegated with the permission to act as a signed-in user when it makes calls to the target resource.
  
  Some delegated permissions can be consented to by non administrators. But some high-privileged permissions require [administrator consent](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#admin-restricted-permissions). To learn which administrator roles can consent to delegated permissions, see [Administrator role permissions in Azure Active Directory (Azure AD)](https://learn.microsoft.com/en-us/azure/active-directory/roles/permissions-reference).

- **Application permissions** are used by apps that run without a signed-in user present, for example, apps that run as background services or daemons. Only [an administrator can consent to](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#requesting-consent-for-an-entire-tenant) application permissions.

*Effective permissions* are the permissions that your app has when it makes requests to the target resource. It's important to understand the difference between the delegated permissions and application permissions that your app is granted, and the effective permissions your app is granted when it makes calls to the target resource.

- For delegated permissions, the *effective permissions* of your app are the least-privileged intersection of the delegated permissions the app has been granted (by consent) and the privileges of the currently signed-in user. Your app can never have more privileges than the signed-in user.
  
  Within organizations, the privileges of the signed-in user can be determined by policy or by membership in one or more administrator roles. To learn which administrator roles can consent to delegated permissions, see [Administrator role permissions in Azure AD](https://learn.microsoft.com/en-us/azure/active-directory/roles/permissions-reference).
  
  For example, assume your app has been granted the *User.ReadWrite.All* delegated permission. This permission nominally grants your app permission to read and update the profile of every user in an organization. If the signed-in user is a global administrator, your app can update the profile of every user in the organization. However, if the signed-in user doesn't have an administrator role, your app can update only the profile of the signed-in user. It can't update the profiles of other users in the organization because the user that it has permission to act on behalf of doesn't have those privileges.

- For application permissions, the *effective permissions* of your app are the full level of privileges implied by the permission. For example, an app that has the *User.ReadWrite.All* application permission can update the profile of every user in the organization.

[Delegated permissions and application permissions.](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#permission-types)

### 2. Explain the difference between Application Roles and Groups

Though you can use app roles or groups for authorization, key differences between them can influence which you decide to use for your scenario.

| App roles                                                                                                   | Groups                                                     |
| ----------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------- |
| They're specific to an application and are defined in the app registration. They move with the application. | They aren't specific to an app, but to an Azure AD tenant. |
| App roles are removed when their app registration is removed.                                               | Groups remain intact even if the app is removed.           |
| Provided in the `roles` claim.                                                                              | Provided in `groups` claim.                                |

Developers can use app roles to control whether a user can sign in to an app or an app can obtain an access token for a web API. To extend this security control to groups, developers and admins can also assign security groups to app roles.

App roles are preferred by developers when they want to describe and control the parameters of authorization in their app themselves. For example, an app using groups for authorization will break in the next tenant as both the group ID and name could be different. An app using app roles remains safe. In fact, assigning groups to app roles is popular with SaaS apps for the same reasons as it allows the SaaS app to be provisioned in multiple tenants.

[App roles vs. groups](https://learn.microsoft.com/en-us/Azure/active-directory/develop/howto-add-app-roles-in-Azure-ad-apps#app-roles-vs-groups)
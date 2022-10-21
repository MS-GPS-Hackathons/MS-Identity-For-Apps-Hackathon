# Coach's Guide - Day 1 - Challenge 02 - Add sign-in with Azure AD Identity to an ASP.NET Core web app

 [< Previous Solution](./Solution_D1_01.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D1_03.md)

## Introduction

In this challenge students will use a sample ASP.Net Core web application and integrate Azure AD into the web application.

They can follow the procedure in the QuickStart guide provided. The guide includes the following steps

- Register the Application by creating an App Registration
- Download the ASP.NET Core project sample
- Configure the application settings of the ASP.NET Core project
- Build and run the application with Visual Studio or Visual Studio Code locally

[Quickstart: Sign in users in web apps using the auth code flow](https://docs.microsoft.com/en-us/azure/active-directory/develop/web-app-quickstart?pivots=devlang-aspnet-core)

One of the items in the success criteria ask to "Demonstrate that you have configured the Application which has as an audience all the accounts in your directory only."
Students have to create a Single Tenant application. You can define single tenant application while creating the app registration.

## Answers for Challenge

### 1. Briefly explain the differences between Single Tenant and Multi-tenant app types

Developers can choose to configure their app to be either single-tenant or multi-tenant during app registration in the Azure portal.

- Single-tenant apps are only available in the tenant they were registered in, also known as their home tenant.
- Multi-tenant apps are available to users in both their home tenant and other tenants.

In the Azure portal, you can configure your app to be single-tenant or multi-tenant by setting the audience as follows.

| Audience                                                                                              | Single/multi-tenant | Who can sign in                                                                                                                                                                                                                                                                                                  |
| ----------------------------------------------------------------------------------------------------- | ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Accounts in this directory only                                                                       | Single tenant       | All user and guest accounts in your directory can use your application or API.*Use this option if your target audience is internal to your organization.*                                                                                                                                                        |
| Accounts in any Azure AD directory                                                                    | Multi-tenant        | All users and guests with a work or school account from Microsoft can use your application or API. This includes schools and businesses that use Microsoft 365.*Use this option if your target audience is business or educational customers.*                                                                   |
| Accounts in any Azure AD directory and personal Microsoft accounts (such as Skype, Xbox, Outlook.com) | Multi-tenant        | All users with a work or school, or personal Microsoft account can use your application or API. It includes schools and businesses that use Microsoft 365 as well as personal accounts that are used to sign in to services like Xbox and Skype.Use this option to target the widest set of Microsoft accounts.* |

#### Best practices for multi-tenant apps

Building great multi-tenant apps can be challenging because of the number of different policies that IT administrators can set in their tenants. If you choose to build a multi-tenant app, follow these best practices:

- Test your app in a tenant that has configured [Conditional Access policies](https://learn.microsoft.com/en-us/azure/active-directory/azuread-dev/conditional-access-dev-guide).
- Follow the principle of least user access to ensure that your app only requests permissions it actually needs.
- Provide appropriate names and descriptions for any permissions you expose as part of your app. This helps users and admins know what they're agreeing to when they attempt to use your app's APIs. For more information, see the best practices section in the [permissions guide](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent).

[Single and multi-tenant apps](https://docs.microsoft.com/en-us/azure/active-directory/develop/single-and-multi-tenant-apps)

### 2. Explain what is the usage of scopes and permissions

The Microsoft identity platform implements the [OAuth 2.0](https://learn.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols) authorization protocol. OAuth 2.0 is a method through which a third-party app can access web-hosted resources on behalf of a user. Any web-hosted resource that integrates with the Microsoft identity platform has a resource identifier, or *application ID URI*.

Here are some examples of Microsoft web-hosted resources:

- Microsoft Graph: `https://graph.microsoft.com`
- Microsoft 365 Mail API: `https://outlook.office.com`
- Azure Key Vault: `https://vault.azure.net`

The same is true for any third-party resources that have integrated with the Microsoft identity platform. Any of these resources also can define a set of permissions that can be used to divide the functionality of that resource into smaller chunks. As an example, [Microsoft Graph](https://graph.microsoft.com/) has defined permissions to do the following tasks, among others:

- Read a user's calendar
- Write to a user's calendar
- Send mail as a user

Because of these types of permission definitions, the resource has fine-grained control over its data and how API functionality is exposed. A third-party app can request these permissions from users and administrators, who must approve the request before the app can access data or act on a user's behalf.

When a resource's functionality is chunked into small permission sets, third-party apps can be built to request only the permissions that they need to perform their function. Users and administrators can know what data the app can access. And they can be more confident that the app isn't behaving with malicious intent. Developers should always abide by the principle of least privilege, asking for only the permissions they need for their applications to function.

In OAuth 2.0, these types of permission sets are called *scopes*. They're also often referred to as *permissions*. In the Microsoft identity platform, a permission is represented as a string value. An app requests the permissions it needs by specifying the permission in the `scope` query parameter. Identity platform supports several well-defined [OpenID Connect scopes](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#openid-connect-scopes) as well as resource-based permissions (each permission is indicated by appending the permission value to the resource's identifier or application ID URI). For example, the permission string `https://graph.microsoft.com/Calendars.Read` is used to request permission to read users calendars in Microsoft Graph.

An app most commonly requests these permissions by specifying the scopes in requests to the Microsoft identity platform authorize endpoint. However, some high-privilege permissions can be granted only through administrator consent. They can be requested or granted by using the [administrator consent endpoint](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#admin-restricted-permissions). Keep reading to learn more.

In requests to the authorization, token or consent endpoints for the Microsoft Identity platform, if the resource identifier is omitted in the scope parameter, the resource is assumed to be Microsoft Graph. For example, `scope=User.Read` is equivalent to `https://graph.microsoft.com/User.Read`.

[Scopes and permissions](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#scopes-and-permissions)

### 3. Explain what are the Permission types

The Microsoft identity platform supports two types of permissions: *delegated permissions* and *application permissions*.

- **Delegated permissions** are used by apps that have a signed-in user present. For these apps, either the user or an administrator consents to the permissions that the app requests. The app is delegated with the permission to act as a signed-in user when it makes calls to the target resource.
  
  Some delegated permissions can be consented to by nonadministrators. But some high-privileged permissions require [administrator consent](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#admin-restricted-permissions). To learn which administrator roles can consent to delegated permissions, see [Administrator role permissions in Azure Active Directory (Azure AD)](https://learn.microsoft.com/en-us/azure/active-directory/roles/permissions-reference).

- **Application permissions** are used by apps that run without a signed-in user present, for example, apps that run as background services or daemons. Only [an administrator can consent to](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#requesting-consent-for-an-entire-tenant) application permissions.

*Effective permissions* are the permissions that your app has when it makes requests to the target resource. It's important to understand the difference between the delegated permissions and application permissions that your app is granted, and the effective permissions your app is granted when it makes calls to the target resource.

- For delegated permissions, the *effective permissions* of your app are the least-privileged intersection of the delegated permissions the app has been granted (by consent) and the privileges of the currently signed-in user. Your app can never have more privileges than the signed-in user.
  
  Within organizations, the privileges of the signed-in user can be determined by policy or by membership in one or more administrator roles. To learn which administrator roles can consent to delegated permissions, see [Administrator role permissions in Azure AD](https://learn.microsoft.com/en-us/azure/active-directory/roles/permissions-reference).
  
  For example, assume your app has been granted the *User.ReadWrite.All* delegated permission. This permission nominally grants your app permission to read and update the profile of every user in an organization. If the signed-in user is a global administrator, your app can update the profile of every user in the organization. However, if the signed-in user doesn't have an administrator role, your app can update only the profile of the signed-in user. It can't update the profiles of other users in the organization because the user that it has permission to act on behalf of doesn't have those privileges.

- For application permissions, the *effective permissions* of your app are the full level of privileges implied by the permission. For example, an app that has the *User.ReadWrite.All* application permission can update the profile of every user in the organization.
  
  [Permission types](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#permission-types)

### 4. Explain what is User Consent and Admin Consent

Applications in Microsoft identity platform rely on consent in order to gain access to necessary resources or APIs. There are a number of kinds of consent that your app may need to know about in order to be successful. If you are defining permissions, you will also need to understand how your users will gain access to your app or API.

#### Admin Consent

Admin consent is required when your app needs access to certain high-privilege permissions. Admin consent ensures that administrators have some additional controls before authorizing apps or users to access highly privileged data from the organization.

Admin consent done on behalf of an organization is highly recommended if your app has an enterprise audience. Admin consent done on behalf of an organization requires the static permissions to be registered for the app in the portal. Set those permissions for apps in the app registration portal if you need an admin to give consent on behalf of the entire organization. The admin can consent to those permissions on behalf of all users in the org, once. The users will not need to go through the consent experience for those permissions when signing in to the app. This is easier for users and reduces the cycles required by the organization admin to set up the application.

#### User Consent

In an [OpenID Connect or OAuth 2.0](https://learn.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols) authorization request, an app can request the permissions it needs by using the `scope` query parameter. For example, when a user signs in to an app, the app sends a request like the following example. (Line breaks are added for legibility.)

```
GET https://login.microsoftonline.com/common/oauth2/v2.0/authorize
?client_id=6731de76-14a6-49ae-97bc-6eba6914391e
&response_type=code
&redirect_uri=http%3A%2F%2Flocalhost%2Fmyapp%2F
&response_mode=query
&scope=https%3A%2F%2Fgraph.microsoft.com%2Fcalendars.read%20
https%3A%2F%2Fgraph.microsoft.com%2Fmail.send
&state=12345
```

The `scope` parameter is a space-separated list of delegated permissions that the app is requesting. Each permission is indicated by appending the permission value to the resource's identifier (the application ID URI). In the request example, the app needs permission to read the user's calendar and send mail as the user.

After the user enters their credentials, the Microsoft identity platform checks for a matching record of *user consent*. If the user hasn't consented to any of the requested permissions in the past, and if the administrator hasn't consented to these permissions on behalf of the entire organization, the Microsoft identity platform asks the user to grant the requested permissions.

At this time, the `offline_access` ("Maintain access to data you have given it access to") permission and `User.Read` ("Sign you in and read your profile") permission are automatically included in the initial consent to an application. These permissions are generally required for proper app functionality. The `offline_access` permission gives the app access to refresh tokens that are critical for native apps and web apps. The `User.Read` permission gives access to the `sub` claim. It allows the client or app to correctly identify the user over time and access rudimentary user information.

When the user approves the permission request, consent is recorded. The user doesn't have to consent again when they later sign in to the application.

[Consent Types](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#consent-types)

### 5. (Optional) Explain the Application types options (SPA, web app, desktop app, daemon app) by specifying what authentication flow you will use for every option

The Microsoft identity platform supports authentication for different kinds of modern application architectures. All of the architectures are based on the industry-standard protocols [OAuth 2.0 and OpenID Connect](https://learn.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols).

As a coach you should get familiar with the authentication flows adn their usage. You can reference all the scenarios and supported authentication flows [here](https://learn.microsoft.com/en-us/azure/active-directory/develop/authentication-flows-app-scenarios#scenarios-and-supported-authentication-flows)


# Coach's Guide - Day 1 - Challenge 04 - Enable External Identities

 [< Previous Solution](./Solution_D1_03.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D1_05.md)

## Introduction

In this challenge students should enable external identities and invite guest user in the Home Tenant.

As a first step they have to create a new tenant, which will be used as their “ExternalTenant”.

[Quickstart - Access & create new tenant](https://learn.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-access-create-new-tenant)

Then, they will create an admin user account and assign “Global Administrator” rights.

Later on they have to create a new user, which will be invited as guest user in the “HomeTenant”.

The next step is to invite the External user as guest in the Home Tenant.

You can invite guest users to the directory, to a group, or to an application. After you invite a user through any of these methods, the invited user's account is added to Azure Active Directory (Azure AD), with a user type of *Guest*. The guest user must then redeem their invitation to access resources. An invitation of a user does not expire.

After you add a guest user to the directory, you can either send the guest user a direct link to a shared app, or the guest user can select the redemption URL in the invitation email. 

[Invite guest users](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/add-users-administrator)

Studenets should ensure that only users assigned to specific admin roles can invite guest users. 

By default, all users and admins can invite guests. But your organization's external collaboration policies might be configured to prevent certain types of users or admins from inviting guests.

To find out how to view and set these policies, see [Enable B2B external collaboration and manage who can invite guests](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-collaboration-settings-configure).

Students should also configure to allow invitations only to the specified domain of the “ExternalTenant”.

You can use an allowlist or a blocklist to allow or block invitations to B2B collaboration users from specific organizations. For example, if you want to block personal email address domains, you can set up a blocklist that contains domains like Gmail.com and Outlook.com. Or, if your business has a partnership with other businesses like Contoso.com, Fabrikam.com, and Litware.com, and you want to restrict invitations to only these organizations, you can add Contoso.com, Fabrikam.com, and Litware.com to your allowlist.

[Allow or block invites to specific organizations](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/allow-deny-list)

## Answers for Challenge

### 1. Briefly explain what are “B2B Collaboration”, “B2B direct connect” and “Azure AD B2C” capabilities

#### B2B collaboration

With [B2B collaboration](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/what-is-b2b), you can invite anyone to sign in to your Azure AD organization using their own credentials so they can access the apps and resources you want to share with them. Use B2B collaboration when you need to let external users access your Office 365 apps, software-as-a-service (SaaS) apps, and line-of-business applications, especially when the partner doesn't use Azure AD or it's impractical for administrators to set up a mutual connection through B2B direct connect. There are no credentials associated with B2B collaboration users. Instead, they authenticate with their home organization or identity provider, and then your organization checks the guest user’s eligibility for B2B collaboration.

There are various ways to add external users to your organization for B2B collaboration:

- Invite users to B2B collaboration using their Azure AD accounts, Microsoft accounts, or social identities that you enable, such as Google. 

- Use self-service sign-up user flows to let external users sign up for applications themselves.

- Use [Azure AD entitlement management](https://learn.microsoft.com/en-us/azure/active-directory/governance/entitlement-management-overview), an identity governance feature that lets you manage [identity and access for external users at scale](https://learn.microsoft.com/en-us/azure/active-directory/governance/entitlement-management-external-users#how-access-works-for-external-users) by automating access request workflows, access assignments, reviews, and expiration.

A user object is created for the B2B collaboration user in the same directory as your employees. This user object can be managed like other user objects in your directory, added to groups, and so on. You can assign permissions to the user object (for authorization) while letting them use their existing credentials (for authentication).

[B2B Collaboration](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#b2b-collaboration)

#### B2B direct connect

B2B direct connect is a new way to collaborate with other Azure AD organizations. This feature currently works with Microsoft Teams shared channels. With B2B direct connect, you create two-way trust relationships with other Azure AD organizations to allow users to seamlessly sign in to your shared resources and vice versa. B2B direct connect users aren't added as guests to your Azure AD directory. When two organizations mutually enable B2B direct connect, users authenticate in their home organization and receive a token from the resource organization for access. Learn more about [B2B direct connect in Azure AD](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/b2b-direct-connect-overview).

[B2B direct connect](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#b2b-direct-connect)

#### Azure AD B2C

Azure AD B2C is a Customer Identity and Access Management (CIAM) solution that lets you build user journeys for consumer- and customer-facing apps. If you're a business or individual developer creating customer-facing apps, you can scale to millions of consumers, customers, or citizens by using Azure AD B2C. Developers can use Azure AD B2C as the full-featured CIAM system for their applications.

With Azure AD B2C, customers can sign in with an identity they've already established (like Facebook or Gmail). You can completely customize and control how customers sign up, sign in, and manage their profiles when using your applications.

Although Azure AD B2C is built on the same technology as Azure AD, it's a separate service with some feature differences. For more information about how an Azure AD B2C tenant differs from an Azure AD tenant, see [Supported Azure AD features](https://learn.microsoft.com/en-us/azure/active-directory-b2c/supported-azure-ad-features) in the [Azure AD B2C documentation](https://learn.microsoft.com/en-us/azure/active-directory-b2c/).

[Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#azure-ad-b2c)
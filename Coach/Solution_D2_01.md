# Coach's Guide - Day 2 - Challenge 01 - Getting Started with Azure AD B2C

**[Home](../README.md)** - [Next Solution >](./Solution_D2_02.md)

## Introduction

In this challenge the attendees should create a new B2C tenant or use an existing one. You can follow the steps in this [tutorial](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-tenant) to create a new tenant

## Answers for Challenge

### 1. Explain some of the differences between Azure AD B2B and Azure AD B2C.

Azure AD B2B is a feature in Azure AD. It enables cross-organizational collaboration on identity-based applications. Azure AD B2C is an independent service for creating a consumer application identity repository. It is a separate service from Azure AD but it’s build on the same technology.

**Azure AD B2B collaboration** is intended for organizations that want to be able to authenticate users from partner/supplier organization, regardless of the identity provider, and be able
to manage the lifecycle of those guest users. These accounts are managed in the same directory as employees, and can be added to the same groups and resources.
Some of the supported features are:

- App Registrations
- Enterprise Applications
- External Identities integration
- Identity Protection
- Application Roles
- Privileged Identity Management
- Conditional Access Policies
- Logging/Monitoring

**Azure AD B2C** is intended for commerce and other interactions with consumers, citizens, or members of another group that does not require access to internal resources. These accounts are managed in a
separate B2C directory, and are completely separate from your internal user accounts. B2C accounts are a customer lifecycle: they are either managed by the customer, or directly by the application. Some of the supported features are:

- Azure AD B2C is a separate service from Azure AD, build on the same technology
- Customers SignUp - self service
- External Identities integration
- Fully Custom-branded identity solution
- Identity experiences: user flows or custom policies
- Add your own business logic and call RESTful API. Can be used for claims enrichment
- Progressive profiling
- Experiences localization
- App Registrations
- MFA
- Identity Protection
- Application Roles existing in Azure AD B2B are not supported.
- Unsupported Service to service applications (client credentials flow)

[Technical and feature overview](https://learn.microsoft.com/en-us/azure/active-directory-b2c/technical-overview)

**Comparing External Identities feature sets.** The following table gives a detailed comparison of the scenarios you can enable with Azure AD External Identities. In the B2B scenarios, an external user is anyone who isn't homed in your Azure AD organization.

|                                    | B2B collaboration                                                                                                                                                                                                                                                                                                                                                                         | Azure AD B2C                                                                                                                                                                                                                                                                                                                               |
| ---------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Primary scenario                   | Collaborate with external users by letting them use their preferred identity to sign in to resources in your Azure AD organization. Provides access to Microsoft applications or your own applications (SaaS apps, custom-developed apps, etc.).  *Example:* Invite an external user to sign in to your Microsoft apps or become a guest member in Teams. | Publish apps to consumers and customers using Azure AD B2C for identity experiences. Provides identity and access management for modern SaaS or custom-developed applications (not first-party Microsoft apps).                                                                                                                    |
| Intended for                       | Collaborating with business partners from external organizations like suppliers, partners, vendors. These users may or may not have Azure AD or managed IT.                                                                                                                                                                                                                       | Customers of your product. These users are managed in a separate Azure AD directory.                                                                                                                                                                                                                                                   |
| User management                    | B2B collaboration users are managed in the same directory as employees but are typically annotated as guest users. Guest users can be managed the same way as employees, added to the same groups, and so on. Cross-tenant access settings can be used to determine which users have access to B2B collaboration.                                                         | User objects are created for consumer users in your Azure AD B2C directory. They're managed separately from the organization's employee and partner directory (if any).                                                                                                                                                            |
| Identity providers supported   | External users can collaborate using work accounts, school accounts, any email address, SAML and WS-Fed based identity providers, and social identity providers like Gmail and Facebook.                                                                                                                                                                                          | Consumer users with local application accounts (any email address, user name, or phone number), Azure AD, various supported social identities, and users with corporate and government-issued identities via SAML/WS-Fed-based identity provider federation.                                                                   |
| Single sign-on (SSO)               | SSO to all Azure AD-connected apps is supported. For example, you can provide access to Microsoft 365 or on-premises apps, and to other SaaS apps such as Salesforce or Workday.                                                                                                                                                                                                  | SSO to customer owned apps within the Azure AD B2C tenants is supported. SSO to Microsoft 365 or to other Microsoft SaaS apps isn't supported.                                                                                                                                                                                         |
| Licensing and billing              | Based on monthly active users (MAU), including B2B collaboration and Azure AD B2C users. Learn more about [External Identities pricing](https://azure.microsoft.com/pricing/details/active-directory/external-identities/) and [billing setup for B2B](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-pricing).                     | Based on monthly active users (MAU), including B2B collaboration and Azure AD B2C users. Learn more about [External Identities pricing](https://azure.microsoft.com/pricing/details/active-directory/external-identities/) and [billing setup for Azure AD B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/billing). |
| Security policy and compliance | Managed by the host/inviting organization (for example, with [Conditional Access policies](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/authentication-conditional-access) and cross-tenant access settings).                                                                                                                                             | Managed by the organization via Conditional Access and Identity Protection.                                                                                                                                                                                                                                                            |
| Branding                           | Host/inviting organization's brand is used.                                                                                                                                                                                                                                                                                                                                               | Fully customizable branding per application or organization.                                                                                                                                                                                                                                                                               |

[External Identities in Azure Active Directory](https://learn.microsoft.com/en-us/azure/active-directory/external-identities/external-identities-overview#comparing-external-identities-feature-sets)

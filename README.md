# Identity for Apps Hackathon

The Identity for Apps hackathon will provide a deep dive experience targeted for developers by integrating Azure AD Identity solutions into applications. Hackathon is a collaborative learning experience, designed as a set of challenges to practice your technical skills.  By participating in this hackathon, you will be able to understand the capabilities of Azure AD B2B and Azure AD B2C and learn how modern authentication works with Microsoft identity platform.

## Learning Objectives

The learning objectives for this hack will cover the following topics:

- Implement initial configuration of Azure Active Directory.
- Create, configure, and manage users, groups, service principals and identities.
- Configure and use Azure roles and Azure AD roles.
- Get understanding of various Application types for the Microsoft identity platform.
- Get understanding of OAuth 2.0 and OpenID Connect in the Microsoft identity platform.
- Implement and configure application registrations.
- Implement and manage external identities.
- Get understanding of Azure AD B2B and Azure AD B2C as an Identity platform.
- Understand the difference between Single Tenant vs Multitenant identities.
- Understand the difference between App Registration (Application Object) and Enterprise Application (Service Principal).
- Configure scopes, permissions, and consent for your App Registrations.
- Integrate your Application with Microsoft Identity platform.
- Get to know Microsoft Authentication Library (MSAL).
- Configure external identity providers.
- Enable MFA with conditional access policies.
- Monitoring and Observability.

## Prerequisites

- Your laptop: Win, MacOS or Linux OR a development machine that you have administrator rights.
  - An active Azure subscription with Global Administrator access to create or modify resources and permissions.
  - **OR**
  - Use the Azure Pass that will be provided during the Hackathon.
- Visual Studio 2019/2022 or Visual Studio Code.
- Azure AD Premium P2 trial licence.
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1) and [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli)
- [PowerShell](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.2)
- [Git Client](https://git-scm.com/download)

## Day 1 Challenges

---

### Day 1 - Challenge 0: **[Prepare Your Environment](Student/Challenge_D1_00.md)**

- Setup your environment and get ready to deploy Identity solutions

### Day 1 - Challenge 1: **[Getting Started](Student/Challenge_D1_01.md)**

- Getting started by configuring your Azure AD tenant

### Day 1 - Challenge 2: **[Add sign-in with Azure AD Identity to an ASP.NET Core web app](Student/Challenge_D1_02.md)**

- Integrate an ASP.NET Core web app sample with Azure AD B2B and get familiar with the identity concepts

### Day 1 - Challenge 3: **[Deploy your Web Application to Azure](Student/Challenge_D1_03.md)**

- Deploy the ASP.NET Core web app sample in Azure as an App Service Web App and get familiar with secutity tokens

### Day 1 - Challenge 4: **[Enable External Identities](Student/Challenge_D1_04.md)**

- Create an external tenant and configure your home tenant by enabling external identities

### Day 1 - Challenge 5: **[Control who can authenticate in your app](Student/Challenge_D1_05.md)**

- Control the users or groups who can authenticate in your app

### Day 1 - Challenge 6: **[Enable Conditional Access Policies and enforce Multifactor Authentication](Student/Challenge_D1_06.md)**

- Enforce Multifactor Authentication by enabling Conditional Access Policies

### Day 1 - Challenge 7: **[Make your application Multi-tenant](Student/Challenge_D1_07.md)**

- Transform your application from Single-tenant to Multi-tenant

## Day 1 - Advanced Challenges (Optional)

Are you too comfortable and eager to do more? Try these additional challenges!

### Day 1 - Optional Challenge 8: **[Branding your sign-in page](Student/Challenge_D1_08.md)**

- Add branding to your sign-in page

### Day 1 - Optional Challenge 9: **[Login with a Microsoft (outlook.com), Google or Facebook account](Student/Challenge_D1_09.md)**

- Setting up federation with Google or Facebook and login to your application with third party identity providers

### Day 1 - Optional Challenge 10: **[Configure App Roles](Student/Challenge_D1_10.md)**

- Configure and use App roles to control whether a user can sign in to your application

## Day 2 Challenges

---

### Day 2 - Challenge 1: **[Getting Started with Azure AD B2C](Student/Challenge_D2_01.md)**

- Getting started by configuring your Azure AD B2C tenant

### Day 2 - Challenge 2: **[Add Azure AD B2C sign-in, sign-up to an ASP.NET Core web app](Student/Challenge_D2_02.md)**

- Integrate an ASP.NET Core web app sample with Azure AD B2C

### Day 2 - Challenge 3: **[Deploy the web app to Azure](Student/Challenge_D2_03.md)**

- Deploy the ASP.NET Core web app sample in Azure as an App Service Web App

### Day 2 - Challenge 4: **[Login with External Identity Providers](Student/Challenge_D2_04.md)**

- Setting up federation with Google or Facebook and login to your application with third party identity providers

### Day 2 - Challenge 5: **[Branding](Student/Challenge_D2_05.md)**

- Add branding and customize user experience

### Day 2 - Challenge 6: **[Claims Enrichment with API Connectors](Student/Challenge_D2_06.md)**

- Claims enrichment with external API connectors

### Day 2 - Challenge 7: **[Monitoring and Observability](Student/Challenge_D2_07.md)**

- Monitoring your B2C tenant

## Day 2 - Advanced Challenges (Optional)

Are you too comfortable and eager to do more? Try these additional challenges!

### Day 2 - Optional Challenge 8: **[Identity Experience Framework, get ready for custom policies](Student/Challenge_D2_08.md)**

- Get ready with custom policies by configuring the Trust Framework in your B2C tenant.

### Day 2 - Optional Challenge 9: **[Create Custom Policies](Student/Challenge_D2_09.md)**

- Use custom policies in Sign Up and Sign In user journeys by incorporating dynamic 'Terms of Use' prompt

### Day 2 - Optional Challenge 10: **[Conditional Access and MFA](Student/Challenge_D2_10.md)**

- Implement Multifactor Authentication by enabling Conditional Access Policies

---

## Repository Contents

- `./Student`
  - Student's Challenge Guide
- `./Student/Resources`
  - Resource files, sample code, scripts, etc meant to be provided to students. (Must be packaged up by the coach and provided to students at start of event)
- `./Coach`
  - Coach's Guide and related files
- `./Coach/Solutions`
  - Solution files with completed example answers to a challenge

## Contributors

- Rodanthi Alexiou
- Klaudia Gebala
- Phanis Parpas

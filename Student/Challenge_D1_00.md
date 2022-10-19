# Challenge 00 - Setup

**[Home](../README.md)** - [Next Challenge >](./Challenge_D1_01.md)

## Pre-requisites

- Your laptop: Win, MacOS or Linux OR a development machine that you have administrator rights
- Active Azure Subscription with Global Administrator access to create or modify resources and permissions.
- **OR**
- Use an [Azure Pass](https://www.microsoftazurepass.com/) that will be provided to you during this Hack.

## Introduction

In this challenge you will setup your computer and cloud environment with the minimum requirements.

## Description

Setup and configure the following.

### Configure Azure Subscription

- In case an Azure Pass was provided in this Hack please follow the steps below:
  
  - Create an Azure Active Directory tenant by following the [QuickStart](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/ctive-directory-access-create-new-tenant) steps. This will be your "HomeTenant" for this Hackathon.
  
  - In the new tenant, create an admin user account, name it HomeAdmin and assign "Global Administrator" rights.
  
  - Set the Usage Location property for the HomeAdmin account (usage location is required for assigning "Azure AD Premium P2" licence)
    
    - Assign "Azure AD Premium P2" trial licence to the HomeAdmin account
    
    - Create a Microsoft [Azure Pass](https://www.microsoftazurepass.com/Home/HowTo?Length=5) Subscription
      
      - Step 1: Redeem a Microsoft Azure Pass Promo Code (Please ensure that you login with the HomeAdmin account created in a previous step)
      - Step 2: Activate your subscription
    
    - Log into the [Azure Portal](https://portal.azure.com/) with the HomeAdmin account and confirm that you have an active subscription. It can take a few minutes to show up.
  
  **OR**

- In case an Azure Pass was not provided you can create a free trial [here](https://azure.microsoft.com/free/) or use an existing subscription. 
  
  - Log into the [Azure Portal](https://portal.azure.com/) and confirm that you have an active subscription.
  - Create an admin user account, name it HomeAdmin and assign "Global Administrator" rights.
  - Set the Usage Location property for the HomeAdmin account. (usage location is required for assigning "Azure AD Premium P2" licence)
  - Assign "Azure AD Premium P2" trial licence to the HomeAdmin account

### Other Prerequisites

- Download and install Git Client
- Use Visual Studio 2022 or download and install [Visual Studio Code](https://code.visualstudio.com/) if you don\'t have it.
- Download and Install the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1) and [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) if you don\'t have it.
- Download and install the [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli) if you don\'t have it.
- Download and install [PowerShell](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.2) if you don\'t have it.

## Success Criteria

- Verify that you are able to log in to the Azure Portal with HomeAdmin account.
- Demonstrate that HomeAdmin account has Global Administrator rights (Azure AD role).
- Demonstrate that you Azure subscription used is associated with your "HomeTenant".
- Demonstrate that you assigned the "Azure AD Premium P2" licence to the HomeAdmin account.

## Tips

- You can use "Azure AD Premium P2" or "Enterprise Mobility + Security E5"
  free trial to enable Azure AD Premium P2 licence.

## Learning Resources

- [Quickstart - Access & create new tenant - Azure AD - Microsoft Entra \| Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-access-create-new-tenant)
- [Assign Azure AD roles to users - Azure Active Directory - Microsoft Entra \| Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-users-assign-role-azure-portal)
- [Assign or remove licenses - Azure Active Directory - Microsoft Entra \| Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/license-users-groups#assign-licenses-to-users-or-groups)
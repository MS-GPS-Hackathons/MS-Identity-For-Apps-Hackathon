# Coach's Guide - Day 2 - Challenge 03 - Deploy your Web Application to Azure

 [< Previous Solution](./Solution_D2_02.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D2_04.md)

## Introduction

In this challenge students will deploy the sample ASP.Net web application used in the previous challenge to Azure.

Encourage users to use the script provided to deploy the application to save time.

Ensure that users configured the following parameters in the script.

```powershell
# Deployment Parameters
$subscription = "[Enter your Subscription Id]"
$AzureAdB2C_Instance = "[Enter your B2C Instance Domain i.e xxxx.b2clogin.com]"
$AzureAdB2C_ClientId = "[Enter your Client ID]"
$AzureAdB2C_Domain = "[Enter your B2C Tenant Domain i.e xxxx.onmicrosoft.com]"
$AzureAdB2C_SignedOutCallbackPath = "[Enter /signout/<your-sign-up-in-policy>, i.e /signout/B2C_1_susi]"
$AzureAdB2C_SignUpSignInPolicyId = "[Enter <your-sign-up-in-policy>, i.e B2C_1_susi]"
$AzureAdB2C_ResetPasswordPolicyId = "[Enter <your-reset-password-policy>, i.e B2C_1_reset_password]"
$AzureAdB2C_EditProfilePolicyId = "[Enter <your-edit-profile-policy>, i.e B2C_1_edit_profile]"
```

Please note that the web application is build on .Net 6.0

The script uses the Azure CLI and executes the following steps:

- Login to Azure
- Set subscription to use in current context
- Create Resource group if not exists
- Create App Service Plan
- Create Web Application
- Configure the application setting on the web application
  - WEBSITE_RUN_FROM_PACKAGE="1" 
  - ASPNETCORE_ENVIRONMENT="Development" 
  - AzureAdB2C:Instance=$AzureAdB2C_Instance 
  - AzureAdB2C:ClientId=$AzureAdB2C_ClientId 
  - AzureAdB2C:Domain=$AzureAdB2C_Domain 
  - AzureAdB2C:SignedOutCallbackPath=$AzureAdB2C_SignedOutCallbackPath
  - AzureAdB2C:SignUpSignInPolicyId=$AzureAdB2C_SignUpSignInPolicyId
  - AzureAdB2C:ResetPasswordPolicyId=$AzureAdB2C_ResetPasswordPolicyId 
  - AzureAdB2C:EditProfilePolicyId=$AzureAdB2C_EditProfilePolicyId 
- Build .Net Web application
- Publish the application to a local folder
- Compress the publish folder to a zip file
- Deploy the application to the web app (uses the published zip file)

After the deployment, students should set the Redirect URI in the App Registration. It may take up to 10m mins for the change to take effect.

[Deploy files to App Service](https://learn.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)
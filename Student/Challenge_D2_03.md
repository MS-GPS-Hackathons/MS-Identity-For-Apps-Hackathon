# Day 2 - Challenge 03 - Deploy your Web Application to Azure

 [< Previous Challenge](./Challenge_D2_02.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D2_04.md)

## Introduction

You are now ready to deploy the solution and demonstrate the Proof of Concept to the Product team.

## Description

In the previous challenge you were able to integrate Azure AD B2C to a web application. Now it is time to deploy this on an App service and demonstrate the solution to the Product team. Your DevOps engineer prepared the following Azure CLI scripts which you can run on a PowerShell env to deploy the solution in Azure as an App Service Web App.

```powershell
# Deployment Parameters 
$location = "eastus"
$resourceGroupName = "IdentityHackathon"

$subscription = "[Enter your Subscription Id]"

$AzureAdB2C_Instance = "[Enter your B2C Instance Domain i.e xxxx.b2clogin.com]"
$AzureAdB2C_ClientId = "[Enter your Client ID]"
$AzureAdB2C_Domain = "[Enter your B2C Tenant Domain i.e xxxx.onmicrosoft.com]"
$AzureAdB2C_SignedOutCallbackPath = "[Enter /signout/<your-sign-up-in-policy>, i.e /signout/B2C_1_susi]"
$AzureAdB2C_SignUpSignInPolicyId = "[Enter <your-sign-up-in-policy>, i.e B2C_1_susi]"
$AzureAdB2C_ResetPasswordPolicyId = "[Enter <your-reset-password-policy>, i.e B2C_1_reset_password]"
$AzureAdB2C_EditProfilePolicyId = "[Enter <your-edit-profile-policy>, i.e B2C_1_edit_profile]"

$random = Get-Random
# Web Application Name
$name = "identityhackathon-b2c-" + $random
$PublishFolder = "publish-b2c-" + $random
# Define the Visual Studio project directory
$projectPath = "C:\Azure-Samples\active-directory-aspnetcore-webapp-openidconnect-v2-master\active-directory-aspnetcore-webapp-openidconnect-v2-master\1-WebApp-OIDC\1-5-B2C\WebApp-OpenIDConnect-DotNet.csproj"

# Login to Azure 
az login

# Set default account subscription
az account set --subscription $subscription

# Useful commands for login in Azure
# az account show
# az account list
# az logout

# Create resource group
az group create --location $location --resource-group $resourceGroupName

# Create App Service plan
az appservice plan create --name $name --resource-group $resourceGroupName --sku P1V2 --location $location 

# Create a Web App in App Service Plan created in previous step
# You can use the “az webapp list-runtimes” to get the available runtimes (i.e "dotnet:6", "DOTNETCORE:3.1",  etc.) 
az webapp create --name $name --plan $name --resource-group $resourceGroupName --runtime "dotnet:6" 
# Set Web App Configuration App Settings
az webapp config appsettings set --resource-group $resourceGroupName --name $name --settings WEBSITE_RUN_FROM_PACKAGE="1" ASPNETCORE_ENVIRONMENT="Development" AzureAdB2C:Instance=$AzureAdB2C_Instance AzureAdB2C:ClientId=$AzureAdB2C_ClientId AzureAdB2C:Domain=$AzureAdB2C_Domain AzureAdB2C:SignedOutCallbackPath=$AzureAdB2C_SignedOutCallbackPath AzureAdB2C:SignUpSignInPolicyId=$AzureAdB2C_SignUpSignInPolicyId AzureAdB2C:ResetPasswordPolicyId=$AzureAdB2C_ResetPasswordPolicyId AzureAdB2C:EditProfilePolicyId=$AzureAdB2C_EditProfilePolicyId

# Build and publish the project in local directory
dotnet build $projectPath --configuration Release 
dotnet publish $projectPath --configuration Release -o .\$PublishFolder

# Compress and add in zip file the published version
Compress-Archive -Path .\$PublishFolder\* -DestinationPath ./$PublishFolder.zip -Force
# Deploy the Zip file to Web App Service.
az webapp deployment source config-zip --resource-group $resourceGroupName --name $name --src "./$PublishFolder.zip"
```

You can find the script [here](./Resources/Challenge_D2_03/DeployAppScriptB2C.azcli)

## Success Criteria

- Demonstrate that you have successfully deployed the web application on Azure.
- Demonstrate that you can login with a user created in previous challenge in your web application you recently deployed in Azure.
- Verify that the application configuration settings of the web application you recently deployed in Azure is properly set.

## Tips

After the deployment you should configure the Redirect URI i.e https://[WebAppHostName].azurewebsites.net/signin-oidc

## Learning Resources

[Deploy files to App Service - Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)

[Configure apps - Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/configure-common?tabs=portal)

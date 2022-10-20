# Day 1 - Challenge 03 - Deploy your Web Application to Azure

 [< Previous Challenge](./Challenge_D1_02.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_04.md)

## Introduction

You are now ready to deploy the solution and demonstrate the Proof of Concept to the Product team.

## Description

In the previous challenge you were able to integrate Azure AD as an identity solution to a web application by enabling users in your Azure AD directory to login to the application. Now it is time to deploy this on an App service and demonstrate the solution to the Product team. Your DevOps engineer prepared the following Azure CLI scripts which you can run on a PowerShell env to deploy the solution in Azure as an App Service Web App. 

```powershell
# Deployment Parameters
$location = "eastus"
$resourceGroupName = "IdentiyHackathon"

$subscription = "[Enter your Subscription Id]"
$AzureAdDomain = "[Enter your Tenant Domain i.e xxxx.onmicrosoft.com]"
$HomeTenantId = "[Enter your Tenant Id]"
$AzureAdClientId = "[Enter your Client ID]"
$AzureAdClientSecret = "[Enter your Client Secret]"

$random = Get-Random
# Web Application Name
$name = "identityhackathon-" + $random
$PublishFolder = "publish-" + $random
# Define the Visual Studio project directory
$projectPath = "C:\Azure-Samples\active-directory-aspnetcore-webapp-openidconnect-v2-aspnetcore3-1-callsgraph\WebApp-OpenIDConnect-DotNet.csproj"

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
az webapp create --name $name --plan $name --resource-group $resourceGroupName --runtime "DOTNETCORE:3.1" 
# Set Web App Configuration App Settings
az webapp config appsettings set --resource-group $resourceGroupName --name $name --settings WEBSITE_RUN_FROM_PACKAGE="1" AzureAd:Instance='https://login.microsoftonline.com/' AzureAd:TenantId=$HomeTenantId AzureAd:CallbackPath='/signin-oidc' AzureAd:ClientId=$AzureAdClientId AzureAd:Domain=$AzureAdDomain AzureAd:ClientSecret=$AzureAdClientSecret

# Build and publish the project in local directory
dotnet build $projectPath --configuration Release 
dotnet publish $projectPath --configuration Release -o .\$PublishFolder

# Compress and add in zip file the published version
Compress-Archive -Path .\$PublishFolder\* -DestinationPath ./$PublishFolder.zip -Force
# Deplpoy the Zip file to Web App Service.
az webapp deployment source config-zip --resource-group $resourceGroupName --name $name --src "./$PublishFolder.zip"
```

You can find the code in this [GitHub repository](./Resources/Challenge_D1_03/DeployAppScriptB2B.azcli)

## Success Criteria

- Demonstrate that you have successfully deployed the web application on Azure.
- Demonstrate that you can login with UserA account in your web application you recently deployed in Azure.
- Verify that the application configuration settings of the web application you recently deployed in Azure is properly set.
- Explain what are the Redirect URIs and why they are used

## Tips

Ensure that you will run the script with “HomeAdmin” account, which has “Owner” role assignment on subscription level.

After the deployment you should configure the Redirect URI i.e https://[WebAppHostName].azurewebsites.net/signin-oidc

## Learning Resources

[Deploy files to App Service - Azure App Service | Microsoft Docs](https://docs.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)

[Configure apps - Azure App Service | Microsoft Docs](https://docs.microsoft.com/en-us/azure/app-service/configure-common?tabs=portal)

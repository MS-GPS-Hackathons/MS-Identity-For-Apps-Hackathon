# Day 2 - Challenge 03 - Deploy your Web Application in Azure

 [< Previous Challenge](./Challenge_D2_02.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D2_04.md)

## Introduction

You are now ready to deploy the solution and demonstrate the Proof of Concept to the Product team.

## Description

In the previous challenge you were able to integrate Azure AD B2C to a web application. Now it is time to deploy this on an App service and demonstrate the solution to the Product team. Your DevOps engineer prepared the following Azure CLI scripts which you can run on a PowerShell env to deploy the solution in Azure as an App Service Web App.

You can find the script [here](./Resources/Challenge_D2_03/DeployAppScriptB2C.azcli)

## Success Criteria

- Demonstrate that you have successfully deployed the web application on Azure.
- Demonstrate that you can login with a user created in previous challenge in your web application you recently deployed in Azure.
- Verify that the application configuration settings of the web application you recently deployed in Azure is properly set.

## Tips

After the deployment you should configure the Redirect URI i.e https://[WebAppHostName].azurewebsites.net/signin-oidc
It may take up to 10m mins for the change to take effect.

## Learning Resources

[Deploy files to App Service - Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)

[Configure apps - Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/configure-common?tabs=portal)

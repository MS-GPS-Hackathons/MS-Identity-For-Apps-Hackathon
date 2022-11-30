# Day 1 - Challenge 03 - Deploy your Web Application to Azure

 [< Previous Challenge](./Challenge_D1_02.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge_D1_04.md)

## Introduction

You are now ready to deploy the solution and demonstrate the Proof of Concept to the Product team.

## Description

In the previous challenge you were able to integrate Azure AD as an identity solution to a web application by enabling users in your Azure AD directory to login to the application. Now it is time to deploy this on an App service and demonstrate the solution to the Product team. Your DevOps engineer prepared the following Azure CLI scripts which you can run on a PowerShell env to deploy the solution in Azure as an App Service Web App.

You can find the script [here](./Resources/Challenge_D1_03/DeployAppScriptB2B.azcli)

After completing the application deployment, you need to get familiar with oAuth security tokens.
You should go through the learning resources and explain to your coach the following:

- What is an access token, ID token and refresh token
- How the validation of security tokens works
- JSON Web Tokens and claims

## Success Criteria

- Demonstrate that you have successfully deployed the web application on Azure.
- Demonstrate that you can login with HomeUserA account in your web application you recently deployed in Azure.
- Verify that the application configuration settings of the web application you recently deployed in Azure is properly set.
- Explain what are the Redirect URIs and why they are used
- Explain what is an access token, ID token and refresh token.
- Explain how the validation of security tokens works
- Explain the usage of JSON Web Tokens and claims.

## Tips

Ensure that you will run the script with “HomeAdmin” account, which has “Owner” role assignment on subscription level.

After the deployment you should configure the Redirect URI i.e https://[WebAppHostName].azurewebsites.net/signin-oidc
It may take up to 10m mins for the change to take effect. 

## Learning Resources

[Deploy files to App Service](https://docs.microsoft.com/en-us/azure/app-service/deploy-zip?tabs=cli#deploy-a-zip-package)

[Configure apps - Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/configure-common?tabs=portal)

[Redirect URI (reply URL)](https://learn.microsoft.com/en-us/azure/active-directory/develop/reply-url)

[Security tokens](https://docs.microsoft.com/en-us/azure/active-directory/develop/security-tokens)

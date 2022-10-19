# (Optional) Day 1 - Advanced Challenge 10 - Configure App Roles

 [< Previous Advanced Challenge (Optional)](./Challenge_D1_09.md) - **[Home](../README.md)**

## Introduction

The Product Owner during his\her involvement and research with Azure AD Identity, discovered the Application roles functionality. They challenge you to explore and configure Application Roles.

## Description

The product owner request sounds challenging to you, because you were not aware of this functionality. 

During your research you discovered that you could leverage this functionality to make the authorization decisions in the application code by using the “roles” claim. You found a very good example in GitHub repository in Azure samples and decided to proceed with this. 

The link to the GitHub sample can be found in the Learning Resources below.

## Success Criteria

- Demonstrate that HomeUserA user has the  “UserReaders” role and has permissions to access “Users” endpoint and does NOT have permissions to access the “Groups” endpoint
- Demonstrate that HomeUserB user has the  “DirectoryViewers” role and has permissions to access “Groups” endpoint and does NOT have permissions to access the “Users” endpoint
- Demonstrate the configuration done in your application code to enable authorization decisions with “Role” claim.
- Explain the differences between the two permission types “Delegated permissions” and “Application permissions“.
- Explain the difference between Application Roles and Groups

## Learning Resources

[Add app roles and get them from a token - Microsoft Entra | Microsoft Docs](https://docs.microsoft.com/en-us/Azure/active-directory/develop/howto-add-app-roles-in-Azure-ad-apps#app-roles-vs-groups)

[Delegated permissions and application permissions.](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#permission-types)

[GitHub sample](https://github.com/Azure-Samples/active-directory-aspnetcore-webapp-openidconnect-v2/blob/master/5-WebApp-AuthZ/5-1-Roles/README.md)
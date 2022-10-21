# Coach's Guide - Day 1 - Challenge 05 - Control who can authenticate in your app

 [< Previous Solution](./Solution_D1_04.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D1_06.md)

## Introduction

In this challenge students need to configure and control who can authenticate in the application.

In the previous challenge students enabled the external identities and allow all internal or external users invited to the Tenant to access the web application.

Students should allow access to the application only for “HomeUserA” and “ExternalUserA”.

To allow access only to specific users they have to enable the "assignment required" enterprise application property .
If this option is set to Yes, then users and other applications or services must first be assigned this application before being able to access it.
If this option is set to No, then all users are able to sign in, and other applications and services are able to obtain an access token to the application.

[Enable Assignment required property](https://learn.microsoft.com/en-us/azure/active-directory/manage-apps/application-properties?source=recommendations#assignment-required)

[Configure enterprise application properties](https://learn.microsoft.com/en-us/azure/active-directory/manage-apps/add-application-portal-configure#configure-application-properties)

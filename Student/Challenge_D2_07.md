# Day 2 - Challenge 07 - Monitoring and Observability

 [< Previous Challenge](./Challenge_D2_06.md) - **[Home](../README.md)** - [Next Advanced Challenge (Optional) >](./Challenge_D2_08.md)

## Introduction

Well done! The Product team is excited about your Azure AD B2C setup, but they have one final request: help them monitor the B2C activity around logins, conditional access request, failed logins, etc.

You are considering different monitoring solutions to route log events (Azure Storage, Log Analytics, Azure Event Hubs) using Azure Monitor. The Product team would like to visualize and create alerts for certain events, so incorporating B2C monitoring into Log Analytics seems like the most logical move.

## Description

In the previous challenge you successfully enabled enriching tokens with claims from external sources. Now you’re investigating the Product team’s request to use a Log Analytics workspace to collect data from Azure AD B2C logs, and then visualize it with queries and workbooks, and create alerts.

## Success Criteria

- Demonstrate how you can export B2C logs into a Log Analytics workspace
- Demonstrate how you can configure your Log Analytics workspace to query and visualize your data
- Demonstrate how you can create alert rules in Azure Monitor based on specific performance metrics or when certain events occur or are absent
- Demonstrate how you can access the sign-ins logs in Azure AD portal

## Learning Resources

[Monitor Azure AD B2C with Azure Monitor - Azure AD B2C](https://docs.microsoft.com/en-us/azure/active-directory-b2c/azure-monitor) 

[Azure Active Directory activity logs in Azure Monitor](https://docs.microsoft.com/en-us/azure/active-directory/reports-monitoring/concept-activity-logs-azure-monitor)

[Sign-in logs in Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/reports-monitoring/concept-sign-ins)

[Access and review audit logs - Azure AD B2C](https://docs.microsoft.com/en-us/azure/active-directory-b2c/view-audit-logs)

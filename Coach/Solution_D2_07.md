# Coach's Guide - Day 2 - Challenge 07 - Monitoring and Observability

 [< Previous Solution](./Solution_D2_06.md) - **[Home](./README.md)** - [Next Advanced Solution (Optional)>](./Solution_D2_08.md)

 Work In Progress

 ## Introduction

In this challenge attendees should monitor the B2C activity by proceeding with the following:
- use a Log Analytics workspace to collect data from Azure AD B2C logs
- visualize it with queries and workbooks
- create alerts in Azure Monitor

They can follow the procedure in the Microsoft Learn guide document provided. The guide includes the following steps:

### 1. Integration between Azure AD B2C and Log Analytics, which is where we'll send the logs

Attendes should:
- Create or choose resource group
- Create a Log Analytics workspace
- Deploy an Azure Resource Manager template to the subscription that contains the Log Analytics workspace

The following diagram shows the components you'll configure in your Azure AD and Azure AD B2C tenants.

![Resource Group Projection](../Resources/Images/resource-group-projection.png)

- Configure diagnostic settings, that define where logs and metrics for a resource should be sent


### 2. Configure the Log Analytics workspace to query and visualize the data

Attendees must firstly create a  Kusto Query Language query in Log Analytics workspace that shows policy usage by operation over the past x days - default 90 days (90d).
By using the render operator in the query, the attendees can visualize the data as a piechar diagram.


### 3. Create alert rules in Azure Monitor 

When certain events occur or are absent, attendees must showcase how to create alert rules in Azure Monitor based on some specific events. If there is a drop of 25% or more in the total requests within the past hour, create a query and a new alert rule.



 #### References for this challenge
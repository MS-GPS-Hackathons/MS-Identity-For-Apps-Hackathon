# (Optional) Coach's Guide - Day 2 - Advanced Challenge 09 - Create Custom Policies

 [< Previous Advanced Solution (Optional)](./Solution_D2_08.md) - **[Home](./README.md)** - [Next Advanced Solution (Optional)>](./Solution_D2_10.md)

  ## Introduction

Custom policies were introduced during a previous challenge. 
This one concentrates on more complex scenarios, how policies are built inside and how they can be deployed easily.
Please, refer to the previous challenge or the link below for general overwiev of the concept of custom policies.

[custom policy overview](https://learn.microsoft.com/en-us/azure/active-directory-b2c/custom-policy-overview)

### Challenge Walkthrough

Examine the github with available policy samples and choose the most similar to your business scenario.

[github with policy samples](https://github.com/azure-ad-b2c/samples)

In this case, you can use [A B2C IEF Custom Policy - Sign Up and Sign In with 'Terms of Use' prompt](https://github.com/azure-ad-b2c/samples/tree/master/policies/sign-in-sign-up-versioned-tou)

The readme file includes additional references and prerequisities.

It presents a [setup tool](https://b2ciefsetupapp.azurewebsites.net/) that can automate the entire process from: 
- [Get started with custom policies in Azure Active Directory B2C](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-user-flows?pivots=b2c-custom-policy). It will deploy the Social, Local and MFA files, with Local Account journeys. This allows you to build upon these foundations without any missing dependancies.
- It will integrate Extension Attribute support from: [Enable custom attributes in a custom profile policy.](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-custom-attributes?pivots=b2c-custom-policy#create-a-new-application-to-store-the-extension-properties)
- After completing this setup, you will be able to use the [Azure AD B2C IEF Sample Policies.](https://github.com/azure-ad-b2c/samples)

Basically, it automatically performs all the steps you did manually during the challenge number 8 including setup of IdentityExperienceFramework, ProxyIdentityExperienceFramework and basic custom policies (TrustFrameworkBase, TrustFrameworkLocalization, TrustFrameworkExtensions, signup_signin, PasswordReset, ProfileEdit). 

The next step is to download, modify and upload provided samples. 

The only thing that needs to be modified is a tenant name at the beggining of each policy.

```xml
<TrustFrameworkPolicy xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/online/cpim/schemas/2013/06" PolicySchemaVersion="0.3.0.0" 
  TenantId="yourtenant.onmicrosoft.com" 
  PolicyId="B2C_1A_Demo_TrustFrameworkExtensions_TOU" 
  PublicPolicyUri="http://yourtenant.onmicrosoft.com/B2C_1A_Demo_TrustFrameworkExtensions_TOU">

  <BasePolicy>
    <TenantId>yourtenant.onmicrosoft.com</TenantId>
    <PolicyId>B2C_1A_TrustFrameworkExtensions</PolicyId>
  </BasePolicy>
 ```
 
 Carefully examine the contents of the policies, especially the TrustFrameworkExtensions_TOU.xml,
 
 From the code sample posted above you can see that the base policy is B2C_1A_TrustFrameworkExtensions. As you should remember, policies create a hierarchical chain. TrustFrameworkExtensions is based on the TrustFrameworkLocalization which is based on the TrustFrameworkBase. Be carefull not to remove any of these policies. 
 
 Follow the "How it works" part of readme.md file and compare it with the contents of the policies to understand the whole flow. 
 
 Upload your modified policies on top of the existing ones.
 
 You can validate that it works properly directly through AAD portal by running the endpoint of your new sign it policy. If you didn't modify its name in the xml file it will be called B2C_1A_DEMO_SUSI_TOU. 
 
 

#### References for this challenge


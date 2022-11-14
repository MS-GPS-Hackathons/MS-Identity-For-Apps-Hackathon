# (Optional) Coach's Guide - Day 2 - Advanced Challenge 08 - Identity Experience Framework, get ready for custom policies

 [< Previous Solution](./Solution_D2_07.md) - **[Home](./README.md)** - [Next Advanced Solution (Optional)>](./Solution_D2_09.md)
 
## Introduction

Custom policies are configuration files that define the behavior of your Azure Active Directory B2C (Azure AD B2C) tenant. While user flows are predefined in the Azure AD B2C portal for the most common identity tasks, custom policies can be fully edited by an identity developer to complete many different tasks and implement own business logic.

A custom policy is represented as one or more XML-formatted files, which refer to each other in a hierarchical chain. The XML elements define elements of the policy, such as the claims schema, claims transformations, content definitions, claims providers, technical profiles, user journey, and orchestration steps. Each policy file is defined within the top-level TrustFrameworkPolicy element of a policy file.

Azure AD B2C custom policy starter pack comes with several pre-built policies to get you going quickly. Each of these starter packs contains the smallest number of technical profiles and user journeys needed to achieve the scenarios described:

LocalAccounts - Enables the use of local accounts only.
SocialAccounts - Enables the use of social (or federated) accounts only.
SocialAndLocalAccounts - Enables the use of both local and social accounts. Most of our samples refer to this policy.
SocialAndLocalAccountsWithMFA - Enables social, local, and multi-factor authentication options.

[Azure AD B2C custom policy starter pack](https://github.com/Azure-Samples/active-directory-b2c-custom-policy-starterpack)

To modify them or develop your own, you can use documentation:

[custom policy documentation](https://learn.microsoft.com/en-us/azure/active-directory-b2c/trustframeworkpolicy)

The custom policy gives you the ability to construct user journeys with any combination of steps. For example:

* Federate with other identity providers

* First- and third-party multifactor authentication (MFA) challenges

* Collect any user input

* Integrate with external systems using REST API communication

Use provided links to learn more as it is a very broad topic with many configuration possibilities. 

### Challenge Walkthrough

The easiest way to satisfy all success criteria is to follow the tutorial step by step:

[custom policy tutorial](https://learn.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-user-flows?pivots=b2c-custom-policy)

The tutorial guides you through setting customy policy for using social and local accounts. In this case it is designed to use Facebook as an identity provider. 
Have in mind that Facebook policy requires three different valid URls linking to the terms of service, privacy and user data deletion policy to register an app. 
If you don't have it and you just want to practice working with local policies, the easiest way is to use LocalAccounts template. 
The other option is to modify the policy to use google as an identity provider: 

[google example](https://learn.microsoft.com/en-us/azure/active-directory-b2c/identity-provider-google?pivots=b2c-custom-policy)

The key is to correctly register IdentityExperienceFramework and ProxyIdentityExperienceFramework applications exactly as it is described in the tutorial. 

Next step is modification of the chosen policy templates. 

In each file "yourtenant" string must be replaced with the name of your tenant.

```xml
  TenantId="yourtenant.onmicrosoft.com"
  PolicyId="B2C_1A_PasswordReset"
  PublicPolicyUri="http://yourtenant.onmicrosoft.com/B2C_1A_PasswordReset">

  <BasePolicy>
    <TenantId>yourtenant.onmicrosoft.com</TenantId>
    <PolicyId>B2C_1A_TrustFrameworkExtensions</PolicyId>
  </BasePolicy>
```

Additionally in the TrustFrameworkExtensions.xml the correct application ids for IdentityExperienceFramework and ProxyIdentityExperienceFramework should replace placeholders. You can find corerrect values in the app registration blade. 

```xml
    <ClaimsProvider>
      <DisplayName>Local Account SignIn</DisplayName>
      <TechnicalProfiles>
         <TechnicalProfile Id="login-NonInteractive">
          <Metadata>
            <Item Key="client_id">ProxyIdentityExperienceFrameworkAppId</Item>
            <Item Key="IdTokenAudience">IdentityExperienceFrameworkAppId</Item>
          </Metadata>
          <InputClaims>
            <InputClaim ClaimTypeReferenceId="client_id" DefaultValue="ProxyIdentityExperienceFrameworkAppId" />
            <InputClaim ClaimTypeReferenceId="resource_id" PartnerClaimType="resource" DefaultValue="IdentityExperienceFrameworkAppId" />
          </InputClaims>
        </TechnicalProfile>
      </TechnicalProfiles>
    </ClaimsProvider>
```

Upload the policies in the correct order as defined in the tutorial. Remember they form a hierarchical chain.

The easiest way to test a policy is to run it directly from the AAD B2C portal. You need to click the Policy id and run the endpoint.  If you want to avoid integration of your custom policies into the code of your application, you can simply change the redirect URL in the app registration to https://jwt.ms and then validate the correct behavior of the policy and examine the token and claims. 


#### References for this challenge

 [user flows and custom policies overview](https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview)
 
 [Azure AD B2C custom policy overwiev](https://learn.microsoft.com/en-us/azure/active-directory-b2c/custom-policy-overview)
 
 [custom policy schema references](https://learn.microsoft.com/en-us/azure/active-directory-b2c/trustframeworkpolicy)
 
 [custom policy samples](https://github.com/Azure-Samples/active-directory-b2c-custom-policy-starterpack)
 
 [bigger list of policy samples](https://github.com/azure-ad-b2c/samples)
 
 

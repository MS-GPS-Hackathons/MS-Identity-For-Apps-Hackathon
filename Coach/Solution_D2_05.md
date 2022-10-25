# Coach's Guide - Day 2 - Challenge 05 - Branding

 [< Previous Solution](./Solution_D2_04.md) - **[Home](./README.md)** - [Next Solution >](./Solution_D2_06.md)

## Introduction

In this challenge attendees should customize the user interface of Azure AD B2C with the following.

- Check the available built-in templates and select one of your choice
- Basic sign-in page with custom logo of your choice
- Language customization

### Built-in templates

Azure AD B2C provide several built-in templates you can choose from to give your user experience pages a professional look. These page templates can also and serve as starting point for your own customization, using the company branding feature.

[Built-in templates](https://learn.microsoft.com/en-us/azure/active-directory-b2c/customize-ui?pivots=b2c-user-flow#overview)

### Company branding

You can customize your Azure AD B2C pages with a banner logo, background image, and background color by using Azure Active Directory Company branding. The company branding includes signing up, signing in, profile editing, and password resetting.

[Add branding to your organization's sign-in page](https://learn.microsoft.com/en-us/azure/active-directory/fundamentals/customize-branding)

### Language customization

Language customization in Azure Active Directory B2C (Azure AD B2C) allows your user flow to accommodate different languages to suit your customer needs. Microsoft provides the translations for 36 languages, but you can also provide your own translations for any language. Even if your experience is provided for only a single language, you can customize any text on the pages.

[Language customization](https://learn.microsoft.com/en-us/azure/active-directory-b2c/language-customization?pivots=b2c-user-flow)

## Answers for Challenge

### 1. Explain how you can achieve further customization and better branding using AAD B2C

Branding and customizing the user interface that Azure Active Directory B2C (Azure AD B2C) displays to your customers helps provide a seamless user experience in your application. These experiences include signing up, signing in, profile editing, and password resetting.

Azure AD B2C runs code in your customer's browser by using Cross-Origin Resource Sharing (CORS). At runtime, content is loaded from a URL you specify in your user flow or custom policy. Each page in the user experience loads its content from the URL you specify for that page. After content is loaded from your URL, it's merged with an HTML fragment inserted by Azure AD B2C, and then the page is displayed to your customer.

You can create an HTML page with your own branding to serve your custom page content. This page can be a static *.html page, or a dynamic page like .NET, Node.js, or PHP.

Your custom page content can contain any HTML elements, including CSS and JavaScript, but cannot include insecure elements like iframes. The only required element is a div element with id set to api, such as this one `<div id="api"></div>` within your HTML page.

Instead of creating your custom page content from scratch, you can customize Azure AD B2C's default page content.

```html
<!DOCTYPE html>
<html>
<head>
    <title>My Product Brand Name</title>
</head>
<body>
    <div id="api"></div>
</body>
</html>
```

[Customize the user interface with HTML templates](https://learn.microsoft.com/en-us/azure/active-directory-b2c/customize-ui-with-html?pivots=b2c-user-flow)

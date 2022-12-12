# Deployment Parameters 
$subscription = "[Enter your Subscription Id]"
$ApiUserName = "[Enter The Api Connector Username]"
$ApiPassword = "[Enter The Api Connector Password]"
$extensionsAppId = "[Enter The Extension App Id. This is the client id of the app registration created during Azure AD B2C tenant creation]"
$random = "[Add a 6 digit random value, will be used to create a uinique value for the App Service]"

# Define the Visual Studio project file (full path) to publish
$projectFile = "[Enter the full path of the Visual Studio project file ending with .csproj]"

# Other Parameters 
$location = "eastus"
$resourceGroupName = "IdentityHackathon"
$functionName = "identityhackathon-b2c-api-" + $random
$storageName = "funstorage" + $random
$PublishFolder = "publish-b2c-api-" + $random

# Build the project
dotnet build $projectFile --configuration Release
$buildResult = $LASTEXITCODE
if($buildResult -eq 0)
    {
        Write-Host "Build completed succesfully."
    } else {
        Write-Host "Build FAILED." -ForegroundColor Red;
    }

# Publish the project in local directory, if previous build completed succesfully
if($buildResult -eq 0) {
    dotnet publish $projectFile --configuration Release -o .\$PublishFolder
    $publishResult = $LASTEXITCODE
    # Write output result
    if($publishResult -eq 0)
    {
        Write-Host "Publish completed succesfully."
    } else {
        Write-Host "Publish FAILED." -ForegroundColor Red;
    }
}

# Compress the published version in zip file, if the previous publish command completed succesfully
if(($buildResult -eq 0) -and ($publishResult -eq 0)) {
    $error.Clear();
    Compress-Archive -Path .\$PublishFolder\* -DestinationPath ./$PublishFolder.zip -Force
    $compressResult = $error.Count   
    # Write output result
    if($compressResult -eq 0)
    {
        Write-Host "Compress file completed succesfully."
    } else {
        Write-Host "Compress file FAILED." -ForegroundColor Red;
    }
}

# Deploy to Azure, if previous steps completed succesfully
if(($buildResult -eq 0) -and ($publishResult -eq 0)  -and ($compressResult -eq 0)) {
    
    Write-Host "Deploy to Azure..."

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

    # Create an Azure storage account in the resource group.
    az storage account create --name $storageName --location "$location" --resource-group $resourceGroupName --sku "Standard_LRS"

    # Create a serverless function app in the resource group.
    az functionapp create --name $functionName --storage-account $storageName --consumption-plan-location "$location" --resource-group $resourceGroupName --functions-version "4"

    # Set Web App Configuration App Settings
    az functionapp config appsettings set --resource-group $resourceGroupName --name $functionName --settings WEBSITE_RUN_FROM_PACKAGE="1"  ASPNETCORE_ENVIRONMENT="Development" ApiUserName=$ApiUserName ApiPassword=$ApiPassword extensions-app-id=$extensionsAppId

    # Deploy the Zip file to Azure Function.
    az functionapp deployment source config-zip --resource-group $resourceGroupName --name $functionName --src "./$PublishFolder.zip"

    $functionUrl = az functionapp function show --resource-group $resourceGroupName --name $functionName --function-name ClaimsEnrichment --query invokeUrlTemplate
    echo "Use the below function URL and username/password in your API Connector"
    echo "Function URL: $functionUrl"
    echo "Username: $ApiUserName"
    echo "Password: $ApiPassword"
}
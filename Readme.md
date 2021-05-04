# Open Referrals UI
This repo contains the source code for the Open Referrals UI project.

TODO: Add in project description

This Project requires the use of an Azure AD B2C tenant to store user credentials and 
and to do authentication.  

## Prerequisites / Dependencies
 - Azure B2C Tenant
 - A local or deployed instance of the OpenReferralAPI

## Source Code
This project uses BlazorServer and is written in C#

## Setup Azure Resources
- Create an OpenReferralUI app registration
- Create a client secret and copy it down
- Add the _user_impersonation permission from the OpenReferralAPI app registration (See OpenReferralAPI project)

## Getting started Locally

### Setup Azure Resources
- Create an OpenReferralUI app registration
- Create a client secret and copy it down
- Add the _user_impersonation permission from the OpenReferralAPI app registration (See OpenReferralAPI project)

### Local machine setup
- Clone the repository
- Open the sln file in VS 2019
- Create a local file named 'appsettings.Development.json'
- Copy the appsettings.json file contents into the file you just created.
- Add all the settings from the azure resources
- Make sure the OpenReferral API is running, see [OpenReferralAPI](https://github.com/siccar/referrals-api)
- Run

### Styling
- The app is styled using a stylesheet called SiccarCast.css.
- The css is built using SASS/SCSS.  Information about sass/scss can be found here (https://sass-lang.com/)
- In the css dircectory there is a file called SiccarCast.scss.  This file contains imports to various other sections that build the CSS file
- There is a partials directory that contains all the scss for the various parts of the site
- The colours, font-sizes, responsive utils reside within the main css folder.
- In the root of the project there is a file called compilerconfig.json.  This file was autogenrated in Visual Studio by a plugin.
- if using Visual Studio the plugin can be installed from here (https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler)
- Once installed when changes are made to any of the .scss files and then saved the new complied CSS files are built.
- The SiccarCast.css and the SiccarCast.min.css reside in the wwwroot/css folder

## Deployment
This project can easily deployed using VS2019
 - Firstly follow the same steps in the [OpenReferralAPI](https://github.com/siccar/referrals-api)
 - Get the deployed address of the API from the Azure AppService and paste this into the ORApi:BaseUrl
 - Fill out the appsettings.json file with deployment settings
 - Right click on the project
 - Select Publish
 - Target Azure
 - Use windows app service
 - Target an existing app service instance or create a new one.
 - Skip the api management step
 - Save and publish

 This project also has azure-pipelines.yml setup for Azure DevOps.
 
 - Copy the repository into your own DevOps Repo.
 - Create a new pipeline called OpenReferralUI and target the azure-pipelines.yml
 - Create a release which targets the OpenReferralUi artifact and targets and app service.
 - If you don't want secrets in source code, inject the appsettings configuration at deployment time.
 - Setup triggers or manually create a build and then release to the app service.

## Feedback
User can leave feedback via a [Google Form](https://docs.google.com/forms/d/e/1FAIpQLSfw5D-YCGzu8SDMhkmxqzJSu1KJJx-hYaRuLnrnU_Um7ILyxw/viewform).
This link is also embedded in the app. 

[Issues](https://github.com/siccar/referrals-ui/issues) can also be created against the Github repository 

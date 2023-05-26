# BlazorConf 2023

This is a Blazor application built with Visual Studio and the Teams Toolkit that runs as Teams tab. It allows users to list files on OneDrive using the Microsoft Graph API. The application can also generate a summary of Word documents using OpenAI and ChatGPT.

You can watch the recording of the session at [https://blazorconf.it/](https://blazorconf.it/).

### Prerequisites
To run the application, you will need the following:

- Visual Studio 2019 version 17.6 or later
- The ASP.NET web development workload installed in Visual Studio
- The Microsoft Teams development feature installed in Visual Studio
- A Microsoft 365 tenant (you can get one for free using the [Microsoft 365 Developer Program](https://developer.microsoft.com/en-us/microsoft-365/dev-program)
- An Azure OpenAI or OpenAI key to use the summary function

### Getting Started
- Clone this repository.
- Open the solution file (BlazorConf2023.sln) in Visual Studio.
- Right-click on the project in the Solution Explorer and select Teams Toolkit > Prepare Teams Apps Dependencies.
- Login with your Microsoft 365 account
- Press F5 in Visual Studio to sideload the application in Teams.

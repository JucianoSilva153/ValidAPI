<h1 align="center">ValidusAPI</h1>
<p align="center">
<img src="http://img.shields.io/static/v1?label=STATUS&message=On%20Development&color=GREEN&style=for-the-badge"/>

ValidusAPI is an open-source project based on an API for Information and Data Validation. With ValidusAPI, developers can easily validate information from their forms, such as phone numbers, emails, identification cards, and even check for secure passwords.
### ValidusAPI Features
* Identification Validation (Angola Only)
* Phone Number Validation (Angola only)
* Email Validation
* Password Checker
### Installation Guide
* Clone this repository [here](https://github.com/JucianoSilva153/ValidAPI.git).
* Run <em>dotnet restore</em> to install all dependencies
### Usage
* Run <em>dotnet run</em> do execute de API.
* Connect to the API using the url given in the console.
### API Endpoints
| HTTP Verbs | Endpoints | Action |
| --- | --- | --- |
| GET | /api/Validacao/{email} | To validate an email |
| GET | /api/Validacao/BI/{BI number} | To validate a BI number |
| GET | /api/Validacao/AO/{phone number} | To validate a phone number (for Angola) |
| GET | /api/Validacao/Senha/{minChar}/{password} | To validate a password by checking if its secure |
### Technologies Used
* [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) NET is a free, cross-platform, open-source developer platform. .NET has languages, editors, and libraries to build for web, mobile, desktop, games, and IoT.
* [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-8.0) ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-enabled, Internet-connected apps.
### Authors
* [Juciano Silva](https://github.com/jucianosilva153)
### ValidusAPI needs your contribuition!!
I would be grateful if you could contribute to my project. So, if you want to make any type of contribution, please feel free to do so. Just clone the project and push all your changes to a new branch!
### License
This project is available for use under the MIT License.

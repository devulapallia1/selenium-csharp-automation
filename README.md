This project automates the login functionality of a demo web application using Selenium WebDriver and C#.
Objective: Automate a real-time web application (e.g., login functionality of a demo app).
Tools Used: Selenium WebDriver, C#, NUnit for testing framework, and GitHub for version control.

Project Directory Structure:
selenium-csharp-automation/
├── src/
│   ├── main/
│   │   └── Automation/
│   │       ├── Drivers/
│   │       │   └── WebDriverSetup.cs
│   │       ├── Pages/
│   │       │   └── LoginPage.cs
│   │       ├── Tests/
│   │       │   └── LoginTests.cs
│   │       └── Utils/
│   │           └── ConfigReader.cs
├── .gitignore
├── README.md
├── selenium-csharp-automation.sln
├── selenium-csharp-automation.csproj
└── appsettings.json


## Prerequisites
- Visual Studio or JetBrains Rider
- .NET 6 or higher
- ChromeDriver (compatible with your Chrome version)
- NuGet Packages:
  - Selenium.WebDriver
  - Selenium.WebDriver.ChromeDriver
  - NUnit

## Running the Tests
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/selenium-csharp-automation.git
2. Open the solution in Visual Studio.
3. Install NuGet dependencies.
4. Run the tests using the Test Explorer.

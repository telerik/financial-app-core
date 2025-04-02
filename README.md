Finance App sample application powered by Progress® Telerik® UI for ASP.NET Core  
Finance App is a sample application built with Progress® Telerik® UI for ASP.NET Core — a professional set of UI components designed to help you deliver modern, feature-rich, and responsive web applications quickly and efficiently.

The app demonstrates how easy it is to create a dynamic, data-driven financial dashboard using Telerik’s built-in components like TileLayout, Grid, Gauge, DropDownList, and Chart. It also shows how to implement virtualized filtering, clean layout strategies, and SQLite data integration with minimal setup.

This project is ideal as a reference for building real-world .NET Core applications with modern frontend UX.

Public URL - https://github.com/telerik/financial-app-core

---

### Requirements

- Progress® Telerik® UI for ASP.NET Core 
- Visual Studio 2022 or later – [Download](https://visualstudio.microsoft.com/vs/)  
- .NET 8.0 SDK – [Download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- SQLite (included, no setup required)

---

### Running this app

**1. Configure Telerik NuGet Feed**

Before restoring NuGet packages, add Telerik’s NuGet feed using the command line:

dotnet nuget add source https://nuget.telerik.com/v3/index.json --name telerik.com --username YOUR_USERNAME --password YOUR_PASSWORD

Alternatively, configure the feed in Visual Studio:

- Go to `Tools > NuGet Package Manager > Package Sources`
- Add a new source with the Telerik URL and your credentials

---

**2. Open the solution**

Open `FinancialApp.sln` in Visual Studio 2022 or later.

---

**3. Run the app**

Press `Ctrl + F5` to build and launch the application.  
The app will start at a localhost URL (e.g., https://localhost:5001)

---

### Highlights

- Modular dashboard layout using Telerik TileLayout
- Real-time KPI tracking with Telerik Gauge
- Portfolio distribution via Telerik Pie Chart
- Server-side filtering with virtualized DropDownLists
- Configurable Kendo Grid with grouping, sorting, and filtering
- SQLite database integration with sample demo data

---

### License

This is a sample application intended for demonstration purposes only.  
Use of Telerik® UI for ASP.NET Core requires a valid commercial license from Progress® Telerik®.  
Learn more: https://www.telerik.com/aspnet-core-ui

# Singleton Pattern Example in .NET

This repository demonstrates how the singleton pattern works in .NET applications.

## About Singletons

Singletons are design patterns that ensure a class has only one instance and provide a global point of access to that instance. This is useful for managing shared resources, configuration settings, or services that should exist only once throughout the application's lifetime.

## Getting Started

### Prerequisites

- .NET SDK installed (version compatible with the project)

### Running the Application

1. Navigate to the project root directory in your terminal
2. Run `dotnet restore` to restore NuGet dependencies
3. Run `dotnet watch run` to start the development server with hot reload
4. Open your browser and navigate to `https://localhost:5001` (or the port shown in console)
5. The Blazor application will load in your browser

### Production Build

For production builds, use:

```bash
dotnet publish -c Release
```

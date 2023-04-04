# Simple Restful Calculator

This is a simple calculator in form of web application + APIs written in C# and .NET Framework

## Installation

You will need to install [.NET 7](https://learn.microsoft.com/en-us/dotnet/core/install/linux) in order to run this application.

After the installation is ready, go the app folder in terminal (**CalculatorApp** folder) and do
```bash
dotnet build
```

## Running

Being in the app folder, you can run the application from terminal with

```bash
dotnet run
```

## Usage

The application will start on port 5197.
You can access web app's frontend from the browser under http://localhost:5197.

Otherwise you can also use app's REST APIs which described in the classes of **Controller** folder in the project. For example in terminal do:

```bash
curl localhost:5197/api/sum/4.0/324.6
```

## Testing

The solution has a small suite of tests in **CalculatorApp.Tests** project. It includes a unit and an integration test.

To run those, switch to the project's folder in terminal and do

```bash
dotnet test
```

## Xunit
### Folder structure

```
MyApp/
  Program.cs ← top level statement
  Calculator.cs
  MyApp.csproj

MyApp.Tests/
  CalculatorTests.cs
  MyApp.Tests.csproj
```

### Create test project

Main project
```
dotnet new console -o HelloApp
```

Create Test project and link to Main project
```bash
dotnet new xunit -o HelloApp.Tests
dotnet add HelloApp.Tests/HelloApp.Tests.csproj reference HelloApp/HelloApp.csproj
```

### Run test

```bash
dotnet test
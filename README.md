# Smart Home - Expenses

## Create project

```shell
dotnet new solution -n SmartHome.Expenses
dotnet new webapi -n SmartHome.Expenses.Api -lang "C#"
dotnet sln SmartHome.Expenses.sln add SmartHome.Expenses.Api/SmartHome.Expenses.Api.csproj --solution-folder 01-application
dotnet new classlib -n SmartHome.Expenses.Domain -lang "C#"
dotnet sln SmartHome.Expenses.sln add SmartHome.Expenses.Domain/SmartHome.Expenses.Domain.csproj --solution-folder 02-domain
dotnet new classlib -n SmartHome.Expenses.Infrastructure -lang "C#"
dotnet sln SmartHome.Expenses.sln add SmartHome.Expenses.Infrastructure/SmartHome.Expenses.Infrastructure.csproj --solution-folder 03-infrastructure
```

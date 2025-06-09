Tips for self:

1. Blazor Server is no longer supported in v8


Steps:
1. dotnet new blazor -o SyringaHelpDesk
2. Create Ticket.cs and AppDBContext.cs

4. Apply Migrations and create db
    dotnet tool install --global dotnet-ef
    dotnet ef migrations add InitialCreate
    dotnet ef database update

    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet add package Microsoft.EntityFrameworkCore.Design



Tips for me:

1. What is AppDbContext?    
    In a Blazor / Entity Core App:
    - AppDbContext is the bridge between the db and C# code
    - it manages querying, saving and mapping objects to db tables
    - inherits from DbContext, which is the EF Core base class that enables all of this

    You'll typically define porperties as such:

    public DbSet<Customer> Customers { get; set; }

    This tells EF Core, "I want a Customers table in the db that maps to my Customer model."

2. UseSqlServer()
    This is an extension method that tells EF Core to use SQL Server as the db provider.

    It needs a connection string that tells EF Core how to connect to the SQl Server instance

    Install the EF Core SQL Server package:

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

    In Program.cs:

    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    In AppSettings.JSON:

    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=TelecomDB;Trusted_Connection=True;TrustServerCertificate=True;"
    }

    This sets up the link between the app and the db.

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

3. Create db
    init.sql file 
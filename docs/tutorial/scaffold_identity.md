# Scaffold Identity

Before you can scaffold the identity tables, you need to make sure that your database connection is setup correctly. Lets check the Startup.cs file and see whats been set. 

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddDatabaseDeveloperPageExceptionFilter();

    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
    services.AddControllersWithViews();
}
```

You can see above that the UseSqlServer configuration is set to use the <strong>DefaultConnection</strong>. The value for this is located in the <strong>appsettings.json</strong> file. Open it up and and you should see something similar:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-MVCAuthExample-C8303DD1-4295-49C2-8F96-93B10D88543F;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

Change the DefaultConnection string to your running MSSQL Database. 

```json

```


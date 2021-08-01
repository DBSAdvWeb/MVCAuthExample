# Adding a Secure Page
To test our login feature, we need to make sure that only logged in users can see the Accounts Page. To start, lets create a model called Account.

```csharp
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAuthExample.Models
{
    public class Account
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Type {get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total {get; set;}
    }
}
```

Lets scaffold the controller & views for Account. Make sure your project has the following dependencies installed:

```shell
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

Before running the code generator make sure that the path is available: (Linux/Mac only)

```shell
export PATH=$HOME/.dotnet/tools:$PATH
```

```shell
dotnet-aspnet-codegenerator controller -name AccountsController -m Account -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

You shoul now have a new Controller & Views setup for the Accounts view. Next, we need to add our migration scripts. Run the following:

```shell
dotnet ef migrations add CreateAccount
```

```shell
dotnet ef database update
```

A new table called Account will now be setup on your database. Start up the app and go to the following page - https://localhost:5001/Accounts. You should notice that we were able to see this page without actually being logged in. This is something we need to fix. 
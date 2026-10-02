using System;
using System.IO;
using System.Reflection;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration.UserSecrets;
using SupportToolsServerDbPart.Db;
using SupportToolsServerDbTools.DbMigration;
using SupportToolsServerDbTools.FakeHost;
using Xunit;

namespace SupportToolsServerDbTools.Tests.FakeHost;

//The factory reads the connection string from the FakeHost user secrets, which are looked up under %APPDATA%.
//The tests point APPDATA at a temporary folder with a made-up secrets file, so the developer's own secrets are never read
public sealed class SupportToolsServerDesignTimeDbContextFactoryTests : IDisposable
{
    private const string AppDataVariable = "APPDATA";

    //A string that is valid only in format: the context never connects to a database
    private const string ConnectionString =
        "Server=localhost;Database=SupportToolsServerDbToolsTests;Trusted_Connection=True";

    private readonly string _appData =
        Path.Combine(Path.GetTempPath(), "StsDbToolsTests", Guid.NewGuid().ToString("N"));

    private readonly string? _originalAppData = Environment.GetEnvironmentVariable(AppDataVariable);

    public SupportToolsServerDesignTimeDbContextFactoryTests()
    {
        string userSecretsId = typeof(SupportToolsServerDesignTimeDbContextFactory).Assembly
            .GetCustomAttribute<UserSecretsIdAttribute>()!.UserSecretsId;
        string secretsFolder = Path.Combine(_appData, "Microsoft", "UserSecrets", userSecretsId);
        Directory.CreateDirectory(secretsFolder);
        File.WriteAllText(Path.Combine(secretsFolder, "secrets.json"),
            $$"""{ "ConnectionString": "{{ConnectionString}}" }""");
        Environment.SetEnvironmentVariable(AppDataVariable, _appData);
    }

    public void Dispose()
    {
        Environment.SetEnvironmentVariable(AppDataVariable, _originalAppData);
        Directory.Delete(_appData, true);
    }

    [Fact]
    public void CreateDbContext_ReadsTheConnectionStringFromTheUserSecrets()
    {
        var sut = new SupportToolsServerDesignTimeDbContextFactory();

        using SupportToolsServerDbContext context = sut.CreateDbContext([]);

        //EF Core returns the connection string normalized (Server → Data Source), so its parts are compared
        var connectionString = new SqlConnectionStringBuilder(context.Database.GetConnectionString());
        Assert.Equal("localhost", connectionString.DataSource);
        Assert.Equal("SupportToolsServerDbToolsTests", connectionString.InitialCatalog);
    }

    [Fact]
    public void CreateDbContext_TakesTheMigrationsFromTheDbMigrationAssembly()
    {
        var sut = new SupportToolsServerDesignTimeDbContextFactory();

        using SupportToolsServerDbContext context = sut.CreateDbContext([]);

        Assert.Same(AssemblyReference.Assembly, context.GetService<IMigrationsAssembly>().Assembly);
    }
}

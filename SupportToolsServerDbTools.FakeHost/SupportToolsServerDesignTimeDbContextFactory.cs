using Microsoft.EntityFrameworkCore;
using SupportToolsServerDbPart.Db;
using SupportToolsServerDbTools.DbMigration;
using SystemTools.DatabaseToolsShared;

namespace SupportToolsServerDbTools.FakeHost;

//ეს კლასი საჭიროა იმისათვის, რომ შესაძლებელი გახდეს მიგრაციასთან მუშაობა.
//ანუ დეველოპერ ბაზის წაშლა და ახლიდან დაგენერირება, ან მიგრაციაში ცვლილებების გაკეთება
// ReSharper disable once UnusedType.Global
public sealed class SupportToolsServerDesignTimeDbContextFactory : SqlServerDesignTimeDbContextFactory<
    SupportToolsServerDbContext>
{
    //ConnectionString, როგორც დაცული ინფორმაცია, მოდის FakeHost-ის User Secrets-იდან (UserSecretsId წერია csproj-ში).
    //კონსტრუქტორი აუცილებლად უპარამეტრო უნდა იყოს, რადგან dotnet ef ამ კლასს თვითონ ქმნის რეფლექსიით
    // ReSharper disable once ConvertToPrimaryConstructor
    public SupportToolsServerDesignTimeDbContextFactory() : base(AssemblyReference.Assembly.GetName().Name!,
        "ConnectionString", true)
    {
    }

    protected override SupportToolsServerDbContext CreateDbContext(
        DbContextOptions<SupportToolsServerDbContext> options)
    {
        // ReSharper disable once DisposableConstructor
        return new SupportToolsServerDbContext(options);
    }
}

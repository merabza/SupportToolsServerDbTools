# SupportToolsServerDbTools

EF Core migrations tooling of [SupportToolsServer](https://github.com/merabza/SupportToolsServer): the migrations assembly for `SupportToolsServerDbContext` (defined in [SupportToolsServerDbPart](https://github.com/merabza/SupportToolsServerDbPart)) and the fake web host that `dotnet ef` uses as its startup project.

| Project | Purpose |
|---|---|
| `SupportToolsServerDbTools.DbMigration` | Migrations assembly: the `Migrations` folder plus `AssemblyReference` |
| `SupportToolsServerDbTools.FakeHost` | Minimal web host used only as the `dotnet ef` startup project; `SupportToolsServerDesignTimeDbContextFactory` creates the context at design time |

The design-time factory reads the connection string from the FakeHost project's User Secrets (`ConnectionString` key; the `UserSecretsId` is in `SupportToolsServerDbTools.FakeHost.csproj`):

```powershell
dotnet user-secrets set ConnectionString "<connection string>" --project SupportToolsServerDbTools.FakeHost
```

## Migrations

```powershell
dotnet ef migrations add <Name> --project SupportToolsServerDbTools.DbMigration --startup-project SupportToolsServerDbTools.FakeHost
dotnet ef database update --project SupportToolsServerDbTools.DbMigration --startup-project SupportToolsServerDbTools.FakeHost
```

## Repository layout — sibling repos are required

Projects reference sibling clones by relative path (`..\..\SupportToolsServerDbPart\...`, `..\..\SupportToolsServer\...`, `..\..\SystemTools\...`), so the repositories must be cloned next to each other:

```
<root>\
├── SupportToolsServerDbTools\   this repository (SupportToolsServerDbTools.slnx lives here)
├── SupportToolsServerDbPart\    SupportToolsServerDbContext and entity configurations (merabza/SupportToolsServerDbPart)
├── SupportToolsServer\          domain entities and application abstractions (merabza/SupportToolsServer)
├── SupportToolsServerShared\    API contracts (merabza/SupportToolsServerShared)
└── SystemTools\                 shared libraries (merabza/SystemTools)
```

## Build

```powershell
dotnet build SupportToolsServerDbTools.slnx
```

## License

[MIT](LICENSE)

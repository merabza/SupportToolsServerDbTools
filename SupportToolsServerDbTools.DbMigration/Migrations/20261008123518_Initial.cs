using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiClients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Server = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ApiKey = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DotnetTools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PackageId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxVersion = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotnetTools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EditorConfigFileTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65536, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorConfigFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Environments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileStorages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileStoragePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FileNameMaxLength = table.Column<int>(type: "int", nullable: false),
                    FileSizeSplitPositionInRow = table.Column<int>(type: "int", nullable: false),
                    FtpSiteLsFileOffset = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStorages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GitIgnoreFileTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 16384, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitIgnoreFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NpmPackages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(214)", maxLength: 214, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpmPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReactAppTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Template = table.Column<string>(type: "nvarchar(214)", maxLength: 214, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactAppTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Runtimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runtimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartSchemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastPreserveCount = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartSchemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoredFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sha256 = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    UpdatedAtUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseServerConnections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatabaseServerProvider = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DbWebAgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RemoteDbConnectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServerAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    WindowsNtIntegratedSecurity = table.Column<bool>(type: "bit", nullable: false),
                    ServerUser = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ServerPass = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TrustServerCertificate = table.Column<bool>(type: "bit", nullable: false),
                    ConnectionTimeOut = table.Column<int>(type: "int", nullable: false),
                    Encrypt = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseServerConnections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatabaseServerConnections_ApiClients_DbWebAgentId",
                        column: x => x.DbWebAgentId,
                        principalTable: "ApiClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GitRepos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FolderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GitIgnoreFileTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepos_GitIgnoreFileTypes_GitIgnoreFileTypeId",
                        column: x => x.GitIgnoreFileTypeId,
                        principalTable: "GitIgnoreFileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SupportProjectType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TestProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TestProjectShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UseDatabase = table.Column<bool>(type: "bit", nullable: false),
                    UseDbPartFolderForDatabaseProjects = table.Column<bool>(type: "bit", nullable: false),
                    UseMenu = table.Column<bool>(type: "bit", nullable: false),
                    UseHttps = table.Column<bool>(type: "bit", nullable: false),
                    UseReact = table.Column<bool>(type: "bit", nullable: false),
                    UseCarcass = table.Column<bool>(type: "bit", nullable: false),
                    UseIdentity = table.Column<bool>(type: "bit", nullable: false),
                    UseReCounter = table.Column<bool>(type: "bit", nullable: false),
                    UseSignalR = table.Column<bool>(type: "bit", nullable: false),
                    UseFluentValidation = table.Column<bool>(type: "bit", nullable: false),
                    ReactTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTemplates_ReactAppTemplates_ReactTemplateId",
                        column: x => x.ReactTemplateId,
                        principalTable: "ReactAppTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WebAgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WebAgentInstallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilesUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    FilesUsersGroupName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    RuntimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServerSideDownloadFolder = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    ServerSideDeployFolder = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_ApiClients_WebAgentId",
                        column: x => x.WebAgentId,
                        principalTable: "ApiClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servers_ApiClients_WebAgentInstallerId",
                        column: x => x.WebAgentInstallerId,
                        principalTable: "ApiClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servers_Runtimes_RuntimeId",
                        column: x => x.RuntimeId,
                        principalTable: "Runtimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GlobalSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceDescriptionSignature = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UploadTempExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProgramArchiveDateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProgramArchiveExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParametersFileDateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParametersFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MediatRLicenseKey = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    FileStorageForExchangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SmartSchemaForExchangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SmartSchemaForLocalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocalPackageManagerWebApiClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatabasesBackupFilesExchange_DownloadTempExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DatabasesBackupFilesExchange_UploadTempExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DatabasesBackupFilesExchange_ExchangeFileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatabasesBackupFilesExchange_ExchangeSmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatabasesBackupFilesExchange_LocalSmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalSettings", x => x.Id);
                    table.CheckConstraint("CK_GlobalSettings_Singleton", "[Id] = '00000000-0000-0000-0000-000000000001'");
                    table.ForeignKey(
                        name: "FK_GlobalSettings_ApiClients_LocalPackageManagerWebApiClientId",
                        column: x => x.LocalPackageManagerWebApiClientId,
                        principalTable: "ApiClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_FileStorages_DatabasesBackupFilesExchange_ExchangeFileStorageId",
                        column: x => x.DatabasesBackupFilesExchange_ExchangeFileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_FileStorages_FileStorageForExchangeId",
                        column: x => x.FileStorageForExchangeId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_SmartSchemas_DatabasesBackupFilesExchange_ExchangeSmartSchemaId",
                        column: x => x.DatabasesBackupFilesExchange_ExchangeSmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_SmartSchemas_DatabasesBackupFilesExchange_LocalSmartSchemaId",
                        column: x => x.DatabasesBackupFilesExchange_LocalSmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_SmartSchemas_SmartSchemaForExchangeId",
                        column: x => x.SmartSchemaForExchangeId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalSettings_SmartSchemas_SmartSchemaForLocalId",
                        column: x => x.SmartSchemaForLocalId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmartSchemaDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PreserveCount = table.Column<int>(type: "int", nullable: false),
                    SmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartSchemaDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmartSchemaDetails_SmartSchemas_SmartSchemaId",
                        column: x => x.SmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseFoldersSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Backup = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    Data = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    DataLog = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    DatabaseServerConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseFoldersSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatabaseFoldersSets_DatabaseServerConnections_DatabaseServerConnectionId",
                        column: x => x.DatabaseServerConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MajorVersion = table.Column<int>(type: "int", nullable: false),
                    MinorVersion = table.Column<int>(type: "int", nullable: false),
                    UseAlternativeWebAgent = table.Column<bool>(type: "bit", nullable: false),
                    EditorConfigFileTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MainProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApiContractsProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SpaProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DbContextName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProjectShortPrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ScaffoldSeederProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DbContextProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewDataSeedingClassLibProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProgramArchiveDateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProgramArchiveExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParametersFileDateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParametersFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectFolderName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    SolutionFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    ProjectSecurityFolderPath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    MigrationStartupProjectFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    MigrationProjectFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    DataSeederRulesByTableStartupProjectFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    OldDataConvertorForDataSeeder = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    SeedProjectFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    SeedProjectParametersFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    ExcludesRulesParametersFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    AppSetEnKeysJsonFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    MigrationSqlFilesFolder = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    PrepareProdCopyDatabaseProjectFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    PrepareProdCopyDatabaseProjectParametersFilePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    PairedDbObjectsResultFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    KeyGuidPart = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DevDatabaseParameters_DbConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DevDatabaseParameters_DatabaseRecoveryModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DevDatabaseParameters_DbServerFoldersSetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DevDatabaseParameters_DatabaseName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DevDatabaseParameters_SmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DevDatabaseParameters_FileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DevDatabaseParameters_CommandTimeOut = table.Column<int>(type: "int", nullable: true),
                    DevDatabaseParameters_SkipBackupBeforeRestore = table.Column<bool>(type: "bit", nullable: true),
                    DevDatabaseParameters_BackupNamePrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DevDatabaseParameters_DateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DevDatabaseParameters_BackupFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DevDatabaseParameters_BackupNameMiddlePart = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DevDatabaseParameters_Compress = table.Column<bool>(type: "bit", nullable: true),
                    DevDatabaseParameters_Verify = table.Column<bool>(type: "bit", nullable: true),
                    DevDatabaseParameters_BackupType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdCopyDatabaseParameters_DbConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdCopyDatabaseParameters_DatabaseRecoveryModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdCopyDatabaseParameters_DbServerFoldersSetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdCopyDatabaseParameters_DatabaseName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ProdCopyDatabaseParameters_SmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdCopyDatabaseParameters_FileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdCopyDatabaseParameters_CommandTimeOut = table.Column<int>(type: "int", nullable: true),
                    ProdCopyDatabaseParameters_SkipBackupBeforeRestore = table.Column<bool>(type: "bit", nullable: true),
                    ProdCopyDatabaseParameters_BackupNamePrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProdCopyDatabaseParameters_DateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdCopyDatabaseParameters_BackupFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdCopyDatabaseParameters_BackupNameMiddlePart = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProdCopyDatabaseParameters_Compress = table.Column<bool>(type: "bit", nullable: true),
                    ProdCopyDatabaseParameters_Verify = table.Column<bool>(type: "bit", nullable: true),
                    ProdCopyDatabaseParameters_BackupType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_DatabaseServerConnections_DevDatabaseParameters_DbConnectionId",
                        column: x => x.DevDatabaseParameters_DbConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_DatabaseServerConnections_ProdCopyDatabaseParameters_DbConnectionId",
                        column: x => x.ProdCopyDatabaseParameters_DbConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_EditorConfigFileTypes_EditorConfigFileTypeId",
                        column: x => x.EditorConfigFileTypeId,
                        principalTable: "EditorConfigFileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_FileStorages_DevDatabaseParameters_FileStorageId",
                        column: x => x.DevDatabaseParameters_FileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_FileStorages_ProdCopyDatabaseParameters_FileStorageId",
                        column: x => x.ProdCopyDatabaseParameters_FileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_SmartSchemas_DevDatabaseParameters_SmartSchemaId",
                        column: x => x.DevDatabaseParameters_SmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_SmartSchemas_ProdCopyDatabaseParameters_SmartSchemaId",
                        column: x => x.ProdCopyDatabaseParameters_SmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GitRepoProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GitRepoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectRelativePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    ProjectFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepoProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepoProjects_GitRepos_GitRepoId",
                        column: x => x.GitRepoId,
                        principalTable: "GitRepos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCreatorSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndentSize = table.Column<int>(type: "int", nullable: false),
                    FakeHostProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProjectsFolderPathReal = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    SecretsFolderPathReal = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    ProductionServerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductionEnvironmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeveloperDbConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DatabaseExchangeFileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UseSmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCreatorSettings", x => x.Id);
                    table.CheckConstraint("CK_ProjectCreatorSettings_Singleton", "[Id] = '00000000-0000-0000-0000-000000000001'");
                    table.ForeignKey(
                        name: "FK_ProjectCreatorSettings_DatabaseServerConnections_DeveloperDbConnectionId",
                        column: x => x.DeveloperDbConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectCreatorSettings_Environments_ProductionEnvironmentId",
                        column: x => x.ProductionEnvironmentId,
                        principalTable: "Environments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectCreatorSettings_FileStorages_DatabaseExchangeFileStorageId",
                        column: x => x.DatabaseExchangeFileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectCreatorSettings_Servers_ProductionServerId",
                        column: x => x.ProductionServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectCreatorSettings_SmartSchemas_UseSmartSchemaId",
                        column: x => x.UseSmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAllowedTools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToolName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAllowedTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectAllowedTools_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectEndpoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EndpointName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EndpointRoute = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RequireAuthorization = table.Column<bool>(type: "bit", nullable: false),
                    HttpMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EndpointType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReturnType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SendMessageToCurrentUser = table.Column<bool>(type: "bit", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectEndpoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectEndpoints_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGitRepos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GitRepoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGitRepos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectGitRepos_GitRepos_GitRepoId",
                        column: x => x.GitRepoId,
                        principalTable: "GitRepos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectGitRepos_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectNpmPackages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NpmPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNpmPackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectNpmPackages_NpmPackages_NpmPackageId",
                        column: x => x.NpmPackageId,
                        principalTable: "NpmPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectNpmPackages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRedundantFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRedundantFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectRedundantFiles_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRouteClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Root = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApiVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Base = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRouteClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectRouteClasses_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnvironmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebAgentForCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServerSidePort = table.Column<int>(type: "int", nullable: false),
                    ApiVersionId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AppSettingsJsonSourceFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    AppSettingsEncodedJsonFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    ServiceUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CurrentDatabaseParameters_DbConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentDatabaseParameters_DatabaseRecoveryModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentDatabaseParameters_DbServerFoldersSetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentDatabaseParameters_DatabaseName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CurrentDatabaseParameters_SmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentDatabaseParameters_FileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentDatabaseParameters_CommandTimeOut = table.Column<int>(type: "int", nullable: true),
                    CurrentDatabaseParameters_SkipBackupBeforeRestore = table.Column<bool>(type: "bit", nullable: true),
                    CurrentDatabaseParameters_BackupNamePrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrentDatabaseParameters_DateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentDatabaseParameters_BackupFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentDatabaseParameters_BackupNameMiddlePart = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrentDatabaseParameters_Compress = table.Column<bool>(type: "bit", nullable: true),
                    CurrentDatabaseParameters_Verify = table.Column<bool>(type: "bit", nullable: true),
                    CurrentDatabaseParameters_BackupType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewDatabaseParameters_DbConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NewDatabaseParameters_DatabaseRecoveryModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewDatabaseParameters_DbServerFoldersSetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewDatabaseParameters_DatabaseName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NewDatabaseParameters_SmartSchemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NewDatabaseParameters_FileStorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NewDatabaseParameters_CommandTimeOut = table.Column<int>(type: "int", nullable: true),
                    NewDatabaseParameters_SkipBackupBeforeRestore = table.Column<bool>(type: "bit", nullable: true),
                    NewDatabaseParameters_BackupNamePrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewDatabaseParameters_DateMask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewDatabaseParameters_BackupFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewDatabaseParameters_BackupNameMiddlePart = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewDatabaseParameters_Compress = table.Column<bool>(type: "bit", nullable: true),
                    NewDatabaseParameters_Verify = table.Column<bool>(type: "bit", nullable: true),
                    NewDatabaseParameters_BackupType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerInfos_ApiClients_WebAgentForCheckId",
                        column: x => x.WebAgentForCheckId,
                        principalTable: "ApiClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_DatabaseServerConnections_CurrentDatabaseParameters_DbConnectionId",
                        column: x => x.CurrentDatabaseParameters_DbConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_DatabaseServerConnections_NewDatabaseParameters_DbConnectionId",
                        column: x => x.NewDatabaseParameters_DbConnectionId,
                        principalTable: "DatabaseServerConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_Environments_EnvironmentId",
                        column: x => x.EnvironmentId,
                        principalTable: "Environments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_FileStorages_CurrentDatabaseParameters_FileStorageId",
                        column: x => x.CurrentDatabaseParameters_FileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_FileStorages_NewDatabaseParameters_FileStorageId",
                        column: x => x.NewDatabaseParameters_FileStorageId,
                        principalTable: "FileStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerInfos_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_SmartSchemas_CurrentDatabaseParameters_SmartSchemaId",
                        column: x => x.CurrentDatabaseParameters_SmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerInfos_SmartSchemas_NewDatabaseParameters_SmartSchemaId",
                        column: x => x.NewDatabaseParameters_SmartSchemaId,
                        principalTable: "SmartSchemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GitRepoProjectDependencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GitRepoProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepoProjectDependencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepoProjectDependencies_GitRepoProjects_GitRepoProjectId",
                        column: x => x.GitRepoProjectId,
                        principalTable: "GitRepoProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerInfoAllowedTools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToolName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServerInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerInfoAllowedTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerInfoAllowedTools_ServerInfos_ServerInfoId",
                        column: x => x.ServerInfoId,
                        principalTable: "ServerInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiClients_Name",
                table: "ApiClients",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseFoldersSets_DatabaseServerConnectionId_Name",
                table: "DatabaseFoldersSets",
                columns: new[] { "DatabaseServerConnectionId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseServerConnections_DbWebAgentId",
                table: "DatabaseServerConnections",
                column: "DbWebAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseServerConnections_Name",
                table: "DatabaseServerConnections",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DotnetTools_Name",
                table: "DotnetTools",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditorConfigFileTypes_Name",
                table: "EditorConfigFileTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Environments_Name",
                table: "Environments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileStorages_Name",
                table: "FileStorages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitIgnoreFileTypes_Name",
                table: "GitIgnoreFileTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitRepoProjectDependencies_GitRepoProjectId_ProjectName",
                table: "GitRepoProjectDependencies",
                columns: new[] { "GitRepoProjectId", "ProjectName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitRepoProjects_GitRepoId_ProjectRelativePath_ProjectFileName",
                table: "GitRepoProjects",
                columns: new[] { "GitRepoId", "ProjectRelativePath", "ProjectFileName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitRepos_Address",
                table: "GitRepos",
                column: "Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitRepos_GitIgnoreFileTypeId",
                table: "GitRepos",
                column: "GitIgnoreFileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GitRepos_Name",
                table: "GitRepos",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_DatabasesBackupFilesExchange_ExchangeFileStorageId",
                table: "GlobalSettings",
                column: "DatabasesBackupFilesExchange_ExchangeFileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_DatabasesBackupFilesExchange_ExchangeSmartSchemaId",
                table: "GlobalSettings",
                column: "DatabasesBackupFilesExchange_ExchangeSmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_DatabasesBackupFilesExchange_LocalSmartSchemaId",
                table: "GlobalSettings",
                column: "DatabasesBackupFilesExchange_LocalSmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_FileStorageForExchangeId",
                table: "GlobalSettings",
                column: "FileStorageForExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_LocalPackageManagerWebApiClientId",
                table: "GlobalSettings",
                column: "LocalPackageManagerWebApiClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_SmartSchemaForExchangeId",
                table: "GlobalSettings",
                column: "SmartSchemaForExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalSettings_SmartSchemaForLocalId",
                table: "GlobalSettings",
                column: "SmartSchemaForLocalId");

            migrationBuilder.CreateIndex(
                name: "IX_NpmPackages_Name",
                table: "NpmPackages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAllowedTools_ProjectId_ToolName",
                table: "ProjectAllowedTools",
                columns: new[] { "ProjectId", "ToolName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCreatorSettings_DatabaseExchangeFileStorageId",
                table: "ProjectCreatorSettings",
                column: "DatabaseExchangeFileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCreatorSettings_DeveloperDbConnectionId",
                table: "ProjectCreatorSettings",
                column: "DeveloperDbConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCreatorSettings_ProductionEnvironmentId",
                table: "ProjectCreatorSettings",
                column: "ProductionEnvironmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCreatorSettings_ProductionServerId",
                table: "ProjectCreatorSettings",
                column: "ProductionServerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCreatorSettings_UseSmartSchemaId",
                table: "ProjectCreatorSettings",
                column: "UseSmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEndpoints_ProjectId_Name",
                table: "ProjectEndpoints",
                columns: new[] { "ProjectId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGitRepos_GitRepoId",
                table: "ProjectGitRepos",
                column: "GitRepoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGitRepos_ProjectId_GitRepoId_Kind",
                table: "ProjectGitRepos",
                columns: new[] { "ProjectId", "GitRepoId", "Kind" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNpmPackages_NpmPackageId",
                table: "ProjectNpmPackages",
                column: "NpmPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNpmPackages_ProjectId_NpmPackageId",
                table: "ProjectNpmPackages",
                columns: new[] { "ProjectId", "NpmPackageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRedundantFiles_ProjectId_FileName",
                table: "ProjectRedundantFiles",
                columns: new[] { "ProjectId", "FileName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRouteClasses_ProjectId_Name",
                table: "ProjectRouteClasses",
                columns: new[] { "ProjectId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DevDatabaseParameters_DbConnectionId",
                table: "Projects",
                column: "DevDatabaseParameters_DbConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DevDatabaseParameters_FileStorageId",
                table: "Projects",
                column: "DevDatabaseParameters_FileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DevDatabaseParameters_SmartSchemaId",
                table: "Projects",
                column: "DevDatabaseParameters_SmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_EditorConfigFileTypeId",
                table: "Projects",
                column: "EditorConfigFileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Name",
                table: "Projects",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProdCopyDatabaseParameters_DbConnectionId",
                table: "Projects",
                column: "ProdCopyDatabaseParameters_DbConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProdCopyDatabaseParameters_FileStorageId",
                table: "Projects",
                column: "ProdCopyDatabaseParameters_FileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProdCopyDatabaseParameters_SmartSchemaId",
                table: "Projects",
                column: "ProdCopyDatabaseParameters_SmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTemplates_Name",
                table: "ProjectTemplates",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTemplates_ReactTemplateId",
                table: "ProjectTemplates",
                column: "ReactTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactAppTemplates_Name",
                table: "ReactAppTemplates",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runtimes_Name",
                table: "Runtimes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfoAllowedTools_ServerInfoId_ToolName",
                table: "ServerInfoAllowedTools",
                columns: new[] { "ServerInfoId", "ToolName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_CurrentDatabaseParameters_DbConnectionId",
                table: "ServerInfos",
                column: "CurrentDatabaseParameters_DbConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_CurrentDatabaseParameters_FileStorageId",
                table: "ServerInfos",
                column: "CurrentDatabaseParameters_FileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_CurrentDatabaseParameters_SmartSchemaId",
                table: "ServerInfos",
                column: "CurrentDatabaseParameters_SmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_EnvironmentId",
                table: "ServerInfos",
                column: "EnvironmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_NewDatabaseParameters_DbConnectionId",
                table: "ServerInfos",
                column: "NewDatabaseParameters_DbConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_NewDatabaseParameters_FileStorageId",
                table: "ServerInfos",
                column: "NewDatabaseParameters_FileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_NewDatabaseParameters_SmartSchemaId",
                table: "ServerInfos",
                column: "NewDatabaseParameters_SmartSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_ProjectId_ServerId_EnvironmentId",
                table: "ServerInfos",
                columns: new[] { "ProjectId", "ServerId", "EnvironmentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_ServerId",
                table: "ServerInfos",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerInfos_WebAgentForCheckId",
                table: "ServerInfos",
                column: "WebAgentForCheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_Name",
                table: "Servers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servers_RuntimeId",
                table: "Servers",
                column: "RuntimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_WebAgentId",
                table: "Servers",
                column: "WebAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_WebAgentInstallerId",
                table: "Servers",
                column: "WebAgentInstallerId");

            migrationBuilder.CreateIndex(
                name: "IX_SmartSchemaDetails_SmartSchemaId_PeriodType",
                table: "SmartSchemaDetails",
                columns: new[] { "SmartSchemaId", "PeriodType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SmartSchemas_Name",
                table: "SmartSchemas",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoredFiles_Path",
                table: "StoredFiles",
                column: "Path",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatabaseFoldersSets");

            migrationBuilder.DropTable(
                name: "DotnetTools");

            migrationBuilder.DropTable(
                name: "GitRepoProjectDependencies");

            migrationBuilder.DropTable(
                name: "GlobalSettings");

            migrationBuilder.DropTable(
                name: "ProjectAllowedTools");

            migrationBuilder.DropTable(
                name: "ProjectCreatorSettings");

            migrationBuilder.DropTable(
                name: "ProjectEndpoints");

            migrationBuilder.DropTable(
                name: "ProjectGitRepos");

            migrationBuilder.DropTable(
                name: "ProjectNpmPackages");

            migrationBuilder.DropTable(
                name: "ProjectRedundantFiles");

            migrationBuilder.DropTable(
                name: "ProjectRouteClasses");

            migrationBuilder.DropTable(
                name: "ProjectTemplates");

            migrationBuilder.DropTable(
                name: "ServerInfoAllowedTools");

            migrationBuilder.DropTable(
                name: "SmartSchemaDetails");

            migrationBuilder.DropTable(
                name: "StoredFiles");

            migrationBuilder.DropTable(
                name: "GitRepoProjects");

            migrationBuilder.DropTable(
                name: "NpmPackages");

            migrationBuilder.DropTable(
                name: "ReactAppTemplates");

            migrationBuilder.DropTable(
                name: "ServerInfos");

            migrationBuilder.DropTable(
                name: "GitRepos");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "GitIgnoreFileTypes");

            migrationBuilder.DropTable(
                name: "DatabaseServerConnections");

            migrationBuilder.DropTable(
                name: "EditorConfigFileTypes");

            migrationBuilder.DropTable(
                name: "FileStorages");

            migrationBuilder.DropTable(
                name: "SmartSchemas");

            migrationBuilder.DropTable(
                name: "Runtimes");

            migrationBuilder.DropTable(
                name: "ApiClients");
        }
    }
}

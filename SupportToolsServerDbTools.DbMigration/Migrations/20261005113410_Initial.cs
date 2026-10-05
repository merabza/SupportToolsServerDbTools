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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatabaseFoldersSets");

            migrationBuilder.DropTable(
                name: "DotnetTools");

            migrationBuilder.DropTable(
                name: "EditorConfigFileTypes");

            migrationBuilder.DropTable(
                name: "GitRepos");

            migrationBuilder.DropTable(
                name: "GlobalSettings");

            migrationBuilder.DropTable(
                name: "NpmPackages");

            migrationBuilder.DropTable(
                name: "ProjectCreatorSettings");

            migrationBuilder.DropTable(
                name: "ProjectTemplates");

            migrationBuilder.DropTable(
                name: "SmartSchemaDetails");

            migrationBuilder.DropTable(
                name: "GitIgnoreFileTypes");

            migrationBuilder.DropTable(
                name: "DatabaseServerConnections");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.DropTable(
                name: "FileStorages");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "ReactAppTemplates");

            migrationBuilder.DropTable(
                name: "SmartSchemas");

            migrationBuilder.DropTable(
                name: "ApiClients");

            migrationBuilder.DropTable(
                name: "Runtimes");
        }
    }
}

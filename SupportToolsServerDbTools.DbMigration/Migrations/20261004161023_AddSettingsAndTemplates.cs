using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddSettingsAndTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalSettings");

            migrationBuilder.DropTable(
                name: "ProjectCreatorSettings");

            migrationBuilder.DropTable(
                name: "ProjectTemplates");
        }
    }
}

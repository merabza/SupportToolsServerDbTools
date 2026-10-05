using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAllowedTools_ProjectId_ToolName",
                table: "ProjectAllowedTools",
                columns: new[] { "ProjectId", "ToolName" },
                unique: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectAllowedTools");

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
                name: "Projects");
        }
    }
}

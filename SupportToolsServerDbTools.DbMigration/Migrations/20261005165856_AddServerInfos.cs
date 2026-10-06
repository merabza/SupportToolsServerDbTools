using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddServerInfos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerInfoAllowedTools");

            migrationBuilder.DropTable(
                name: "ServerInfos");
        }
    }
}

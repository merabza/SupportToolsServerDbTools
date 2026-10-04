using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddInfrastructureResources : Migration
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
                name: "IX_FileStorages_Name",
                table: "FileStorages",
                column: "Name",
                unique: true);

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
                name: "FileStorages");

            migrationBuilder.DropTable(
                name: "SmartSchemaDetails");

            migrationBuilder.DropTable(
                name: "DatabaseServerConnections");

            migrationBuilder.DropTable(
                name: "SmartSchemas");

            migrationBuilder.DropTable(
                name: "ApiClients");
        }
    }
}

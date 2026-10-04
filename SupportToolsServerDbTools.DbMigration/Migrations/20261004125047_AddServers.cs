using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddServers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}

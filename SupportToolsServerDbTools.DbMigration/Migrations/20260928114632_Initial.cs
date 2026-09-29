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
                name: "GitIgnoreFileTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 16384, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitIgnoreFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GitRepos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FolderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GitIgnoreFileTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitRepos");

            migrationBuilder.DropTable(
                name: "GitIgnoreFileTypes");
        }
    }
}

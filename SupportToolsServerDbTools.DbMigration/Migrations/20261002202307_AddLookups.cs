using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddLookups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_DotnetTools_Name",
                table: "DotnetTools",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NpmPackages_Name",
                table: "NpmPackages",
                column: "Name",
                unique: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DotnetTools");

            migrationBuilder.DropTable(
                name: "NpmPackages");

            migrationBuilder.DropTable(
                name: "ReactAppTemplates");

            migrationBuilder.DropTable(
                name: "Runtimes");
        }
    }
}

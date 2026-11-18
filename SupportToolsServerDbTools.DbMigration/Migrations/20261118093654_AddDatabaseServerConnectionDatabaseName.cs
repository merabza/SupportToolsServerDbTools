using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations;

/// <inheritdoc />
public partial class _20261118093654_AddDatabaseServerConnectionDatabaseName : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "DatabaseName",
            table: "DatabaseServerConnections",
            type: "nvarchar(128)",
            maxLength: 128,
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "DatabaseName",
            table: "DatabaseServerConnections");
    }
}

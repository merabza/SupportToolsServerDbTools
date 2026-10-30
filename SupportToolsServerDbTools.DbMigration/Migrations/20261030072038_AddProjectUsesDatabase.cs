using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectUsesDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UsesDatabase",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsesDatabase",
                table: "Projects");
        }
    }
}

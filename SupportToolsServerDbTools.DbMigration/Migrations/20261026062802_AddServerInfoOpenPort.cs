using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddServerInfoOpenPort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OpenPort",
                table: "ServerInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenPort",
                table: "ServerInfos");
        }
    }
}

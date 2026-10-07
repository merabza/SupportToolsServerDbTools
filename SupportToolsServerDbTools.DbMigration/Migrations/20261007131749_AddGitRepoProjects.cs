using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddGitRepoProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GitRepoProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GitRepoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectRelativePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false),
                    ProjectFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepoProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepoProjects_GitRepos_GitRepoId",
                        column: x => x.GitRepoId,
                        principalTable: "GitRepos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GitRepoProjectDependencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GitRepoProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepoProjectDependencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepoProjectDependencies_GitRepoProjects_GitRepoProjectId",
                        column: x => x.GitRepoProjectId,
                        principalTable: "GitRepoProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GitRepoProjectDependencies_GitRepoProjectId_ProjectName",
                table: "GitRepoProjectDependencies",
                columns: new[] { "GitRepoProjectId", "ProjectName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GitRepoProjects_GitRepoId_ProjectRelativePath_ProjectFileName",
                table: "GitRepoProjects",
                columns: new[] { "GitRepoId", "ProjectRelativePath", "ProjectFileName" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitRepoProjectDependencies");

            migrationBuilder.DropTable(
                name: "GitRepoProjects");
        }
    }
}

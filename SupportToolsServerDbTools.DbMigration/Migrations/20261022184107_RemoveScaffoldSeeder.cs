using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportToolsServerDbTools.DbMigration.Migrations
{
    /// <inheritdoc />
    public partial class RemoveScaffoldSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //ScaffoldSeeder-ის მექანიზმი წაიშალა: scaffold seeder-ის git-ები (Kind = ScaffoldSeed) და წაშლილი
            //ხელსაწყოების სახელები (კლიენტის ფაილი მათ 7-10 ნომრებად ინახავდა) აღარ გამოიყენება. git-ები Kind-ის
            //სვეტის წაშლამდე იშლება: ერთი git პროექტში ორივე როლში შეიძლება ყოფილიყო, ახალი უნიკალური ინდექსი კი
            //(ProjectId, GitRepoId)-ია. პროექტების ვერსია არ იცვლება: კლიენტი ამ მნიშვნელობებს უკვე აღარ კითხულობს.
            //EXEC: idempotent სკრიპტი ბრძანებას იმ ბაზაშიც აკომპილირებს, სადაც მიგრაცია უკვე გაშვებულია და Kind-ის
            //სვეტი აღარ არის (Invalid column name)
            migrationBuilder.Sql("EXEC(N'DELETE FROM [ProjectGitRepos] WHERE [Kind] = N''ScaffoldSeed''');");
            migrationBuilder.Sql(
                "DELETE FROM [ProjectAllowedTools] WHERE [ToolName] IN (N'JsonFromProjectDbProjectGetter', " +
                "N'ScaffoldSeederCreator', N'SeedData', N'PrepareProdCopyDatabase', N'7', N'8', N'9', N'10');");

            migrationBuilder.DropIndex(
                name: "IX_ProjectGitRepos_ProjectId_GitRepoId_Kind",
                table: "ProjectGitRepos");

            migrationBuilder.DropColumn(
                name: "DbContextProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExcludesRulesParametersFilePath",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MigrationSqlFilesFolder",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "NewDataSeedingClassLibProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PrepareProdCopyDatabaseProjectFilePath",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PrepareProdCopyDatabaseProjectParametersFilePath",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectShortPrefix",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ScaffoldSeederProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SeedProjectFilePath",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SeedProjectParametersFilePath",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Kind",
                table: "ProjectGitRepos");

            migrationBuilder.DropColumn(
                name: "FakeHostProjectName",
                table: "ProjectCreatorSettings");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGitRepos_ProjectId_GitRepoId",
                table: "ProjectGitRepos",
                columns: new[] { "ProjectId", "GitRepoId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectGitRepos_ProjectId_GitRepoId",
                table: "ProjectGitRepos");

            migrationBuilder.AddColumn<string>(
                name: "DbContextProjectName",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExcludesRulesParametersFilePath",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MigrationSqlFilesFolder",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewDataSeedingClassLibProjectName",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrepareProdCopyDatabaseProjectFilePath",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrepareProdCopyDatabaseProjectParametersFilePath",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectShortPrefix",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScaffoldSeederProjectName",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeedProjectFilePath",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeedProjectParametersFilePath",
                table: "Projects",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true);

            //დარჩენილი git-ები პროექტის git-ებია (Main). წაშლილი ScaffoldSeed git-ები და ხელსაწყოები არ ბრუნდება
            migrationBuilder.AddColumn<string>(
                name: "Kind",
                table: "ProjectGitRepos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Main");

            migrationBuilder.AddColumn<string>(
                name: "FakeHostProjectName",
                table: "ProjectCreatorSettings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGitRepos_ProjectId_GitRepoId_Kind",
                table: "ProjectGitRepos",
                columns: new[] { "ProjectId", "GitRepoId", "Kind" },
                unique: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyBallers.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TouchdownsScoredLastYear",
                table: "FantasyTeams",
                newName: "TouchdownsLastYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TouchdownsLastYear",
                table: "FantasyTeams",
                newName: "TouchdownsScoredLastYear");
        }
    }
}

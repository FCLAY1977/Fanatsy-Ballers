using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyBallers.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FantasyTeams",
                columns: table => new
                {
                    QB1 = table.Column<string>(type: "TEXT", nullable: false),
                    QB2 = table.Column<string>(type: "TEXT", nullable: true),
                    RB1 = table.Column<string>(type: "TEXT", nullable: true),
                    RB2 = table.Column<string>(type: "TEXT", nullable: true),
                    WR1 = table.Column<string>(type: "TEXT", nullable: true),
                    WR2 = table.Column<string>(type: "TEXT", nullable: true),
                    TE = table.Column<string>(type: "TEXT", nullable: true),
                    Flex = table.Column<string>(type: "TEXT", nullable: true),
                    Kicker = table.Column<string>(type: "TEXT", nullable: true),
                    Defense = table.Column<string>(type: "TEXT", nullable: true),
                    SkillLevel = table.Column<double>(type: "REAL", nullable: true),
                    TouchdownsScoredLastYear = table.Column<int>(type: "INTEGER", nullable: true),
                    TouchDownsProjected = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FantasyTeams", x => x.QB1);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FantasyTeams");
        }
    }
}

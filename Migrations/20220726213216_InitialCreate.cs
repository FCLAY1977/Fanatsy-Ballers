using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyBallers.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FantasyTeams",
                table: "FantasyTeams");

            migrationBuilder.AlterColumn<string>(
                name: "QB1",
                table: "FantasyTeams",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "FantasyTeams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FantasyTeams",
                table: "FantasyTeams",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FantasyTeams",
                table: "FantasyTeams");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "FantasyTeams");

            migrationBuilder.AlterColumn<string>(
                name: "QB1",
                table: "FantasyTeams",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FantasyTeams",
                table: "FantasyTeams",
                column: "QB1");
        }
    }
}

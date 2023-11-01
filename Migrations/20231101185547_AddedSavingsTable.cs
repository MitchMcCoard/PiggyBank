using Microsoft.EntityFrameworkCore.Migrations;

namespace PiggyBank.Migrations
{
    public partial class AddedSavingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavingsGoals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    GoalPrice = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LinkToPage = table.Column<string>(nullable: true),
                    LinkToImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsGoals", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavingsGoals");
        }
    }
}

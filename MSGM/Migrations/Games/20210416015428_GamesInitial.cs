using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class GamesInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GenreGames = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DtLaunch = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SM = table.Column<string>(type: "varchar(50)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Developer = table.Column<string>(type: "varchar(150)", nullable: false),
                    Available = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GamesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}

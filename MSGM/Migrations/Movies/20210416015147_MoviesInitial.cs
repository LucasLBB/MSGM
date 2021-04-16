using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class MoviesInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GenreMovies = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DtLaunch = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Duration = table.Column<string>(type: "varchar(50)", nullable: false),
                    Producer = table.Column<string>(type: "varchar(50)", nullable: false),
                    MainCharacters = table.Column<string>(type: "varchar(150)", nullable: false),
                    Available = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MoviesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

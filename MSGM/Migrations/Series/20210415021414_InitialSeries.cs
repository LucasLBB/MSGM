using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class InitialSeries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GenreSeries = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DtLaunch = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Seasons = table.Column<string>(type: "varchar(50)", nullable: false),
                    Producer = table.Column<string>(type: "varchar(50)", nullable: false),
                    Available = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}

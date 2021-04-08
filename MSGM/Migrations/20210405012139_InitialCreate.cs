using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    MusicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GenreMusic = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DtLancamento = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Singer = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LinkMusic = table.Column<string>(type: "varchar(150)", nullable: false),
                    Available = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.MusicId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}

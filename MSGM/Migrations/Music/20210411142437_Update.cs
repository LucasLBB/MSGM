using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DtLancamento",
                table: "Musics",
                newName: "DtLaunch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DtLaunch",
                table: "Musics",
                newName: "DtLancamento");
        }
    }
}

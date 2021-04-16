using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class UpdateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "GenreMusic",
                table: "Musics",
                nullable: false
                );

            migrationBuilder.AlterColumn<string>(
                name: "DtLaunch",
                table: "Musics",
                nullable: false
                );

            migrationBuilder.AlterColumn<string>(
                name: "Singer",
                table: "Musics",
                nullable: false
                );

            migrationBuilder.AlterColumn<string>(
                name: "LinkMusic",
                table: "Musics",
                nullable: false
                );

            migrationBuilder.AlterColumn<string>(
                name: "Available",
                table: "Musics",
                nullable: false
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

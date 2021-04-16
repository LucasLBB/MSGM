using Microsoft.EntityFrameworkCore.Migrations;

namespace MSGM.Migrations
{
    public partial class CreateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "Name",
               table: "Musics",
               type: "varchar(100)",
               nullable: false
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

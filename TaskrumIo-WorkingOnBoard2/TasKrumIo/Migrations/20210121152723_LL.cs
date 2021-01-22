using Microsoft.EntityFrameworkCore.Migrations;

namespace TasKrumIo.Migrations
{
    public partial class LL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SS",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SS",
                table: "AspNetUsers");
        }
    }
}

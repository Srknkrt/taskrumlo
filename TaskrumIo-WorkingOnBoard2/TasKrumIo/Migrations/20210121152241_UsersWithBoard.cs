using Microsoft.EntityFrameworkCore.Migrations;

namespace TasKrumIo.Migrations
{
    public partial class UsersWithBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TasKrumIoUserId",
                table: "Board",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Board_TasKrumIoUserId",
                table: "Board",
                column: "TasKrumIoUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Board_AspNetUsers_TasKrumIoUserId",
                table: "Board",
                column: "TasKrumIoUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Board_AspNetUsers_TasKrumIoUserId",
                table: "Board");

            migrationBuilder.DropIndex(
                name: "IX_Board_TasKrumIoUserId",
                table: "Board");

            migrationBuilder.DropColumn(
                name: "TasKrumIoUserId",
                table: "Board");
        }
    }
}

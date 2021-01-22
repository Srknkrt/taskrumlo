using Microsoft.EntityFrameworkCore.Migrations;

namespace TasKrumIo.Migrations
{
    public partial class BoardsUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SS",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BoardsId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BoardsId",
                table: "AspNetUsers",
                column: "BoardsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Board_BoardsId",
                table: "AspNetUsers",
                column: "BoardsId",
                principalTable: "Board",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Board_BoardsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BoardsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BoardsId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "TasKrumIoUserId",
                table: "Board",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SS",
                table: "AspNetUsers",
                type: "nvarchar(max)",
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
    }
}

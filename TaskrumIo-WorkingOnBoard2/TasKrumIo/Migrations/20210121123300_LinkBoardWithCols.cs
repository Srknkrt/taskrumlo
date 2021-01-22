using Microsoft.EntityFrameworkCore.Migrations;

namespace TasKrumIo.Migrations
{
    public partial class LinkBoardWithCols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Columns",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Columns_BoardId",
                table: "Columns",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Board_BoardId",
                table: "Columns",
                column: "BoardId",
                principalTable: "Board",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Board_BoardId",
                table: "Columns");

            migrationBuilder.DropIndex(
                name: "IX_Columns_BoardId",
                table: "Columns");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Columns");
        }
    }
}

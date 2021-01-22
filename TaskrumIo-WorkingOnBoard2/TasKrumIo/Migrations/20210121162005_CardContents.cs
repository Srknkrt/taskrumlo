using Microsoft.EntityFrameworkCore.Migrations;

namespace TasKrumIo.Migrations
{
    public partial class CardContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardContentsId",
                table: "Cards",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CardContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardContents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardContentsId",
                table: "Cards",
                column: "CardContentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardContents_CardContentsId",
                table: "Cards",
                column: "CardContentsId",
                principalTable: "CardContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardContents_CardContentsId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "CardContents");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardContentsId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardContentsId",
                table: "Cards");
        }
    }
}

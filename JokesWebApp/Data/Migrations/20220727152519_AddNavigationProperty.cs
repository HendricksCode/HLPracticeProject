using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWebApp.Data.Migrations
{
    public partial class AddNavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Joke_CategoryId",
                table: "Joke",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_Category_CategoryId",
                table: "Joke",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_Category_CategoryId",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_CategoryId",
                table: "Joke");
        }
    }
}

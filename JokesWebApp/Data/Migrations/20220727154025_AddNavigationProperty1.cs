using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWebApp.Data.Migrations
{
    public partial class AddNavigationProperty1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_Category_CategoryId",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_CategoryId",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Joke");

            migrationBuilder.AddColumn<int>(
                name: "JokeId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Category_JokeId",
                table: "Category",
                column: "JokeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Joke_JokeId",
                table: "Category",
                column: "JokeId",
                principalTable: "Joke",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Joke_JokeId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_JokeId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "JokeId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Joke",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}

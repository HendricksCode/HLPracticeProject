using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWebApp.Data.Migrations
{
    public partial class AddedCategoryClasstoJokeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "JokeCategoryCategoryId",
                table: "Joke",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Joke_JokeCategoryCategoryId",
                table: "Joke",
                column: "JokeCategoryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_Category_JokeCategoryCategoryId",
                table: "Joke",
                column: "JokeCategoryCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_Category_JokeCategoryCategoryId",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_JokeCategoryCategoryId",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "JokeCategoryCategoryId",
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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class nn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyChildren_MyUsers_UserId",
                table: "MyChildren");

            migrationBuilder.DropIndex(
                name: "IX_MyChildren_UserId",
                table: "MyChildren");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MyChildren_UserId",
                table: "MyChildren",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyChildren_MyUsers_UserId",
                table: "MyChildren",
                column: "UserId",
                principalTable: "MyUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

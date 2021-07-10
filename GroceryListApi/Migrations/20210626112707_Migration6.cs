using Microsoft.EntityFrameworkCore.Migrations;

namespace GoceryListApi.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Items_ListId",
                table: "Items",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Lists_ListId",
                table: "Items",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Lists_ListId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ListId",
                table: "Items");
        }
    }
}

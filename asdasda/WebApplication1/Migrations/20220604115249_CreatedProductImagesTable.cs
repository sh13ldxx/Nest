using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreatedProductImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutcImage_Products_ProductId",
                table: "ProdutcImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutcImage",
                table: "ProdutcImage");

            migrationBuilder.RenameTable(
                name: "ProdutcImage",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutcImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProdutcImage");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProdutcImage",
                newName: "IX_ProdutcImage_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutcImage",
                table: "ProdutcImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutcImage_Products_ProductId",
                table: "ProdutcImage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

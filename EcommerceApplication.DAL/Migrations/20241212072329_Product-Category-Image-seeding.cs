using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceApplication.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategoryImageseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/I/61SaQ1G5wtL._SY466_.jpg", 1 },
                    { 2, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1572016258i/41438058.jpg", 2 },
                    { 3, "https://m.media-amazon.com/images/I/61SaQ1G5wtL._SY466_.jpg", 3 },
                    { 4, "https://m.media-amazon.com/images/I/61SaQ1G5wtL._SY466_.jpg", 4 },
                    { 5, "https://m.media-amazon.com/images/I/61SaQ1G5wtL._SY466_.jpg", 5 },
                    { 6, "https://m.media-amazon.com/images/I/61SaQ1G5wtL._SY466_.jpg", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

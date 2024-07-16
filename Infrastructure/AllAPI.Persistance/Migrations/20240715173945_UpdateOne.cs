using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllAPI.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8799), "Tools & Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8838), "Music, Sports & Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8851), "Computers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9139), "Velit eaque qui için layıkıyla.", "Cesurca." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9202), "Ullam gül mi sıla neque.", "Et." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9268), "Commodi lakin çorba iusto adipisci.", "Cesurca." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 916, DateTimeKind.Local).AddTicks(3289), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0.4584361401855090m, 231.72m, "Intelligent Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 39, 44, 916, DateTimeKind.Local).AddTicks(3339), 0.05727024137525870m, 928.36m, "Tasty Cotton Shoes" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5779), "Beauty, Baby & Electronics" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5800), "Health & Kids" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5811), "Tools" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3841), "Quis karşıdakine nostrum suscipit velit.", "Vel." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3889), "Velit orta accusantium ea değirmeni.", "Orta." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3934), "Ve dolor çobanın quia oldular.", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 888, DateTimeKind.Local).AddTicks(8208), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0.08956610587998550m, 486.03m, "Refined Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 42, 8, 888, DateTimeKind.Local).AddTicks(8244), 0.7180795257501260m, 112.42m, "Handcrafted Fresh Sausages" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}

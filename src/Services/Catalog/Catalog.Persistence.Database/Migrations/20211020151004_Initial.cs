using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 411m },
                    { 73, "Description for product 73", "Product 73", 838m },
                    { 72, "Description for product 72", "Product 72", 187m },
                    { 71, "Description for product 71", "Product 71", 729m },
                    { 70, "Description for product 70", "Product 70", 377m },
                    { 69, "Description for product 69", "Product 69", 647m },
                    { 68, "Description for product 68", "Product 68", 808m },
                    { 67, "Description for product 67", "Product 67", 647m },
                    { 66, "Description for product 66", "Product 66", 517m },
                    { 65, "Description for product 65", "Product 65", 698m },
                    { 64, "Description for product 64", "Product 64", 747m },
                    { 63, "Description for product 63", "Product 63", 152m },
                    { 62, "Description for product 62", "Product 62", 384m },
                    { 61, "Description for product 61", "Product 61", 621m },
                    { 60, "Description for product 60", "Product 60", 529m },
                    { 59, "Description for product 59", "Product 59", 280m },
                    { 58, "Description for product 58", "Product 58", 713m },
                    { 57, "Description for product 57", "Product 57", 878m },
                    { 56, "Description for product 56", "Product 56", 412m },
                    { 55, "Description for product 55", "Product 55", 622m },
                    { 54, "Description for product 54", "Product 54", 329m },
                    { 53, "Description for product 53", "Product 53", 765m },
                    { 74, "Description for product 74", "Product 74", 965m },
                    { 52, "Description for product 52", "Product 52", 467m },
                    { 75, "Description for product 75", "Product 75", 908m },
                    { 77, "Description for product 77", "Product 77", 309m },
                    { 98, "Description for product 98", "Product 98", 141m },
                    { 97, "Description for product 97", "Product 97", 448m },
                    { 96, "Description for product 96", "Product 96", 843m },
                    { 95, "Description for product 95", "Product 95", 416m },
                    { 94, "Description for product 94", "Product 94", 263m },
                    { 93, "Description for product 93", "Product 93", 666m },
                    { 92, "Description for product 92", "Product 92", 224m },
                    { 91, "Description for product 91", "Product 91", 532m },
                    { 90, "Description for product 90", "Product 90", 716m },
                    { 89, "Description for product 89", "Product 89", 847m },
                    { 88, "Description for product 88", "Product 88", 653m },
                    { 87, "Description for product 87", "Product 87", 513m },
                    { 86, "Description for product 86", "Product 86", 651m },
                    { 85, "Description for product 85", "Product 85", 794m },
                    { 84, "Description for product 84", "Product 84", 266m },
                    { 83, "Description for product 83", "Product 83", 962m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 528m },
                    { 81, "Description for product 81", "Product 81", 438m },
                    { 80, "Description for product 80", "Product 80", 314m },
                    { 79, "Description for product 79", "Product 79", 196m },
                    { 78, "Description for product 78", "Product 78", 838m },
                    { 76, "Description for product 76", "Product 76", 560m },
                    { 51, "Description for product 51", "Product 51", 265m },
                    { 50, "Description for product 50", "Product 50", 767m },
                    { 49, "Description for product 49", "Product 49", 607m },
                    { 22, "Description for product 22", "Product 22", 998m },
                    { 21, "Description for product 21", "Product 21", 961m },
                    { 20, "Description for product 20", "Product 20", 136m },
                    { 19, "Description for product 19", "Product 19", 902m },
                    { 18, "Description for product 18", "Product 18", 531m },
                    { 17, "Description for product 17", "Product 17", 935m },
                    { 16, "Description for product 16", "Product 16", 567m },
                    { 15, "Description for product 15", "Product 15", 688m },
                    { 14, "Description for product 14", "Product 14", 677m },
                    { 13, "Description for product 13", "Product 13", 277m },
                    { 12, "Description for product 12", "Product 12", 530m },
                    { 11, "Description for product 11", "Product 11", 697m },
                    { 10, "Description for product 10", "Product 10", 717m },
                    { 9, "Description for product 9", "Product 9", 707m },
                    { 8, "Description for product 8", "Product 8", 986m },
                    { 7, "Description for product 7", "Product 7", 854m },
                    { 6, "Description for product 6", "Product 6", 611m },
                    { 5, "Description for product 5", "Product 5", 991m },
                    { 4, "Description for product 4", "Product 4", 215m },
                    { 3, "Description for product 3", "Product 3", 360m },
                    { 2, "Description for product 2", "Product 2", 632m },
                    { 23, "Description for product 23", "Product 23", 753m },
                    { 24, "Description for product 24", "Product 24", 647m },
                    { 25, "Description for product 25", "Product 25", 934m },
                    { 26, "Description for product 26", "Product 26", 561m },
                    { 48, "Description for product 48", "Product 48", 562m },
                    { 47, "Description for product 47", "Product 47", 222m },
                    { 46, "Description for product 46", "Product 46", 720m },
                    { 45, "Description for product 45", "Product 45", 551m },
                    { 44, "Description for product 44", "Product 44", 915m },
                    { 43, "Description for product 43", "Product 43", 789m },
                    { 42, "Description for product 42", "Product 42", 501m },
                    { 41, "Description for product 41", "Product 41", 228m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 937m },
                    { 39, "Description for product 39", "Product 39", 692m },
                    { 99, "Description for product 99", "Product 99", 316m },
                    { 38, "Description for product 38", "Product 38", 847m },
                    { 36, "Description for product 36", "Product 36", 411m },
                    { 35, "Description for product 35", "Product 35", 129m },
                    { 34, "Description for product 34", "Product 34", 469m },
                    { 33, "Description for product 33", "Product 33", 882m },
                    { 32, "Description for product 32", "Product 32", 279m },
                    { 31, "Description for product 31", "Product 31", 118m },
                    { 30, "Description for product 30", "Product 30", 959m },
                    { 29, "Description for product 29", "Product 29", 933m },
                    { 28, "Description for product 28", "Product 28", 569m },
                    { 27, "Description for product 27", "Product 27", 990m },
                    { 37, "Description for product 37", "Product 37", 837m },
                    { 100, "Description for product 100", "Product 100", 133m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "Id", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 38 },
                    { 73, 73, 66 },
                    { 72, 72, 60 },
                    { 71, 71, 85 },
                    { 70, 70, 21 },
                    { 69, 69, 55 },
                    { 68, 68, 50 },
                    { 67, 67, 7 },
                    { 66, 66, 85 },
                    { 65, 65, 86 },
                    { 64, 64, 99 },
                    { 63, 63, 93 },
                    { 62, 62, 31 },
                    { 61, 61, 67 },
                    { 60, 60, 87 },
                    { 59, 59, 74 },
                    { 58, 58, 40 },
                    { 57, 57, 35 },
                    { 56, 56, 26 },
                    { 55, 55, 94 },
                    { 54, 54, 88 },
                    { 53, 53, 22 },
                    { 74, 74, 99 },
                    { 52, 52, 19 },
                    { 75, 75, 16 },
                    { 77, 77, 35 },
                    { 98, 98, 77 },
                    { 97, 97, 3 },
                    { 96, 96, 71 },
                    { 95, 95, 85 },
                    { 94, 94, 31 },
                    { 93, 93, 29 },
                    { 92, 92, 54 },
                    { 91, 91, 35 },
                    { 90, 90, 23 },
                    { 89, 89, 18 },
                    { 88, 88, 39 },
                    { 87, 87, 98 },
                    { 86, 86, 12 },
                    { 85, 85, 67 },
                    { 84, 84, 43 },
                    { 83, 83, 15 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "Id", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 16 },
                    { 81, 81, 86 },
                    { 80, 80, 2 },
                    { 79, 79, 56 },
                    { 78, 78, 78 },
                    { 76, 76, 4 },
                    { 51, 51, 69 },
                    { 50, 50, 51 },
                    { 49, 49, 15 },
                    { 22, 22, 11 },
                    { 21, 21, 1 },
                    { 20, 20, 19 },
                    { 19, 19, 52 },
                    { 18, 18, 86 },
                    { 17, 17, 65 },
                    { 16, 16, 79 },
                    { 15, 15, 92 },
                    { 14, 14, 5 },
                    { 13, 13, 62 },
                    { 12, 12, 35 },
                    { 11, 11, 6 },
                    { 10, 10, 18 },
                    { 9, 9, 36 },
                    { 8, 8, 87 },
                    { 7, 7, 62 },
                    { 6, 6, 67 },
                    { 5, 5, 13 },
                    { 4, 4, 80 },
                    { 3, 3, 7 },
                    { 2, 2, 90 },
                    { 23, 23, 55 },
                    { 24, 24, 67 },
                    { 25, 25, 5 },
                    { 26, 26, 25 },
                    { 48, 48, 83 },
                    { 47, 47, 39 },
                    { 46, 46, 2 },
                    { 45, 45, 10 },
                    { 44, 44, 77 },
                    { 43, 43, 76 },
                    { 42, 42, 96 },
                    { 41, 41, 2 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "Id", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 53 },
                    { 39, 39, 19 },
                    { 99, 99, 90 },
                    { 38, 38, 4 },
                    { 36, 36, 71 },
                    { 35, 35, 50 },
                    { 34, 34, 12 },
                    { 33, 33, 28 },
                    { 32, 32, 20 },
                    { 31, 31, 31 },
                    { 30, 30, 36 },
                    { 29, 29, 94 },
                    { 28, 28, 31 },
                    { 27, 27, 99 },
                    { 37, 37, 94 },
                    { 100, 100, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                schema: "Catalog",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Id",
                schema: "Catalog",
                table: "Stocks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}

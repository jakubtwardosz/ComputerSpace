using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerSpace.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Biznesowy laptop Lenovo ThinkBook 15 to styl i wydajność w klasie premium.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg", 9.99m, "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Laptop Dell Vostro 3510 znakomicie spisuje się zarówno w biurze, jak i poza nim.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg", 6.99m, "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "HP Neverstop 1200w to idealne rozwiązanie, gdy musisz szybko wydrukować bądź skopiować dokumenty przed wyjściem albo prowadzisz małą firmę i potrzebujesz od czasu do czasu skorzystać ze skanera.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg", 4.99m, "HP Neverstop 1200w WiFi Mono USB LCD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

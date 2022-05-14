using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerSpace.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 3699.00m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 3599.00m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 1079.00m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 649.00m);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 5, 1, "Elegancja do pary z wygodą użytkowania? To właśnie oferuje ultramobilny laptop ASUS ZenBook 14 UM425QA, który świetnie sprawdzi się zarówno jako narzędzie do pracy, jak i multimedialne centrum rozrywki, na którym zobaczysz kolejne sezony swoich ulubionych seriali.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_6_15_20_38_82_00.jpg", 4299.00m, "ASUS ZenBook 14 UM425QA R5-5600H/16GB/512/Win11" },
                    { 6, 2, "Wszechstronne urządzenie wielofunkcyjne Epson EcoTank L6290 pozwoli Ci zaoszczędzić czas i zredukować koszty zarówno w domu, jak i małej firmie. Wysoka ekonomia pracy i energooszczędność idą w parze jakością oraz szybkością zarówno kopiowania, skanowania, jak i wydruku.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_21_10_29_7_52_00.jpg", 1899.00m, "Epson EcoTank L6290" },
                    { 7, 2, "Urządzenie wielofunkcyjne Brother DCP-1623W zostało zaprojektowane, aby sprostać wymaganiom domowym, choć świetnie sprawdzi się też w małym biurze.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2018/5/pr_2018_5_29_10_21_26_78_00.jpg", 899.00m, "Brother DCP-1623WE" },
                    { 8, 3, "Nowy system dwóch aparatów pozwala uchwycić więcej. Najszybszy czip w historii smartfonów i bateria na cały dzień – jeszcze więcej zdziałać. A dzięki wideo o jakości nieosiągalnej dla żadnego innego smartfona zapisane wspomnienia będą wyglądać piękniej niż kiedykolwiek.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_11_9_8_14_748_00.jpg", 2599.00m, "Apple iPhone 11 64GB Black" },
                    { 9, 3, "Motorola Edge 30 5G 128 GB Aurora Green to moc dostosowana do potrzeb każdego użytkownika. Dzięki pojemnej baterii i funkcji szybkiego ładowania masz pewność, że w kluczowych momentach nigdy nie zabraknie Ci mocy.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_5_14_5_52_38_05.jpg", 2199.00m, "Motorola Edge 30 5G 8/128GB Aurora Green 144Hz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 9.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 6.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 4.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 4.99m);
        }
    }
}

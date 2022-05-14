namespace ComputerSpace.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Laptopy",
                    Url = "laptopy"
                },
                new Category
                {
                    Id = 2,
                    Name = "Drukarki",
                    Url = "drukarki"
                },
                new Category
                {
                    Id = 3,
                    Name = "Smartfony",
                    Url = "smartfony"
                });


            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P",
                    Description = "Biznesowy laptop Lenovo ThinkBook 15 to styl i wydajność w klasie premium.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg",
                    Price = 3699.00m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                    Description = "Laptop Dell Vostro 3510 znakomicie spisuje się zarówno w biurze, jak i poza nim.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",
                    Price = 3599.00m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 3,
                    Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                    Description = "HP Neverstop 1200w to idealne rozwiązanie, gdy musisz szybko wydrukować bądź skopiować dokumenty przed wyjściem albo prowadzisz małą firmę i potrzebujesz od czasu do czasu skorzystać ze skanera.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                    Price = 1079.00m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 4,
                    Title = "Xiaomi Redmi 9C NFC 3/64GB Midnight Grey",
                    Description = "Wybierz Xiaomi Redmi 9C NFC szary i poczuj różnicę. Duży ekran o przekątnej 6,53” wyświetli obraz bogaty w żywe kolory. Świetne zdjęcia niezależnie od sytuacji wykonasz przy użyciu systemu 2 aparatów umieszczonych na tylnej obudowie.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/7/pr_2021_7_8_9_2_28_148_00.jpg",
                    Price = 649.00m,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 5,
                    Title = "ASUS ZenBook 14 UM425QA R5-5600H/16GB/512/Win11",
                    Description = "Elegancja do pary z wygodą użytkowania? To właśnie oferuje ultramobilny laptop ASUS ZenBook 14 UM425QA, który świetnie sprawdzi się zarówno jako narzędzie do pracy, jak i multimedialne centrum rozrywki, na którym zobaczysz kolejne sezony swoich ulubionych seriali.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_6_15_20_38_82_00.jpg",
                    Price = 4299.00m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 6,
                    Title = "Epson EcoTank L6290",
                    Description = "Wszechstronne urządzenie wielofunkcyjne Epson EcoTank L6290 pozwoli Ci zaoszczędzić czas i zredukować koszty zarówno w domu, jak i małej firmie. Wysoka ekonomia pracy i energooszczędność idą w parze jakością oraz szybkością zarówno kopiowania, skanowania, jak i wydruku.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_21_10_29_7_52_00.jpg",
                    Price = 1899.00m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 7,
                    Title = "Brother DCP-1623WE",
                    Description = "Urządzenie wielofunkcyjne Brother DCP-1623W zostało zaprojektowane, aby sprostać wymaganiom domowym, choć świetnie sprawdzi się też w małym biurze.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2018/5/pr_2018_5_29_10_21_26_78_00.jpg",
                    Price = 899.00m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 8,
                    Title = "Apple iPhone 11 64GB Black",
                    Description = "Nowy system dwóch aparatów pozwala uchwycić więcej. Najszybszy czip w historii smartfonów i bateria na cały dzień – jeszcze więcej zdziałać. A dzięki wideo o jakości nieosiągalnej dla żadnego innego smartfona zapisane wspomnienia będą wyglądać piękniej niż kiedykolwiek.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_11_9_8_14_748_00.jpg",
                    Price = 2599.00m,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 9,
                    Title = "Motorola Edge 30 5G 8/128GB Aurora Green 144Hz",
                    Description = "Motorola Edge 30 5G 128 GB Aurora Green to moc dostosowana do potrzeb każdego użytkownika. Dzięki pojemnej baterii i funkcji szybkiego ładowania masz pewność, że w kluczowych momentach nigdy nie zabraknie Ci mocy.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_5_14_5_52_38_05.jpg",
                    Price = 2199.00m,
                    CategoryId = 3,
                });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

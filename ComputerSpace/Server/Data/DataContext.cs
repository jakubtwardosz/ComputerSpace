namespace ComputerSpace.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });
            
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "Paperback" },
                    new ProductType { Id = 3, Name = "E-Book" },
                    new ProductType { Id = 4, Name = "Audiobook" },
                    new ProductType { Id = 5, Name = "Stream" },
                    new ProductType { Id = 6, Name = "Blu-ray" },
                    new ProductType { Id = 7, Name = "VHS" },
                    new ProductType { Id = 8, Name = "PC" },
                    new ProductType { Id = 9, Name = "PlayStation" },
                    new ProductType { Id = 10, Name = "Xbox" }
                );

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
                },
                new Category
                {
                    Id = 4,
                    Name = "Programy",
                    Url = "programy"
                });


            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P",
                    Description = "Biznesowy laptop Lenovo ThinkBook 15 to styl i wydajność w klasie premium.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                    Description = "Laptop Dell Vostro 3510 znakomicie spisuje się zarówno w biurze, jak i poza nim.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",

                    CategoryId = 1,
                },
                new Product
                {
                    Id = 3,
                    Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                    Description = "HP Neverstop 1200w to idealne rozwiązanie, gdy musisz szybko wydrukować bądź skopiować dokumenty przed wyjściem albo prowadzisz małą firmę i potrzebujesz od czasu do czasu skorzystać ze skanera.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 4,
                    Title = "Xiaomi Redmi 9C NFC 3/64GB Midnight Grey",
                    Description = "Wybierz Xiaomi Redmi 9C NFC szary i poczuj różnicę. Duży ekran o przekątnej 6,53” wyświetli obraz bogaty w żywe kolory. Świetne zdjęcia niezależnie od sytuacji wykonasz przy użyciu systemu 2 aparatów umieszczonych na tylnej obudowie.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/7/pr_2021_7_8_9_2_28_148_00.jpg",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = 5,
                    Title = "ASUS ZenBook 14 UM425QA R5-5600H/16GB/512/Win11",
                    Description = "Elegancja do pary z wygodą użytkowania? To właśnie oferuje ultramobilny laptop ASUS ZenBook 14 UM425QA, który świetnie sprawdzi się zarówno jako narzędzie do pracy, jak i multimedialne centrum rozrywki, na którym zobaczysz kolejne sezony swoich ulubionych seriali.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_6_15_20_38_82_00.jpg",

                    CategoryId = 1,
                },
                new Product
                {
                    Id = 6,
                    Title = "Epson EcoTank L6290",
                    Description = "Wszechstronne urządzenie wielofunkcyjne Epson EcoTank L6290 pozwoli Ci zaoszczędzić czas i zredukować koszty zarówno w domu, jak i małej firmie. Wysoka ekonomia pracy i energooszczędność idą w parze jakością oraz szybkością zarówno kopiowania, skanowania, jak i wydruku.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_21_10_29_7_52_00.jpg",

                    CategoryId = 2,
                },
                new Product
                {
                    Id = 7,
                    Title = "Brother DCP-1623WE",
                    Description = "Urządzenie wielofunkcyjne Brother DCP-1623W zostało zaprojektowane, aby sprostać wymaganiom domowym, choć świetnie sprawdzi się też w małym biurze.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2018/5/pr_2018_5_29_10_21_26_78_00.jpg",

                    CategoryId = 2,
                },
                new Product
                {
                    Id = 8,
                    Title = "Apple iPhone 11 64GB Black",
                    Description = "Nowy system dwóch aparatów pozwala uchwycić więcej. Najszybszy czip w historii smartfonów i bateria na cały dzień – jeszcze więcej zdziałać. A dzięki wideo o jakości nieosiągalnej dla żadnego innego smartfona zapisane wspomnienia będą wyglądać piękniej niż kiedykolwiek.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_11_9_8_14_748_00.jpg",

                    CategoryId = 3,
                },
                new Product
                {
                    Id = 9,
                    Title = "Motorola Edge 30 5G 8/128GB Aurora Green 144Hz",
                    Description = "Motorola Edge 30 5G 128 GB Aurora Green to moc dostosowana do potrzeb każdego użytkownika. Dzięki pojemnej baterii i funkcji szybkiego ładowania masz pewność, że w kluczowych momentach nigdy nie zabraknie Ci mocy.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_5_14_5_52_38_05.jpg",

                    CategoryId = 3,
                },
                new Product
                {
                    Id = 10,
                    Title = "Microsoft Office Home & Business 2021",
                    Description = "Microsoft Office Home & Business 2021 to dobrze znane narzędzia zwiększające produktywność, które udoskonaliliśmy, aby jeszcze lepiej pomagać Ci organizować pracę, tworzyć treści i współpracować.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_13_14_20_18_226_00.jpg",

                    CategoryId = 4,
                },
                new Product
                {
                    Id = 11,
                    Title = "NortonLifeLock 360 Standard 1st. (12m)",
                    Description = "Produkt Norton 360 oferuje komputerowi PC, Mac®, smartfonowi lub tabletowi ochronę w czasie rzeczywistym przed oprogramowaniem wymuszającym okup, wirusami, programami typu spyware, wyłudzaniem danych i innymi zagrożeniami pochodzącymi z Internetu, monitoruje nieautoryzowany ruch i blokuje go oraz pomaga chronić dane osobowe i finansowe w Internecie.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2020/3/pr_2020_3_3_10_4_35_199_00.jpg",

                    CategoryId = 4,
                });

            modelBuilder.Entity<ProductVariant>().HasData(
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 3,
                Price = 7.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 4,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                ProductTypeId = 2,
                Price = 7.99m,
                OriginalPrice = 14.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                ProductTypeId = 2,
                Price = 6.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 5,
                Price = 3.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 6,
                Price = 9.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 7,
                Price = 19.99m
            },
            new ProductVariant
            {
                ProductId = 5,
                ProductTypeId = 5,
                Price = 3.99m,
            },
            new ProductVariant
            {
                ProductId = 6,
                ProductTypeId = 5,
                Price = 2.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 8,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 9,
                Price = 69.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 10,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant
            {
                ProductId = 8,
                ProductTypeId = 8,
                Price = 9.99m,
                OriginalPrice = 24.99m,
            },
            new ProductVariant
            {
                ProductId = 9,
                ProductTypeId = 8,
                Price = 14.99m
            },
            new ProductVariant
            {
                ProductId = 10,
                ProductTypeId = 1,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 11,
                ProductTypeId = 1,
                Price = 79.99m,
                OriginalPrice = 399m
            }
        );

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }




    }
}

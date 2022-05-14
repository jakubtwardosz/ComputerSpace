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
                    Price = 9.99m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                    Description = "Laptop Dell Vostro 3510 znakomicie spisuje się zarówno w biurze, jak i poza nim.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",
                    Price = 6.99m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 3,
                    Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                    Description = "HP Neverstop 1200w to idealne rozwiązanie, gdy musisz szybko wydrukować bądź skopiować dokumenty przed wyjściem albo prowadzisz małą firmę i potrzebujesz od czasu do czasu skorzystać ze skanera.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                    Price = 4.99m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 4,
                    Title = "Xiaomi Redmi 9C NFC 3/64GB Midnight Grey",
                    Description = "Wybierz Xiaomi Redmi 9C NFC szary i poczuj różnicę. Duży ekran o przekątnej 6,53” wyświetli obraz bogaty w żywe kolory. Świetne zdjęcia niezależnie od sytuacji wykonasz przy użyciu systemu 2 aparatów umieszczonych na tylnej obudowie.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/7/pr_2021_7_8_9_2_28_148_00.jpg",
                    Price = 4.99m,
                    CategoryId = 3,
                });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

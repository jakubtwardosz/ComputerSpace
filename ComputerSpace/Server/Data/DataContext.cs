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
                    new ProductType { Id = 1, Name = "Product type 1" },
                    new ProductType { Id = 2, Name = "Product type 2" },
                    new ProductType { Id = 3, Name = "Product type 3" },
                    new ProductType { Id = 4, Name = "Product type 4" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Laptops",
                    Url = "laptops"
                },
                new Category
                {
                    Id = 2,
                    Name = "Printers",
                    Url = "printers"
                },
                new Category
                {
                    Id = 3,
                    Name = "Smartphones",
                    Url = "smartphones"
                },
                new Category
                {
                    Id = 4,
                    Name = "Software",
                    Url = "software"
                });


            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 3,
                    Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 4,
                    Title = "Xiaomi Redmi 9C NFC 3/64GB Midnight Grey",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/7/pr_2021_7_8_9_2_28_148_00.jpg",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = 5,
                    Title = "ASUS ZenBook 14 UM425QA R5-5600H/16GB/512/Win11",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_6_15_20_38_82_00.jpg",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 6,
                    Title = "Epson EcoTank L6290",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_21_10_29_7_52_00.jpg",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 7,
                    Title = "Brother DCP-1623WE",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2018/5/pr_2018_5_29_10_21_26_78_00.jpg",
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 8,
                    Title = "Apple iPhone 11 64GB Black",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_11_9_8_14_748_00.jpg",
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 9,
                    Title = "Motorola Edge 30 5G 8/128GB Aurora Green 144Hz",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_5_14_5_52_38_05.jpg",
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 10,
                    Title = "Microsoft Office Home & Business 2021",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_13_14_20_18_226_00.jpg",
                    CategoryId = 4,
                },
                new Product
                {
                    Id = 11,
                    Title = "NortonLifeLock 360 Standard 1st. (12m)",
                    Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                    ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2020/3/pr_2020_3_3_10_4_35_199_00.jpg",
                    CategoryId = 4,
                });

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 399.00m,
                    OriginalPrice = 499.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 599.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 3,
                    Price = 249.00m,
                    OriginalPrice = 299.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 199.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    OriginalPrice = 399.00m,
                    Price = 349.00m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 2,
                    Price = 199.00m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 3,
                    Price = 299.00m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 4,
                    Price = 499.00m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 1,
                    OriginalPrice = 399.00m,
                    Price = 388.00m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 2,
                    Price = 249.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 3,
                    OriginalPrice = 49.99m,
                    Price = 39.99m
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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}

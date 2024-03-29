﻿// <auto-generated />
using System;
using ComputerSpace.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputerSpace.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComputerSpace.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ComputerSpace.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Laptops",
                            Url = "laptops",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Printers",
                            Url = "printers",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Smartphones",
                            Url = "smartphones",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            Name = "Software",
                            Url = "software",
                            Visible = true
                        });
                });

            modelBuilder.Entity("ComputerSpace.Shared.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ComputerSpace.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = true,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg",
                            Title = "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",
                            Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = true,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                            Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = true,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/7/pr_2021_7_8_9_2_28_148_00.jpg",
                            Title = "Xiaomi Redmi 9C NFC 3/64GB Midnight Grey",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = true,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_6_15_20_38_82_00.jpg",
                            Title = "ASUS ZenBook 14 UM425QA R5-5600H/16GB/512/Win11",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = true,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_21_10_29_7_52_00.jpg",
                            Title = "Epson EcoTank L6290",
                            Visible = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2018/5/pr_2018_5_29_10_21_26_78_00.jpg",
                            Title = "Brother DCP-1623WE",
                            Visible = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_11_9_8_14_748_00.jpg",
                            Title = "Apple iPhone 11 64GB Black",
                            Visible = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_5_14_5_52_38_05.jpg",
                            Title = "Motorola Edge 30 5G 8/128GB Aurora Green 144Hz",
                            Visible = true
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_13_14_20_18_226_00.jpg",
                            Title = "Microsoft Office Home & Business 2021",
                            Visible = true
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Deleted = false,
                            Description = "Dolorem doloremque reiciendis quis odit. Nesciunt delectus consequatur tenetur laborum. Vero nostrum quo consequuntur odit autem ratione. Inventore officia eum illum sit.",
                            Featured = false,
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2020/3/pr_2020_3_3_10_4_35_199_00.jpg",
                            Title = "NortonLifeLock 360 Standard 1st. (12m)",
                            Visible = true
                        });
                });

            modelBuilder.Entity("ComputerSpace.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Product type 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Product type 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Product type 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Product type 4"
                        });
                });

            modelBuilder.Entity("ComputerSpace.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 499.00m,
                            Price = 399.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 599.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 299.00m,
                            Price = 249.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 4,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 199.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 399.00m,
                            Price = 349.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 199.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 299.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 4,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 499.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 399.00m,
                            Price = 388.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 249.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 49.99m,
                            Price = 39.99m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("ComputerSpace.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Address", b =>
                {
                    b.HasOne("ComputerSpace.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("ComputerSpace.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerSpace.Shared.Image", b =>
                {
                    b.HasOne("ComputerSpace.Shared.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("ComputerSpace.Shared.OrderItem", b =>
                {
                    b.HasOne("ComputerSpace.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerSpace.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerSpace.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Product", b =>
                {
                    b.HasOne("ComputerSpace.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ComputerSpace.Shared.ProductVariant", b =>
                {
                    b.HasOne("ComputerSpace.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerSpace.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ComputerSpace.Shared.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("ComputerSpace.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

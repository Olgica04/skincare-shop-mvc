﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "?`?z?r%5???-l",
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cleansers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Serums"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Masks"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Eye cream"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Moisturizer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Facial Tools"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<string>("ItemsInOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("OrderDate")
                        .HasMaxLength(128)
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasMaxLength(64)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<double>("Price")
                        .HasMaxLength(128)
                        .HasColumnType("float");

                    b.Property<int>("QuantityForOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A cleanly formulated, nondrying gel cleanser with exfoliating, natural salicylic acid and hydrating grape water to purify skin and absorb excess oil.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2491413-main-zoom.jpg?imwidth=315",
                            Name = "Caudalie-Vinopure Pore Purifying Gel Cleanser",
                            Price = 30.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A universal face wash that’s proven to maintain skin’s pH while also cleansing, softening, and hydrating all skin types and tones.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2534675-main-zoom.jpg?imwidth=315",
                            Name = "fresh-Soy Hydrating Gentle Face Cleanser",
                            Price = 39.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A gentle, moisturizing facial cleanser.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2278091-main-zoom.jpg?imwidth=315",
                            Name = "The Ordinary-Squalane Cleanser",
                            Price = 19.899999999999999,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = " A gentle cleanser to remove makeup, excess oil, pollution, and grime that rinses away without residue, leaving skin clean and soft.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2429884-main-zoom.jpg?imwidth=315",
                            Name = "Drunk Elephant-Mini Beste™ No. 9 Jelly Cleanser",
                            Price = 16.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "A breakthrough, multiuse highlighting serum that hydrates and visibly reduces the look of hyperpigmentation for a dewy, reflective glow—without mica, glitter, or gray cast.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2404846-main-zoom.jpg?imwidth=315",
                            Name = "Glow Recipe-Watermelon Glow Niacinamide Dew Drops",
                            Price = 35.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "A hydrating formula with ultra-pure, vegan hyaluronic acid.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2031375-main-zoom.jpg?imwidth=315",
                            Name = "The Ordinary-Hyaluronic Acid 2% + B5 Hydrating Serum",
                            Price = 8.9000000000000004,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315",
                            Name = "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid",
                            Price = 49.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "A three-in-one serum that smooths the look of fine lines and texture with lactic acid from Hadasei-3™, visibly plumps with hyaluronic acid, and locks in moisture with squalane.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2406858-main-zoom.jpg?imwidth=315",
                            Name = "Tatcha-The Dewy Serum Resurfacing and Plumping Treatment",
                            Price = 89.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "A high-strength lactic acid peeling formula for smoother, healthier-looking skin.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2031433-main-zoom.jpg?imwidth=315",
                            Name = "The Ordinary-Lactic Acid 10% + HA 2% Exfoliating Serum",
                            Price = 8.9000000000000004,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "An oil-free hydrating serum packed with hyaluronic acid to moisturize and soothe any skin type. Ideal for sensitive skin.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2461895-main-zoom.jpg?imwidth=315",
                            Name = "Caudalie-Vinosource-Hydra SOS Hydrating Hyaluronic Acid Serum",
                            Price = 52.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "A moisturizing sheet mask that nourishes dry, flaky skin, relieves tightness, and supports the skin’s barrier.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2640647-main-zoom.jpg?imwidth=315",
                            Name = "Dr. Jart+ -Ceramidin™ Skin Barrier Moisturizing Mask",
                            Price = 9.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Each of the 91% naturally sourced, vegan ingredients in this five-minute bio-celulose eye mask target under-eye concerns like dryness and dark circles.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2283034-main-zoom.jpg?imwidth=315",
                            Name = "SEPHORA COLLECTION-Clean Eye Mask",
                            Price = 3.5,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "A non-drying whipped clay mask with charcoal that deeply purifies pores. Clinically tested to instantly improve skin's texture and fight shine all day.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2536415-main-zoom.jpg?imwidth=315",
                            Name = "Fenty Skin-Cookies N Clean Whipped Clay Pore Detox Face Mask with Salicylic Acid + Charcoal",
                            Price = 35.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "A luxurious face mask that leaves skin looking and feeling hydrated and protected.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2106169-main-zoom.jpg?imwidth=315",
                            Name = "FOREO-Call It A Night Activated Mask",
                            Price = 10.99,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "A non-drying clay mask with hyaluronic-infused clay, BHA, PHA, and watermelon enzymes to unclog pores, smooth, and hydrate for softer, clearer-looking skin.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2461853-main-zoom.jpg?imwidth=315",
                            Name = "Glow Recipe-Watermelon Glow Hyaluronic Clay Pore-Tight Facial Mask",
                            Price = 40.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Description = "A clinically demonstrated, brightening eye cream that rapidly reduces the appearance of dark circles, visibly depuffs, and smooths the look of fine lines with vitamin C and hydrating honey.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2641850-main-zoom.jpg?imwidth=315",
                            Name = "Farmacy-Wake Up Honey Eye Cream with Brightening Vitamin C",
                            Price = 45.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Description = "A brightening under-eye cream that combines skincare and cosmetics to give an instant illuminating and priming effect while reducing the look of dark circles.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2280428-main-zoom.jpg?imwidth=315",
                            Name = "The INKEY List-Brighten-i Eye Cream",
                            Price = 12.99,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "A potent yet gentle, visibly brightening eye cream to reduce the look of dark circles, hydrate, and depuff the entire eye area with 10 percent encapsulated vitamin C complex, niacinamide blend, and peptides.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2594430-main-zoom.jpg?imwidth=315",
                            Name = "Glow Recipe-Guava Vitamin C Bright-Eye Gel Cream",
                            Price = 38.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "An eye cream that improves the look of dark circles and puffiness, and visibly firms with hyaluronic acid, peptides, and five percent vitamin C.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2574820-main-zoom.jpg?imwidth=315",
                            Name = "Paula's Choice-C5 Super Boost Vitamin C Eye Cream",
                            Price = 39.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "A moisturizing eye cream formulated with avocado oil to hydrate, smooth, visibly de-puff, and brighten the look of the under-eye area.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s1988815-main-zoom.jpg?imwidth=315",
                            Name = "Kiehl's Since 1851-Mini Creamy Eye Treatment with Avocado",
                            Price = 36.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            Description = "A fragrance-free moisturizing cream, formulated with squalane, that provides up to 24 hours of ultra-lightweight hydration.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2663763-main-zoom.jpg?imwidth=315",
                            Name = "Kiehl's Since 1851-Ultra Facial Moisturizing Cream with Squalane",
                            Price = 38.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Description = "A powerful overnight resurfacing mask to gently exfoliate, hydrate, and visibly brighten with a 2.5 percent pH-balanced AHA complex for smoother, firmer-looking skin.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2535151-main-zoom.jpg?imwidth=315",
                            Name = "Glow Recipe-Watermelon Glow AHA Night Treatment",
                            Price = 40.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            Description = "A hydrating formula with amino acids, dermal lipids, and hyaluronic acid.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2031425-main-zoom.jpg?imwidth=315",
                            Name = "The Ordinary-Mini Natural Moisturizing Factors + HA",
                            Price = 6.5,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            Description = "An invisible SPF 30 moisturizer that locks in fresh hydration, fades the look of dark spots, smooths the look of pores and defends against pollution.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2418879-main-zoom.jpg?imwidth=315",
                            Name = "Fenty Skin-Hydra Vizor Invisible Moisturizer Broad Spectrum SPF 30 Sunscreen with Niacinamide + Kalahari Melon",
                            Price = 39.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Description = " A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315",
                            Name = "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid",
                            Price = 49.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 6,
                            Description = "A customizable facial roller set of three interchangeable roller heads with a built-in eye roller in the handle.",
                            ImgSrc = "https://www.sephora.com/productimages/product/p474090-av-01-zoom.jpg?imwidth=315",
                            Name = "SEPHORA COLLECTION-Deluxe Facial Roller Set",
                            Price = 20.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            Description = "A facial cleansing pad, made of flexible silicone, that gently removes stubborn dirt and grime.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2398212-main-zoom.jpg?imwidth=315",
                            Name = "SEPHORA COLLECTION-Facial Cleansing Tool",
                            Price = 8.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 6,
                            Description = "A travel-friendly tool that lifts away visible dirt and oil with a one-minute cleanse and a firming facial massage that leaves skin smoother.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2604411-main-zoom.jpg?imwidth=315",
                            Name = "FOREO-LUNA™ 4 go Facial Cleansing & Massaging Device",
                            Price = 129.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 6,
                            Description = "A rose quartz roller that supports lymphatic drainage to reduce the appearance of puffiness, and wrinkles.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2087294-main-zoom.jpg?imwidth=315",
                            Name = "Herbivore-Rose Quartz Facial Roller",
                            Price = 40.0,
                            QuantityForOrder = 0
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 6,
                            Description = "A facial massage tool that enhances beauty rituals by promoting the lifting and smoothing of the skin, leaving the face lifted and radiant after use.",
                            ImgSrc = "https://www.sephora.com/productimages/sku/s2113553-main-zoom.jpg?imwidth=315",
                            Name = "Mount Lai-Gua Sha Facial Lifting Tool",
                            Price = 30.0,
                            QuantityForOrder = 0
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

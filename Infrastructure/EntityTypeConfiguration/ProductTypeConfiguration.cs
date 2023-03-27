using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
            .HasMaxLength(512)
            .IsRequired();

            builder.Property(p => p.Description)
            .HasMaxLength(1024)
            .IsRequired();

            builder.Property(p => p.Price)
            .HasMaxLength(128)
            .IsRequired();

            builder.Property(p => p.ImgSrc)
            .HasMaxLength(1024)
            .IsRequired();

            builder.Property(p => p.Id)
            .IsRequired();

            builder.HasData(
                new Product(1, "Caudalie-Vinopure Pore Purifying Gel Cleanser", "A cleanly formulated, nondrying gel cleanser with exfoliating, natural salicylic acid and hydrating grape water to purify skin and absorb excess oil.", 30.00, "https://www.sephora.com/productimages/sku/s2491413-main-zoom.jpg?imwidth=315", 1),
                new Product(2, "fresh-Soy Hydrating Gentle Face Cleanser", "A universal face wash that’s proven to maintain skin’s pH while also cleansing, softening, and hydrating all skin types and tones.", 39.00, "https://www.sephora.com/productimages/sku/s2534675-main-zoom.jpg?imwidth=315", 1),
                new Product(3, "The Ordinary-Squalane Cleanser", "A gentle, moisturizing facial cleanser.", 19.90, "https://www.sephora.com/productimages/sku/s2278091-main-zoom.jpg?imwidth=315", 1),
                new Product(4, "Drunk Elephant-Mini Beste™ No. 9 Jelly Cleanser", " A gentle cleanser to remove makeup, excess oil, pollution, and grime that rinses away without residue, leaving skin clean and soft.", 16.00, "https://www.sephora.com/productimages/sku/s2429884-main-zoom.jpg?imwidth=315", 1),
                new Product(5, "Glow Recipe-Watermelon Glow Niacinamide Dew Drops", "A breakthrough, multiuse highlighting serum that hydrates and visibly reduces the look of hyperpigmentation for a dewy, reflective glow—without mica, glitter, or gray cast.", 35.00, "https://www.sephora.com/productimages/sku/s2404846-main-zoom.jpg?imwidth=315", 2),
                new Product(6, "The Ordinary-Hyaluronic Acid 2% + B5 Hydrating Serum", "A hydrating formula with ultra-pure, vegan hyaluronic acid.", 8.90, "https://www.sephora.com/productimages/sku/s2031375-main-zoom.jpg?imwidth=315", 2),
                new Product(7, "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid", "A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.", 49.00, "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315", 2),
                new Product(8, "Tatcha-The Dewy Serum Resurfacing and Plumping Treatment", "A three-in-one serum that smooths the look of fine lines and texture with lactic acid from Hadasei-3™, visibly plumps with hyaluronic acid, and locks in moisture with squalane.", 89.00, "https://www.sephora.com/productimages/sku/s2406858-main-zoom.jpg?imwidth=315", 2),
                new Product(9, "The Ordinary-Lactic Acid 10% + HA 2% Exfoliating Serum", "A high-strength lactic acid peeling formula for smoother, healthier-looking skin.", 8.90, "https://www.sephora.com/productimages/sku/s2031433-main-zoom.jpg?imwidth=315", 2),
                new Product(10, "Caudalie-Vinosource-Hydra SOS Hydrating Hyaluronic Acid Serum", "An oil-free hydrating serum packed with hyaluronic acid to moisturize and soothe any skin type. Ideal for sensitive skin.", 52.00, "https://www.sephora.com/productimages/sku/s2461895-main-zoom.jpg?imwidth=315", 2),
                new Product(11, "Dr. Jart+ -Ceramidin™ Skin Barrier Moisturizing Mask", "A moisturizing sheet mask that nourishes dry, flaky skin, relieves tightness, and supports the skin’s barrier.", 9.00, "https://www.sephora.com/productimages/sku/s2640647-main-zoom.jpg?imwidth=315", 3),
                new Product(12, "SEPHORA COLLECTION-Clean Eye Mask", "Each of the 91% naturally sourced, vegan ingredients in this five-minute bio-celulose eye mask target under-eye concerns like dryness and dark circles.", 3.50, "https://www.sephora.com/productimages/sku/s2283034-main-zoom.jpg?imwidth=315", 3),
                new Product(13, "Fenty Skin-Cookies N Clean Whipped Clay Pore Detox Face Mask with Salicylic Acid + Charcoal", "A non-drying whipped clay mask with charcoal that deeply purifies pores. Clinically tested to instantly improve skin's texture and fight shine all day.", 35.00, "https://www.sephora.com/productimages/sku/s2536415-main-zoom.jpg?imwidth=315", 3),
                new Product(14, "FOREO-Call It A Night Activated Mask", "A luxurious face mask that leaves skin looking and feeling hydrated and protected.", 10.99, "https://www.sephora.com/productimages/sku/s2106169-main-zoom.jpg?imwidth=315", 3),
                new Product(15, "Glow Recipe-Watermelon Glow Hyaluronic Clay Pore-Tight Facial Mask", "A non-drying clay mask with hyaluronic-infused clay, BHA, PHA, and watermelon enzymes to unclog pores, smooth, and hydrate for softer, clearer-looking skin.", 40.00, "https://www.sephora.com/productimages/sku/s2461853-main-zoom.jpg?imwidth=315", 3),
                new Product(16, "Farmacy-Wake Up Honey Eye Cream with Brightening Vitamin C", "A clinically demonstrated, brightening eye cream that rapidly reduces the appearance of dark circles, visibly depuffs, and smooths the look of fine lines with vitamin C and hydrating honey.", 45.00, "https://www.sephora.com/productimages/sku/s2641850-main-zoom.jpg?imwidth=315", 4),
                new Product(17, "The INKEY List-Brighten-i Eye Cream", "A brightening under-eye cream that combines skincare and cosmetics to give an instant illuminating and priming effect while reducing the look of dark circles.", 12.99, "https://www.sephora.com/productimages/sku/s2280428-main-zoom.jpg?imwidth=315", 4),
                new Product(18, "Glow Recipe-Guava Vitamin C Bright-Eye Gel Cream", "A potent yet gentle, visibly brightening eye cream to reduce the look of dark circles, hydrate, and depuff the entire eye area with 10 percent encapsulated vitamin C complex, niacinamide blend, and peptides.", 38.00, "https://www.sephora.com/productimages/sku/s2594430-main-zoom.jpg?imwidth=315", 4),
                new Product(19, "Paula's Choice-C5 Super Boost Vitamin C Eye Cream", "An eye cream that improves the look of dark circles and puffiness, and visibly firms with hyaluronic acid, peptides, and five percent vitamin C.", 39.00, "https://www.sephora.com/productimages/sku/s2574820-main-zoom.jpg?imwidth=315", 4),
                new Product(20, "Kiehl's Since 1851-Mini Creamy Eye Treatment with Avocado", "A moisturizing eye cream formulated with avocado oil to hydrate, smooth, visibly de-puff, and brighten the look of the under-eye area.", 36.00, "https://www.sephora.com/productimages/sku/s1988815-main-zoom.jpg?imwidth=315", 4),
                new Product(21, "Kiehl's Since 1851-Ultra Facial Moisturizing Cream with Squalane", "A fragrance-free moisturizing cream, formulated with squalane, that provides up to 24 hours of ultra-lightweight hydration.", 38.00, "https://www.sephora.com/productimages/sku/s2663763-main-zoom.jpg?imwidth=315", 5),
                new Product(22, "Glow Recipe-Watermelon Glow AHA Night Treatment", "A powerful overnight resurfacing mask to gently exfoliate, hydrate, and visibly brighten with a 2.5 percent pH-balanced AHA complex for smoother, firmer-looking skin.", 40.00, "https://www.sephora.com/productimages/sku/s2535151-main-zoom.jpg?imwidth=315", 5),
                new Product(23, "The Ordinary-Mini Natural Moisturizing Factors + HA", "A hydrating formula with amino acids, dermal lipids, and hyaluronic acid.", 6.50, "https://www.sephora.com/productimages/sku/s2031425-main-zoom.jpg?imwidth=315", 5),
                new Product(24, "Fenty Skin-Hydra Vizor Invisible Moisturizer Broad Spectrum SPF 30 Sunscreen with Niacinamide + Kalahari Melon", "An invisible SPF 30 moisturizer that locks in fresh hydration, fades the look of dark spots, smooths the look of pores and defends against pollution.", 39.00, "https://www.sephora.com/productimages/sku/s2418879-main-zoom.jpg?imwidth=315", 5),
                new Product(25, "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid", " A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.", 49.00, "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315", 5),
                new Product(26, "SEPHORA COLLECTION-Deluxe Facial Roller Set", "A customizable facial roller set of three interchangeable roller heads with a built-in eye roller in the handle.", 20, "https://www.sephora.com/productimages/product/p474090-av-01-zoom.jpg?imwidth=315", 6),
                new Product(27, "SEPHORA COLLECTION-Facial Cleansing Tool", "A facial cleansing pad, made of flexible silicone, that gently removes stubborn dirt and grime.", 8.00, "https://www.sephora.com/productimages/sku/s2398212-main-zoom.jpg?imwidth=315", 6),
                new Product(28, "FOREO-LUNA™ 4 go Facial Cleansing & Massaging Device", "A travel-friendly tool that lifts away visible dirt and oil with a one-minute cleanse and a firming facial massage that leaves skin smoother.", 129.00, "https://www.sephora.com/productimages/sku/s2604411-main-zoom.jpg?imwidth=315", 6),
                new Product(29, "Herbivore-Rose Quartz Facial Roller", "A rose quartz roller that supports lymphatic drainage to reduce the appearance of puffiness, and wrinkles.", 40.00, "https://www.sephora.com/productimages/sku/s2087294-main-zoom.jpg?imwidth=315", 6),
                new Product(30, "Mount Lai-Gua Sha Facial Lifting Tool", "A facial massage tool that enhances beauty rituals by promoting the lifting and smoothing of the skin, leaving the face lifted and radiant after use.", 30.00, "https://www.sephora.com/productimages/sku/s2113553-main-zoom.jpg?imwidth=315", 6)
                );
        }
    }
}
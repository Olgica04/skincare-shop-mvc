using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ItemsInOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", maxLength: 128, nullable: false),
                    TotalPrice = table.Column<double>(type: "float", maxLength: 64, nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ImgSrc = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 128, nullable: false),
                    QuantityForOrder = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "?`?z?r%5???-l", "Admin" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cleansers" },
                    { 2, "Serums" },
                    { 3, "Masks" },
                    { 4, "Eye cream" },
                    { 5, "Moisturizer" },
                    { 6, "Facial Tools" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgSrc", "Name", "Price", "QuantityForOrder" },
                values: new object[,]
                {
                    { 1, 1, "A cleanly formulated, nondrying gel cleanser with exfoliating, natural salicylic acid and hydrating grape water to purify skin and absorb excess oil.", "https://www.sephora.com/productimages/sku/s2491413-main-zoom.jpg?imwidth=315", "Caudalie-Vinopure Pore Purifying Gel Cleanser", 30.0, 0 },
                    { 2, 1, "A universal face wash that’s proven to maintain skin’s pH while also cleansing, softening, and hydrating all skin types and tones.", "https://www.sephora.com/productimages/sku/s2534675-main-zoom.jpg?imwidth=315", "fresh-Soy Hydrating Gentle Face Cleanser", 39.0, 0 },
                    { 3, 1, "A gentle, moisturizing facial cleanser.", "https://www.sephora.com/productimages/sku/s2278091-main-zoom.jpg?imwidth=315", "The Ordinary-Squalane Cleanser", 19.899999999999999, 0 },
                    { 4, 1, " A gentle cleanser to remove makeup, excess oil, pollution, and grime that rinses away without residue, leaving skin clean and soft.", "https://www.sephora.com/productimages/sku/s2429884-main-zoom.jpg?imwidth=315", "Drunk Elephant-Mini Beste™ No. 9 Jelly Cleanser", 16.0, 0 },
                    { 5, 2, "A breakthrough, multiuse highlighting serum that hydrates and visibly reduces the look of hyperpigmentation for a dewy, reflective glow—without mica, glitter, or gray cast.", "https://www.sephora.com/productimages/sku/s2404846-main-zoom.jpg?imwidth=315", "Glow Recipe-Watermelon Glow Niacinamide Dew Drops", 35.0, 0 },
                    { 6, 2, "A hydrating formula with ultra-pure, vegan hyaluronic acid.", "https://www.sephora.com/productimages/sku/s2031375-main-zoom.jpg?imwidth=315", "The Ordinary-Hyaluronic Acid 2% + B5 Hydrating Serum", 8.9000000000000004, 0 },
                    { 7, 2, "A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.", "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315", "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid", 49.0, 0 },
                    { 8, 2, "A three-in-one serum that smooths the look of fine lines and texture with lactic acid from Hadasei-3™, visibly plumps with hyaluronic acid, and locks in moisture with squalane.", "https://www.sephora.com/productimages/sku/s2406858-main-zoom.jpg?imwidth=315", "Tatcha-The Dewy Serum Resurfacing and Plumping Treatment", 89.0, 0 },
                    { 9, 2, "A high-strength lactic acid peeling formula for smoother, healthier-looking skin.", "https://www.sephora.com/productimages/sku/s2031433-main-zoom.jpg?imwidth=315", "The Ordinary-Lactic Acid 10% + HA 2% Exfoliating Serum", 8.9000000000000004, 0 },
                    { 10, 2, "An oil-free hydrating serum packed with hyaluronic acid to moisturize and soothe any skin type. Ideal for sensitive skin.", "https://www.sephora.com/productimages/sku/s2461895-main-zoom.jpg?imwidth=315", "Caudalie-Vinosource-Hydra SOS Hydrating Hyaluronic Acid Serum", 52.0, 0 },
                    { 11, 3, "A moisturizing sheet mask that nourishes dry, flaky skin, relieves tightness, and supports the skin’s barrier.", "https://www.sephora.com/productimages/sku/s2640647-main-zoom.jpg?imwidth=315", "Dr. Jart+ -Ceramidin™ Skin Barrier Moisturizing Mask", 9.0, 0 },
                    { 12, 3, "Each of the 91% naturally sourced, vegan ingredients in this five-minute bio-celulose eye mask target under-eye concerns like dryness and dark circles.", "https://www.sephora.com/productimages/sku/s2283034-main-zoom.jpg?imwidth=315", "SEPHORA COLLECTION-Clean Eye Mask", 3.5, 0 },
                    { 13, 3, "A non-drying whipped clay mask with charcoal that deeply purifies pores. Clinically tested to instantly improve skin's texture and fight shine all day.", "https://www.sephora.com/productimages/sku/s2536415-main-zoom.jpg?imwidth=315", "Fenty Skin-Cookies N Clean Whipped Clay Pore Detox Face Mask with Salicylic Acid + Charcoal", 35.0, 0 },
                    { 14, 3, "A luxurious face mask that leaves skin looking and feeling hydrated and protected.", "https://www.sephora.com/productimages/sku/s2106169-main-zoom.jpg?imwidth=315", "FOREO-Call It A Night Activated Mask", 10.99, 0 },
                    { 15, 3, "A non-drying clay mask with hyaluronic-infused clay, BHA, PHA, and watermelon enzymes to unclog pores, smooth, and hydrate for softer, clearer-looking skin.", "https://www.sephora.com/productimages/sku/s2461853-main-zoom.jpg?imwidth=315", "Glow Recipe-Watermelon Glow Hyaluronic Clay Pore-Tight Facial Mask", 40.0, 0 },
                    { 16, 4, "A clinically demonstrated, brightening eye cream that rapidly reduces the appearance of dark circles, visibly depuffs, and smooths the look of fine lines with vitamin C and hydrating honey.", "https://www.sephora.com/productimages/sku/s2641850-main-zoom.jpg?imwidth=315", "Farmacy-Wake Up Honey Eye Cream with Brightening Vitamin C", 45.0, 0 },
                    { 17, 4, "A brightening under-eye cream that combines skincare and cosmetics to give an instant illuminating and priming effect while reducing the look of dark circles.", "https://www.sephora.com/productimages/sku/s2280428-main-zoom.jpg?imwidth=315", "The INKEY List-Brighten-i Eye Cream", 12.99, 0 },
                    { 18, 4, "A potent yet gentle, visibly brightening eye cream to reduce the look of dark circles, hydrate, and depuff the entire eye area with 10 percent encapsulated vitamin C complex, niacinamide blend, and peptides.", "https://www.sephora.com/productimages/sku/s2594430-main-zoom.jpg?imwidth=315", "Glow Recipe-Guava Vitamin C Bright-Eye Gel Cream", 38.0, 0 },
                    { 19, 4, "An eye cream that improves the look of dark circles and puffiness, and visibly firms with hyaluronic acid, peptides, and five percent vitamin C.", "https://www.sephora.com/productimages/sku/s2574820-main-zoom.jpg?imwidth=315", "Paula's Choice-C5 Super Boost Vitamin C Eye Cream", 39.0, 0 },
                    { 20, 4, "A moisturizing eye cream formulated with avocado oil to hydrate, smooth, visibly de-puff, and brighten the look of the under-eye area.", "https://www.sephora.com/productimages/sku/s1988815-main-zoom.jpg?imwidth=315", "Kiehl's Since 1851-Mini Creamy Eye Treatment with Avocado", 36.0, 0 },
                    { 21, 5, "A fragrance-free moisturizing cream, formulated with squalane, that provides up to 24 hours of ultra-lightweight hydration.", "https://www.sephora.com/productimages/sku/s2663763-main-zoom.jpg?imwidth=315", "Kiehl's Since 1851-Ultra Facial Moisturizing Cream with Squalane", 38.0, 0 },
                    { 22, 5, "A powerful overnight resurfacing mask to gently exfoliate, hydrate, and visibly brighten with a 2.5 percent pH-balanced AHA complex for smoother, firmer-looking skin.", "https://www.sephora.com/productimages/sku/s2535151-main-zoom.jpg?imwidth=315", "Glow Recipe-Watermelon Glow AHA Night Treatment", 40.0, 0 },
                    { 23, 5, "A hydrating formula with amino acids, dermal lipids, and hyaluronic acid.", "https://www.sephora.com/productimages/sku/s2031425-main-zoom.jpg?imwidth=315", "The Ordinary-Mini Natural Moisturizing Factors + HA", 6.5, 0 },
                    { 24, 5, "An invisible SPF 30 moisturizer that locks in fresh hydration, fades the look of dark spots, smooths the look of pores and defends against pollution.", "https://www.sephora.com/productimages/sku/s2418879-main-zoom.jpg?imwidth=315", "Fenty Skin-Hydra Vizor Invisible Moisturizer Broad Spectrum SPF 30 Sunscreen with Niacinamide + Kalahari Melon", 39.0, 0 },
                    { 25, 5, " A cool drink of water for thirsty skin, this hydrating serum visibly replenishes the complexion and improves the look of skin texture and tone.", "https://www.sephora.com/productimages/sku/s1785856-main-zoom.jpg?imwidth=315", "Drunk Elephant-B-Hydra™ Intensive Hydration Serum with Hyaluronic Acid", 49.0, 0 },
                    { 26, 6, "A customizable facial roller set of three interchangeable roller heads with a built-in eye roller in the handle.", "https://www.sephora.com/productimages/product/p474090-av-01-zoom.jpg?imwidth=315", "SEPHORA COLLECTION-Deluxe Facial Roller Set", 20.0, 0 },
                    { 27, 6, "A facial cleansing pad, made of flexible silicone, that gently removes stubborn dirt and grime.", "https://www.sephora.com/productimages/sku/s2398212-main-zoom.jpg?imwidth=315", "SEPHORA COLLECTION-Facial Cleansing Tool", 8.0, 0 },
                    { 28, 6, "A travel-friendly tool that lifts away visible dirt and oil with a one-minute cleanse and a firming facial massage that leaves skin smoother.", "https://www.sephora.com/productimages/sku/s2604411-main-zoom.jpg?imwidth=315", "FOREO-LUNA™ 4 go Facial Cleansing & Massaging Device", 129.0, 0 },
                    { 29, 6, "A rose quartz roller that supports lymphatic drainage to reduce the appearance of puffiness, and wrinkles.", "https://www.sephora.com/productimages/sku/s2087294-main-zoom.jpg?imwidth=315", "Herbivore-Rose Quartz Facial Roller", 40.0, 0 },
                    { 30, 6, "A facial massage tool that enhances beauty rituals by promoting the lifting and smoothing of the skin, leaving the face lifted and radiant after use.", "https://www.sephora.com/productimages/sku/s2113553-main-zoom.jpg?imwidth=315", "Mount Lai-Gua Sha Facial Lifting Tool", 30.0, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}

namespace Domain.Entities
{
    public class Product : IBaseEntity
    {
        public Product() { }
        public Product(string name, string description, double price, string img)
        {
            Name = name;
            Description = description;
            Price = price;
            ImgSrc = img;
            //Category = category;
        }
        public Product(int id, string name, string description, double price, string img, int categoryId)
        {
            Id = id;
            Description = description;
            Name = name;
            ImgSrc = img;
            Price = price;
            CategoryId = categoryId;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImgSrc { get; set; } = string.Empty;
        public double Price { get; set; }
        public int QuantityForOrder { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
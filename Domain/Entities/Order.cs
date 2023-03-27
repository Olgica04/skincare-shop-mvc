namespace Domain.Entities
{
    public class Order : IBaseEntity
    {
        public Order() { }
        public Order(string firstName, string lastName, string address, DateTime orderDate, ICollection<Product> products, bool isCancelled)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            Products = products;
            IsCancelled = isCancelled;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string Address { get; set; } = string.Empty;
        public string ItemsInOrder { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public void ClearProducts()
        {
            Products.Clear();
        }
        public void AddProduct(Product? product, int quantity)
        {
            if (product is null)
            {
                throw new Exception("Product doesn't exist");
            }

            Enumerable.Range(0, quantity).ToList().ForEach(_ =>
            {
                Products.Add(product);
            });
        }
    }
}
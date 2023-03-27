namespace Application.Dto.Product
{
    public class SelectProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
        public double BatchOrderPrice => ProductPrice * Quantity;
    }
}
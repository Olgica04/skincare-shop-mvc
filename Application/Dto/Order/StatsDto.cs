using Application.Dto.Product;

namespace Application.Dto.Order
{
    public class StatsDto
    {
        public int OrdersServed { get; set; }
        public double AverageOrderPrice { get; set; }
        public ProductDto? BestSellingProduct { get; set; }
    }
}
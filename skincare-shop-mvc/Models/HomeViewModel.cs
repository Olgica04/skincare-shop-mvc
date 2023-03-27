using Application.Dto.Order;
using Application.Dto.Product;

namespace skincare_shop_mvc.Models
{
    public class HomeViewModel
    {
        public StatsDto? Stats { get; set; }
        public IList<ProductDto> FeaturedProducts { get; set; } = new List<ProductDto>();
    }
}
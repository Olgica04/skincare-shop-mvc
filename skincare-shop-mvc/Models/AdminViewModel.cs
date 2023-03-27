using Application.Dto.Order;
using Application.Dto.Product;

namespace skincare_shop_mvc.Models
{
    public class AdminViewModel
    {
        public IList<ProductDto> Products { get; set; } = new List<ProductDto>();
        public IList<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public StatsDto? Stats { get; set; }
    }
}
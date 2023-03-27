using Application.Dto.Product;

namespace skincare_shop_mvc.Models
{
    public class ProductsViewModel
    {
        public IList<ProductDto> Products = new List<ProductDto>();
        public IList<string> Categories = new List<string>();
    }
}
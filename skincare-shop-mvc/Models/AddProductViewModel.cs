using Application.Dto.Product;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace skincare_shop_mvc.Models
{
    public class AddProductViewModel
    {
        public AddProductDto? Form { get; set; }
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}

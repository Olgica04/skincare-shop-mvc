using Application.Services;
using Microsoft.AspNetCore.Mvc;
using skincare_shop_mvc.Models;

namespace skincare_shop_mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var model = new ProductsViewModel
            {
                Products = _productService.GetAllProducts(),
                Categories = _productService.GetCategoriesNames()
            };

            return View(model);
        }
    }
}
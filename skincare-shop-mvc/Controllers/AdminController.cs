using Application.Dto.Product;
using Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using skincare_shop_mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace skincare_shop_mvc.Controllers
{
    [Authorize(Policy = SystemPolicies.IsAdmin)]
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public AdminController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var model = new AdminViewModel()
            {
                Categories = _productService.GetCategories(),
                Products = _productService.GetAllProducts(),
                Stats = _orderService.GetStatistics()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var model = new AddProductViewModel()
            {
                Categories = _productService.GetCategories().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList(),
                Form = new AddProductDto()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel model)
        {
            try
            {
                _productService.AddProduct(model.Form);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = _productService.GetProduct(id);

            var model = new AddProductViewModel()
            {
                Form = product,
                Categories = _productService.GetCategories().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditProduct(int id, AddProductViewModel model)
        {
            try
            {
                _productService.EditProduct(model.Form, id);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("Admin/DeleteProduct/{id}")]
        public IActionResult DeleteWarning(int id)
        {
            var product = _productService.GetProduct(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryDto dto)
        {
            try
            {
                _productService.AddCategory(dto);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _productService.GetCategory(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(int id, CategoryDto dto)
        {
            try
            {
                _productService.EditCategory(dto, id);
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("Admin/DeleteCategory/{id}")]
        public IActionResult DeleteCategoryWarning(int id)
        {
            var category = _productService.GetCategory(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int id)
        {
            _productService.DeleteCategory(id);

            return RedirectToAction("Index");
        }
    }
}
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using skincare_shop_mvc.Models;
using System.Diagnostics;

namespace skincare_shop_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderService _orderService;

        public HomeController(ILogger<HomeController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel()
            {
                Stats = _orderService.GetStatistics(),
                FeaturedProducts = _orderService.GetFeaturedProducts()
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
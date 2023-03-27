using Application.Dto.Order;
using Application.Services;
using Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace skincare_shop_mvc.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var order = new CreateOrderDto { Products = _orderService.GetOrderableProducts() };

            return View(order);
        }

        [HttpGet("Order/SingleOrder/{id}")]
        public IActionResult SingleOrder(int id)
        {
            var order = new CreateOrderDto
            {
                Products = _orderService.GetOrderableProducts(isSingleProduct: true, productId: id)
            };

            return View(order);
        }

        [HttpPost]
        public IActionResult ConfirmOrder(CreateOrderDto order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var confirm = _orderService.CreateOrder(order);

            return View(confirm);
        }

        [HttpPost]
        public IActionResult CancelOrder(int id)
        {
            _orderService.CancelOrder(id);

            return RedirectToAction("Index");
        }

        [Authorize(Policy = SystemPolicies.IsAdmin)]
        [HttpGet]
        public IActionResult Orders()
        {
            var orders = _orderService.GetOrders();
            return View(orders);
        }

        [Authorize(Policy = SystemPolicies.IsAdmin)]
        [HttpGet("Order/OrderLog/{id}")]
        public IActionResult OrderLog(int id)
        {
            var order = _orderService.GetOrder(id);
            return View(order);
        }
    }
}
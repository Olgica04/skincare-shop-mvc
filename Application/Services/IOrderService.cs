using Application.Dto.Order;
using Application.Dto.Product;

namespace Application.Services
{
    public interface IOrderService
    {
        OrderDto CreateOrder(CreateOrderDto create);
        void CancelOrder(int id);
        IList<OrderDto> GetOrders();
        OrderDto GetOrder(int id);
        StatsDto GetStatistics();
        IList<ProductDto> GetFeaturedProducts();
        IList<SelectProductDto> GetOrderableProducts(bool isSingleProduct = false, int productId = 0);
    }
}
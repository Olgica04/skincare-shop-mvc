using Application.Dto.Order;
using Application.Dto.Product;
using Application.Mapper;
using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Product> _productRepository;
        public OrderService(IRepository<Order> orderRepository, IRepository<Product> productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }
        public OrderDto GetOrder(int id)
        {
            var order = _orderRepository.Query().Include(x => x.Products).FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Not found");

            foreach (var product in order.Products)
            {
                order.ItemsInOrder += $"{product.Name}; ";
            }

            return order.ToOrderDto();
        }
        public IList<OrderDto> GetOrders()
        {
            var orders = _orderRepository.Query().Include(x => x.Products).Select(x => x.ToOrderDto());

            return orders.ToList();
        }
        public OrderDto CreateOrder(CreateOrderDto create)
        {

            var entity = create.ToOrder();
            var items = "";

            foreach (var product in create.Products.Where(x => x.IsSelected))
            {
                items += product.ProductName;
                var productEntity = _productRepository.GetById(product.ProductId);

                if (productEntity != null)
                {
                    productEntity.QuantityForOrder = product.Quantity;
                    entity.AddProduct(productEntity, 1);
                }
            }

            entity.ItemsInOrder = items;

            _orderRepository.Create(entity);

            return create.ToOrderDto();
        }
        public void CancelOrder(int id)
        {
            var order = _orderRepository.Query().OrderBy(x => x.OrderDate).LastOrDefault() ?? throw new Exception();

            order.IsCancelled = true;

            _orderRepository.Update(order);
        }
        public IList<SelectProductDto> GetOrderableProducts(bool isSingleProduct = false, int productId = 0)
        {
            var product = new List<SelectProductDto>();

            if (isSingleProduct)
            {
                product = _productRepository.Query().Where(x => x.Id == productId).Select(x => new SelectProductDto
                {
                    ProductId = x.Id,
                    ProductName = x.Name,
                    IsSelected = true,
                    Quantity = 0,
                    ProductPrice = x.Price,
                }).ToList();
            }

            if (!isSingleProduct)
            {
                product = _productRepository.Query().Select(x => new SelectProductDto
                {
                    ProductId = x.Id,
                    ProductName = x.Name,
                    IsSelected = false,
                    Quantity = 0,
                    ProductPrice = x.Price
                }).ToList();
            }

            return product;
        }
        public StatsDto GetStatistics()
        {
            var bestSellerId = _orderRepository.Query()
                .Where(x => !x.IsCancelled)
                .SelectMany(o => o.Products)
                .GroupBy(p => p.Id)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();


            var bestSeller = _productRepository.Query().Include(x => x.Category).FirstOrDefault(x => x.Id == bestSellerId);
            var ordersCount = _orderRepository.Query().Where(o => !o.IsCancelled).Count();
            var averagePrice = _orderRepository.Query().Where(x => !x.IsCancelled).Sum(x => x.TotalPrice) / ordersCount;

            return bestSeller == null ?
            new()
            {
                BestSellingProduct = new(),
                OrdersServed = 0,
                AverageOrderPrice = 0.0
            }
            :
            new()
            {
                BestSellingProduct = bestSeller.ToProductDto(),
                OrdersServed = ordersCount,
                AverageOrderPrice = averagePrice
            };
        }

        public IList<ProductDto> GetFeaturedProducts()
        {
            var products = _productRepository.Query().Include(x => x.Category).ToList();

            var featuredItems = new List<ProductDto>();

            for (int i = 0; i < 5; i++)
            {
                var randomIndex = new Random().Next(0, products.Count());
                var item = products[randomIndex];
                featuredItems.Add(item.ToProductDto());
                products.RemoveAt(randomIndex);
            }

            return featuredItems;
        }
    }
}
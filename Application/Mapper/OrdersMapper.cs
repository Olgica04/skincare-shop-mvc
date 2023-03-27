using Application.Dto.Order;
using Application.Dto.Product;
using Domain.Entities;
using System;

namespace Application.Mapper
{
    public static class OrdersMapper
    {
        public static Order ToOrder(this CreateOrderDto createOrder)
        {
            return new Order(createOrder.FirstName, createOrder.LastName, createOrder.Address, createOrder.OrderDate, new List<Product>(), false)
            {
                TotalPrice = createOrder.Products.Where(b => b.IsSelected).Sum(x => x.BatchOrderPrice),
            };
        }
        public static OrderDto ToOrderDto(this Order order)
        {
            return new()
            {
                Id = order.Id,
                FirstName = order.FirstName,
                LastName = order.LastName,
                Products = order.Products.Select(p => new SelectProductDto
                {
                    ProductId = p.Id,
                    IsSelected = false,
                    ProductName = p.Name,
                    Quantity = p.QuantityForOrder,
                    ProductPrice = p.Price,
                }).ToList(),
                Address = order.Address,
                TotalPrice = order.TotalPrice,
                OrderDate = order.OrderDate,
                ItemsInOrder = order.ItemsInOrder,
                IsCancelled = order.IsCancelled
            };
        }

        public static OrderDto ToOrderDto(this CreateOrderDto create)
        {
            return new()
            {
                Id = create.Id,
                Products = create.Products,
                Address = create.Address,
                FirstName = create.FirstName,
                LastName = create.LastName,
                TotalPrice = create.Products.Where(b => b.IsSelected).Sum(x => x.BatchOrderPrice),
                OrderDate = create.OrderDate,
                Payment = new()
            };
        }
    }
}
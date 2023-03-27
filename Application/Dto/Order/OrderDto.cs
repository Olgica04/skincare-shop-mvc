namespace Application.Dto.Order
{
    public class OrderDto : CreateOrderDto
    {
        public OrderPayment? Payment { get; set; }
        public string ItemsInOrder { get; set; } = string.Empty;
    }
}
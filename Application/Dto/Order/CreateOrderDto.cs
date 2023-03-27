using Application.Dto.Product;
using System.ComponentModel.DataAnnotations;

namespace Application.Dto.Order
{
    public class CreateOrderDto
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        public double TotalPrice { get; set; }
        public bool IsCancelled { get; set; }

        public DateTime OrderDate = DateTime.Now;
        public IList<SelectProductDto> Products { get; set; } = new List<SelectProductDto>();
    }
}
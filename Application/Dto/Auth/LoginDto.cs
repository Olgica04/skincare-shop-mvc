using System.ComponentModel.DataAnnotations;

namespace Application.Dto.Auth
{
    public class LoginDto
    {
        [Required]
        public string Userame { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
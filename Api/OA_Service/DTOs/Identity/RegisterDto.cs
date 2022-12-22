using System.ComponentModel.DataAnnotations;

namespace OA_Service.DTOs.Identity
{
    public class RegisterDto
    {
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
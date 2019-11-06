using System.ComponentModel.DataAnnotations;

namespace DemoApplication.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
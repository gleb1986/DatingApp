using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    
        [Required]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Bad password")]
        public string Password { get; set; }
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace infass_Jimenez_A1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}

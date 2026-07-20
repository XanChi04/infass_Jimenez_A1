using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace infass_Jimenez_A1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}

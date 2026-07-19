using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace infass_Jimenez_A1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public int Email {  get; set; }

        [Required]
        public string Password { get; set; }
    }
}

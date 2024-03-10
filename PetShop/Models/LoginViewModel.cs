using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class LoginViewModel
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(60)]
        public string? Username { get; set; }

        [Required, StringLength(60)]
        public string? Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string? Username { get; set; }

        [Required, StringLength(60)]
        public string? Password { get; set; }
    }
}

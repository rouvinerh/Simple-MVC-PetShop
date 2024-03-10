using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Range(1, 300), Required]
        public int Age { get; set; }

        [StringLength(60, MinimumLength = 4), Required]
        public string? Species { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(6)]
        public string? Sex { get; set; }

        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        public DateTime GetDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string? Name { get; set; }

        [Range(1, 5000), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

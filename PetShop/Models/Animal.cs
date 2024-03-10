using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string Species { get; set; }

        public string Sex { get; set; }

        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        public DateTime GetDate { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

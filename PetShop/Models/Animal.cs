using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string Species { get; set; }

        [DataType(DataType.Date)]
        public DateTime GetDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SoldDate { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}

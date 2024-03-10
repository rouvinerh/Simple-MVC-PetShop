using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetShop.Models
{
    public class AnimalSpeciesViewModel
    {
        public List<Animal>? Animals { get; set; }
        public SelectList? Species { get; set; }
        public string? AnimalSpecies { get; set; }
        public string? SearchString { get; set; }
    }
}

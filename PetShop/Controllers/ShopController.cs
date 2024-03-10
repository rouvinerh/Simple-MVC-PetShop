using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly PetShopContext _context;

        public ShopController(PetShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString, string animalSpecies)
        {
            if (_context.Animal == null)
            {
                return Problem("Entity set 'PetShopContext.Animal' is null.");
            }

            IQueryable<string> specifesQuery = from m in _context.Animal
                                               orderby m.Species
                                               select m.Species;

            var animals = from m in _context.Animal
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                animals = animals.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(animalSpecies))
            {
                animals = animals.Where(x => x.Species == animalSpecies);
            }

            var animalSpeciesVM = new AnimalSpeciesViewModel
            {
                Species = new SelectList(await specifesQuery.Distinct().ToListAsync()),
                Animals = await animals.ToListAsync()
            };

            return View(animalSpeciesVM);
        }
    }
}

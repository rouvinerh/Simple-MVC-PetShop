using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Data;
using System;
using System.Linq;

namespace PetShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PetShopContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<PetShopContext>>()))
            {
                if (context.Animal.Any())
                {
                    return;
                }
                context.Animal.AddRange(
                    new Animal
                    {
                        Age = 5,
                        Species = "Hamster",
                        GetDate = DateTime.Parse("2023-5-13"),
                        SoldDate = DateTime.Parse("2023-5-14"),
                        Name = "Butter",
                        Price = 60.59M
                    },
                    new Animal
                    {
                        Age = 12,
                        Species = "Fish",
                        GetDate = DateTime.Parse("2023-8-13"),
                        SoldDate = DateTime.Parse("2023-8-14"),
                        Name = "Fighter",
                        Price = 5.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}



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
                    Name = "Butter",
                    Price = 60.59M
                },
                new Animal
                {
                    Age = 12,
                    Species = "Fish",
                    GetDate = DateTime.Parse("2023-8-13"),
                    Name = "Fighter",
                    Price = 5.00M
                },
                new Animal
                {
                    Age = 2,
                    Species = "Parrot",
                    GetDate = DateTime.Parse("2023-10-21"),
                    Name = "Rio",
                    Price = 120.99M
                },
                new Animal
                {
                    Age = 8,
                    Species = "Cat",
                    GetDate = DateTime.Parse("2023-6-5"),
                    Name = "Whiskers",
                    Price = 75.50M
                },
                new Animal
                {
                    Age = 3,
                    Species = "Rabbit",
                    GetDate = DateTime.Parse("2023-4-12"),
                    Name = "Fluffy",
                    Price = 40.25M
                },
                new Animal
                {
                    Age = 7,
                    Species = "Snake",
                    GetDate = DateTime.Parse("2023-9-8"),
                    Name = "Slither",
                    Price = 90.75M
                },
                new Animal
                {
                    Age = 1,
                    Species = "Turtle",
                    GetDate = DateTime.Parse("2023-7-17"),
                    Name = "Shelly",
                    Price = 30.00M
                },
                new Animal
                {
                    Age = 4,
                    Species = "Guinea Pig",
                    GetDate = DateTime.Parse("2023-11-2"),
                    Name = "Nibbles",
                    Price = 55.80M
                },
                new Animal
                {
                    Age = 6,
                    Species = "Dog",
                    GetDate = DateTime.Parse("2023-2-14"),
                    Name = "Buddy",
                    Price = 85.25M
                },
                new Animal
                {
                    Age = 9,
                    Species = "Ferret",
                    GetDate = DateTime.Parse("2023-12-7"),
                    Name = "Fuzzball",
                    Price = 65.50M
                },
                new Animal
                {
                    Age = 2,
                    Species = "Iguana",
                    GetDate = DateTime.Parse("2023-3-25"),
                    Name = "Spike",
                    Price = 75.00M
                },
                new Animal
                {
                    Age = 5,
                    Species = "Hedgehog",
                    GetDate = DateTime.Parse("2023-1-9"),
                    Name = "Quill",
                    Price = 50.20M
                },
                new Animal
                {
                    Age = 7,
                    Species = "Chinchilla",
                    GetDate = DateTime.Parse("2023-8-30"),
                    Name = "Dusty",
                    Price = 70.75M
                },
                new Animal
                {
                    Age = 3,
                    Species = "Hamster",
                    GetDate = DateTime.Parse("2023-6-18"),
                    Name = "Nibbler",
                    Price = 45.99M
                },
                new Animal
                {
                    Age = 1,
                    Species = "Fish",
                    GetDate = DateTime.Parse("2023-9-22"),
                    Name = "Splash",
                    Price = 8.50M
                },
                new Animal
                {
                    Age = 4,
                    Species = "Parakeet",
                    GetDate = DateTime.Parse("2023-11-11"),
                    Name = "Sky",
                    Price = 55.00M
                },
                new Animal
                {
                    Age = 6,
                    Species = "Tortoise",
                    GetDate = DateTime.Parse("2023-4-5"),
                    Name = "Rocky",
                    Price = 100.75M
                });
                context.SaveChanges();
            }
        }
    }
}



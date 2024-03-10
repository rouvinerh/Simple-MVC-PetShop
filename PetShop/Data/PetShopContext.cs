using Microsoft.EntityFrameworkCore;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext (DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public DbSet<PetShop.Models.Animal> Animal { get; set; } = default!;

        public DbSet<PetShop.Models.Users> Users { get; set; } = default!;
    }
}

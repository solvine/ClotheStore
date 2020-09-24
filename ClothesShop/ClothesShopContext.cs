using System.Data.Entity;

namespace ClothesShop
{
    public class ClothesShopContext : DbContext
    {
        public ClothesShopContext() : base("ClotheShop")
        {
            Database.SetInitializer(new ClothesShopInitializer());
        }
        public DbSet<ClothingItem> ClothingItems { get; set; }
        public DbSet<ClothingSize> ClothingSizes { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

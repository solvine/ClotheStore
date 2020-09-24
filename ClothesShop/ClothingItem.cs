using System.Collections.Generic;

namespace ClothesShop
{
   public class ClothingItem
    {
        public int ClothingItemId { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public virtual List<ClothingSize> ClothingSizes { get; set; }
    }
}

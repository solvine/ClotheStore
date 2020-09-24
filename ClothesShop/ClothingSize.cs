namespace ClothesShop
{
    public class ClothingSize
    {
        public int ClothingSizeId { get; set; }
        public string Size { get; set; }

        public int Quantity { get; set; }

        public int ClothingItemId { get; set; }
        public virtual ClothingItem ClothingItem { get; set; }
    }
}

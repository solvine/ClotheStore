using System;

namespace ClothesShop
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }
        public string ClothingItem { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }

        public void ViewBasketItem()
        {
            Console.WriteLine($" {ClothingItem} ({Size}) {Quantity} {Amount} EUR");
        }
    }
}

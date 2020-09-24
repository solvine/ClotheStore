using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothesShop
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int UserId { get; set; }

        public double Amount { get; set; }

        public DateTime PurchaceDateTime { get; set; }

        public string ShippingAdress { get; set; }

        public virtual User User { get; set; }

        public void AddSale(ClothesShopContext db, double totalAmount, string shippingAddress, List<BasketItem> BasketItems, int userId)
        {
            db.Sales.Add(new Sale { Amount = totalAmount, ShippingAdress = shippingAddress, PurchaceDateTime = DateTime.Now, UserId = userId });
            db.SaveChanges();
            foreach (var item in BasketItems)
            {
                db.BasketItems.Add(
                    new BasketItem
                    {
                        Amount = item.Amount,
                        ClothingItem = item.ClothingItem,
                        Quantity = item.Quantity,
                        Size = item.Size,
                        SaleId = db.Sales.Count()
                    }
                    );
            }
            db.SaveChanges();
            Console.Clear();
            Console.WriteLine("Thank you for your purchace!");
        }

        public void ChangeSizeQuantityInDb(ClothesShopContext db, string type,List<BasketItem> basketItems)
        {
            int itemId;
            foreach (var item in basketItems)
            {
                itemId = db.ClothingItems.FirstOrDefault(c => c.Name == item.ClothingItem && c.Type == type).ClothingItemId;
                var dbItem = db.ClothingSizes.FirstOrDefault(d => d.Size == item.Size && d.ClothingItemId == itemId);
                if (dbItem != null)
                {
                    dbItem.Quantity -= item.Quantity;
                    if (dbItem.Quantity == 0) // if all quantity for size sold
                    {
                        db.ClothingSizes.Remove(dbItem);
                        db.SaveChanges();
                        if (!db.ClothingSizes.Any(a => a.ClothingItemId == itemId)) // if no sizes for clothingItem left
                        {
                            db.ClothingItems.Remove(db.ClothingItems.FirstOrDefault(a => a.ClothingItemId == itemId));
                        }
                    }
                }
            }
            db.SaveChanges();
        }

    }
}

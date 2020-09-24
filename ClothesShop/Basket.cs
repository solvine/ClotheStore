using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothesShop
{
    public class Basket
    {
        public List <BasketItem> BasketItems { get; set; }
        public int ItemId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }

        public int BasketItemNumber { get; set; }

        public double TotalAmount { get; set; }

        public Basket()
        {
            BasketItems = new List<BasketItem>();
        }

        public void AddItemToBasket(ClothesShopContext db, int itemId)
        {
            var existantBasketItem = BasketItems.FirstOrDefault(b => b.ClothingItem == db.ClothingItems.First(c => c.ClothingItemId == itemId).Name && b.Size == Size);
            if (existantBasketItem != null)
            {
                existantBasketItem.Quantity += Quantity;
                existantBasketItem.Amount = (int)db.ClothingItems.First(c => c.ClothingItemId == itemId).Price * existantBasketItem.Quantity;
                Console.Clear();
                Console.WriteLine($"{existantBasketItem.ClothingItem} ({Size}) Qty:{Quantity} added to basket");
            }
            else
            {
                BasketItems.Add(new BasketItem()
                {
                    ClothingItem = db.ClothingItems.First(c => c.ClothingItemId == itemId).Name,
                    Size = Size,
                    Quantity = Quantity,
                    Amount = (int)db.ClothingItems.First(c => c.ClothingItemId == itemId).Price * Quantity

                }
                );
                Console.Clear();
                Console.WriteLine($"{BasketItems[BasketItems.Count() - 1].ClothingItem} ({Size}) Qty:{Quantity} added to basket");
            }
            
            
        }

        public void ChooseSizeQuantity(ClothesShopContext db, int itemId)
        {
            Console.WriteLine($"Please choose the size: ");
            string sizeChoice = Console.ReadLine().ToUpper();
            while (!db.ClothingSizes.Any(s => s.Size == sizeChoice && s.ClothingItemId == itemId))
            {
                Console.WriteLine("There is no such size. Please provide size");
                sizeChoice = Console.ReadLine().ToUpper();
            }
                Size = sizeChoice;
                var availableQuantity = db.ClothingSizes.First(q => q.Size == sizeChoice && q.ClothingItemId == itemId).Quantity;
                Console.WriteLine($"How many items you want to add to basket? Available: {availableQuantity}");
                Console.WriteLine("Type 0 to cancel");
                CheckQuantityAvailability(db.ClothingItems.First(c => c.ClothingItemId == itemId).Name, availableQuantity);
        }
        public void CheckQuantityAvailability(string clothing, int availableQuantity)
        {
            Quantity = GeneralStaticClass.ReadIntNumber();
            foreach (var item in BasketItems)
            {
                while (item.ClothingItem == clothing && item.Size == Size && item.Quantity + Quantity > availableQuantity)
                {
                    Console.WriteLine($"Unavailable quantity. Quantity already in basket: {item.Quantity}");
                    Console.WriteLine("Type 0 to cancel");
                    Quantity = GeneralStaticClass.ReadIntNumber();
                }
            }

            while (Quantity > availableQuantity || Quantity < 0)
            {
                Console.WriteLine("Wrong quantity");
                Quantity = GeneralStaticClass.ReadIntNumber();
            }
        }

        public void ShowBasket()
        {
            TotalAmount = 0;
            BasketItemNumber = 0;
            foreach (var item in BasketItems)
            {
                Console.Write($"{BasketItemNumber+1}: ");
                item.ViewBasketItem();
                TotalAmount += item.Amount;
                BasketItemNumber++;
            }
            Console.WriteLine($"TOTAL TO PAY: {TotalAmount} EUR");
        }

        public void UpdateItem()
        {
            Console.Clear();
            Console.WriteLine("BASKET VIEW");
            ShowBasket();
            Console.WriteLine();
            int itemToUpdate = GetItemToUpdateNo()-1;
            int newQuantity = GetNewItemQuantity(itemToUpdate);

            if (newQuantity == 0)
            {
                BasketItems.RemoveAt(itemToUpdate);
            }
            else
            {
                BasketItems[itemToUpdate].Amount = BasketItems[itemToUpdate].Amount / BasketItems[itemToUpdate].Quantity * newQuantity;
                BasketItems[itemToUpdate].Quantity = newQuantity;
            }

        }

        public void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("BASKET VIEW");
            ShowBasket();
            Console.WriteLine();
            Console.WriteLine("Please provide the item number for deletion");
            Console.WriteLine($"To delete all items, write {BasketItems.Count() + 1}");
            int itemToDelete = GeneralStaticClass.ReadIntNumber();
            while (BasketItems.Count() + 1 < itemToDelete || itemToDelete < 0)
            {
                Console.WriteLine("Invalid choice");
                itemToDelete = GeneralStaticClass.ReadIntNumber();
            }
            if (itemToDelete == BasketItems.Count() + 1)
            {
                BasketItems.Clear();
            }
            else
            {
                BasketItems.RemoveAt(itemToDelete - 1);
            }
        }

        public int GetNewItemQuantity(int itemToUpdate)
        {
            Console.WriteLine("Please provide new quantity");
            int newQuantity = GeneralStaticClass.ReadIntNumber();
            while (newQuantity < 0 || newQuantity > BasketItems[itemToUpdate].Quantity)
            {
                Console.WriteLine("Invalid quantity. Try again!");
                newQuantity = GeneralStaticClass.ReadIntNumber();
            }
            return newQuantity;
        }

        public int GetItemToUpdateNo()
        {
            Console.WriteLine("Please provide the item number for updating");
            int itemToUpdate = GeneralStaticClass.ReadIntNumber();
            while (BasketItems.Count() < itemToUpdate || itemToUpdate < 0)
            {
                Console.WriteLine("Invalid choice");
                itemToUpdate = GeneralStaticClass.ReadIntNumber();
            }
            return itemToUpdate;
        }
    }
}
 


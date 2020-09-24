using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothesShop
{
    public class View
    {
        public Dictionary<int, string> Categories { get; set; }
        public Dictionary<int, string> Types { get; set; }
        public List<int> ItemIds { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }

        public int ItemId { get; set; }

        public View()
        {
            Categories = new Dictionary<int, string>();
            Types = new Dictionary<int, string>();
        }

        public void ShowTypes(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Available clothing types:");
            FindDbClothingItemTypes(db);
        }

        public void AskUserTypeChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose the type");
            int typeNumber = GeneralStaticClass.ReadIntNumber();

            while (!CheckTypeValidity(typeNumber))
            {
                Console.WriteLine("Invalid choice");
                typeNumber = GeneralStaticClass.ReadIntNumber();
            }
        }

        public int AskUserCategoryChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose the category");
            int categoryNumber = GeneralStaticClass.ReadIntNumber();

            while (!CheckCategoryValidity(categoryNumber) && categoryNumber != Categories.Count()+1)
            {
                Console.WriteLine("Invalid choice");
                categoryNumber = GeneralStaticClass.ReadIntNumber();
            }
            return categoryNumber;
        }

        public void AskUserItemChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Please write ID to view the item");
            ItemId = GeneralStaticClass.ReadIntNumber();

            while (!ItemIds.Contains(ItemId))
            {
                Console.WriteLine("Invalid choice");
                ItemId = GeneralStaticClass.ReadIntNumber();
            }
        }
        public bool CheckTypeValidity(int typeNumber)
        {
            while (!Types.ContainsKey(typeNumber))
            {
                return false;
            }
            Type = Types[typeNumber];
            return true;
        }

        public bool CheckCategoryValidity(int categoryNumber)
        {
            while (!Categories.ContainsKey(categoryNumber))
            {
                return false;
            }
            Category = Categories[categoryNumber];
            return true;
        }

        public void ShowItem(ClothesShopContext db)
        {
            Console.Clear();
            var item = db.ClothingItems.FirstOrDefault(i => i.ClothingItemId == ItemId);
            if (item!=null)
            {
                Console.WriteLine($"ID: {item.ClothingItemId} {item.Name} {item.Price} EUR");
                Console.WriteLine("Available sizes: ");
                foreach (var size in db.ClothingSizes.Where(s => s.ClothingItemId == ItemId))
                 {
                  Console.Write($"{size.Size}, ");
                 }
            }
        }

        public void FindDbClothingItemTypes(ClothesShopContext db)
        {
                foreach (var item in db.ClothingItems)
                {
  
                    if (!Types.Values.Contains(item.Type))
                    {
                        Types.Add(Types.Count()+1, item.Type);
                    }
                }

            foreach (var type in Types)
            {
                Console.WriteLine($"{type.Key} - {type.Value}");
            }
        }

        public void ShowClothingItemCategories(ClothesShopContext db)
        {
            Console.Clear();
            Console.WriteLine($"{Type} categories:");

            foreach (var item in db.ClothingItems.Where(i => i.Type == Type))
            {

                if (!Categories.Values.Contains(item.Category))
                {
                    Categories.Add(Categories.Count() + 1, item.Category);
                }
            }
            if (!Categories.Values.Contains("View All"))
            {
                Categories.Add(Categories.Count() + 1, "View All");
            }

            foreach (var category in Categories)
            {
                Console.WriteLine($"{category.Key} - {category.Value}");
            }

        }

        public void ShowClothingCategoryItems(ClothesShopContext db)
        {
            Console.Clear();
            if (Category == "View All")
            {
                ItemIds = new List<int>();
                Console.WriteLine($"{Type} {Category}:");
                foreach (var item in db.ClothingItems.Where(i=>i.Type == Type))
                {
                    Console.WriteLine($"ID: {item.ClothingItemId} {item.Name} {item.Price} EUR");
                    ItemIds.Add(item.ClothingItemId);
                }
            }
            else
            {
                ItemIds = new List<int>();
                Console.WriteLine($"{Type} {Category}:");
                foreach (var item in db.ClothingItems.Where(i => i.Type == Type && i.Category == Category))
                {
                    Console.WriteLine($"ID: {item.ClothingItemId} {item.Name} {item.Price} EUR");
                    ItemIds.Add(item.ClothingItemId);
                }
            }
        }
    }
}

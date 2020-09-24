using System;
using System.Linq;


namespace ClothesShop
{
    
    public class BuyingClothes
    {
        public Basket Basket { get; set; }
        public View View { get; set; }
        public ActionMenu ActionMenu { get; set; }
        public User User { get; set; }

        public BuyingClothes()
        {
            Basket = new Basket();
            View = new View();
            ActionMenu = new ActionMenu(this);
            User = new User();
        }
        public void PurchaceClothes()
        {
            using (var db = new ClothesShopContext())
            {
                Console.WriteLine("Welcome to the online clothing shop!");
                ActionMenu.ChooseStartingUserAction(db);                
            }
        }

        public void ShowHome(ClothesShopContext db)
        {
            var userFirstName = db.Users.FirstOrDefault(u => u.UserId == User.UserId).Name;
            if (userFirstName!="UNKNOWN")
            {
                Console.WriteLine($"Welcome to the online clothing shop {userFirstName}!");
            }
            else
            {
                Console.WriteLine($"Welcome to the online clothing shop!");
            }
            View.ShowTypes(db);
            View.AskUserTypeChoice();
            ShowCategories(db);
        }

        public void ShowCategories (ClothesShopContext db)
        {
            View.ShowClothingItemCategories(db);
            Console.WriteLine($"{View.Categories.Count() + 1} - Back to HomePage");
            int categoryChoice =  View.AskUserCategoryChoice();
            if (categoryChoice == View.Categories.Count()+1)
            {
                Console.Clear();
                ShowHome(db);
            }
            else
            {
                View.ShowClothingCategoryItems(db);
                ActionMenu.ChooseCategoryAction(db);
            }
        }

        public void ShowItem(ClothesShopContext db)
        {
            View.AskUserItemChoice();
            View.ShowItem(db);
            ActionMenu.ChooseItemAction(db);
        }

        public void ShowBasket(ClothesShopContext db)
        {
            Console.Clear();
            Console.WriteLine("BASKET VIEW");
            if (Basket.BasketItems.Count() == 0)
            {
                Console.WriteLine("Your basket is empty");
                ActionMenu.ChooseEmptyBasketAction(db);
            }
            else
            {
                Basket.ShowBasket();
                ActionMenu.ChooseFullBasketAction(db);
            }
        }

        public void Checkout(ClothesShopContext db)
        {
            Console.Clear();
            Console.WriteLine("CHECKOUT");
            Console.WriteLine();
            Basket.ShowBasket();
            Console.WriteLine();
            string shippingAddress = User.ChooseShippingAddress(db);
            if (User.PayForGoods(db,Basket.TotalAmount))
            {
                var sale = new Sale();
                sale.AddSale(db, Basket.TotalAmount, shippingAddress, Basket.BasketItems, User.UserId);
                sale.ChangeSizeQuantityInDb(db, View.Type, Basket.BasketItems);
                if (User.UserName == "UNKNOWN")
                {
                    ActionMenu.ChooseUnregisterUserActions(db);
                }
                else
                {
                    ActionMenu.ChooseUserActions(db);
                }
            }
        }
    }


}


using System;

namespace ClothesShop
{
    public class ActionMenu
    {
        public BuyingClothes BuyingClothes { get; set; }

        public ActionMenu(BuyingClothes buyingClothes)
        {
            BuyingClothes = buyingClothes;

        }

        public void ChooseStartingUserAction(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - Log in");
            Console.WriteLine("2 - Register");
            Console.WriteLine("3 - Shop without registration");

            int choice = GeneralStaticClass.ReadIntNumber();
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("There is no such choice");
                choice = GeneralStaticClass.ReadIntNumber();
            }

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    BuyingClothes.User.LogIn(db);
                    ChooseUserActions(db);
                    break;
                case 2:
                    Console.Clear();
                    BuyingClothes.User.Register(db);
                    Console.WriteLine("User registered, please log in");
                    BuyingClothes.User.LogIn(db);
                    ChooseUserActions(db);
                    break;
                case 3:
                    Console.Clear();
                    BuyingClothes.User.SetUnregisteredShopping(db);
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }
        public void ChooseCategoryAction(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - View Item");
            Console.WriteLine("2 - Back to Categories");
            Console.WriteLine("3 - Back to HomePage");

            int choice = GeneralStaticClass.ReadIntNumber();
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("There is no such choice");
                choice = GeneralStaticClass.ReadIntNumber();
            }
            switch (choice)
            {
                case 1:
                    BuyingClothes.ShowItem(db);
                    break;
                case 2:
                    BuyingClothes.ShowCategories(db);
                    break;
                case 3:
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }

        }

        public void ChooseItemAction(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - Add Item to Basket");
            Console.WriteLine("2 - Go to Basket");
            Console.WriteLine("3 - Back to Category Items");
            Console.WriteLine("4 - Back to HomePage");

            int choice = GeneralStaticClass.ReadIntNumber();
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4)
            {
                Console.WriteLine("There is no such choice");
                choice = GeneralStaticClass.ReadIntNumber();
            }
            switch (choice)
            {
                case 1:
                    BuyingClothes.Basket.AddItemToBasket(db, BuyingClothes.View.ItemId);
                    ChooseItemActionAfterAddingToBasket(db);
                    break;
                case 2:
                    BuyingClothes.ShowBasket(db);
                    break;
                case 3:
                    BuyingClothes.View.ShowClothingCategoryItems(db);
                    ChooseCategoryAction(db);
                    break;
                case 4:
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        public void ChooseEmptyBasketAction(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - Back to Item View");
            Console.WriteLine("2 - Back to HomePage");
            switch (GeneralStaticClass.ReadIntNumber())
            {
                case 1:
                    Console.Clear();
                    BuyingClothes.View.ShowItem(db);
                    ChooseItemAction(db);
                    break;
                case 2:
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        public void ChooseFullBasketAction(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - Proceed to Checkout");
            Console.WriteLine("2 - Update Basket Item");
            Console.WriteLine("3 - Delete Basket Item(s)");
            Console.WriteLine("4 - Back to Item View");
            Console.WriteLine("5 - Back to HomePage");

            switch (GeneralStaticClass.ReadIntNumber())
            {
                case 1:
                    BuyingClothes.Checkout(db);
                    break;
                case 2:
                    BuyingClothes.Basket.UpdateItem();
                    BuyingClothes.ShowBasket(db);
                    break;
                case 3:
                    BuyingClothes.Basket.DeleteItem();
                    BuyingClothes.ShowBasket(db);
                    break;
                case 4:
                    Console.Clear();
                    BuyingClothes.View.ShowItem(db);
                    ChooseItemAction(db);
                    break;
                case 5:
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        public void ChooseItemActionAfterAddingToBasket(ClothesShopContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - Go to Basket");
            Console.WriteLine("2 - Back to Item View");
            Console.WriteLine("3 - Back to Category View");
            Console.WriteLine("4 - Back to Home Page");

            switch (GeneralStaticClass.ReadIntNumber())
            {
                case 1:
                    Console.Clear();
                    BuyingClothes.ShowBasket(db);
                    break;
                case 2:
                    Console.Clear();
                    BuyingClothes.View.ShowItem(db);
                    ChooseItemAction(db);
                    break;
                case 3:
                    Console.Clear();
                    BuyingClothes.ShowCategories(db);
                    break;
                case 4:
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        public void ChooseUserActions(ClothesShopContext db)
        {
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("1 - User Information");
            Console.WriteLine("2 - Home Page");
            int choice = GeneralStaticClass.ReadIntNumber();
            while (choice!=1 && choice!=2)
            {
                Console.WriteLine("Invalid choice");
                choice = GeneralStaticClass.ReadIntNumber();
            }
            if (choice == 1)
            {
                Console.Clear();
                BuyingClothes.User.ShowUserInfo(db);
                Console.WriteLine();
                Console.WriteLine("Back to Home Page? Y/N");

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.Clear();
                    BuyingClothes.ShowHome(db);
                }
            }
            else
            {
                Console.Clear();
                BuyingClothes.ShowHome(db);
            }
        }

        public void ChooseUnregisterUserActions(ClothesShopContext db)
        {
            Console.WriteLine("Back to Home Page? Y/N");
            string choice = Console.ReadLine().ToUpper();
            while (choice != "Y" && choice != "N")
            {
                Console.WriteLine("Invalid choice");
                choice = Console.ReadLine().ToUpper();
            }
            if (choice == "Y")
            {
                BuyingClothes.ShowHome(db);
            }
        }
    }
    }







using System;
using System.Linq;

namespace ClothesShop
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }

        public void LogIn(ClothesShopContext db)
        {
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();

            var user = db.Users.FirstOrDefault(u => u.UserName == username);
            
            while (user == null || user.Name == "UNKNOWN")
            {
                Console.WriteLine("Wrong username. Try again!");
                username = Console.ReadLine();
            }
            UserName = username;
            UserId = user.UserId;
            Console.Clear();
        }

        public void Register(ClothesShopContext db)
        {
            Console.WriteLine("Please choose your username");

            string userName = Console.ReadLine();
            while (db.Users.Any(u => u.UserName == userName))
            {
                Console.Clear();
                Console.WriteLine("Such username already exists");
                Console.WriteLine("Please choose your username");
                userName = Console.ReadLine();
            }
            UserName = userName;
            Console.WriteLine("Please provide your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please provide your Surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Please provide your Address");
            Address = Console.ReadLine();
            Console.WriteLine("Please provide your Email");

            string email = Console.ReadLine();

            while (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Invalid email. Please provide email");
                email = Console.ReadLine();
            }
            while (db.Users.Any(u => u.Email == email))
            {
                Console.WriteLine("User with such email address already exists");
                Console.WriteLine("Please provide your Email");
                email = Console.ReadLine();
            }

            Email = email;
            db.Users.Add(new User { Address = Address, Email = Email, Name = Name, Surname = Surname, UserName = UserName });
            db.SaveChanges();
            UserId = db.Users.FirstOrDefault(a => a.UserName == UserName).UserId;
            Console.Clear();
        }

        public void SetUnregisteredShopping(ClothesShopContext db)
        {
            UserId = db.Users.FirstOrDefault(a => a.UserName == "UNKNOWN").UserId;
            UserName = "UNKNOWN";
        }

        public string ChooseShippingAddress(ClothesShopContext db)
        {
            var shippingAddress = db.Users.FirstOrDefault(a => a.UserId == UserId).Address;
            if (shippingAddress == "UNKNOWN")
            {
                Console.WriteLine("Please provide shipping address");
                shippingAddress = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Current address: {shippingAddress}");
                Console.WriteLine("Ship to address? Y/N");
                string choice = Console.ReadLine().ToUpper();
                while (choice != "Y" && choice != "N")
                {
                    Console.WriteLine("Invalid choice");
                    choice = Console.ReadLine();
                }
                if (choice == "N")
                {
                    Console.WriteLine("Please provide shipping address");
                    shippingAddress = Console.ReadLine();
                }
            }

            return shippingAddress;
        }

        public bool PayForGoods(ClothesShopContext db, double payableAmount)
        {
            var userFirstName = db.Users.FirstOrDefault(u => u.UserId == UserId).Name;
            if (userFirstName!= "UNKNOWN")
            {
                Console.WriteLine($"Please pay {payableAmount} EUR, {userFirstName}. Confirm? Y/N");
            }
            else
            {
                Console.WriteLine($"Please pay {payableAmount} EUR. Confirm? Y/N");
            }
            
            string paymentConfirmation = Console.ReadLine().ToUpper();
            while (paymentConfirmation != "Y" && paymentConfirmation != "N")
            {
                Console.WriteLine("Invalid choice. Try again.");
                paymentConfirmation = Console.ReadLine().ToUpper();
            }
            if (paymentConfirmation == "Y")
            {
                
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
            
        }

        public void ShowUserInfo(ClothesShopContext db)
        {
            var user = db.Users.FirstOrDefault(u => u.UserId == UserId);
            Console.WriteLine("PERSONAL DETAILS");
            Console.WriteLine();
            Console.WriteLine($"USERNAME: {user.UserName}");
            Console.WriteLine($"NAME: {user.Name}");
            Console.WriteLine($"SURNAME: {user.Surname}");
            Console.WriteLine($"ADDRESS: {user.Address}");
            Console.WriteLine($"EMAIL: {user.Email}");
            Console.WriteLine();
            Console.WriteLine("ORDER HISTORY");
            Console.WriteLine();
            var orders = db.Sales.Where(o => o.UserId == UserId);

            foreach (var order in orders)
            {
                Console.WriteLine(order.PurchaceDateTime);
                var purchasedItems = db.BasketItems.Where(i => i.SaleId == order.SaleId);
                foreach (var item in purchasedItems)
                {
                    Console.WriteLine($"{item.ClothingItem} ({item.Size}) Qty:{item.Quantity} {item.Amount} EUR");
                }
                Console.WriteLine();
            }
        }
    }
}




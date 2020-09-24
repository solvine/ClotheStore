using System;
using System.Linq;

namespace ClothesShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new BuyingClothes();
            shop.PurchaceClothes();

            ExitApp();
        }

        static void ExitApp()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

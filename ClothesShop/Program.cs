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

            GeneralStaticClass.ExitApp();
        }

  
    }
}

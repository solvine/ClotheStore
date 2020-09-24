using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    static class GeneralStaticClass
    {
        public static int ReadIntNumber()
        {
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Wrong input");
            }

            return choice;
        }
    }
}

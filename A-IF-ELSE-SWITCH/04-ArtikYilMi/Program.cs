using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArtikYilMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir yıl giriniz:");
            int yil = Convert.ToInt32(Console.ReadLine());
            if (yil % 4 == 0 && (yil % 100 != 0 || yil % 400 == 0))
                Console.WriteLine($"{yil} Artık yıldır.");
            else
                Console.WriteLine($"{yil} Artık yıl değildir.");

            Console.ReadKey();
        }
    }
}

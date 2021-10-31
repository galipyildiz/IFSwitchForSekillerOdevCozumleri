using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UcSayidanBuyuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi 1 girinz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi 2 giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi 3 giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 <= sayi2 && sayi1 <= sayi3)
            {
                Console.WriteLine("Küçük sayı: " + sayi1);
            }
            else
            {
                if (sayi2 < sayi3)
                {
                    Console.WriteLine("Küçük sayı: " + sayi2);
                }
                else
                {
                    Console.WriteLine("Küçük sayı: " + sayi3);
                }
            }

            Console.ReadKey();
        }
    }
}

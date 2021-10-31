using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_KarakterBuyukKucuk
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            Console.WriteLine("Bir karakter giriniz.");
            char karakter = Convert.ToChar(Console.ReadLine());
            if (Char.IsLower(karakter))
                Console.WriteLine("küçük harf girdiniz.");
            else if (Char.IsUpper(karakter))
                Console.WriteLine("büyük harf girdiniz.");
            else
            {
                Console.WriteLine("Lütfen harf giriniz.");
                goto baslangic;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BuyukMuKucukMu
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1;
            double sayi2;
            Console.Write("Sayi 1 giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayi 2 giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("Büyük sayı sayi1: " + sayi1.ToString());
            else if (sayi1 < sayi2)
                Console.WriteLine("Büyük sayı sayi2: " + sayi2.ToString());
            else
                Console.WriteLine("Sayılar eşit.");

            Console.ReadKey();
        }
    }
}

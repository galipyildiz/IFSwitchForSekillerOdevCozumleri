using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SayiMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            string sayi = Console.ReadLine();
            bool sayiMi = false;
            char[] sayiDizisi = sayi.ToCharArray();
            foreach (var item in sayiDizisi)
            {
                if (char.IsNumber(item))
                    sayiMi = true;
                else
                    sayiMi = false;
            }
            Console.WriteLine(sayiMi ? "Sayidir" : "Sayi Değildir");

            Console.ReadKey();
        }
    }
}

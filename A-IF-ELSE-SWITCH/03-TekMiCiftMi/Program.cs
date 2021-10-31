using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TekMiCiftMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine("Sayı çifttir.");
            else
                Console.WriteLine("Sayı tektir.");

            Console.ReadKey();
        }
    }
}

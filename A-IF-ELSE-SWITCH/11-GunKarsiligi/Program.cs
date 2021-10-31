using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GunKarsiligi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz: (1-7)");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case (1):
                    Console.WriteLine("Pazartesi");
                    break;
                case (2):
                    Console.WriteLine("Salı");
                    break;
                case (3):
                    Console.WriteLine("Çarşamba");
                    break;
                case (4):
                    Console.WriteLine("Perşembe");
                    break;
                case (5):
                    Console.WriteLine("Cuma");
                    break;
                case (6):
                    Console.WriteLine("Cumartesi");
                    break;
                case (7):
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("1-7 arasında değer giriniz.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

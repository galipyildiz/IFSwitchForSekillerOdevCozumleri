using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_HarfNotuKarsiligi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınav Puanı giriniz.");
            double puan = Convert.ToDouble(Console.ReadLine());
            if (puan < 40)
                Console.WriteLine("Harf Notunuz: F");
            else if (puan < 65)
                Console.WriteLine("Harf Notunuz: D");
            else if (puan < 80)
                Console.WriteLine("Harf Notunuz: C");
            else if (puan < 90)
                Console.WriteLine("Harf Notunuz: B");
            else if (puan <= 100)
                Console.WriteLine("Harf Notunuz: A");
            else
                Console.WriteLine("0-100 arası değer giriniz.");

            Console.ReadKey();
        }
    }
}

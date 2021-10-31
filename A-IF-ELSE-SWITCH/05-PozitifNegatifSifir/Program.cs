using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PozitifNegatifSifir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0)
                Console.WriteLine(sayi + " negatiftir.");
            else if (sayi > 0)
                Console.WriteLine(sayi + " pozitiftir.");
            else
                Console.WriteLine(sayi + " sıfırdır.");

            Console.ReadKey();
        }
    }
}

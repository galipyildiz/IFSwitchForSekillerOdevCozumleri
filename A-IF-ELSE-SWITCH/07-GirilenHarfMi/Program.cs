using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_GirilenHarfMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir karakter giriniz:");
            char karakter = Convert.ToChar(Console.Read());
            if ((karakter >= 65 && karakter <= 90) || (karakter >= 97 && karakter <= 122))
                Console.WriteLine("Karakter harftir.");
            else
                Console.WriteLine("Karakter harf değildir.");

            //2. yöntem
            if (Char.IsLetter(karakter))
                Console.WriteLine("Harftir.");
            else
                Console.WriteLine("Harf değildir.");
            Console.ReadKey();
        }
    }
}

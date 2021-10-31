using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_UcgenCesit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin 1. kenar uzunluğunu giriniz.");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 2. kenar uzunluğunu giriniz.");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 3. kenar uzunluğunu giriniz.");
            int kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 && kenar1 == kenar3 && kenar2 == kenar3)
                Console.WriteLine("Eş kenar üçgen.");
            else if (kenar1 == kenar2 || kenar2 == kenar3 || kenar3 == kenar1)
                Console.WriteLine("İkiz kenar üçgen.");
            else
                Console.WriteLine("Çeşit kenar üçgen.");

            Console.ReadKey();
        }
    }
}

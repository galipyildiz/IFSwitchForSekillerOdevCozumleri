using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AciyaGoreUcgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin 1. acisini giriniz.");
            int aci1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 2. acisini giriniz.");
            int aci2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 3. acisini giriniz.");
            int aci3 = Convert.ToInt32(Console.ReadLine());

            if (aci1 + aci2 + aci3 == 180)
                Console.WriteLine("Geçerli üçgen.");
            else
                Console.WriteLine("Üçgen değildir.");

            Console.ReadKey();
        }
    }
}

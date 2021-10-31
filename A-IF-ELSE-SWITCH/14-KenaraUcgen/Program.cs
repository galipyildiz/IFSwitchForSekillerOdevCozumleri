using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_KenaraUcgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen 1. uzunluğu giriniz. Büyükten küçüğe doğru giriniz.");
            int uzunluk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgen 2. uzunluğu giriniz.");
            int uzunluk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgen 3. uzunluğu giriniz.");
            int uzunluk3 = Convert.ToInt32(Console.ReadLine());

            if (uzunluk1 < uzunluk2 + uzunluk3 && uzunluk1 > uzunluk2 - uzunluk3)
            {
                Console.WriteLine("Geçerli üçgen.");
            }
            else
            {
                Console.WriteLine("Üçgen geçersiz.");
            }

            Console.ReadKey();
        }
    }
}

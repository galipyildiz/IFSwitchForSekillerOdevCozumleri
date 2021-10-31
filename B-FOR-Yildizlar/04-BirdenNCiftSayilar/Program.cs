using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BirdenNCiftSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaça kadar sayı yazılsın.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BirdenNeTumSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaça kadar sayı yazılsın.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}

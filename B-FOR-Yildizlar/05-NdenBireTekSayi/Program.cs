using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_NdenBireTekSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaça kadar sayı yazılsın.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (i % 2 == 1)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}

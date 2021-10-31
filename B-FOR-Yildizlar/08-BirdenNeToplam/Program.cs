using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BirdenNeToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N degeri giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NninKatlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N degeri giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            int ortakKat = 0;
            for (int i = n; i > 1; i--)
            {
                if (n % i == 0)
                {
                    ortakKat = i;
                }
            }
            Console.WriteLine(ortakKat);
            for (int j = 0; j <= n; j++)
            {
                if (j % ortakKat == 0)
                {
                    Console.Write(j + " ");
                }
            }

            Console.ReadLine();
        }
    }
}

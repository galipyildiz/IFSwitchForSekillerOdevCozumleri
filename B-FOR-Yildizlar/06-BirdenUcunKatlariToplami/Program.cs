using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BirdenUcunKatlariToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaça kadar sayı yazılsın.");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("Toplam: " + toplam);

            Console.ReadLine();
        }
    }
}

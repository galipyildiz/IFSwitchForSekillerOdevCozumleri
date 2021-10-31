using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_KarMaliyetZarHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürünün maliyet fiyatını giriniz.");
            decimal maliyet = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ürünün satış fiyatını giriniz.");
            decimal satis = Convert.ToDecimal(Console.ReadLine());
            decimal kazancZarar;
            if (maliyet > satis)
            {
                kazancZarar = maliyet - satis;
                Console.WriteLine($"{kazancZarar}TL ZARAR ettiniz.");
            }
            else if (maliyet < satis)
            {
                kazancZarar = satis - maliyet;
                Console.WriteLine($"{kazancZarar}TL KAR ettiniz.");
            }
            else
            {
                Console.WriteLine("Ne kar ne zarar edilmiştir.");
            }

            Console.ReadLine();
        }
    }
}

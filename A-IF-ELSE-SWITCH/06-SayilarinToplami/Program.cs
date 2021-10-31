using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SayilarinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayi toplamak istiyorsunuz?");
            int sayiAdet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplamak istediğiniz sayıları giriniz.");
            int toplam = 0;
            for (int i = 0; i < sayiAdet; i++)
            {
                int[] sayiDizi = new int[sayiAdet];
                sayiDizi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizi[i];
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AyNoGoreGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ay numarası giriniz.");
            int ayNo = Convert.ToInt32(Console.ReadLine());
            switch (ayNo)
            {
                case (1):
                    Console.WriteLine("Ay Ocak 31 gün içermektedir.");
                    break;
                case (2):
                    Console.WriteLine("Ay Şubat 28 gün içermektedir.");
                    break;
                case (3):
                    Console.WriteLine("Ay Mart 31 gün içermektedir.");
                    break;
                case (4):
                    Console.WriteLine("Ay Nisan 30 gün içermektedir.");
                    break;
                case (5):
                    Console.WriteLine("Ay Mayıs 31 gün içermektedir.");
                    break;
                case (6):
                    Console.WriteLine("Ay Haziran 30 gün içermektedir.");
                    break;
                case (7):
                    Console.WriteLine("Ay Temmuz 31 gün içermektedir.");
                    break;
                case (8):
                    Console.WriteLine("Ay Ağustos 31 gün içermektedir.");
                    break;
                case (9):
                    Console.WriteLine("Ay Eylül 30 gün içermektedir.");
                    break;
                case (10):
                    Console.WriteLine("Ay Ekim 31 gün içermektedir.");
                    break;
                case (11):
                    Console.WriteLine("Ay Kasım 30 gün içermektedir.");
                    break;
                case (12):
                    Console.WriteLine("Ay Aralık 31 gün içermektedir.");
                    break;
                default:
                    Console.WriteLine("1-12 arasında değer giriniz.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

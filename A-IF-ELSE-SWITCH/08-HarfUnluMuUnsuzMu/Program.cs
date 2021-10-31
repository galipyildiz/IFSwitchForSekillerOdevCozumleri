using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_HarfUnluMuUnsuzMu
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            Console.WriteLine("Bir ascii giriniz:");
            char harf = Convert.ToChar(Console.ReadLine());
            int ascii = Convert.ToInt32(harf);
            if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
            {
                switch (ascii)
                {
                    case (65):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (69):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (73):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (79):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (85):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (97):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (101):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (105):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (111):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    case (117):
                        Console.WriteLine("Ünlüdür.");
                        break;
                    default:
                        Console.WriteLine("Ünsüzdür.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen ascii yada ingilizce harf giriniz.");
                goto baslangic;
            }

            Console.ReadLine();
        }
    }
}

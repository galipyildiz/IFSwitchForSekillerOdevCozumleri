using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizliSekiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SekilleriCiz();
        }

        private void nudSatirSayisi_ValueChanged(object sender, EventArgs e)
        {
            SekilleriCiz();
        }
        private void txtKarakter_TextChanged(object sender, EventArgs e)
        {
            SekilleriCiz();
        }

        private void SekilleriCiz()
        {
            int n = (int)nudSatirSayisi.Value;
            string karakter = txtKarakter.Text;
            Sekil1(n, karakter);
            Sekil2(n, karakter);
            Sekil3(n, karakter);
            Sekil4(n, karakter);
            Sekil5(n, karakter);
            Sekil6(n, karakter);
            Sekil7(n, karakter);
            Sekil8(n, karakter);
            Sekil9(n, karakter);
            Sekil10(n, karakter);
        }



        private string Kere(string metin, int adet)
        {
            string sonuc = "";
            for (int i = 0; i < adet; i++)
            {
                sonuc += metin;
            }
            return sonuc;
        }
        private void Sekil10(int n, string karakter)
        {
            int orta = (n + 1) / 2;
            int yildizAdet, boslukAdet;
            int genislik = n / 2 == 0 ? n - 1 : n;
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                yildizAdet = (i > orta ? n + 1 - i : i) * 2 - 1;
                boslukAdet = (genislik - yildizAdet) / 2;
                sonuc += Kere(new string(' ', karakter.Length), boslukAdet);
                sonuc += Kere(karakter, yildizAdet);
                sonuc += Kere(new string(' ', karakter.Length), boslukAdet);
                sonuc += Environment.NewLine;
            }
            txtSekil10.Text = sonuc;
        }
        private void Sekil9(int n, string karakter)
        {
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)//başlangıç ve bitiş
                    sonuc += Kere(karakter, n);
                else//2 yıldız şekli azaltılmış şekilde başlangıçta ve sonda yıldız
                    sonuc += karakter + Kere(new string(' ', karakter.Length), n - 2) + karakter;
                sonuc += Environment.NewLine;
            }
            txtSekil9.Text = sonuc;
        }
        private void Sekil8(int n, string karakter)
        {
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sonuc += (i == j || i + j == n + 1) ? karakter : new string(' ', karakter.Length);
                    //1-1 yada 1+4 == 4+1 1. satır
                    //2-2 yada 2+3 == 4+4 2. satır
                }
                sonuc += Environment.NewLine;
            }

            txtSekil8.Text = sonuc;
        }
        private void Sekil7(int n, string karakter)
        {
            string sonuc = "";//n-i kadar boşluk azalan

            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(new string(' ', karakter.Length), n - i);
                sonuc += karakter;
                sonuc += Environment.NewLine;
            }

            txtSekil7.Text = sonuc;
        }
        private void Sekil6(int n, string karakter)
        {
            string sonuc = "";//i kadar boşluk
            for (int i = 0; i < n; i++)
            {
                sonuc += Kere(new string(' ', karakter.Length), i);
                sonuc += karakter;
                sonuc += Environment.NewLine;
            }

            txtSekil6.Text = sonuc;
        }
        private void Sekil5(int n, string karakter)
        {
            string sonuc = "";//2*n-1 kadar artıyor aşağıya doğru
            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(" ", (n - i) * karakter.Length);
                sonuc += Kere(karakter, 2 * i - 1);
                sonuc += "\r\n";
            }
            txtSekil5.Text = sonuc;
        }
        private void Sekil4(int n, string karakter)
        {
            string sonuc = "";
            for (int i = 1; i <= n; i++)
            {
                sonuc += Kere(" ", (n - i) * karakter.Length); //boşluk at tek karakter atmazsak bozulmasın diye length ile çarpıyoruz
                sonuc += Kere(karakter, i);//karakter çiz
                sonuc += "\r\n";
            }
            txtSekil4.Text = sonuc;
        }
        private void Sekil3(int n, string karakter)
        {
            string sonuc = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sonuc += karakter + " ";
                }
                sonuc += Environment.NewLine;
            }
            txtSekil3.Text = sonuc;
        }
        private void Sekil2(int n, string karakter)
        {
            string sonuc = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sonuc += karakter;
                }
                sonuc += Environment.NewLine;
            }
            txtSekil2.Text = sonuc;
        }
        private void Sekil1(int n, string karakter)
        {
            string sonuc = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sonuc += karakter;
                }
                sonuc += "\r\n";
            }
            txtSekil1.Text = sonuc;
        }
    }
}

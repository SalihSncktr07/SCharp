using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Şekil
{
    string path = System.IO.Path.GetFullPath("/../../sekiller");
    int[] UretilenSayilar = new int[30];
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int puan = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Text = "Sonraki Soru";

            sayac++;
        }

        private int uretilmeyenSayiUret()
        {
            int sayi = sayiUret;
            bool dahaOnceUretildimi = false;
            for (int i = 0; i < uretilenSayilar.length; i++)
            {
                if (uretilenSayilar[i] == sayi)
                {
                    sayi == sayiUret();
                    dahaOnceUretildimi = true;
                }
            }
            if (dahaOnceUretildimi == false)
            {
                raturn sayi;
            }
            return uretilmeyenSayiUret();
        }

        private int sayiUret()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 30);
            return sayi;
        }

        string[] SeceneklerKumesi = new string[];
        {
            "kare", "dikdörtgen", "yıldız", "elips",
            "dükucgen", "artı", "eksi", "kuş",
            "altıgen", "yedigen", "kare", "yuvarlak",
            "beşgen", "düzgen", "dörtköşeliyıldız", "dörtyaprak",
            "dokuzgen", "kalp", "artı", "küp", "yuvarlak", "yıldız",
            "dikdörtgen", "kare", "dokuzgen", "kare", "dikdörtgen",
            "ok", "yuvarlak", "elips", "yıldız", "eksi", "artı"};

    private 
        }
    }
}

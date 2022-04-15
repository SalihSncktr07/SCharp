using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    internal class Kutu
    {
        // Field (Alan)

        public double uzunluk;
        private double genislik;
        private double yukseklik;

        // Constructor (Yapıcı Metot)

        public Kutu()
        {
            //uzunluk = 5;
            //Console.WriteLine("Nesne Kuruldu");


        }
        // Consturctor Overload

        public Kutu(double uzunluk, double genislik, double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        //Erişim Belirliyicileri
        /*
          
        Public                  : Her yerden erişilebilir.
        Private                 : Sadece Tanımlandığı sınıf içerisinden erişilebilir.
        Interanl                : Sadece bulunduğu projede erişilebilir.
        Protected               : Sadece tanımlandığı sınıf ta da o sınıfı miras alan sınıflardan erişilebilir.
        Protected Internal      : Sadece tanımlandığı sınıf ta da o sınıfı miras alan sınıflardan erişilebilir.
            Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur, Protected dan farkı budur.
        
        */
    }
}

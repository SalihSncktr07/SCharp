using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Yetki.SuperAdmin);

            //var id = (int)Yetki.SuperAdmin;
            //Console.WriteLine(id);

            Ayakkabı ayak = new = Ayakkabı();
            ayak.Brand = AyakkabıMarka.Nike;
            ayak.SearchByBrand(AyakkabıMarka.Nike);

            Console.WriteLine("No : " + int(AyakkabıMarka.Adidas));
            Console.WriteLine("Marka : " + ayak.Brand);
            Console.WriteLine("No : " + int(ayak.Brand));

            Console.ReadLine();
        }
    }

    //enum Yetki
    //{
    //    Normal,
    //    Moderator,
    //    Editor,
    //    Admin,
    //    SuperAdmin
    //}

    //enum Yetki
    //{
    //    Normal = 0,
    //    Moderator = 1,
    //    Editor = 2,
    //    Admin = 3,
    //    SuperAdmin = 4
    //}

    enum AyakkabıMarka
    {
        Nike = 43,
        Adidas = 26,
        Puma = 84,
        Colombia = 100
    }

    class Ayakkabı
    {
        public AyakkabıMarka Brand(get; set;)
            public void SearchByBrand(AyakkabıMarka brand)
        {
            if (Brand = brand)
            {
                Console.WriteLine("Mevcut");
            }
            else
            {
                Console.WriteLine("Stokta Yok");
            }
        }
    }
}

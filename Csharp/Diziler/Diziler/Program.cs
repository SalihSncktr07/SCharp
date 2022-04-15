using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            //int[] dizi = new int[25];
            //bool[] dizi1 = new bool[13];
            //int[] dizi2;
            //dizi2 = new int[43];

            //Diziye Değer Atama

            //int[] strDizi = new int[3];
            //strDizi[0] = 5;
            //strDizi[1] = 7;
            //strDizi[2] = 9;
            //Console.WriteLine("Değer : " + strDizi[2]);

            //String Dizi Oluşturma

            //string[] sDizi = new string[5];
            //sDizi[0] = "a";
            //sDizi[1] = "b";
            //sDizi[2] = "c";
            //sDizi[3] = "d";
            //sDizi[2] = "e";
            //Console.WriteLine(sDizi[3]);

            //İç İçe Dizi oluşturma

            //string[] sehirler = new string[3];
            //sehirler[0] = "Antalya";
            //sehirler[1] = "İstanbul";
            //sehirler[2] = "Adana";

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    for (int j = 0; j < sehirler[i].Length; j++)
            //    {
            //        Console.Write(sehirler[i][j]);
            //    }
            //    Console.WriteLine("***");
            //}

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    if (sehirler[i] == "Adana")
            //    {
            //        Console.WriteLine(sehirler[i] + " ili içerisinde dönülüyor");
            //        System.Threading.Thread.Sleep(2000);
            //        for (int h = 0; h < sehirler[i].Length; h++)
            //        {
            //            if (h == 3)
            //            {
            //                Console.WriteLine("Aranan kan bulundu : " + sehirler[i][h]);
            //            }
            //        }
            //    }
            //}

            //int[] values = new int[3];
            //values[0] = 5;
            //values[1] = values[0] * 2;
            //values[2] = values[1] * 4;
            //Console.WriteLine(values[2]);



            //ÇOK BOYUTLU DİZİLER
            //İki Boyutlu Diziler

            //int[,] ikiBoyut =
            //{
            //    {1, 2 },
            //    {3, 4 },
            //    {5, 6 },
            //    {7, 8 },
            //};
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(ikiBoyut[i, j]);
            //    }
            //}

            //ikiBoyut[0, 0] = 10;
            //ikiBoyut[0, 1] = 20;
            //ikiBoyut[1, 0] = 30;
            //ikiBoyut[1, 1] = 40;
            //ikiBoyut[2, 0] = 50;
            //ikiBoyut[2, 1] = 60;
            //ikiBoyut[3, 0] = 70;
            //ikiBoyut[3, 1] = 80;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(ikiBoyut[i, j]);
            //    }
            //}



            ////Üç Boyutlu Diziler

            ////int[,,] ucBoyut = new int[4, 2, 2];
            //int[,,] ucBoyut =
            //{
            //    {{1, 2}, {3, 4}},
            //    {{5, 6}, {7, 8}},
            //    {{9, 10}, {11, 12}},
            //    {{13, 14}, {15, 16}}
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine(ucBoyut[i, j, k]);
            //        }
            //    }
            //}

            //ucBoyut [0, 0, 0] = 10;
            //ucBoyut [0, 0, 1] = 20;
            //ucBoyut [0, 1, 0] = 30;
            //ucBoyut [0, 1, 1] = 40;
            //ucBoyut [1, 0, 0] = 50;
            //ucBoyut [1, 0, 1] = 60;
            //ucBoyut [1, 1, 0] = 70;
            //ucBoyut [1, 1, 1] = 80;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine(ucBoyut[i, j, k]);
            //        }
            //    }
            //}

            //Düzensiz(Jagged) Diziler

            //int[][] jagged =
            //{
            //    new int[] { 1, 2, 3, 4, 5, 6},
            //    new int[] { 1, 2},
            //    new int[] { 1, 2, 3, 4},
            //    new int[] {1}
            //};

            //foreach(var jag in jagged)
            //{
            //    foreach (var eleman in jag)
            //    {
            //        Console.Write(eleman);
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}

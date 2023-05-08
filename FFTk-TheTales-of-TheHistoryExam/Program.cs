using FFTkTheTalesofTheHistoryExam.kviz;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace FFTkTheTalesofTheHistoryExam
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Megjelenites megjelenito = new Megjelenites();
            //megjelenito.palyaMegjelenites("pálya1");
            //megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz");
            //megjelenito.menuMegjelenites(0);
            Kviz kviz = new Kviz();

            //foreach (var item in kviz.beolvasas())
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            Console.WriteLine(kviz.kvizTest());



            Console.ReadKey();
        }
    }
}

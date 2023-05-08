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
            //
            //Megjelenites megjelenito = new Megjelenites();
            //megjelenito.palyaMegjelenites("pálya1");
            //megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz");
            //megjelenito.menuMegjelenites(0);



            //foreach (var item in kviz.beolvasas("kviz.txt"))
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            /*Amikor meghívjuk a kvízt ezzel a módszerrel meg kell adni, hogy melyik pályának a kvízét szertnénk pl.: kviz_palyaneve.txt. 
            Ebben a példában az alap (test) kvíz található. | Összesen egy tesztben 5 db kérdés található 
            Jelen pillanatban mind a két helyen át kell írni. */

            Kviz kviz = new Kviz("kviz.txt");
            Console.WriteLine(kviz.kvizTest("kviz.txt"));



            Console.ReadKey();
        }
    }
}

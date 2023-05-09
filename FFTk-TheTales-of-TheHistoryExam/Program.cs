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




            /*                                           
             ____  _     _  ____ 
            /  _ \/ \ /\/ \/_   \
            | / \|| | ||| | /   /
            | \_\|| \_/|| |/   /_
            \____\\____/\_/\____/                                                                        
            */

            /*Amikor meghívjuk a kvízt ezzel a módszerrel meg kell adni, hogy melyik pályának a kvízét szertnénk pl.: kviz_palyaneve.txt. 
            Ebben a példában az alap (test) kvíz található. | Összesen egy tesztben 5 db kérdés található 
            */

            Kviz kviz = new Kviz("athen.txt");
            Console.WriteLine(kviz.kvizTest("athen.txt"));
            //Kérédések kiírása 
            Console.WriteLine(String.Join("\n ---", kviz.Kerdesek()));
            //Pont
            Console.WriteLine("Ennyi pontot értél el: "+kviz.Pont());


            Console.ReadKey();
        }
    }
}

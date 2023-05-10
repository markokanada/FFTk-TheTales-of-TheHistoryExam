using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FFTkTheTalesofTheHistoryExam
{
    internal class Harc : ISebzes, IGyogyulas, IVedelem
    {
        public Harc()
        {
            Random random = new Random();

            Elet = 100;
            SebzesMertek = random.Next(15, 21);
            VedelemMertek = random.Next(1, 6);
        }

        private int elet;
        public int Elet
        {
            get { return elet; }
            set { elet = value; }
        }

        private int sebzes;
        public int SebzesMertek
        {
            get { return sebzes; }
            set { sebzes = value; }
        }
        private int vedelem;
        public int VedelemMertek
        {
            get { return vedelem; }
            set { vedelem = value; }
        }

        public void Harcolas(Ellenfel ellenfel)
        {
            Console.WriteLine("-----A harc elkezdődik!-----\n\n");


            while (Elet > 0 && ellenfel.Elet > 0)
            {

                Thread.Sleep(1000);
                //player támad
                if (Elet > 0)
                {
                    int dmg = SebzesMertek - ellenfel.VedelemMertek;
                    ellenfel.Elet -= dmg;
                    Console.WriteLine("Te támadsz !");
                    Console.WriteLine("Hátralévő ellenfél életerő -> " + ellenfel.Elet);
                    Console.WriteLine();
                }

                Thread.Sleep(1000);

                //enemy támad

                if (ellenfel.Elet > 0)
                {
                    int dmg = ellenfel.SebzesMertek - VedelemMertek;
                    Elet -= dmg;
                    Console.WriteLine("Az ellenfél támad !");
                    Console.WriteLine("Hátralévő életerő -> " + Elet);
                    Console.WriteLine();

                }

            }

            if (Elet > 0)
            {
                Console.WriteLine("Nyertél!");
            }
            else
            {
                Console.WriteLine("Vesztettél!");
            }
        }


        public int Pancel
        {
            get { return Pancel; }
            private set
            {
                if (value > 0 && value <= 100)
                {
                    Pancel = value;
                }
                else
                {
                    Pancel = 50;
                }
            }
        }

        public int GyogyulasMerteke
        {
            get { return GyogyulasMerteke; }
            private set
            {
                if (value > 0 && value <= 40)
                {
                    GyogyulasMerteke = value;
                }
                else
                {
                    GyogyulasMerteke = 20;
                }
            }
        }




        public bool Elpusztitas() //sikeres vagy nem
        {
            throw new NotImplementedException();
        }

        public int Gyogyulas() //gyógyulás mértéke
        {
            throw new NotImplementedException();
        }

        public bool Sebzes() //sikeres vagy nem
        {
            throw new NotImplementedException();
        }

        public bool Vedes() //sikeres vagy nem
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Harc : ISebzes, IGyogyulas, IVedelem
    {
        private int elet;
        public int Elet
        {
            get { return elet; }
            set
            {
                elet = value;
            }
        }

        private int sebzes;
        public int SebzesMertek
        {
            get { return sebzes; }
            set
            {
                sebzes = value;
            }
        }
        private int vedelem;
        public int VedelemMertek
        {
            get { return vedelem; }
            set
            {
                vedelem = value;
            }
        }

        public void Fight(Ellenfel ellenfel)
        {
            Console.WriteLine("A harc elkezdődik!");

            while (Elet > 0 && ellenfel.Elet > 0)
            {
                //player támad

                int dmg = SebzesMertek - ellenfel.VedelemMertek;
                ellenfel.Elet -= dmg;
                Console.WriteLine("Ellenfél élet -> " + ellenfel.Elet);

                //enemy támad

                dmg = ellenfel.SebzesMertek - VedelemMertek;
                Elet -= dmg;
                Console.WriteLine("Élet -> " + Elet);
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

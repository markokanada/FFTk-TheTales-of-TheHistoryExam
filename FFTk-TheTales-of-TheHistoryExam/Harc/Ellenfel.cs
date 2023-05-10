using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Ellenfel
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

        public void Tamadas(Harc harc)
        {
            int damage = this.SebzesMertek - harc.VedelemMertek;
            if (damage > 0)
            {
                harc.Elet -= damage;
                Console.WriteLine("Játékos sebzése: " + SebzesMertek);
            }
            else
            {
                Console.WriteLine("Játékos nem sebzett!");
            }
        }
    }
}

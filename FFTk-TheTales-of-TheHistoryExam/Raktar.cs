using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Raktar : IRaktar
    {
        private int meret;
        public int Meret
        {
            get
            {
                return meret;
            }
            private set 
            {
                if (value > 0 && value <= 10)
                {
                    meret = value;
                }
                else
                {
                    meret = 5;
                }
            }
        }

        private string[] raktar;

        public bool RaktarMeretMegadasa(int meret)
        {
            Meret = meret;
            raktar = new string[Meret];

            if (raktar.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string[] RaktarLekerdezes()
        {
            return raktar;
        }

        public string[] TargyTorles(string targynev)
        {
            List<string> ideiglenesTorleshez = raktar.ToList();
            if (ideiglenesTorleshez.Contains(targynev) == true)
            {
                ideiglenesTorleshez.Remove(targynev);
                raktar = ideiglenesTorleshez.ToArray();
            }

            return raktar;
        }
        public string[] TargyHozzadas(string targynev) //ha null, akkor nincs hely egy új tárgynak
        {

            if (raktar.Length > raktar.Count(x => x != null))
            {
                //if (raktar.Contains(targynev) == true)
                //{
                //majd darab növelés a megadott tárgynál
                //}
                raktar[raktar.Count(x => x != null)] = targynev;
                
                return raktar;
            }
            else
            {
                return null;
            }
        }


        public Raktar(int meret)
        {
            RaktarMeretMegadasa(meret);
        }
    }
}

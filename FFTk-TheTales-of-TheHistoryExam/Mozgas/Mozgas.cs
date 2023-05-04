using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Mozgas : IMozgas
    {

        string[] NemLehetRalepni = new string[9] {"=>", "[", "]", "#", "!", "?", "X", "-", "*"};


        private int sebesseg;
        public int Sebesseg
        {
            get
            {
                return sebesseg;
            }
            set
            {
                if (value < 5 && value > 0)
                {
                    sebesseg = value;
                }
                else
                {
                    sebesseg = 1;
                }
            }
        }

        //jobb és bal
        public int minX { get; private set; }
        public int maxX { get; private set; }
        public int jelenlegiX { get; private set; }

        //fel és le
        public int minY { get; private set; }
        public int maxY { get; private set; }
        public int jelenlegiY { get; private set; }


        public Mozgas(int minx, int maxx, int jelenlegix, int miny, int maxy, int jelenlegiy)
        {
            minX = minx;
            maxX = maxx;
            
            minY = miny;
            maxY = maxy;
            
            jelenlegiX = jelenlegix;
            jelenlegiY = jelenlegiy;
        }


        public void Balra()
        {
            if (jelenlegiX > minX && 1 > minX)
            {
                jelenlegiX -= 1;
            }
        }
        public void Jobbra()
        {
            if(jelenlegiX < maxX && 1 < maxX)
            {
                jelenlegiX += 1;
            }
        }
        public void Fel()
        {
            if (jelenlegiY > minY && 1 > minY)
            {
                jelenlegiY -= 1;
            }
        }
        public void Le()
        {
            if (jelenlegiY < maxY && 1 < maxY)
            {
                jelenlegiY += 1;
            }
        }

        public void Noveles(int mertek)
        {
            Sebesseg += mertek;
        }

        public string Adatok()
        {
            return $"maxX -> {maxX}\nmaxY -> {maxY}\nminX -> {minX}\nmaxY -> {maxY}\njelenlegiX -> {jelenlegiX}\njelenlegiY -> {jelenlegiY}";
        }
    }
}

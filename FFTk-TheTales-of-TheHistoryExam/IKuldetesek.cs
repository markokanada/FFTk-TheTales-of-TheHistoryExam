using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    interface IKuldetesek : IKKuldetes
    {
        void Megnyitas();
        void Bezaras();
        void Interakcio();

        string Nev { get; set; }
        string Leiras { get; set; }
        int Index { get; set; }
    }
}

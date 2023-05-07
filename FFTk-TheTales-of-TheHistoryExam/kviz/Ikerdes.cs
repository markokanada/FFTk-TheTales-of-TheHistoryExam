using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.kviz
{
    interface Ikerdes
    {
        string Kerdes { get; }
        string[] Valaszok { get; }
        int Pontszam { get; }
        string Megoldas(string valasz);
    }
}

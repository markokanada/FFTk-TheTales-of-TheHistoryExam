using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal interface ISzoba
    {
        //"id":0;"név":"Kezdő szoba";"Történet":"Ez egy kezdő szoba";"Kilépési_pont":"szoba2"
        int Id { get; }
        string Nev { get; }
        string Tortenet { get; }
        string KilepesiPont { get; }
    }
}
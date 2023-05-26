using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal interface ISzoba
    {
        int Id { get; }
        string Nev { get; }
        string Leiras { get; }
        string Tortenet { get; }
        int EllenfelekSzama { get; }
        int NPCkSzama { get; }
        List<ISzoba> Targyak { get; }
        List<ISzoba> Szobak { get; }
        int KuldetesekSzama { get;}
    }
}
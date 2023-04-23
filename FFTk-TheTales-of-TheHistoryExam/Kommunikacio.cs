using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Kommunikacio : IKommunikalas, IMegjelenites
    {
        #region IKommunikalas
        void IKommunikalas.Beszed()
        {
            throw new NotImplementedException();
        }

        void IKommunikalas.Bezaras()
        {
            throw new NotImplementedException();
        }

        void IKommunikalas.Interakcio()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IMegjelenites
        string IMegjelenites.KarakterNev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMegjelenites.NPCNev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMegjelenites.KarakterKep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMegjelenites.NPCKep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMegjelenites.Szoveg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenites.ParbeszedIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
    }
}

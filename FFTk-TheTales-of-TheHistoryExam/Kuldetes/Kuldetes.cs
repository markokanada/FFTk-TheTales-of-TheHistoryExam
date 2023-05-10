using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FFTkTheTalesofTheHistoryExam
{
    internal class Kuldetes : ITerkep, IKuldetesek, IKezeles, IMegjelenit
    {
        
        #region ITerkep
        void ITerkep.Bezaras()
        {
            throw new NotImplementedException();
        }
        void ITerkep.Interakcio()
        {
            throw new NotImplementedException();
        }
        void ITerkep.Kicsinyites()
        {
            throw new NotImplementedException();
        }

        void ITerkep.Megnyitas()
        {
            throw new NotImplementedException();
        }

        

        void ITerkep.Nagyitas()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IKuldetesek
        string IKuldetesek.Nev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IKuldetesek.Leiras { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IKuldetesek.Index { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        void IKuldetesek.Interakcio()
        {
            throw new NotImplementedException();
        }
        void IKuldetesek.Bezaras()
        {
            throw new NotImplementedException();
        }
        void IKuldetesek.Megnyitas()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IKezeles
        void IKezeles.Kovetkezo()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Elozo()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Kiiratas()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Erzekeles()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IMegjelenit
        string IMegjelenit.Nev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMegjelenit.Leiras { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenit.Index { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

    }
}

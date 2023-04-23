using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Raktar : IKezeles, ITargy, IFegyver, IGyogyitok, IPancelzat, IHasznalas, IMegjelenitHosszabb
    {
        public int Meret { get; private set; }
        
        #region IKezeles
        void IKezeles.Elozo()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Erzekeles()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Kiiratas()
        {
            throw new NotImplementedException();
        }

        void IKezeles.Kovetkezo()
        {
            throw new NotImplementedException();
        }

       
        #endregion

        #region ITargy
        string ITargy.Nev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ITargy.Szint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

        #region IFegyver
        int IFegyver.Sebzes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IFegyver.Eldobhatosag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region IGyogyitok
        int IGyogyitok.Gyogyitas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region IPancelzat
        int IPancelzat.Vedelem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        #endregion

        #region IHasznalas
        void IHasznalas.Elhasznalas()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IMegjelenitesHosszabb
        string IMegjelenitHosszabb.TargyakNeve { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenitHosszabb.Sebzes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenitHosszabb.Gyogyitas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenitHosszabb.Pancel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenitHosszabb.Eletero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMegjelenitHosszabb.Meret { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
    }
}

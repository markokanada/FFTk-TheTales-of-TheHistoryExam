using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Targy
{
    internal class Targy : ITargy, IFegyver, IGyogyitok, IPancelzat, IHasznalas, IMegjelenitHosszabb
    {

        #region ITargy
        public string Nev
        {
            get
            {
                return Nev;
            }
            private set
            {
                Nev = value;
            }
        }

        public int Szint
        {
            get
            {
                return Szint;
            }
            private set
            {
                Szint = value;
            }
        }
        public int Darab
        {
            get
            {
                return Darab;
            }
            private set
            {
                Darab = value;
            }
        }

        //majd ez egy targyFactory
        public bool TargyLetrehozas(string nev, int szint, int darab)
        {
            Nev = nev;
            Szint = szint;
            Darab = darab;

            if (Nev != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Perkuliahan
{
    #region Mahasiswa
    public class Mahasiswa
    {
        #region Member Variables
        protected int _ID;
        protected string _Nama;
        protected int _NIM;
        #endregion
        #region Constructors
        public Mahasiswa() { }
        public Mahasiswa(string Nama, int NIM)
        {
            this._Nama=Nama;
            this._NIM=NIM;
        }
        #endregion
        #region Public Properties
        public virtual int ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string Nama
        {
            get {return _Nama;}
            set {_Nama=value;}
        }
        public virtual int NIM
        {
            get {return _NIM;}
            set {_NIM=value;}
        }
        #endregion
    }
    #endregion
}
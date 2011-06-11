using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DBConnection
{
    
    public class Student : ClanBiblioteke
    {
	    private int brojIndexa ;
	    private string nazivFakulteta ;
        private int tipClanarine;        
        private int uposlenikID;

        public Student(string blk, string i, string p, string a, string e, string bt, DateTime du, int ind, string faks, int clanarina) : base (blk, i, p, a, e, bt, du)
	    {            
            brojIndexa = ind;
            nazivFakulteta = faks;
            tipClanarine = clanarina;
	    }

        public int BrojIndexa
        {
            get { return brojIndexa; }
            set { brojIndexa = value; }
        }

        public string NazivFakulteta
        {
            get { return nazivFakulteta; }
            set { nazivFakulteta = value; }
        }

        public int TipClanarine
        {
            get { return tipClanarine; }
            set { tipClanarine = value; }
        }

        public int UposlenikID
        {
            get { return uposlenikID=0; }
            set { uposlenikID= value; }
        }

            
       
    }

}

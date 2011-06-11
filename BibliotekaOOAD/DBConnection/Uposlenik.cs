using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DBConnection
{
    
    public class Uposlenik : ClanBiblioteke
    {
	    private string jmbg ;
	    private string tipUposlenika ;
        private int studentID;

	    public Uposlenik(string blk, string i, string p, string a, string e, string bt, DateTime du, string j, string tip) : base (blk, i, p, a, e, bt, du)
	    {
            jmbg = j;
            tipUposlenika = tip;
	    }

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public string TipUposlenika
        {
            get { return tipUposlenika; }
            set { tipUposlenika = value; }
        }       

        public int StudentID
        {
            get { return studentID=0; }
            set { studentID = value; }
        }

    }

}

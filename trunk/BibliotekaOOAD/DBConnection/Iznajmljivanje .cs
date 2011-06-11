using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection
{
    public class Iznajmljivanje
    {

        private String ime;
        private String prezime;
        private String ISBN;
        private String naslovKnjige;
        private DateTime datumIznajmljivanja;
        private DateTime datumVracanja;

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public String ISBN1
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public String NaslovKnjige
        {
            get { return naslovKnjige; }
            set { naslovKnjige = value; }
        }

        public DateTime DatumIznajmljivanja
        {
            get { return datumIznajmljivanja; }
            set { datumIznajmljivanja = value; }
        }

        public DateTime DatumVracanja
        {
            get { return datumVracanja; }
            set { datumVracanja = value; }
        }


    }

}
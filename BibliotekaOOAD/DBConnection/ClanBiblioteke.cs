using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DBConnection
{
    public abstract class ClanBiblioteke 
    {
	    private int brojClanskeKarte ;
	    private string brojLicneKarte ;
	    private string ime ;
	    private string prezime ;
	    private string adresa ;
	    private string email ;
	    private string brojTelefona ;
	    private DateTime datumUclanjivanja ;
	    
	    private int brojIznajmljenihKnjiga ;
	    private bool zaduzen ;
        private Bitmap slika;

        public ClanBiblioteke()
        { }

	    public ClanBiblioteke(string blk, string i, string p, string a, string e, string bt, DateTime du)
	    {
            brojLicneKarte = blk;
            ime = i;
            prezime = p;
            adresa = a;
            email = e;
            brojTelefona = bt;
            datumUclanjivanja = du;           
	    }    
	    
	    /*
	    public void produziClanarinu(int tipClanarine, int brojClanskeKartice)
	    {
	    }   
	    
	    public bool provjeraClanstva(DateTime datumRegistracije, DateTime tekuciDatum)
	    {
	    }
        */

        public int BrojClanskeKarte
        {
            get { return brojClanskeKarte; }
            set { brojClanskeKarte = value; }
        }

        public string BrojLicneKarte
        {
            get { return brojLicneKarte; }
            set { brojLicneKarte = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        public DateTime DatumUclanjivanja
        {
            get { return datumUclanjivanja; }
            set { datumUclanjivanja = value; }
        }

        public int BrojIznajmljenihKnjiga
        {
            get { return brojIznajmljenihKnjiga; }
            set { brojIznajmljenihKnjiga = value; }
        }

        public bool Zaduzen
        {
            get
            {
                return zaduzen;
            }
            set { zaduzen = value; }
        }

        public Bitmap Slika
        {
            get { return slika; }
            set { slika = value; }
        }

      
    }

}

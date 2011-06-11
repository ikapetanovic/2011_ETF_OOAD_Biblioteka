using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DBConnection
{    
    public class Knjiga
    {
        private string isbn, naslov, autor, izdavac;
        private int godinaIzdanja, brojKopija, brojRaspolozivihKopija;
        private Bitmap slika;

        public Knjiga() { }
                
        public Knjiga(string Is, string n, string a, string i, int gi, int bk, int brk) 
        {
            isbn = Is;
            naslov = n;
            autor = a;
            izdavac = i;
            godinaIzdanja = gi;
            brojKopija = bk;
            brojRaspolozivihKopija = brk;
        }
        

        public void iznajmiKnjigu(int brojClanskeKartice) { }
        public void vratiKnjigu(int brojClanskeKartice) { }


        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Izdavac
        {
            get { return izdavac; }
            set { izdavac = value; }
        }

        public int GodinaIzdanja
        {
            get { return godinaIzdanja; }
            set { godinaIzdanja = value; }
        }

        public int BrojKopija
        {
            get { return brojKopija; }
            set { brojKopija = value; }
        }

        public int BrojRaspolozivihKopija
        {
            get { return brojRaspolozivihKopija; }
            set { brojRaspolozivihKopija = value; }
        }

        public Bitmap Slika
        {
            get { return slika; }
            set { slika = value; }
        }  


    }
    
}

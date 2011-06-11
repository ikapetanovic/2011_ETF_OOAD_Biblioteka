using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;

namespace WindowsFormsApplication1
{
    public partial class Iznajmljivanje : Form
    {
        public Iznajmljivanje()
        {
            InitializeComponent();
        }

        private bool IspravanBroj(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s, i))
                {
                    return false;
                }
            }
            return true;
        }
        
        private void provjeri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Treba pisati obavijest o članarini i zaduženju", "Izvještaj", MessageBoxButtons.OK);
        }

        private void produzi_Click(object sender, EventArgs e)
        {
            Registracija r = new Registracija();
            r.Show();
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            PretragaKorisnik pbk = new PretragaKorisnik();
            pbk.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /*

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");

                if (clanska.Text.Length < 1 || isbn.Text.Length < 1)
                {
                    toolStripStatusLabel1.Text = "Popunite sva polja";
                }
                if (!IspravanBroj(clanska.Text))
                {
                    toolStripStatusLabel1.Text = "Broj clanske karte smije sadrzavati samo brojeve.";
                }

                else if (dao.JeLiZaduzen(Convert.ToInt32(clanska.Text)))
                {
                    toolStripStatusLabel1.Text = "Korisnik je vec zaduzen.";
                }

                else if (!dao.ImaLiKopija(isbn.Text))
                {
                    toolStripStatusLabel1.Text = "Nema raspolozivih kopija trazene knjige.";
                }
                else
                {
                    int knjigaID = dao.VratiKnjigaID(isbn.Text);
                    dao.Iznajmi(Convert.ToInt32(clanska.Text), Convert.ToInt32(knjigaID));
                    this.Close();
                }
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Greška prilikom iznajmljivanja";
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (clanska.Text.Length < 1 || isbn.Text.Length < 1)
                {
                    toolStripStatusLabel1.Text = "Popunite sva polja";
                }
                else
                {
                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                    int knjigaID = dao.VratiKnjigaID(isbn.Text);
                    int transakcijaID = dao.VratiTransakcijaID(Convert.ToInt32(clanska.Text), knjigaID);
                    dao.Razduzi(Convert.ToInt32(clanska.Text), knjigaID, transakcijaID);
                    this.Close();
                }
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Greška prilikom razduživanja.";
            }

        }

        */

        private void button3_Click(object sender, EventArgs e)
        {
            Dekodiranje d = new Dekodiranje (clanska, isbn);
            d.ShowDialog();
        }

        private void Iznajmljivanje_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (iznajmi.Checked)
            {
                try
                {                   

                    if (clanska.Text.Length < 1 || isbn.Text.Length < 1)
                    {
                        toolStripStatusLabel1.Text = "Popunite sva polja";
                    }
                    if (!IspravanBroj(clanska.Text))
                    {
                        toolStripStatusLabel1.Text = "Broj članske karte smije sadržavati samo brojeve.";
                    }

                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");

                    if (dao.JeLiZaduzen(Convert.ToInt32(clanska.Text)))
                    {
                        toolStripStatusLabel1.Text = "Korisnik je već zadužen.";
                    }

                    else if (!dao.ImaLiKopija(isbn.Text))
                    {
                        toolStripStatusLabel1.Text = "Nema raspoloživih kopija tražene knjige.";
                    }
                    else
                    {                        
                        int knjigaID = dao.VratiKnjigaID(isbn.Text);
                        dao.Iznajmi(Convert.ToInt32(clanska.Text), Convert.ToInt32(knjigaID));
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    toolStripStatusLabel1.Text = "Greška prilikom iznajmljivanja";
                }

            }
            else if (razduzi.Checked)
            {
                try
                {
                    if (clanska.Text.Length < 1 || isbn.Text.Length < 1)
                    {
                        toolStripStatusLabel1.Text = "Popunite sva polja";
                    }
                    else
                    {
                        DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                        int knjigaID = dao.VratiKnjigaID(isbn.Text);
                        int transakcijaID = dao.VratiTransakcijaID(Convert.ToInt32(clanska.Text), knjigaID);
                        dao.Razduzi(Convert.ToInt32(clanska.Text), knjigaID, transakcijaID);
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    toolStripStatusLabel1.Text = "Greška prilikom razduživanja.";
                }

            }

        }

       
    }
}

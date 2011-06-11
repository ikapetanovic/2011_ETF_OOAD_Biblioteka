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
    public partial class Evidencija : Form
    {
        public Evidencija()
        {
            InitializeComponent();
        }

        private void EvidencijaK_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        public Bitmap Smanji(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
        
     
        private void unesi_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (naslov.Text.Length < 1 || autor.Text.Length < 1 || ISBN.Text.Length < 1 || izdavac.Text.Length < 1) {
                    toolStripStatusLabel1.Text = "Popunite sva polja.";
            
                }
                else if (naslov.Text.Length < 100 && autor.Text.Length < 100 && ISBN.Text.Length < 45 && izdavac.Text.Length < 100)
                {
                    Bitmap slika = (Bitmap)naslovnaStrana.Image;
                    Knjiga k = new Knjiga(ISBN.Text, naslov.Text, autor.Text, izdavac.Text, Convert.ToInt16(godinaIzdanja.Value), Convert.ToInt16(brojKopija.Value), Convert.ToInt16(brojKopija.Value));
                    k.Slika = slika;
                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                    dao.DodajKnjigu(k);
                    toolStripStatusLabel1.Text = "";
                    naslov.Text = autor.Text = ISBN.Text = izdavac.Text = "";
                    brojKopija.Value = 1;
                    //naslovnaStrana.Image=((System.Drawing.Image)(Properties.Resources.Book_icon));
                    toolStripStatusLabel1.Text = "Knjiga je dodana";

                    
                }
                else toolStripStatusLabel1.Text = "Polja ne smiju imati vise od 100 znakova (ISBN 45). Knjiga nije dodana";
            
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
             
        }

        private void ponisti_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    naslovnaStrana.Image = (Image)Smanji((new Bitmap(open.FileName)), 144, 187); 
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kamera k = new Kamera(naslovnaStrana);
            k.Show();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    naslovnaStrana.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            Kamera k = new Kamera(naslovnaStrana);
            k.Show();
        }

        private void naslov_Validated(object sender, EventArgs e)
        {
            if (naslov.Text.Length > 100)
                errorProvider1.SetError(naslov, "Naslov ne smije imati vise od 100 slova");
            else errorProvider1.Clear();
        }

        private void autor_Validated(object sender, EventArgs e)
        {
            if (autor.Text.Length > 100)
                errorProvider2.SetError(autor, "Autor ne smije imati vise od 100 slova");
            else errorProvider2.Clear();
        }

        private void ISBN_Validated(object sender, EventArgs e)
        {
            if (ISBN.Text.Length > 45)
                errorProvider3.SetError(ISBN, "ISBN ne smije imati vise od 45 slova");
            else errorProvider3.Clear();
        }

        private void izdavac_Validated(object sender, EventArgs e)
        {
            if (izdavac.Text.Length > 100)
                errorProvider4.SetError(izdavac, "Izdavac ne smije imati vise od 100 slova");
            else errorProvider4.Clear();
        }
    }
}

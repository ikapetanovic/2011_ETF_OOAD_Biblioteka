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
    public partial class PromjenaKnjiga : Form
    {
        private Knjiga k;
        
        public PromjenaKnjiga()
        {
            InitializeComponent();
        }

        public PromjenaKnjiga(Knjiga knjiga)
        {
            InitializeComponent();
            k = knjiga;
             
        }

        private void ponisti_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Da li ste sigurni da želite izrisati knjigu iz baze podataka?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                    int id = dao.VratiKnjigaID(ISBN.Text);
                    dao.IzbrisiKnjigu(id);

                    Close();
                }
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }

        public Bitmap Smanji(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        private void azuriraj_Click(object sender, EventArgs e)
        {
            if (naslov.Text.Length < 1 || autor.Text.Length < 1 || ISBN.Text.Length < 1 || izdavac.Text.Length < 1)
            {
                toolStripStatusLabel1.Text = "Popunite sva polja";
            }

            else if (naslov.Text.Length < 100 && autor.Text.Length < 100 && ISBN.Text.Length < 45 && izdavac.Text.Length < 100)
            {
                DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int id = dao.VratiKnjigaID(k.Isbn);

                Knjiga knjigica = new Knjiga(ISBN.Text, naslov.Text, autor.Text, izdavac.Text, Convert.ToInt16(godinaIzdanja.Value), Convert.ToInt16(brojKopija.Value), Convert.ToInt16(raspolozivo.Value));
                knjigica.Slika = (Bitmap)naslovnaStrana.Image;
                
                dao.AzurirajKnjigu(knjigica, id);
                toolStripStatusLabel1.Text = "";
                Close();
            }
            else toolStripStatusLabel1.Text = "Polja ne smiju imati vise od 100 znakova (ISBN 45). Promjene nisu izvršene";
            
                     
        }

        private void PromjenaKnjiga_Load(object sender, EventArgs e)
        {
            naslov.Text = k.Naslov;
            autor.Text = k.Autor;
            ISBN.Text = k.Isbn;
            izdavac.Text = k.Izdavac;
            godinaIzdanja.Text = k.GodinaIzdanja.ToString();
            brojKopija.Text = k.BrojKopija.ToString();
            raspolozivo.Value = k.BrojRaspolozivihKopija;
            DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
            int ID = dao.VratiKnjigaID(k.Isbn);
            naslovnaStrana.Image = dao.VratiKnjigaSliku(ID);
            toolStripStatusLabel1.Text = "";
            
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

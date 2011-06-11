using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Collections;
using DBConnection;

namespace WindowsFormsApplication1
{
    public partial class PromjenaUposlenik : Form
    {
        private Uposlenik u;
        public PromjenaUposlenik()
        {
            InitializeComponent();
            naslovnaStrana.Image = new Bitmap("default.png");
        }

        public PromjenaUposlenik(Uposlenik uposlenik)
        {
            InitializeComponent();
            u = uposlenik;
         }

        public bool IspravnaLicna(string s)
        {
            if (s.Length < 9)
            {
                return false;
            }
            else if (s.Length > 9)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    if (!Char.IsDigit(s, i))
                    {
                        return false;
                    }
                }
                for (int i = 5; i < 9; i++)
                {
                    if (!Char.IsDigit(s, i))
                    {
                        return false;
                    }
                }
                for (int i = 2; i < 5; i++)
                {
                    if (!Char.IsUpper(s, i))
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        private bool provjeriJMBG(string jmbgUnos)
        {
            if (jmbgUnos.Length == 13)
            {
                int[] danaUmjesecu = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                char[] niz = jmbgUnos.ToCharArray(0, 13);

                char[] godinaRodjenja = jmbgUnos.ToCharArray(4, 3);
                int pomGodina = 100 * (Convert.ToInt32(godinaRodjenja[0] - '0')) +
                                 10 * (Convert.ToInt32(godinaRodjenja[1] - '0')) +
                                       Convert.ToInt32(godinaRodjenja[2] - '0');

                if (godinaRodjenja[0] == '0')
                    pomGodina += 2000;
                else
                    pomGodina += 1000;

                if (pomGodina < 1900)
                {

                    return false;
                }
                else
                {
                    if (pomGodina > DateTime.Now.Year)
                    {

                        return false;
                    }
                }

                char[] mjesecRodjenja = jmbgUnos.ToCharArray(2, 2);
                int pomMjesec = 10 * (Convert.ToInt32(mjesecRodjenja[0] - '0')) +
                                      Convert.ToInt32(mjesecRodjenja[1] - '0');
                if (pomMjesec > 12 || pomMjesec < 1)
                {

                    return false;
                }

                if (((pomGodina % 4) == 0) && (((pomGodina % 100) != 0) || ((pomGodina % 400) == 0))) // prestupna godina
                {
                    danaUmjesecu[1] = 29;
                }

                char[] danRodjenja = jmbgUnos.ToCharArray(0, 2);
                int pomDan = 10 * (Convert.ToInt32(danRodjenja[0] - '0')) +
                                   Convert.ToInt32(danRodjenja[1] - '0');

                if (pomDan > danaUmjesecu[pomMjesec - 1] || pomDan < 1)
                {

                    return false;
                }

                int zbir = 0;

                for (int i = 0; i < 6; i++)
                    zbir += (7 - i) * (Convert.ToInt32(niz[i] - '0') + Convert.ToInt32(niz[6 + i] - '0'));
                int ostatak = zbir % 11;
                int razlika = 11 - ostatak;

                if (ostatak == 1)
                {

                    return false;
                }
                else if (ostatak == 0)
                {
                    if (Convert.ToInt32(niz[12] - '0').Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (razlika == (niz[12] - '0'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ponisti_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Da li ste sigurni da želite izrisati uposlenika iz baze podataka?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                    int id = dao.VratiUposlenikID(jmbg.Text);
                    int cbid = dao.VratiClanBibliotekeID(id, "uposlenik");
                    dao.IzbrisiUposlenika(id, cbid);

                    Close();
                }
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }

        private void PromjenaUposlenik_Load(object sender, EventArgs e)
        {
            ime.Text = u.Ime;
            prezime.Text = u.Prezime;
            licna.Text = u.BrojLicneKarte;
            jmbg.Text = u.Jmbg;
            tipUposlenika.Text = u.TipUposlenika;
            adresa.Text = u.Adresa;
            email.Text = u.Email;
            telefon.Text = u.BrojTelefona;
            datum.Value = u.DatumUclanjivanja;
            tipClanarine.Enabled = false;
            label0.Enabled = false;
            toolStripStatusLabel1.Text = "";
            DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
            int ID = dao.VratiUposlenikID(u.Jmbg);            
            naslovnaStrana.Image = dao.VratiUposlenikSliku(ID);

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
                if (ime.Text.Length < 1 || email.Text.Length < 1 || adresa.Text.Length < 1 || prezime.Text.Length < 1 || jmbg.Text.Length < 1 || telefon.Text.Length < 1)
                {
                    toolStripStatusLabel1.Text = "Popunite sva polja";
                }

                else if ((IspravnaLicna(licna.Text)) && ime.Text.Length < 45 && email.Text.Length < 50 && adresa.Text.Length < 45 && provjeriJMBG(jmbg.Text) && prezime.Text.Length < 45)
                {
                    DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                    int id = dao.VratiUposlenikID(u.Jmbg);
                    int bck = dao.VratiClanBibliotekeID(id, "uposlenik");

                    u.Ime = ime.Text;
                    u.Prezime = prezime.Text;
                    u.BrojLicneKarte = licna.Text;
                    u.Adresa = adresa.Text;
                    u.Email = email.Text;
                    u.BrojTelefona = telefon.Text;
                    u.DatumUclanjivanja = datum.Value;
                    u.Jmbg = jmbg.Text;
                    u.TipUposlenika = tipUposlenika.Text;
                    u.Slika = (Bitmap)naslovnaStrana.Image;
                    
                    dao.AzurirajUposlenika(u, id, bck);
                    toolStripStatusLabel1.Text = "";
                    Close();
                    
                }
                else toolStripStatusLabel1.Text = "Unesite ispravne podatke, promjene nisu izvrsene!";

            }

            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
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
            naslovnaStrana.Image = new Bitmap("capture.png");
        }

        private void tabControl2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
            Kamera k = new Kamera(naslovnaStrana);
            k.Show();
        }

        public Bitmap slika;
        
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    naslovnaStrana.Image = new Bitmap(open.FileName);
                    slika = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void ime_Validated(object sender, EventArgs e)
        {
            if (ime.Text.Length > 45)
                errorProvider1.SetError(ime, "Ime ne smije imati vise od 45 slova");
            else errorProvider1.Clear();
        }

        private void prezime_Validated(object sender, EventArgs e)
        {
            if (prezime.Text.Length > 45)
                errorProvider2.SetError(prezime, "Prezime ne smije imati vise od 45 slova");
            else errorProvider2.Clear();
        }

        private void licna_Validated(object sender, EventArgs e)
        {
            if (!IspravnaLicna(licna.Text))
                errorProvider3.SetError(licna, "Pogresno unesena licna karta. Format unosa je 11AAA1111");
            else errorProvider3.Clear();
        }

        private void jmbg_Validated(object sender, EventArgs e)
        {
            if (!provjeriJMBG(jmbg.Text))
                errorProvider4.SetError(jmbg, "Pogresno unesen jmbg");
            else errorProvider4.Clear();
        }

        private void adresa_Validated(object sender, EventArgs e)
        {
            if (adresa.Text.Length > 45)
                errorProvider5.SetError(adresa, "Adresa ne smije sadrzavati vise od 45 znakova");
            errorProvider5.Clear();
        }

        private void email_Validated(object sender, EventArgs e)
        {
            if (email.Text.Length > 50)
                errorProvider6.SetError(email, "Email ne smije sadrzavati vise od 50 znakova");
            else errorProvider6.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(this.pd_Stampaj);

            previewDialog.Document = pd;
            previewDialog.SetBounds(50, -550, 200, 200);
            previewDialog.ShowDialog();
        }

        private void pd_Stampaj(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile("fre3of9x.ttf");
            FontFamily barkod = new FontFamily("Free 3 of 9 Extended", pfc);
            Font c39Font = new Font(barkod, 30);

            Image clanska = Image.FromFile("clanska1.jpg");
            Graphics g = Graphics.FromImage(clanska);

            slika = new Bitmap(naslovnaStrana.Image);
            g.DrawImage(Smanji(slika, 140, 140), new Point(15, 27));

            g.DrawString(ime.Text, new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold), Brushes.Black, 183, 43);
            g.DrawString(prezime.Text, new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold), Brushes.Black, 183, 98);


            DAO dao3 = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
            int p = dao3.VratiUposlenikID(jmbg.Text);            
            int q = dao3.VratiClanBibliotekeID(p, "uposlenik");
            SizeF barCodeSize = g.MeasureString(Convert.ToString(q), c39Font);
            g.DrawString("Uposlenik", new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold), Brushes.Black, 18, 190);
            g.DrawString(Convert.ToString(q), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.Black, 183, 160);
            g.DrawString(Convert.ToString(q), c39Font, new SolidBrush(Color.Black), 190, 200);

            e.Graphics.DrawImage((Bitmap)clanska, 0, 0);

        }

       
    }
}

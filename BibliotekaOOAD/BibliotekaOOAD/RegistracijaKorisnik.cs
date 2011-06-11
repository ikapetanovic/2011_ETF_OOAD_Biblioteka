using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using DBConnection;
using System.Collections;
using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class Registracija : Form
    {
        public bool status1, status2, status3, status4, status5, status6, status7 = false;
        public Registracija()
        {
            InitializeComponent();
        }

        private bool IspravanIndeks(string s)
        {
            for (int i = 0; i < s.Length; i++) {
                if (!Char.IsDigit(s, i))
                {
                    return false;
                }
                          }
            return true;
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
            Close();
        }

        Bitmap slika;
        //Image defaultpic = Image.FromFile("default.png");

        
        public bool student = false;

  
        private void unesi_Click(object sender, EventArgs e)
        {            
            try
            {
                DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
               // slika = new Bitmap(defaultpic);
                if (tabControl1.SelectedIndex == 0)
                {
                    if (ime.Text.Length < 1 || email.Text.Length < 1 || adresa.Text.Length < 1 || prezime.Text.Length < 1 || jmbg.Text.Length < 1 || telefon.Text.Length < 1)
                    {
                        toolStripStatusLabel1.Text = "Popunite sva polja";
                    }

                    else if ((IspravnaLicna(licna.Text)) && ime.Text.Length < 45 && email.Text.Length < 50 && adresa.Text.Length < 45 && provjeriJMBG(jmbg.Text) && prezime.Text.Length < 45 && IspravanIndeks(index.Text))
                    {
                        Uposlenik u = new Uposlenik(licna.Text, ime.Text, prezime.Text, adresa.Text, email.Text, telefon.Text, Convert.ToDateTime(datum.Text), jmbg.Text, tipUposlenika.Text);
                        u.Slika = (Bitmap)naslovnaStrana.Image;
                        dao.DodajUposlenika(u);
                     

                        PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler(this.pd_Stampaj);

                        previewDialog.Document = pd;
                        previewDialog.SetBounds(50, -550, 200, 200);
                        previewDialog.ShowDialog();

                        toolStripStatusLabel1.Text = "";
                        ime.Text = prezime.Text = licna.Text = jmbg.Text = adresa.Text = email.Text = index.Text = telefon.Text= "";
                        faks.SelectedIndex = 1;
                        clanarina.SelectedIndex = 1;
                        tipUposlenika.SelectedIndex = 1;
                        naslovnaStrana.Image = ((System.Drawing.Image)(Properties.Resources.Misc_User_icon));
                        //   ));
                        toolStripStatusLabel1.Text = "Korisnik dodan";


                    }
                    else toolStripStatusLabel1.Text = "Unesite ispravne podatke, korisnik nije dodan!";

                }
                if (tabControl1.SelectedIndex == 1)
                {
                    if (ime.Text.Length < 1 || email.Text.Length < 1 || adresa.Text.Length < 1 || index.Text.Length < 1 || prezime.Text.Length < 1)
                    {
                        toolStripStatusLabel1.Text = "Popunite sva polja";
                    }
                    else if ((IspravnaLicna(licna.Text)) && ime.Text.Length < 45 && email.Text.Length < 50 && adresa.Text.Length < 45 && index.Text.Length < 11 && prezime.Text.Length < 45)
                    {
                        Student s = new Student(licna.Text, ime.Text, prezime.Text, adresa.Text, email.Text, telefon.Text, Convert.ToDateTime(datum.Text), Convert.ToInt16(index.Text), faks.Text, Convert.ToInt32(clanarina.Text));
                        s.Slika = (Bitmap)naslovnaStrana.Image;
                        dao.DodajStudenta(s);

                        

                        if (tabControl1.SelectedIndex == 1) student = true;

                        if (tabControl2.SelectedIndex == 5)
                        {
                            Image camera = Image.FromFile("capture.png");
                            slika = new Bitmap(camera);

                        }

                        PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler(this.pd_Stampaj);

                        previewDialog.Document = pd;
                        previewDialog.SetBounds(50, -550, 200, 200);
                        previewDialog.ShowDialog();

                        ime.Text = prezime.Text = licna.Text = jmbg.Text = adresa.Text = email.Text = index.Text = telefon.Text ="";
                        faks.SelectedIndex = 1;
                        clanarina.SelectedIndex = 1;
                        tipUposlenika.SelectedIndex = 1;
                        naslovnaStrana.Image = ((System.Drawing.Image)(Properties.Resources.Misc_User_icon));
                        toolStripStatusLabel1.Text = "Korisnik dodan";
                    }

                    else toolStripStatusLabel1.Text = "Unesite ispravne podatke, korisnik nije dodan!";


                }
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
                    slika = new Bitmap(open.FileName);

                }

            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        public Bitmap Smanji(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (tabControl1.SelectedIndex == 1) student = true;
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
                //Resources.clanska));
            Graphics g = Graphics.FromImage(clanska);

            slika = new Bitmap(naslovnaStrana.Image);
            g.DrawImage(Smanji(slika, 140, 140), new Point(15, 27));

            g.DrawString(ime.Text, new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold), Brushes.Black, 183, 43);
            g.DrawString(prezime.Text, new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold), Brushes.Black, 183, 98);

            if (tabControl1.SelectedIndex == 1)
            {
                DAO dao1 = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int x = dao1.VratiStudentID(Convert.ToInt32(index.Text));
                DAO dao2 = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int y = dao2.VratiClanBibliotekeID(x, "student");
                SizeF barCodeSize = g.MeasureString(Convert.ToString(y), c39Font);
                g.DrawString("Student", new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold), Brushes.Black, 18, 190);
                g.DrawString(Convert.ToString(y), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.Black, 183, 160);
                g.DrawString(Convert.ToString(y), c39Font, new SolidBrush(Color.Black), 190, 200);
            }

            else if (tabControl1.SelectedIndex == 0)
            {
                DAO dao3 = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int p = dao3.VratiUposlenikID(jmbg.Text);
                DAO dao4 = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int q = dao4.VratiClanBibliotekeID(p, "uposlenik");
                SizeF barCodeSize = g.MeasureString(Convert.ToString(q), c39Font);
                g.DrawString("Uposlenik", new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold), Brushes.Black, 18, 190);
                g.DrawString(Convert.ToString(q), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.Black, 183, 160);
                g.DrawString(Convert.ToString(q), c39Font, new SolidBrush(Color.Black), 190, 200);
            }

            e.Graphics.DrawImage((Bitmap)clanska, 0, 0);

        }

        public Bitmap Smanji(Image b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kamera k = new Kamera(naslovnaStrana);
            k.Show();
            naslovnaStrana.Image = new Bitmap("capture.png");
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {

            Kamera k = new Kamera(naslovnaStrana);
            k.Show();
            tabControl2.SelectedIndex = 0;

        }

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

        private void Registracija_Load(object sender, EventArgs e)
        {
            clanarina.SelectedIndex = 1;
            tipUposlenika.SelectedIndex = 1;
            faks.SelectedIndex = 1;
            toolStripStatusLabel1.Text = "";
            clanarina.Enabled = false;
            label0.Enabled = false;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            clanarina.Enabled = true;
            label0.Enabled = true;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            clanarina.Enabled = false;
            label0.Enabled = false;
        }

        private void clanarina_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void licna_TextChanged(object sender, EventArgs e)
        {

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

        private void index_Validated(object sender, EventArgs e)
        {
            if (index.Text.Length > 11)
                errorProvider5.SetError(index, "Indeks ne smije sadrzavati vise od 11 znakova");
            else if (!IspravanIndeks(index.Text)) {
                errorProvider5.SetError(index, "Indeks smije sadrzavati samo brojeve");
            }
            else errorProvider5.Clear();
        }

        private void adresa_Validated(object sender, EventArgs e)
        {
            if (adresa.Text.Length > 45)
                errorProvider6.SetError(adresa, "Adresa ne smije sadrzavati vise od 45 znakova");
              else errorProvider6.Clear();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Validated(object sender, EventArgs e)
        {
            if (email.Text.Length > 50)
                errorProvider7.SetError(email, "Email ne smije sadrzavati vise od 50 znakova");
            else errorProvider7.Clear();

        }

        private void telefon_Validated(object sender, EventArgs e)
        {
   
        }




    }
}

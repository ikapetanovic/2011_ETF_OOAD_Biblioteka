using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using DBConnection;


namespace WindowsFormsApplication1
{

    public partial class Menu : Form
    {
        private ArrayList clanovi; 
        private Thread t;

        public Menu()
        {
            InitializeComponent();
            clanovi=new ArrayList();
            toolStripStatusLabel1.Text = "";
        }

        
        private void pretraživanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaKorisnik pbk = new PretragaKorisnik();
            pbk.ShowDialog();
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registracija r = new Registracija();
            r.ShowDialog();
        }

        private void iznajmljivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void evidencijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evidencija ek = new Evidencija();
            ek.ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaKnjiga pbk = new PretragaKnjiga();
            pbk.ShowDialog();
        }

        private void oEBibliotekaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oEBibliotekaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Iznajmljivanje i = new Iznajmljivanje();
            i.ShowDialog();
        }

        private static DateTime GetDateFromTimeSpan(TimeSpan timeSpan)
        {
            return DateTime.Now.Subtract(timeSpan);
        }
        private static DateTime GetDat(TimeSpan timeSpan)
        {
            return DateTime.Now.Subtract(timeSpan);
        }

        private void Clanarina() 
        {
            try
            {
                DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                clanovi= dao.DajIstekle();
                if (clanovi.Count > 0) 
                {
                    statusStrip1.BackColor = Color.Firebrick;
                    toolStripStatusLabel1.Text = "Postoje studenti sa isteklom članarinom. Provjerite izvještaj.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška");
            }       
        }

     /*   private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pokrenuli ste pretrazivanje korisnika sa isteklom clanarinom");
            t = new Thread(new ThreadStart(Clanarina));
            t.Start();
            MessageBox.Show("Pretrazivanje zavrseno!");
            studenti = new ArrayList();            
            Izvjestaj i = new Izvjestaj(clanovi);
            i.Show();
        }*/

        private void Menu_Load(object sender, EventArgs e)
        {

        }

      /*  private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Abort();
        */

        private void amazonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amazon a = new Amazon();
            a.Show();
        }

        
        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportKnjige k=new ReportKnjige();
            k.Show();
        }

        private void clanoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportClanovi c = new ReportClanovi();
            c.Show();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Clanarina));
            t.Start();
                  
        }

        private void istekleClanarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj i = new Izvjestaj(clanovi);
            i.Show();
            toolStripStatusLabel1.Text = "";
            statusStrip1.BackColor = Color.Gainsboro;
        }

        private void iznajmljivanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportIznajmljivanje i = new ReportIznajmljivanje();
            i.Show();
        }

      
     

       
    }
}

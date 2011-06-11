using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBConnection;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class PretragaKorisnik : Form
    {
        private ArrayList clanovi;
        private ArrayList studenti;
        private ArrayList uposlenici;

        public PretragaKorisnik()
        {
            InitializeComponent();
            clanovi = new ArrayList();
            studenti = new ArrayList();
            uposlenici = new ArrayList();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           for (int i = 0; i < listViewStudent.Items.Count; i++)
                if (listViewStudent.Items[i].Selected == true)
                {
                    foreach (Student s in studenti)
                        if (s.BrojIndexa.ToString () == listViewStudent.Items[i].SubItems [11].Text)
                        {
                            PromjenaStudent ps = new PromjenaStudent(s);
                            listViewStudent.Items.Clear();
                            listViewUposlenik.Items.Clear();
                            ps.ShowDialog();
                            return;
                        }
                }
           atribut.SelectedIndex = 0;
        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewUposlenik.Items.Count; i++)
                if (listViewUposlenik.Items[i].Selected == true)
                {
                    foreach (Uposlenik u in uposlenici)
                        if (u.Jmbg == listViewUposlenik.Items[i].SubItems[10].Text)
                        {
                            PromjenaUposlenik pu = new PromjenaUposlenik(u);
                            listViewStudent.Items.Clear();
                            listViewUposlenik.Items.Clear();
                            pu.ShowDialog();
                            atribut.SelectedIndex = 0;
                            return;
                        }
                }

        }

        private void pretrazi_Click(object sender, EventArgs e)
        {
            listViewStudent.Items.Clear();
            listViewUposlenik.Items.Clear();
            
            if (atribut.SelectedIndex == -1)
            {
                atribut.Focus();
                uneseno.Enabled = false;
                toolStripStatusLabel1.Text = "Morate odabrati po čemu želite pretraživati.";
                errorProvider1.SetError(atribut, "Morate odabrati po čemu želite pretraživati.");
                return;
            }
                       
            if (uneseno.Text.Length == 0)
            {
                uneseno.Focus();
                toolStripStatusLabel1.Text = "Niste unijeli potrebne podatke.";
                errorProvider1.SetError(atribut, "Niste unijeli potrebne podatke.");
                return;
            }
            

            ListViewItem temp = new ListViewItem ();

            DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");            
            clanovi = dao.PretraziClanoveBiblioteke(atribut.SelectedItem.ToString(), uneseno.Text);

            foreach (ClanBiblioteke clan in clanovi)
            {
                try
                { 
                    Student s = (Student) clan;
                    
                    temp = listViewStudent.Items.Add(s.BrojClanskeKarte.ToString ());
                    temp.SubItems.Add(s.BrojLicneKarte.ToString ());
                    temp.SubItems.Add(s.Ime);
                    temp.SubItems.Add(s.Prezime);
                    temp.SubItems.Add(s.Adresa);
                    temp.SubItems.Add(s.Email);
                    temp.SubItems.Add(s.BrojTelefona);
                    string datum = s.DatumUclanjivanja.Day + "." + s.DatumUclanjivanja.Month + "." + s.DatumUclanjivanja.Year;
                    temp.SubItems.Add(datum);
                    temp.SubItems.Add(s.TipClanarine.ToString ());
                    temp.SubItems.Add(s.BrojIznajmljenihKnjiga.ToString ());
                    if (s.Zaduzen)
                        temp.SubItems.Add("DA");
                    else
                        temp.SubItems.Add("NE"); 
                    temp.SubItems.Add(s.BrojIndexa.ToString ());
                    temp.SubItems.Add(s.NazivFakulteta);
                    studenti.Add(s);


                    uneseno.Text = "";
                    atribut.SelectedItem = "";
            
                                                        
                }
                catch
                {
                    Uposlenik u = (Uposlenik)clan;

                    temp = listViewUposlenik.Items.Add(u.BrojClanskeKarte.ToString());
                    temp.SubItems.Add(u.BrojLicneKarte.ToString());
                    temp.SubItems.Add(u.Ime);
                    temp.SubItems.Add(u.Prezime);
                    temp.SubItems.Add(u.Adresa);
                    temp.SubItems.Add(u.Email);
                    temp.SubItems.Add(u.BrojTelefona);
                    string datum = u.DatumUclanjivanja.Day + "." + u.DatumUclanjivanja.Month + "." + u.DatumUclanjivanja.Year;
                    temp.SubItems.Add(datum);                    
                    temp.SubItems.Add(u.BrojIznajmljenihKnjiga.ToString());
                    if (u.Zaduzen)
                        temp.SubItems.Add("DA");
                    else
                        temp.SubItems.Add("NE"); 
                    temp.SubItems.Add(u.Jmbg);
                    temp.SubItems.Add(u.TipUposlenika);
                    uposlenici.Add(u);


                    uneseno.Text = "";
                    atribut.SelectedItem = "";
            

                }                
            }
           

        }

        private void PretragaKorisnik_Load(object sender, EventArgs e)
        {
            atribut.SelectedIndex = 0;
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uneseno_Validated(object sender, EventArgs e)
        {
            if (uneseno.Text.Length > 0)
            {
                toolStripStatusLabel1.Text = "";
                errorProvider1.Clear();
            }
            }
    }
}

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
    public partial class Izvjestaj : Form
    {
        private ArrayList clanovi;
        private ArrayList studenti;
        
        public Izvjestaj(ArrayList u1)
        {
            InitializeComponent();
            clanovi = new ArrayList();
            studenti = new ArrayList();
            clanovi = u1;                           
    
        }
        
        public Izvjestaj()
        {
            InitializeComponent();
        }


        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            listViewStudent.Items.Clear();            
            ListViewItem temp = new ListViewItem();

            foreach (ClanBiblioteke clan in clanovi)
            {
                try
                {
                    Student s = (Student)clan;

                    temp = listViewStudent.Items.Add(s.BrojClanskeKarte.ToString());
                    temp.SubItems.Add(s.BrojLicneKarte.ToString());
                    temp.SubItems.Add(s.Ime);
                    temp.SubItems.Add(s.Prezime);
                    temp.SubItems.Add(s.Adresa);
                    temp.SubItems.Add(s.Email);
                    temp.SubItems.Add(s.BrojTelefona);
                    string datum = s.DatumUclanjivanja.Day + "." + s.DatumUclanjivanja.Month + "." + s.DatumUclanjivanja.Year;
                    temp.SubItems.Add(datum);
                    temp.SubItems.Add(s.TipClanarine.ToString());
                    temp.SubItems.Add(s.BrojIznajmljenihKnjiga.ToString());
                    if (s.Zaduzen)
                        temp.SubItems.Add("DA");
                    else
                        temp.SubItems.Add("NE");
                    temp.SubItems.Add(s.BrojIndexa.ToString());
                    temp.SubItems.Add(s.NazivFakulteta);
                    studenti.Add(s);
                }
                catch
                {
                    
                }
            }
           

        }

        private void listViewStudent_ItemActivate(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewStudent.Items.Count; i++)
                if (listViewStudent.Items[i].Selected == true)
                {
                    foreach (Student s in studenti)
                        if (s.BrojIndexa.ToString() == listViewStudent.Items[i].SubItems[11].Text)
                        {
                            PromjenaStudent ps = new PromjenaStudent(s);
                            ps.ShowDialog();
                            return;
                        }
                }
        }

        
    }
}

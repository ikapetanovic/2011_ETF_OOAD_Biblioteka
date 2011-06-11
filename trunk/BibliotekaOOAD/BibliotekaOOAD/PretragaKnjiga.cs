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
    public partial class PretragaKnjiga : Form
    {
        private List<Knjiga> knjige;

        public PretragaKnjiga()
        {
            InitializeComponent();
            knjige = new List<Knjiga>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewKnjiga.Items.Count; i++)
				if (listViewKnjiga.Items[i].Selected == true)	
				{
					foreach (Knjiga k in knjige)
						if (k.Isbn == listViewKnjiga.Items[i].Text)
						{                           
                            PromjenaKnjiga pk = new PromjenaKnjiga(k);
                            listViewKnjiga.Items.Clear ();
                            atribut.SelectedIndex = 0;
                            uneseno.Clear();
							pk.ShowDialog ();							
							return;
                            
						}
				}

        }



        private void pretrazi_Click(object sender, EventArgs e)
        {
            listViewKnjiga.Items.Clear();
            
            if (atribut.SelectedIndex == -1)
            {
                atribut.Focus();
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
            

            ListViewItem temp = new ListViewItem();

            DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");            
            knjige = dao.PretraziKnjige(atribut.SelectedItem.ToString(), uneseno.Text);

            foreach (Knjiga k in knjige)
            {
                temp = listViewKnjiga.Items.Add(k.Isbn);
                temp.SubItems.Add(k.Naslov);
                temp.SubItems.Add(k.Autor);
                temp.SubItems.Add(k.Izdavac);
                temp.SubItems.Add(k.GodinaIzdanja.ToString ());
                temp.SubItems.Add(k.BrojKopija.ToString ());
                temp.SubItems.Add(k.BrojRaspolozivihKopija.ToString ());
            }

            uneseno.ResetText();
            atribut.SelectedIndex = 0;
            
 
        }

        private void PretragaKnjiga_Load(object sender, EventArgs e)
        {
            atribut.SelectedIndex = 0;
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

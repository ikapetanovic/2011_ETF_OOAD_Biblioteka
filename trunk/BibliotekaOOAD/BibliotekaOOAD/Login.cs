
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       

        private void uredu_Click(object sender, EventArgs e)
        {
            string korisnik = korisnickoIme.Text;
            string sifra = lozinka.Text;            
            try
            {
                DAO dao = new DAO("etf.ba", "ooadtim6", "ooadtim6", "ooadtim6");
                int id = dao.VratiUserID(korisnik, sifra);               
                string uloga = dao.ProvjeriPristup(id);
               
                if (uloga == "Bibliotekar")
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                }
                else if (uloga == "Garderobijer")
                {
                    PronalazenjeMjesta pm = new PronalazenjeMjesta();
                    pm.Show();
                    this.Hide();
                }
                
            }
            catch (Exception)
            {
                statusStrip1.BackColor = Color.White;
                toolStripStatusLabel1.Text = "Neovlašten pristup.";
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

       

        

       
    }
   
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReportKnjige : Form
    {
        public ReportKnjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ooadtim6DataSet.knjige' table. You can move, or remove it, as needed.
            this.knjigeTableAdapter.Fill(this.ooadtim6DataSet.knjige);

            this.reportViewer1.RefreshReport();
        }
    }
}

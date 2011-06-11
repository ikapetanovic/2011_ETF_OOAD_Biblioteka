using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Rss;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Amazon : Form
    {
        public Amazon()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RssItem item = (RssItem)listBox1.SelectedItem;
            string itdesc = item.Description;

            string[] niz1 = Regex.Split(itdesc, "<img src=\"");
            string gledajIUci = niz1[1];
            string[] niz2 = Regex.Split(gledajIUci, "\" alt=");
            string nja = niz2[0];           
            pictureBox1.ImageLocation = nja;
        }

        private void Amazon_Load(object sender, EventArgs e)
        {
            RssFeed feed = RssFeed.Read("http://www.amazon.ca/rss/bestsellers/books/ref=pd_ts_rss_link");
            RssChannel channel = (RssChannel)feed.Channels[0];
            listBox1.DataSource = channel.Items;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }       


    }
}

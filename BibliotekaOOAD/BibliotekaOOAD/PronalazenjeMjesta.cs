using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class PronalazenjeMjesta : Form
    {
        private bool zelenaboja1, zelenaboja2, zelenaboja3, zelenaboja4, zelenaboja5, zelenaboja6, zelenaboja7, zelenaboja8;
        private bool zelenaboja9, zelenaboja10, zelenaboja11, zelenaboja12, zelenaboja13, zelenaboja14, zelenaboja15, zelenaboja16;
        private bool zelenaboja17, zelenaboja18, zelenaboja19, zelenaboja20, zelenaboja21, zelenaboja22, zelenaboja23, zelenaboja24;
        public PronalazenjeMjesta()
        {
            InitializeComponent();
            zelenaboja1 = zelenaboja2= zelenaboja3= zelenaboja4=zelenaboja5=zelenaboja6=zelenaboja7=zelenaboja8=true;
            zelenaboja9 = zelenaboja10 = zelenaboja11 = zelenaboja12 = zelenaboja13 = zelenaboja14 = zelenaboja15 = zelenaboja16 = true;
            zelenaboja17 = zelenaboja18 = zelenaboja19 = zelenaboja20= zelenaboja21 = zelenaboja22 = zelenaboja23 = zelenaboja24 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zelenaboja1)
            {
                button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja1 = false;
            }
            else
            {
                button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja1 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zelenaboja2)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja2 = false;
            }
            else
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja2 = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zelenaboja3)
            {
                button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja3 = false;
            }
            else
            {
                button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja3 = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (zelenaboja4)
            {
                button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja4 = false;
            }
            else
            {
                button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja4 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zelenaboja5)
            {
                button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja5 = false;
            }
            else
            {
                button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja5 = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (zelenaboja6)
            {
                button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja6 = false;
            }
            else
            {
                button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja6 = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (zelenaboja7)
            {
                button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja7 = false;
            }
            else
            {
                button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja7 = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (zelenaboja8)
            {
                button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja8 = false;
            }
            else
            {
                button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja8 = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (zelenaboja9)
            {
                button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja9 = false;
            }
            else
            {
                button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja9 = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (zelenaboja10)
            {
                button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja10 = false;
            }
            else
            {
                button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja10 = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (zelenaboja11)
            {
                button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja11 = false;
            }
            else
            {
                button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja11 = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (zelenaboja12)
            {
                button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja12 = false;
            }
            else
            {
                button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja12 = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (zelenaboja13)
            {
                button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja13 = false;
            }
            else
            {
                button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja13 = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (zelenaboja14)
            {
                button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja14 = false;
            }
            else
            {
                button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja14 = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (zelenaboja15)
            {
                button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja15 = false;
            }
            else
            {
                button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja15 = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (zelenaboja16)
            {
                button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja16 = false;
            }
            else
            {
                button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja16 = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (zelenaboja17)
            {
                button17.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja17 = false;
            }
            else
            {
                button17.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja17 = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (zelenaboja18)
            {
                button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja18 = false;
            }
            else
            {
                button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja18 = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (zelenaboja19)
            {
                button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja19 = false;
            }
            else
            {
                button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja19 = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (zelenaboja20)
            {
                button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja20 = false;
            }
            else
            {
                button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja20 = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (zelenaboja21)
            {
                button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja21 = false;
            }
            else
            {
                button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja21 = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (zelenaboja22)
            {
                button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja22 = false;
            }
            else
            {
                button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja22 = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (zelenaboja23)
            {
                button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja23 = false;
            }
            else
            {
                button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja23 = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (zelenaboja24)
            {
                button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red));
                zelenaboja24 = false;
            }
            else
            {
                button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.zelena4));
                zelenaboja24 = true;
            }
        }
    }
}

namespace WindowsFormsApplication1
{
    partial class PromjenaKnjiga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.naslov = new System.Windows.Forms.TextBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.azuriraj = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.TextBox();
            this.podaci = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.raspolozivo = new System.Windows.Forms.NumericUpDown();
            this.brojKopija = new System.Windows.Forms.NumericUpDown();
            this.godinaIzdanja = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izdavac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.naslovnaStrana = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.podaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspolozivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojKopija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godinaIzdanja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaStrana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // naslov
            // 
            this.naslov.Location = new System.Drawing.Point(91, 19);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(130, 20);
            this.naslov.TabIndex = 0;
            this.naslov.Validated += new System.EventHandler(this.naslov_Validated);
            // 
            // izbrisi
            // 
            this.izbrisi.Location = new System.Drawing.Point(336, 230);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(74, 23);
            this.izbrisi.TabIndex = 9;
            this.izbrisi.Text = "Izbriši";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.ponisti_Click);
            // 
            // azuriraj
            // 
            this.azuriraj.Location = new System.Drawing.Point(260, 230);
            this.azuriraj.Name = "azuriraj";
            this.azuriraj.Size = new System.Drawing.Size(71, 23);
            this.azuriraj.TabIndex = 8;
            this.azuriraj.Text = "Ažuriraj";
            this.azuriraj.UseVisualStyleBackColor = true;
            this.azuriraj.Click += new System.EventHandler(this.azuriraj_Click);
            // 
            // autor
            // 
            this.autor.Location = new System.Drawing.Point(91, 45);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(130, 20);
            this.autor.TabIndex = 1;
            this.autor.Validated += new System.EventHandler(this.autor_Validated);
            // 
            // podaci
            // 
            this.podaci.Controls.Add(this.label5);
            this.podaci.Controls.Add(this.raspolozivo);
            this.podaci.Controls.Add(this.brojKopija);
            this.podaci.Controls.Add(this.godinaIzdanja);
            this.podaci.Controls.Add(this.label9);
            this.podaci.Controls.Add(this.label4);
            this.podaci.Controls.Add(this.ISBN);
            this.podaci.Controls.Add(this.label6);
            this.podaci.Controls.Add(this.label3);
            this.podaci.Controls.Add(this.izdavac);
            this.podaci.Location = new System.Drawing.Point(12, 90);
            this.podaci.Name = "podaci";
            this.podaci.Size = new System.Drawing.Size(238, 164);
            this.podaci.TabIndex = 7;
            this.podaci.TabStop = false;
            this.podaci.Text = "Dodatni podaci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj kopija:";
            // 
            // raspolozivo
            // 
            this.raspolozivo.Location = new System.Drawing.Point(92, 122);
            this.raspolozivo.Name = "raspolozivo";
            this.raspolozivo.Size = new System.Drawing.Size(64, 20);
            this.raspolozivo.TabIndex = 19;
            this.raspolozivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brojKopija
            // 
            this.brojKopija.Location = new System.Drawing.Point(91, 96);
            this.brojKopija.Name = "brojKopija";
            this.brojKopija.Size = new System.Drawing.Size(64, 20);
            this.brojKopija.TabIndex = 15;
            this.brojKopija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // godinaIzdanja
            // 
            this.godinaIzdanja.Location = new System.Drawing.Point(91, 70);
            this.godinaIzdanja.Maximum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.godinaIzdanja.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.godinaIzdanja.Name = "godinaIzdanja";
            this.godinaIzdanja.Size = new System.Drawing.Size(64, 20);
            this.godinaIzdanja.TabIndex = 14;
            this.godinaIzdanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.godinaIzdanja.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Raspoloživo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Godina izdanja:";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(92, 18);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(130, 20);
            this.ISBN.TabIndex = 0;
            this.ISBN.Validated += new System.EventHandler(this.ISBN_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izdavač:";
            // 
            // izdavac
            // 
            this.izdavac.Location = new System.Drawing.Point(92, 44);
            this.izdavac.Name = "izdavac";
            this.izdavac.Size = new System.Drawing.Size(130, 20);
            this.izdavac.TabIndex = 1;
            this.izdavac.Validated += new System.EventHandler(this.izdavac_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv autora:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.naslov);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.autor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 78);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osnovni podaci";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(256, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(183, 207);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.naslovnaStrana);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(156, 199);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Slika";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // naslovnaStrana
            // 
            this.naslovnaStrana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.naslovnaStrana.Image = global::WindowsFormsApplication1.Properties.Resources.Book_icon;
            this.naslovnaStrana.Location = new System.Drawing.Point(6, 6);
            this.naslovnaStrana.Name = "naslovnaStrana";
            this.naslovnaStrana.Size = new System.Drawing.Size(144, 187);
            this.naslovnaStrana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.naslovnaStrana.TabIndex = 17;
            this.naslovnaStrana.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(156, 199);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Nađi";
            this.tabPage4.ToolTipText = "Dodaj sliku sa računara";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(156, 199);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Uslikaj";
            this.tabPage5.ToolTipText = "Uslikaj pomoću webcamere";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // PromjenaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 286);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.azuriraj);
            this.Controls.Add(this.podaci);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "PromjenaKnjiga";
            this.Text = "Ažuriranje podataka o knjizi";
            this.Load += new System.EventHandler(this.PromjenaKnjiga_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.podaci.ResumeLayout(false);
            this.podaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspolozivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojKopija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godinaIzdanja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaStrana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox naslov;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button azuriraj;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.GroupBox podaci;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox izdavac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown raspolozivo;
        private System.Windows.Forms.NumericUpDown brojKopija;
        private System.Windows.Forms.NumericUpDown godinaIzdanja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox naslovnaStrana;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}
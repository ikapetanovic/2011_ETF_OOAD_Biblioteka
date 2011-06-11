namespace WindowsFormsApplication1
{
    partial class PromjenaUposlenik
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.licna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.tipClanarine = new System.Windows.Forms.ComboBox();
            this.unesi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tipUposlenika = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jmbg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.naslovnaStrana = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaStrana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.telefon);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.email);
            this.groupBox4.Controls.Add(this.adresa);
            this.groupBox4.Location = new System.Drawing.Point(255, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kontakt podaci";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(92, 75);
            this.telefon.Mask = "(999) 000-000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(73, 20);
            this.telefon.TabIndex = 2;
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj telefona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresa";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(92, 49);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(133, 20);
            this.email.TabIndex = 1;
            this.email.Validated += new System.EventHandler(this.email_Validated);
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(92, 23);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(133, 20);
            this.adresa.TabIndex = 0;
            this.adresa.Validated += new System.EventHandler(this.adresa_Validated);
            // 
            // izbrisi
            // 
            this.izbrisi.Location = new System.Drawing.Point(424, 224);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(75, 23);
            this.izbrisi.TabIndex = 5;
            this.izbrisi.Text = "Izbriši";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.ponisti_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(92, 34);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(133, 20);
            this.datum.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.licna);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prezime);
            this.groupBox1.Controls.Add(this.ime);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lični podaci";
            // 
            // licna
            // 
            this.licna.Location = new System.Drawing.Point(92, 71);
            this.licna.Name = "licna";
            this.licna.Size = new System.Drawing.Size(126, 20);
            this.licna.TabIndex = 2;
            this.licna.Validated += new System.EventHandler(this.licna_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lična karta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(92, 45);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(126, 20);
            this.prezime.TabIndex = 1;
            this.prezime.Validated += new System.EventHandler(this.prezime_Validated);
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(92, 19);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(126, 20);
            this.ime.TabIndex = 0;
            this.ime.Validated += new System.EventHandler(this.ime_Validated);
            // 
            // tipClanarine
            // 
            this.tipClanarine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipClanarine.FormattingEnabled = true;
            this.tipClanarine.Items.AddRange(new object[] {
            "6",
            "12"});
            this.tipClanarine.Location = new System.Drawing.Point(92, 59);
            this.tipClanarine.Name = "tipClanarine";
            this.tipClanarine.Size = new System.Drawing.Size(64, 21);
            this.tipClanarine.TabIndex = 1;
            // 
            // unesi
            // 
            this.unesi.Location = new System.Drawing.Point(343, 224);
            this.unesi.Name = "unesi";
            this.unesi.Size = new System.Drawing.Size(75, 23);
            this.unesi.TabIndex = 4;
            this.unesi.Text = "Ažuriraj";
            this.unesi.UseVisualStyleBackColor = true;
            this.unesi.Click += new System.EventHandler(this.unesi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datum);
            this.groupBox2.Controls.Add(this.tipClanarine);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label0);
            this.groupBox2.Location = new System.Drawing.Point(255, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o članarini";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Datum:";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(10, 66);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(80, 13);
            this.label0.TabIndex = 2;
            this.label0.Text = "Vrsta članarine:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tipUposlenika);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.jmbg);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 95);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodatni podaci";
            // 
            // tipUposlenika
            // 
            this.tipUposlenika.FormattingEnabled = true;
            this.tipUposlenika.Items.AddRange(new object[] {
            "Bibliotekar",
            "Garderobijer"});
            this.tipUposlenika.Location = new System.Drawing.Point(94, 52);
            this.tipUposlenika.Name = "tipUposlenika";
            this.tipUposlenika.Size = new System.Drawing.Size(124, 21);
            this.tipUposlenika.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tip uposlenika:";
            // 
            // jmbg
            // 
            this.jmbg.Location = new System.Drawing.Point(94, 26);
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(124, 20);
            this.jmbg.TabIndex = 0;
            this.jmbg.Validated += new System.EventHandler(this.jmbg_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "JMBG:";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(505, 6);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.ShowToolTips = true;
            this.tabControl2.Size = new System.Drawing.Size(183, 207);
            this.tabControl2.TabIndex = 22;
            this.tabControl2.Enter += new System.EventHandler(this.tabControl2_Enter);
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
            this.naslovnaStrana.Image = global::WindowsFormsApplication1.Properties.Resources.Misc_User_icon;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Generiraj člansku karticu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // PromjenaUposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 281);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unesi);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "PromjenaUposlenik";
            this.Text = "Ažuriranje podataka o uposleniku";
            this.Load += new System.EventHandler(this.PromjenaUposlenik_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaStrana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox licna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.ComboBox tipClanarine;
        private System.Windows.Forms.Button unesi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox tipUposlenika;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox jmbg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox naslovnaStrana;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}
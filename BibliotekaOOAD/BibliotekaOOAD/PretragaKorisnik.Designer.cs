namespace WindowsFormsApplication1
{
    partial class PretragaKorisnik
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
            this.label3 = new System.Windows.Forms.Label();
            this.pretrazi = new System.Windows.Forms.Button();
            this.uneseno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.atribut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUposlenik = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pregled informacija o studentima:";
            // 
            // pretrazi
            // 
            this.pretrazi.Location = new System.Drawing.Point(459, 12);
            this.pretrazi.Name = "pretrazi";
            this.pretrazi.Size = new System.Drawing.Size(75, 23);
            this.pretrazi.TabIndex = 2;
            this.pretrazi.Text = "Pretraži";
            this.pretrazi.UseVisualStyleBackColor = true;
            this.pretrazi.Click += new System.EventHandler(this.pretrazi_Click);
            // 
            // uneseno
            // 
            this.uneseno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uneseno.Location = new System.Drawing.Point(290, 13);
            this.uneseno.Name = "uneseno";
            this.uneseno.Size = new System.Drawing.Size(148, 20);
            this.uneseno.TabIndex = 1;
            this.uneseno.Validated += new System.EventHandler(this.uneseno_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesi:";
            // 
            // atribut
            // 
            this.atribut.BackColor = System.Drawing.SystemColors.Control;
            this.atribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atribut.FormattingEnabled = true;
            this.atribut.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Broj članske karte"});
            this.atribut.Location = new System.Drawing.Point(101, 13);
            this.atribut.Name = "atribut";
            this.atribut.Size = new System.Drawing.Size(124, 21);
            this.atribut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraživanje po:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.atribut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uneseno);
            this.panel1.Controls.Add(this.pretrazi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 46);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pregled informacija o uposlenicima:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewStudent
            // 
            this.listViewStudent.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewStudent.AllowColumnReorder = true;
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewStudent.FullRowSelect = true;
            this.listViewStudent.GridLines = true;
            this.listViewStudent.Location = new System.Drawing.Point(12, 90);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(545, 138);
            this.listViewStudent.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewStudent.TabIndex = 6;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            this.listViewStudent.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listViewStudent.SelectedIndexChanged += new System.EventHandler(this.listViewStudent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Broj članske karte";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj lične karte";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj telefona";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum učlanjivanja";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tip članarine";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Broj iznajmljenih knjiga";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Zadužen";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Broj indexa";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Naziv fakulteta";
            // 
            // listViewUposlenik
            // 
            this.listViewUposlenik.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewUposlenik.AllowColumnReorder = true;
            this.listViewUposlenik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader26,
            this.columnHeader27});
            this.listViewUposlenik.FullRowSelect = true;
            this.listViewUposlenik.GridLines = true;
            this.listViewUposlenik.Location = new System.Drawing.Point(11, 248);
            this.listViewUposlenik.MultiSelect = false;
            this.listViewUposlenik.Name = "listViewUposlenik";
            this.listViewUposlenik.Size = new System.Drawing.Size(545, 161);
            this.listViewUposlenik.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewUposlenik.TabIndex = 7;
            this.listViewUposlenik.UseCompatibleStateImageBehavior = false;
            this.listViewUposlenik.View = System.Windows.Forms.View.Details;
            this.listViewUposlenik.ItemActivate += new System.EventHandler(this.listView2_ItemActivate);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Broj članske karte";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Broj lične karte";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ime";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Prezime";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Adresa";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "E-mail";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Broj telefona";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Datum učlanjivanja";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Broj iznajmljenih knjiga";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Zadužen";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "JMBG";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Tip uposlenika";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PretragaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 441);
            this.Controls.Add(this.listViewUposlenik);
            this.Controls.Add(this.listViewStudent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "PretragaKorisnik";
            this.Text = "Pretraga korisnika";
            this.Load += new System.EventHandler(this.PretragaKorisnik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pretrazi;
        private System.Windows.Forms.TextBox uneseno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox atribut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ListView listViewUposlenik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraživanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.amazonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iznajmljivanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istekleClanarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oEBibliotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oEBibliotekaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.knjigaToolStripMenuItem,
            this.knjigaReportToolStripMenuItem,
            this.oEBibliotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registracijaToolStripMenuItem,
            this.pretraživanjeToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.korisnikToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.user_icon2;
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.add_user_icon1;
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registracijaToolStripMenuItem.Text = "Registracija";
            this.registracijaToolStripMenuItem.Click += new System.EventHandler(this.registracijaToolStripMenuItem_Click);
            // 
            // pretraživanjeToolStripMenuItem
            // 
            this.pretraživanjeToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.loupe_icon;
            this.pretraživanjeToolStripMenuItem.Name = "pretraživanjeToolStripMenuItem";
            this.pretraživanjeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.pretraživanjeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pretraživanjeToolStripMenuItem.Text = "Pretraga";
            this.pretraživanjeToolStripMenuItem.Click += new System.EventHandler(this.pretraživanjeToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.door_out_icon;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // knjigaToolStripMenuItem
            // 
            this.knjigaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.amazonToolStripMenuItem});
            this.knjigaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.book_open_icon;
            this.knjigaToolStripMenuItem.Name = "knjigaToolStripMenuItem";
            this.knjigaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.knjigaToolStripMenuItem.Text = "Knjiga";
            // 
            // evidencijaToolStripMenuItem
            // 
            this.evidencijaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.book_add_icon;
            this.evidencijaToolStripMenuItem.Name = "evidencijaToolStripMenuItem";
            this.evidencijaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.evidencijaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.evidencijaToolStripMenuItem.Text = "Evidencija";
            this.evidencijaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.loupe_icon;
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources._6;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItem1.Text = "Iznajmljivanje";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // amazonToolStripMenuItem
            // 
            this.amazonToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.amazon_logo;
            this.amazonToolStripMenuItem.Name = "amazonToolStripMenuItem";
            this.amazonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.amazonToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.amazonToolStripMenuItem.Text = "Amazon";
            this.amazonToolStripMenuItem.Click += new System.EventHandler(this.amazonToolStripMenuItem_Click);
            // 
            // knjigaReportToolStripMenuItem
            // 
            this.knjigaReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.clanoviToolStripMenuItem,
            this.iznajmljivanjaToolStripMenuItem,
            this.istekleClanarineToolStripMenuItem});
            this.knjigaReportToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.reports_icon;
            this.knjigaReportToolStripMenuItem.Name = "knjigaReportToolStripMenuItem";
            this.knjigaReportToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.knjigaReportToolStripMenuItem.Text = "Izvještaj";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.books_icon1;
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // clanoviToolStripMenuItem
            // 
            this.clanoviToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.user_group_icon;
            this.clanoviToolStripMenuItem.Name = "clanoviToolStripMenuItem";
            this.clanoviToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clanoviToolStripMenuItem.Text = "Članovi";
            this.clanoviToolStripMenuItem.Click += new System.EventHandler(this.clanoviToolStripMenuItem_Click);
            // 
            // iznajmljivanjaToolStripMenuItem
            // 
            this.iznajmljivanjaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.File_History_icon;
            this.iznajmljivanjaToolStripMenuItem.Name = "iznajmljivanjaToolStripMenuItem";
            this.iznajmljivanjaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.iznajmljivanjaToolStripMenuItem.Text = "Iznajmljivanja";
            this.iznajmljivanjaToolStripMenuItem.Click += new System.EventHandler(this.iznajmljivanjaToolStripMenuItem_Click);
            // 
            // istekleClanarineToolStripMenuItem
            // 
            this.istekleClanarineToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.clock_select_remain_icon;
            this.istekleClanarineToolStripMenuItem.Name = "istekleClanarineToolStripMenuItem";
            this.istekleClanarineToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.istekleClanarineToolStripMenuItem.Text = "Istekle članarine";
            this.istekleClanarineToolStripMenuItem.Click += new System.EventHandler(this.istekleClanarineToolStripMenuItem_Click);
            // 
            // oEBibliotekaToolStripMenuItem
            // 
            this.oEBibliotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oEBibliotekaToolStripMenuItem1});
            this.oEBibliotekaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Actions_help_hint_icon;
            this.oEBibliotekaToolStripMenuItem.Name = "oEBibliotekaToolStripMenuItem";
            this.oEBibliotekaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.oEBibliotekaToolStripMenuItem.Text = "Pomoć";
            this.oEBibliotekaToolStripMenuItem.Click += new System.EventHandler(this.oEBibliotekaToolStripMenuItem_Click);
            // 
            // oEBibliotekaToolStripMenuItem1
            // 
            this.oEBibliotekaToolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources.Information_icon1;
            this.oEBibliotekaToolStripMenuItem1.Name = "oEBibliotekaToolStripMenuItem1";
            this.oEBibliotekaToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.oEBibliotekaToolStripMenuItem1.Text = "O Biblioteka";
            this.oEBibliotekaToolStripMenuItem1.Click += new System.EventHandler(this.oEBibliotekaToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraživanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oEBibliotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oEBibliotekaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem amazonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanoviToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem istekleClanarineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iznajmljivanjaToolStripMenuItem;
    }
}
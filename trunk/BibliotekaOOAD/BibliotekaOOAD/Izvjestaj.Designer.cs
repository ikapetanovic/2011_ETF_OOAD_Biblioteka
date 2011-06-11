namespace WindowsFormsApplication1
{
    partial class Izvjestaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.listViewStudent.Location = new System.Drawing.Point(12, 25);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(609, 217);
            this.listViewStudent.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewStudent.TabIndex = 7;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            this.listViewStudent.ItemActivate += new System.EventHandler(this.listViewStudent_ItemActivate);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Studenti sa isteklom članarinom:";
            // 
            // Izvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStudent);
            this.MaximizeBox = false;
            this.Name = "Izvjestaj";
            this.Text = "Izvještaj";
            this.Load += new System.EventHandler(this.Izvjestaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudent;
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
        private System.Windows.Forms.Label label1;
    }
}
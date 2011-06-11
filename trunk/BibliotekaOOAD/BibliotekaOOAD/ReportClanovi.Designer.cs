namespace WindowsFormsApplication1
{
    partial class ReportClanovi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clanovi_bibliotekeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ooadtim6DataSet = new WindowsFormsApplication1.ooadtim6DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clanovi_bibliotekeTableAdapter = new WindowsFormsApplication1.ooadtim6DataSetTableAdapters.clanovi_bibliotekeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clanovi_bibliotekeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clanovi_bibliotekeBindingSource
            // 
            this.clanovi_bibliotekeBindingSource.DataMember = "clanovi_biblioteke";
            this.clanovi_bibliotekeBindingSource.DataSource = this.ooadtim6DataSet;
            // 
            // ooadtim6DataSet
            // 
            this.ooadtim6DataSet.DataSetName = "ooadtim6DataSet";
            this.ooadtim6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clanovi_bibliotekeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1030, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // clanovi_bibliotekeTableAdapter
            // 
            this.clanovi_bibliotekeTableAdapter.ClearBeforeFill = true;
            // 
            // ReportClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 578);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportClanovi";
            this.Text = "Članovi";
            this.Load += new System.EventHandler(this.Članovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanovi_bibliotekeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clanovi_bibliotekeBindingSource;
        private ooadtim6DataSet ooadtim6DataSet;
        private ooadtim6DataSetTableAdapters.clanovi_bibliotekeTableAdapter clanovi_bibliotekeTableAdapter;
    }
}
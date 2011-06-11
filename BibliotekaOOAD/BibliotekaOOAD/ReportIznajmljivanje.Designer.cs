namespace WindowsFormsApplication1
{
    partial class ReportIznajmljivanje
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
            this.iznajmljivanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ooadtim6DataSet1 = new WindowsFormsApplication1.ooadtim6DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iznajmljivanjaTableAdapter = new WindowsFormsApplication1.ooadtim6DataSet1TableAdapters.iznajmljivanjaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljivanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // iznajmljivanjaBindingSource
            // 
            this.iznajmljivanjaBindingSource.DataMember = "iznajmljivanja";
            this.iznajmljivanjaBindingSource.DataSource = this.ooadtim6DataSet1;
            // 
            // ooadtim6DataSet1
            // 
            this.ooadtim6DataSet1.DataSetName = "ooadtim6DataSet1";
            this.ooadtim6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.iznajmljivanjaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1019, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // iznajmljivanjaTableAdapter
            // 
            this.iznajmljivanjaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportIznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportIznajmljivanje";
            this.Text = "Iznajmljivanje";
            this.Load += new System.EventHandler(this.IznajmljivanjeF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljivanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iznajmljivanjaBindingSource;
        private ooadtim6DataSet1 ooadtim6DataSet1;
        private ooadtim6DataSet1TableAdapters.iznajmljivanjaTableAdapter iznajmljivanjaTableAdapter;
    }
}
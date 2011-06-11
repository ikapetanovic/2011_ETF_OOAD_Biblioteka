namespace WindowsFormsApplication1
{
    partial class ReportKnjige
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
            this.knjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ooadtim6DataSet = new WindowsFormsApplication1.ooadtim6DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.knjigeTableAdapter = new WindowsFormsApplication1.ooadtim6DataSetTableAdapters.knjigeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // knjigeBindingSource
            // 
            this.knjigeBindingSource.DataMember = "knjige";
            this.knjigeBindingSource.DataSource = this.ooadtim6DataSet;
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
            reportDataSource1.Value = this.knjigeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1020, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // knjigeTableAdapter
            // 
            this.knjigeTableAdapter.ClearBeforeFill = true;
            // 
            // ReportKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportKnjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ooadtim6DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource knjigeBindingSource;
        private ooadtim6DataSet ooadtim6DataSet;
        private ooadtim6DataSetTableAdapters.knjigeTableAdapter knjigeTableAdapter;
    }
}
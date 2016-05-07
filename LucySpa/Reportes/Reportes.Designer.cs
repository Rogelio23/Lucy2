namespace LucySpa.Reportes
{
    partial class Reportes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.vistaCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCitasTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaCitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LucySpa.Reportes.CrearReporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 206);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCitasBindingSource
            // 
            this.vistaCitasBindingSource.DataMember = "vistaCitas";
            this.vistaCitasBindingSource.DataSource = this.lucySpaDB;
            // 
            // vistaCitasTableAdapter
            // 
            this.vistaCitasTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 261);
            this.Controls.Add(this.reportViewer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCitasBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter vistaCitasTableAdapter;
    }
}
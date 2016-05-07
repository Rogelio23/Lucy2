namespace LucySpa.Productos
{
    partial class ReporteEmpleados
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
            this.paReporteEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporte = new LucySpa.DSReporte();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paReporteEmpleadoTableAdapter = new LucySpa.DSReporteTableAdapters.paReporteEmpleadoTableAdapter();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.paReporteEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // paReporteEmpleadoBindingSource
            // 
            this.paReporteEmpleadoBindingSource.DataMember = "paReporteEmpleado";
            this.paReporteEmpleadoBindingSource.DataSource = this.dSReporte;
            // 
            // dSReporte
            // 
            this.dSReporte.DataSetName = "DSReporte";
            this.dSReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Miriam", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paReporteEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LucySpa.Reportes.ReporteEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 125);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(3);
            this.reportViewer1.Size = new System.Drawing.Size(725, 260);
            this.reportViewer1.TabIndex = 0;
            // 
            // paReporteEmpleadoTableAdapter
            // 
            this.paReporteEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(51, 85);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2015, 11, 18, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 1;
            this.dtpFechaInicio.Value = new System.DateTime(2015, 11, 18, 0, 0, 0, 0);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(301, 85);
            this.dtpFechaFinal.MinDate = new System.DateTime(2015, 11, 18, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.Highlight = false;
            this.btnAceptar.Location = new System.Drawing.Point(544, 73);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 32);
            this.btnAceptar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAceptar.StyleManager = null;
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 388);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.reportViewer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ReporteEmpleados";
            this.Text = "Reporte Empleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paReporteEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paReporteEmpleadoBindingSource;
        private DSReporte dSReporte;
        private DSReporteTableAdapters.paReporteEmpleadoTableAdapter paReporteEmpleadoTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private MetroFramework.Controls.MetroButton btnAceptar;



    }
}
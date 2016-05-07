using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucySpa.DSReporteTableAdapters;

namespace LucySpa.Productos
{
    public partial class ReporteEmpleados : MetroFramework.Forms.MetroForm
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int EmpleadoID { get; set; }
        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            //this.paReporteEmpleadoTableAdapter.Fill(this.dSReporte.paReporteEmpleado, FechaInicio, FechaFinal, EmpleadoID);
           // this.reportViewer1.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.paReporteEmpleadoTableAdapter.Fill(this.dSReporte.paReporteEmpleado, dtpFechaInicio.Value,dtpFechaFinal.Value,EmpleadoID);
            this.reportViewer1.RefreshReport();
        }


    }
}

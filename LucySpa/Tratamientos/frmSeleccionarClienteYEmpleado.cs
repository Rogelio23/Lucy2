using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Tratamientos
{
    public partial class frmSeleccionarClienteYEmpleado : MetroFramework.Forms.MetroForm
    {
        int TratamientoId;
        decimal costo;
        public frmSeleccionarClienteYEmpleado(int TratamientoID,decimal costo)
        {
            InitializeComponent();
            this.TratamientoId = TratamientoID;
            this.costo = costo;
        }

        private void frmSeleccionarClienteYEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.vistaEmpleado' table. You can move, or remove it, as needed.
            this.vistaEmpleadoTableAdapter.Fill(this.lucySpaDB.vistaEmpleado);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaCLiente' table. You can move, or remove it, as needed.
            this.vistaCLienteTableAdapter.Fill(this.lucySpaDB.vistaCLiente);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            int ClienteID = (int)filaSeleccionada.Cells[0].Value;
            frmVentaTratamientocs v = new frmVentaTratamientocs(TratamientoId, ClienteID,costo);
            v.ShowDialog();
            this.Close();
        }
    }
}

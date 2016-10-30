using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace LucySpa
{
    using TAClientes = DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter;
    using RowCliente = DataAccess.LucySpaDB.ClientesRow;
    public partial class frmAsignarTarjetas : MetroFramework.Forms.MetroForm
    {
        Inicio formaPadre;
        int clienteID;
        DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter taTarjetas = new DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter();
        DataAccess.DSTarjetasTableAdapters.VentaTarjetasTableAdapter taVentaTarjetas = new DataAccess.DSTarjetasTableAdapters.VentaTarjetasTableAdapter();

        TAClientes taClientes = new TAClientes();
        public frmAsignarTarjetas()
        {
            InitializeComponent();
        }
        public frmAsignarTarjetas(Inicio formaPadre, int clienteID)
        {
            InitializeComponent();
            this.formaPadre = formaPadre;
            this.clienteID = clienteID;
        }

        private void frmTarjetas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSTarjetas.Tarjetas' Puede moverla o quitarla según sea necesario.
            this.tarjetasTableAdapter.FillByPremiumTarjetas(this.dSTarjetas.Tarjetas);
            //cargarComboBox();
            RowCliente renglon = taClientes.GetDataByClienteID(clienteID)[0];
            String nombreCliente = renglon.Nombre + " " + renglon.Apellido;
            tbCliente.Text = nombreCliente;
        }

        private void tbDireccionCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO Implementar query para asignar nueva tarjeta a usuario
            
            taVentaTarjetas.Insert(clienteID,int.Parse(cbTarjeta.Text), dateTimePicker1.Value, null);

            MessageBox.Show("Tarjeta asignada correctamente");
            this.Close();
        }


        private void rbPremium_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.tarjetasTableAdapter.FillByPremiumTarjetas(this.dSTarjetas.Tarjetas);
            }
            catch{ }
        }

        private void rbRegalo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.tarjetasTableAdapter.FillByRegaloTarjetas(this.dSTarjetas.Tarjetas);
            }
            catch{ }
        }

        private void rbCortesia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.tarjetasTableAdapter.FillByCortesiaTarjetas(this.dSTarjetas.Tarjetas);
            }
            catch{ }
        }
    }
}

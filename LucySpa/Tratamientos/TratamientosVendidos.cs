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
    public partial class TratamientosVendidos : MetroFramework.Forms.MetroForm
    {
        int ClienteID;
        public TratamientosVendidos(int ClienteID)
        {
            InitializeComponent();
            this.ClienteID = ClienteID;
        }

        private void TratamientosVendidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.VistaVentaDeTratamientos' table. You can move, or remove it, as needed.
            this.vistaVentaDeTratamientosTableAdapter.FillByClienteID(this.lucySpaDB.VistaVentaDeTratamientos,ClienteID);


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try {
                DataGridViewRow r = dgTratamientosVenidos.SelectedRows[0];
                int VentaID = (int)r.Cells[0].Value;
                Abonos v = new Abonos(VentaID);
                v.ShowDialog();
            }
            catch { }
        }
    }
}

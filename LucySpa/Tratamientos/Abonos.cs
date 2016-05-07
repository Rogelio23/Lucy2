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
    public partial class Abonos : MetroFramework.Forms.MetroForm
    {
        int VentaTratamientoID;
        public Abonos(int VentaTratamientoID)
        {
            InitializeComponent();
            this.VentaTratamientoID = VentaTratamientoID;
        }

        private void Abonos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.VistaAbonos' table. You can move, or remove it, as needed.
            //this.vistaAbonosTableAdapter.Fill(this.lucySpaDB.VistaAbonos);
            // TODO: This line of code loads data into the 'lucySpaDB.VistaAbonos' table. You can move, or remove it, as needed.
            try
            {
                this.vistaAbonosTableAdapter.FillByID(this.lucySpaDB.VistaAbonos, VentaTratamientoID);
            }
            catch (Exception ex)
            {

            }

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            DataAccess.LucySpaDBTableAdapters.AbonoTableAdapter taAbonos = new DataAccess.LucySpaDBTableAdapters.AbonoTableAdapter();
            decimal cantidad = decimal.Parse(tbAbono.Text);
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            int VentaID = (int)r.Cells[0].Value;
            decimal CostoTratamiento = (decimal)r.Cells[5].Value;
            decimal suma = (decimal)taAbonos.SumarCantidadAbonos(VentaID);
            if (suma >= CostoTratamiento)
            {
                MessageBox.Show("Este tratamiento a sido pagado completamente", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                taAbonos.Insert(VentaID, DateTime.Today, cantidad);
                this.vistaAbonosTableAdapter.FillByID(this.lucySpaDB.VistaAbonos, VentaTratamientoID);
                MessageBox.Show("Se a realizado un abono de " + cantidad + " Pesos", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimal SumaNueva = (decimal)taAbonos.SumarCantidadAbonos(VentaID);
                if (SumaNueva >= CostoTratamiento)
                {
                    MessageBox.Show("Este tratamiento a sido pagado completamente", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void tbAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumeros(e, sender);
        }
    }
}

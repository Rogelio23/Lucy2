using LucySpa.Citas;
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
    public partial class frmVentaTratamientocs : MetroFramework.Forms.MetroForm
    {
        DataAccess.LucySpaDBTableAdapters.CitasTableAdapter taCitas = new DataAccess.LucySpaDBTableAdapters.CitasTableAdapter();
        int TratamientoID,EmpleadoID=0,ClienteID;

        int ServicioidSeleccionado = 0;
        decimal costo;
        int ContarClicks = 0;
        public frmVentaTratamientocs(int TratamientoID,int ClienteID,decimal costo)
        {
            InitializeComponent();
            this.TratamientoID = TratamientoID;
            this.ClienteID = ClienteID;
            this.costo = costo;
        }

        private void tbPago_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void tbPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumeros(e, sender);
        }

        private void cbCuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvServicios_SelectionChanged(object sender, EventArgs e)
        {
            try {
                DataGridViewRow r = dgvServicios.SelectedRows[0];
                ServicioidSeleccionado = (int)r.Cells[0].Value;

                this.cuartoServicioTableAdapter.FillByServicioId(this.lucySpaDB.CuartoServicio, ServicioidSeleccionado);
            }
            catch { }
        }

        private void frmVentaTratamientocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.CuartoServicio' table. You can move, or remove it, as needed.
            this.cuartoServicioTableAdapter.FillByServicioId(this.lucySpaDB.CuartoServicio,ServicioidSeleccionado);
            // TODO: This line of code loads data into the 'lucySpaDB.Cuarto' table. You can move, or remove it, as needed.
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaDiseñoTrataConServicio' table. You can move, or remove it, as needed.
            this.vistaDiseñoTrataConServicioTableAdapter.FillByTratamientoID(this.lucySpaDB.vistaDiseñoTrataConServicio,TratamientoID);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaEmpleado' table. You can move, or remove it, as needed.
            this.vistaEmpleadoTableAdapter.Fill(this.lucySpaDB.vistaEmpleado);
            try {
                cbCuartos.SelectedIndex = 0;
            }
            catch { }
         

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter taVistaCitas = new DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter();

            //se obtiene el ID del Eliente con el reglon seleccionado///
            DataGridViewRow reglonServicio = dgvServicios.SelectedRows[0];
            int servicioID = (int)reglonServicio.Cells[0].Value;
            //se obtiene el ID del Empleado con el reglon seleccionado///
            DataGridViewRow reglonEmpleado = dgvEmpleados.SelectedRows[0];
            EmpleadoID = (int)reglonEmpleado.Cells[0].Value;
            string fecha = ((dtpFechaCita.Value.ToString("MM/dd/yyyy hh:mm tt")).Replace("a. m.", "am")).Replace("p. m.", "pm");
            int cuartoID = (int)cbCuartos.SelectedValue;
            //DataAccess.LucySpaDB.vistaCitasDataTable vistaCitasConflictivas = taVistaCitas.GetDataByCitasConflictivas(ClienteID, fecha, EmpleadoID, servicioID, cuartoID);
            string fechaRogelio = ((dtpFechaCita.Value.ToString("MM/dd/yyyy hh:mm tt")).Replace("a. m.", "am")).Replace("p. m.", "pm");
            DataAccess.LucySpaDB.vistaCitasDataTable vistaCitasConflictivas = taVistaCitas.GetDataByCitasConflictivas(ClienteID, fechaRogelio, EmpleadoID, servicioID, cuartoID);
            if (vistaCitasConflictivas.Rows.Count == 0)
            {//Si no hay citas conflictivas
                int numero = (int)cbCuartos.SelectedValue;
                if (!String.IsNullOrEmpty(tbPago.Text)&&numero>0) {
                    decimal pago = decimal.Parse(tbPago.Text);
                    if (pago >= costo)
                    {
                        taCitas.Insert(ClienteID, EmpleadoID, servicioID, dtpFechaCita.Value, TratamientoID, null, false,numero,true);
                        dgvServicios.Rows.RemoveAt(dgvServicios.CurrentRow.Index);
                        MessageBox.Show("Se Agendo La Cita Correctamente", "Cita agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dgvServicios.RowCount == 0)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        
                        taCitas.Insert(ClienteID, EmpleadoID, servicioID, dtpFechaCita.Value, TratamientoID, null, false,null,false);
                        DataAccess.LucySpaDBTableAdapters.AbonoTableAdapter taAbono = new DataAccess.LucySpaDBTableAdapters.AbonoTableAdapter();
                        DataAccess.LucySpaDBTableAdapters.VentaTratamientoTableAdapter taVentatratamiento = new DataAccess.LucySpaDBTableAdapters.VentaTratamientoTableAdapter();
                        if (ContarClicks < 1)
                        {
                            int idVentaTratamiento = (int)taVentatratamiento.AltaVentaTratamiento(ClienteID, TratamientoID, costo);
                            taAbono.Insert(idVentaTratamiento, DateTime.Today, pago);
                            dgvServicios.Rows.RemoveAt(dgvServicios.CurrentRow.Index);
                            MessageBox.Show("La cita se agendo correctamente mas no es un pago completo lo cual se le abono la cantidad de: $" + tbPago.Text + " A la cita", "Cita agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dgvServicios.RowCount == 0)
                            {
                                this.Close();
                            }
                            ContarClicks = ContarClicks + 1;
                        }
                        else
                        {
                            dgvServicios.Rows.RemoveAt(dgvServicios.CurrentRow.Index);
                            MessageBox.Show("La cita se agendo correctamente mas no es un pago completo lo cual se le abono la cantidad de: $" + tbPago.Text + " A la cita", "Cita agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dgvServicios.RowCount == 0)
                            {
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe introducir el pago para poder realizar esta accion", "Error de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Hay citas conflictivas, asi que se le muestran al usuario en una leyenda.
                FrmMostrarCitasConflictivas frmCitasConflictivas = new FrmMostrarCitasConflictivas(vistaCitasConflictivas);
                frmCitasConflictivas.ShowDialog();
            }
        }

    }
}

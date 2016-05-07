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
using LucySpa.Properties;
namespace LucySpa.Citas
{
    //******Conexiones table adapter//
    using TACitas = DataAccess.LucySpaDBTableAdapters.CitasTableAdapter;
    using TAVistaCitas = DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter;
    using rowCitas = DataAccess.LucySpaDB.CitasRow;
    using VistaCitas = DataAccess.LucySpaDB.vistaCitasDataTable;
    using TAClientes = DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter;
    using RowCliente = DataAccess.LucySpaDB.ClientesRow;

    public partial class frmCitas : MetroFramework.Forms.MetroForm
    {
        DataAccess.LucySpaDBTableAdapters.CitasTableAdapter taCitas = new DataAccess.LucySpaDBTableAdapters.CitasTableAdapter();
        //Ventana de inicio//
        Inicio inicioActuaCita;
        
        //Variable para el registro de citas//
        int clienteID;
        int citaID;
        bool Realizado;
        string ModooVentana = "Registrar";
        public frmCitas(int clienteID,Inicio citaactualizar)
        {
            this.clienteID = clienteID;
            this.inicioActuaCita = citaactualizar;
            InitializeComponent();
        }
        public frmCitas(Inicio citaActualizar, int citaID, int clienteID)
        {

            InitializeComponent();
            ModooVentana = "Modificar";
            this.citaID = citaID;
            this.clienteID = clienteID;
            inicioActuaCita = citaActualizar;
            this.Text = "Modificar Cita";
            mbtnAgendar.Text = "Modificar";

        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Cuarto' Puede moverla o quitarla según sea necesario.
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
            // TODO: This line of code loads data into the 'lucySpaDB.Servicio' table. You can move, or remove it, as needed.
            //this.servicioTableAdapter.Fill(this.lucySpaDB.Servicio);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaEmpleado' table. You can move, or remove it, as needed.
            this.vistaEmpleadoTableAdapter.Fill(this.lucySpaDB.vistaEmpleado);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaCLiente' table. You can move, or remove it, as needed.
            this.vistaCLienteTableAdapter.Fill(this.lucySpaDB.vistaCLiente);

            //Tomar nombre de cliente
            TAClientes taClientes = new TAClientes();

            RowCliente rowCliente = taClientes.GetDataByClienteID(clienteID)[0];
            String nombreCompleto = rowCliente.Nombre + " " + rowCliente.Apellido;
            tbNombreCliente.Text = nombreCompleto + " (" + clienteID + ")";
            if (ModooVentana == "Modificar")
            {
                // Se crea table adapter para obtener los datos de la cita que se quiere modificar//
                TACitas tacitas = new TACitas();
                rowCitas Fila = tacitas.GetDataByCitaID(citaID)[0];
                int servicioID = Fila.ServicioID;
                int empleadoID = Fila.EmpleadoID;
                clienteID = Fila.ClienteID;
                try
                {
                    Realizado = Fila.Realizado;
                }
                catch { }
                // Se obtiene el tamaño del arreglo de la vista Servicio//
                int tamdgvCitas = dgvServicios.RowCount - 1;

                for (int c = 0; c < tamdgvCitas; c++)
                {
                    int fila = (int)dgvServicios.Rows[c].Cells[0].Value;
                    if (fila == servicioID)
                    {
                        dgvServicios.Rows[c].Selected = true;
                    }

                }
                // Se obtiene el tamaño del arreglo de la vista Servicio//
                int tamdgvEmpleado = dgvEmpleado.RowCount - 1;
                for (int c = 0; c < tamdgvEmpleado; c++)
                {
                    int fila = (int)dgvEmpleado.Rows[c].Cells[0].Value;
                    if (fila == empleadoID)
                    {
                        dgvEmpleado.Rows[c].Selected = true;
                    }
                }
                dtpFechaCita.Text = Fila.Fecha.ToString();

            }

        }

        private void mbtnAgendar_Click(object sender, EventArgs e)
        {
            //se obtiene el ID del Eliente con el reglon seleccionado///
            DataGridViewRow reglonServicio = dgvServicios.SelectedRows [0];
            int servicioID = (int)reglonServicio.Cells[0].Value;
        
            //se obtiene el ID del Empleado con el reglon seleccionado///
            DataGridViewRow reglonEmpleado = dgvEmpleado.SelectedRows[0];
            int empleadoID = (int)reglonEmpleado.Cells[0].Value;


            TACitas taCitas = new TACitas();
            TAVistaCitas taVistaCitas = new TAVistaCitas();
            string fecha = ((dtpFechaCita.Value.ToString("MM/dd/yyyy hh:mm tt")).Replace("a. m.","am")).Replace("p. m.","pm");

            //Se busca si hay citas que hacen conflicto con la que se esta agendando
            VistaCitas vistaCitasConflictivas = taVistaCitas.GetDataByCitasConflictivas(fecha, clienteID, empleadoID, servicioID);
            if (vistaCitasConflictivas.Rows.Count == 0) {//Si no hay citas conflictivas
                if (ModooVentana == "Modificar")
                {
                    taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, dtpFechaCita.Value, null, null,null,citaID);
                    MessageBox.Show("Cita modificado satisfactoriamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //Se insertan los datos de la cita a la base de datos//
                    taCitas.Insert(clienteID, empleadoID, servicioID, dtpFechaCita.Value, null, null,null,(int)cbCuartos.SelectedValue,false);
                    MessageBox.Show("Guardado satisfactoriamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //Se actualiza la lista de registro de citas//
                inicioActuaCita.actualizarRegistroCita();
            }
            else
            {
                //Hay citas conflictivas, asi que se le muestran al usuario en una leyenda.
                FrmMostrarCitasConflictivas frmCitasConflictivas = new FrmMostrarCitasConflictivas(vistaCitasConflictivas);
                frmCitasConflictivas.ShowDialog();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //***Metodo que busca a los Empleados por nombre y/o apellido//
            this.vistaEmpleadoTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaEmpleado, tbBuscarEmpleado.Text.Trim());
        }

        private void mbtnBuscarCliente_Click(object sender, EventArgs e)
        {
            //***Metodo que busca a los Empleados por nombre y/o apellido//
            this.servicioTableAdapter.FillByBusquedaServicio(this.lucySpaDB.Servicio, tbBuscarCliente.Text.Trim());

        }

        private void cbCuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.servicioTableAdapter.Fill(this.lucySpaDB.Servicio);
            try
            {
                this.servicioTableAdapter.FillByCuartoID(this.lucySpaDB.Servicio, (int)cbCuartos.SelectedValue);
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            DateTime d3 = new DateTime();


            d1 = dtpFechaCita.Value;
            d2 = d1.AddMinutes(40);
            d3 = d1.AddMinutes(-40);
            
            int cuerto = (int)cbCuartos.SelectedValue;
            
            string citaConCuarto=(string)taCitas.revisarCuartoConCitas(cuerto, d3,d2);
            if(citaConCuarto=="existe"){
                chbDosPersonas.Checked=true;
            }
            else
            {
                chbDosPersonas.Checked = false;
            }
        }


    }
}

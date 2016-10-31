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



namespace LucySpa
{

    //Defincion de Alias
    using TablaCitas = DataAccess.LucySpaDB.vistaCitasDataTable;
    using RowVistaCita = DataAccess.LucySpaDB.vistaCitasRow;
    using RowCita = DataAccess.LucySpaDB.CitasRow;
    using LucySpa.Productos;
    using Tratamientos;

    public partial class Inicio : MetroFramework.Forms.MetroForm
    {

        int intServicioID = 0, intNumCuarto = 0;
        bool boolLoin = false;
        DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter taCuarto = new DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter taClientes = new DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter();
        DataAccess.LucySpaDBTableAdapters.EmpleadosTableAdapter taEmpleado = new DataAccess.LucySpaDBTableAdapters.EmpleadosTableAdapter();
        DataAccess.LucySpaDBTableAdapters.CitasTableAdapter taCitas = new DataAccess.LucySpaDBTableAdapters.CitasTableAdapter();
        DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter taEquipo = new DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.TratamientoTableAdapter taTratamiento = new DataAccess.LucySpaDBTableAdapters.TratamientoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter taProducto = new DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter();
        DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter taUsuarios = new DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter();
        DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter taTarjetas = new DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter();
        DataAccess.DSTarjetasTableAdapters.VentaTarjetasTableAdapter taVentaTarjetas = new DataAccess.DSTarjetasTableAdapters.VentaTarjetasTableAdapter();
        DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter taServicios = new DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();

        

        int equipoID = 0;
        decimal costoTarjetas;
        string tipoTarjeta = "";

        public Inicio()
        {

            InitializeComponent();

            dgvClientes.Columns["fotografiaCliente"].DefaultCellStyle.NullValue = Resources.clienteSinFoto;
            dgvEmpleados.Columns["fotografiaEmppleado"].DefaultCellStyle.NullValue = Resources.clienteSinFoto;

            monthViewAgenda.SelectionStart = DateTime.Today;
            monthViewAgenda.SelectionEnd = DateTime.Today.AddDays(7);

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.lucySpaDB.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dSTarjetas.VistaClientesConTarjetas' Puede moverla o quitarla según sea necesario.
            //this.vistaClientesConTarjetasTableAdapter.FillBy(this.dSTarjetas.VistaClientesConTarjetas);
            // TODO: esta línea de código carga datos en la tabla 'dSTarjetas.VentaTarjetas' Puede moverla o quitarla según sea necesario.
            this.ventaTarjetasTableAdapter.Fill(this.dSTarjetas.VentaTarjetas);
            // TODO: This line of code loads data into the 'lucySpaDB.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.lucySpaDB.Productos);
            // TODO: This line of code loads data into the 'dSTarjetas.Tarjetas' table. You can move, or remove it, as needed.
            try
            {
                this.tarjetasTableAdapter.Fill(this.dSTarjetas.Tarjetas);
            }
            catch { }
            // TODO: This line of code loads data into the 'dSTarjetas.Citas' table. You can move, or remove it, as needed.
            this.citasTableAdapter.Fill(this.dSTarjetas.Citas);
            // TODO: This line of code loads data into the 'lucySpaDB.Tratamiento' table. You can move, or remove it, as needed.
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Equipo' Puede moverla o quitarla según sea necesario.

            // TODO: This line of code loads data into the 'lucySpaDB.vistaCitas' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'lucySpaDB.vistaEmpleado' table. You can move, or remove it, as needed.
            // this.vistaEmpleadoTableAdapter.Fill(this.lucySpaDB.vistaEmpleado);
            // TODO: This line of code loads data into the 'lucySpaDB.vistaCLiente' table. You can move, or remove it, as needed.
            //this.vistaCLienteTableAdapter.Fill(this.lucySpaDB.vistaCLiente);
            // TODO: This line of code loads data into the 'lucySpaDB.Empleados' table. You can move, or remove it, as needed.


            try
            {
                this.tratamientoTableAdapter.Fill(this.lucySpaDB.Tratamiento);
                this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
                this.servicioTableAdapter.Fill(this.lucySpaDB.Servicio);
                this.clientesTableAdapter.Fill(this.lucySpaDB.Clientes);
                this.empleadosTableAdapter.Fill(this.lucySpaDB.Empleados);
                this.vistaEmpleadoTableAdapter.Fill(this.lucySpaDB.vistaEmpleado);
                this.vistaCLienteTableAdapter.Fill(this.lucySpaDB.vistaCLiente);
                this.vistaCitasTableAdapter.Fill(this.lucySpaDB.vistaCitas);
                this.equipoTableAdapter.Fill(this.lucySpaDB.Equipo);
                this.productosTableAdapter.Fill(this.lucySpaDB.Productos);
                this.vistaClientesConTarjetasTableAdapter.FillBy(this.dSTarjetas.VistaClientesConTarjetas);
                actualizarRegistroCita();


            }
            catch (Exception)
            {
                MessageBox.Show(Resources.strSinConexion);
            }

            ////////////////////////bool vipCard = rbVipCard.Checked;
            ////////////////////////bool giftCard = rbGiftCard.Checked;
            ////////////////////////bool lucyFriends = rbLucyFriends.Checked;
            ////////////////////////if (vipCard == true)
            ////////////////////////{
            ////////////////////////    costoTarjetas = (decimal)taTarjetas.QueryCosto();
            ////////////////////////    cargarDatosTarjetas();
            ////////////////////////}
            ////////////////////////else if (giftCard == true)
            ////////////////////////{

            ////////////////////////}
            ////////////////////////else if (lucyFriends == true)
            ////////////////////////{

            ////////////////////////}

            //costoTarjetas = (decimal)taTarjetas.QueryCosto();
            //cargarDatosTarjetas();
            hideFunciones();
            
        }

        /// <summary>
        /// Ocultamos toda funcionalidades requeridas
        /// </summary>
        public void hideFunciones()
        {
            //Ocultamos las funciones 
            tcMenu.TabPages.Remove(tpClientes);
            tcMenu.TabPages.Remove(tpCitas);
            tcMenu.TabPages.Remove(tpEmpleados);
            //tcMenu.TabPages.Remove(tpAgenda);
            tcMenu.TabPages.Remove(tpServicios);
            tcMenu.TabPages.Remove(tpTratamiento);
            tcMenu.TabPages.Remove(tpTarjetas);
            tcMenu.TabPages.Remove(tpProductos);
            tcMenu.TabPages.Remove(tpCuartos);
            tcMenu.TabPages.Remove(tpEquipo);
            tcMenu.TabPages.Remove(tpConfiguraciones);

            //Página cliente
            //tbBuscarCliente.Visible = false;
            //btnBuscar.Visible = false;
            //btnVenderProducto.Visible = false;
            //btnAsignarTarjeta.Visible = false;
            //btnAgendarCita.Visible = false;
            //btnBorrarCliente.Visible = false;
            //btnModificarCliente.Visible = false;
            //btnAgregarCliente.Visible = false;

            //Página usuario
            dgvUsuarios.Visible = false;
            //btnModificarUsuario.Visible = false;
            //btnEliminarUsuario.Visible = false;
            btnAgregarUsuario.Visible = false;
            btnBorrarUsuario.Visible = false;


            //Página empleados
            //tbBuscarEmpleado.Visible = false;
            //btnBuscarEmpleado.Visible = false;
            //btnReportes.Visible = false;
            //btnBorrarEmpleado.Visible = false;
            //btnModificarEmpleado.Visible = false;
            //btnAgregarEmpleado.Visible = false;


        }
        /// <summary>
        /// Muestra las páginas ocultas
        /// </summary>
        public void showPages()
        {
            tcMenu.TabPages.Add(tpClientes);
            tcMenu.TabPages.Add(tpCitas);
            tcMenu.TabPages.Add(tpEmpleados);
            //tcMenu.TabPages.Add(tpAgenda);
            tcMenu.TabPages.Add(tpServicios);
            tcMenu.TabPages.Add(tpTratamiento);
            tcMenu.TabPages.Add(tpTarjetas);
            tcMenu.TabPages.Add(tpProductos);
            tcMenu.TabPages.Add(tpCuartos);
            tcMenu.TabPages.Add(tpEquipo);
            tcMenu.TabPages.Add(tpConfiguraciones);

            //Página cliente
            //tbBuscarCliente.Visible = true;
            //btnBuscar.Visible = true;
            //btnVenderProducto.Visible = true;
            //btnAsignarTarjeta.Visible = true;
            //btnAgendarCita.Visible = true;
            //btnBorrarCliente.Visible = true;
            //btnModificarCliente.Visible = true;
            //btnAgregarCliente.Visible = true;

            //Página usuario
            dgvUsuarios.Visible = true;
            //btnModificarUsuario.Visible = true;
            //btnEliminarUsuario.Visible = true;
            btnAgregarUsuario.Visible = true;
            btnBorrarUsuario.Visible = true;

            //Página empleados
            //tbBuscarEmpleado.Visible = true;
            //btnBuscarEmpleado.Visible = true;
            //btnReportes.Visible = true;
            //btnBorrarEmpleado.Visible = true;
            //btnModificarEmpleado.Visible = true;
            //btnAgregarEmpleado.Visible = true;
            boolLoin = true;
        }


        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void gbCaja_Enter(object sender, EventArgs e)
        {

        }

        private void tpEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmClientes NuevoCliente = new frmClientes(this);
            NuevoCliente.ShowDialog();
            actualizarRegistroClientes();
        }
        // boton agregar empleado 
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados VentanaEmpleado = new frmEmpleados();
            VentanaEmpleado.ShowDialog();
            ActualizarRegistroEmpleado();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpCitas_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmServicios VentanaServicios = new frmServicios(this, 0);
            VentanaServicios.ShowDialog();

        }

        /// <summary>
        /// Actualiza la tabla de Servicios de la vista inicial.
        /// </summary>
        public void actualizarRegistroServicios()
        {
            this.servicioTableAdapter.FillByBusquedaServicio(this.lucySpaDB.Servicio, tbBuscarServicio.Text);
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {

        }
        public void actualizarVentanaEquipo()
        {
            this.equipoTableAdapter.Fill(this.lucySpaDB.Equipo);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //Se identifica el ID del cliente//
            DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int EmpleadoID = (int)filaSeleccionada.Cells[0].Value;

            //Se pregunta si se esta seguro de eliminar al Empleado//
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Empleado seleccionado?",
                "Eliminar Registro de Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                taEmpleado.DeleteQueryEmpleadoID(EmpleadoID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se actualiza la vista registro//
                ActualizarRegistroEmpleado();
            }

        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            //***Se identifica el ID del cliente//
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            int ClienteID = (int)filaSeleccionada.Cells[0].Value;

            //**Se pregunta si esta seguro dee eliminar al Cliente//
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Cliente seleccionado?",
                "Eliminar Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                taClientes.DeleteQueryCliente(ClienteID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //****Se actualizan los datos de la ventana//
                actualizarRegistroClientes();
            }


        }

        private void tpServicios_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscarServicio_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            frmTratamiento VentanaTratamiento = new frmTratamiento(this);
            VentanaTratamiento.ShowDialog();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            frmUsuarios VentanaUsuarios = new frmUsuarios();
            VentanaUsuarios.ShowDialog();
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {

            //frmCrearNuevasTarjetas VentanaTarjetas = new frmCrearNuevasTarjetas(this);
            //VentanaTarjetas.ShowDialog();
            if (validarTarjetas() == true)
            {
                if (rbVipCard.Checked == true)
                {
                    tipoTarjeta = "PREMIUM";
                }
                else if (rbGiftCard.Checked == true)
                {
                    tipoTarjeta = "GIFT CARD";
                }
                else
                {
                    tipoTarjeta = "LUCY FRIENDS";
                }

                taTarjetas.registrarNuevasTarjetas(tipoTarjeta, costoTarjetas, int.Parse(tbNuevasTarjetas.Text));
                MessageBox.Show("Se agregarón " + tbNuevasTarjetas.Text + " Tarjetas");
                cargarDatosTarjetas(tipoTarjeta);
                tbNuevasTarjetas.Text = "";
            }
            else
            {
                MessageBox.Show("Introduzca la cantidad de tarjetas a agregar");
            }

        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            if (intServicioID != 0)
            {
                frmServicios VentanaServicios = new frmServicios(this, intServicioID);
                intServicioID = 0;
                VentanaServicios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una celda");
            }
        }

        private void dgvServicios_Click(object sender, EventArgs e)
        {
            DataGridViewRow Renglon = dgvServicios.SelectedRows[0];
            intServicioID = (int)Renglon.Cells[0].Value;

        }

        private void tbBuscarServicio_TextChanged(object sender, EventArgs e)
        {
            // this.servicioTableAdapter.FillByBuquedaServicio(tbBuscarCliente.Text);x   
            this.servicioTableAdapter.FillByBusquedaServicio(this.lucySpaDB.Servicio, tbBuscarServicio.Text);
        }

        private void btnAgregarCuarto_Click(object sender, EventArgs e)
        {
            intNumCuarto = 0;
            Cuartos.frmCuartos VentanaCuartos = new Cuartos.frmCuartos(intNumCuarto, this);
            VentanaCuartos.ShowDialog();
        }

        private void dgvCuartos_Click(object sender, EventArgs e)
        {
            //DataGridViewRow RenglonCuarto =dgvCuartos.SelectedRows[0];
            //intNumCuarto = (int)RenglonCuarto.Cells[0].Value;

        }

        private void dgvCuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarCuarto_Click(object sender, EventArgs e)
        {
            Cuartos.frmCuartos VentanaCUartos = new Cuartos.frmCuartos(intNumCuarto, this);
            intNumCuarto = 0;

            VentanaCUartos.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //***Metodo que busca a los Clientes por nombre y/o apellido//
            this.vistaCLienteTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaCLiente, tbBuscarCliente.Text.Trim());
        }

        private void tbBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.vistaCLienteTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaCLiente, tbBuscarCliente.Text.Trim());
            }
        }

        private void dgvCuartos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //MessageBox.Show("usted borro una fila");
        }

        private void dgvCuartos_RegionChanged(object sender, EventArgs e)
        {

        }

        private void dgvCuartos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //if (nuevoCuarto == false)
            //{
            //    MessageBox.Show("aqui esta el detalle");

            //    try
            //    {
            //        DataGridViewRow row = dgvCuartos.Rows[e.RowIndex];
            //        taCuarto.UpdateCuarto((string)row.Cells["ColumnaDescripcionCuarto"].Value, (string)row.Cells["ColumnaNombreCuarto"].Value, (int)row.Cells["ColumnaNumeroCuarto"].Value);

            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Revise los datos ingresados");
            //    }


            //}
            //else ///esta parte es para cuando el la variable cuarto is true
            //{
            //    //dgvCuartos.AllowUserToAddRows = false;

            //    DataGridViewRow row = dgvCuartos.Rows[e.RowIndex];

            //    int numcuarto;
            //    string colnom;
            //    string coldesc;
            //    try
            //    {
            //        numcuarto = (int)row.Cells["ColumnaNumeroCuarto"].Value;
            //        colnom = (string)row.Cells["ColumnaNombreCuarto"].Value;
            //        coldesc = (string)row.Cells["ColumnaDescripcionCuarto"].Value;
            //        MessageBox.Show("si atrapo las variables");
            //        dgvCuartos.AllowUserToAddRows = false;
            //        taCuarto.Insert1((int)row.Cells["ColumnaNumeroCuarto"].Value, (string)row.Cells["ColumnaNombreCuarto"].Value, (string)row.Cells["ColumnaDescripcionCuarto"].Value);
            //        idx = idx + 1;


            //        //nuevoCuarto = false;

            //        //nuevoCuarto = true;
            //        //this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);


            //    }
            //    catch (Exception)
            //    {





            //    }


            //}

            //if (nuevoCuarto)
            //    dgvCuartos.Rows[numeroCuarto - 1].Cells["ColumnaNumeroCuarto"].Value = numeroCuarto;


        }

        private void dgvCuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idx = e.RowIndex;


            //if (idx > 0) { //Mientras una celda se encuentre seleccionada
            //    DataGridViewRow row = dgvCuartos.Rows[idx];

            //    //if (nuevoCuarto == true)
            //    //{
            //    //    //int numeroCuarto = (int)taCuarto.NumeroDeCuartoNuevo();
            //    //    //numeroCuarto = (int)taCuarto.NumeroDeCuartoNuevo(1, 1);

            //    //    //    row.Cells["ColumnaNumeroCuarto"].Value = numeroCuarto;
            //    //    //    dgvCuartos.AllowUserToAddRows = false;                 

            //    //}
            //    //else
            //    //{
            //    //    nuevoCuarto = false;
            //    //}

            //    nuevoCuarto = false;
            //}
            //nuevoCuarto = false;
            //if(nuevoCuarto)
            //    dgvCuartos.Rows[numeroCuarto - 1].Cells["ColumnaNumeroCuarto"].Value = numeroCuarto;

        }

        private void tpCuartos_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            int clienteID = (int)filaSeleccionada.Cells[0].Value;
            TabControl tabcontrol = new TabControl();
            frmClientes fromclientes = new frmClientes(clienteID, this);
            fromclientes.Show(this);

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbnBuscarEmpleado_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarRegistroEmpleado()
        {
            //***Metodo que busca a los Clientes por nombre y/o apellido//
            this.vistaEmpleadoTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaEmpleado, "");
        }

        private void btModificarEmpleado_Click_2(object sender, EventArgs e)
        {
            //*****Se Identifica el Reglon Seleccionado//
            DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int EmpleadoID = (int)filaSeleccionada.Cells[0].Value;

            //***Metodo que altualiza la vista de Empleados//
            frmEmpleados frmEmpleados = new frmEmpleados(EmpleadoID, this);
            frmEmpleados.Show(this);


        }
        public void actualizarCuarto()
        {
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
        }
        public void actualizarRegistroClientes()
        {
            //***Metodo que altualiza la vista de Clientes//
            this.vistaCLienteTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaCLiente, "");
        }

        private void tbBuscarEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.vistaEmpleadoTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaEmpleado, tbBuscarCliente.Text.Trim());
            }
        }

        private void btnNuevoCuarto_Click(object sender, EventArgs e)
        {
            int cuartonuevo = 0;
            LucySpa.Cuartos.frmCuartos NuevoCuarto = new Cuartos.frmCuartos(cuartonuevo, this);
            NuevoCuarto.ShowDialog();

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            //***Metodo que busca a los Empleados por nombre y/o apellido//
            this.vistaEmpleadoTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaEmpleado, tbBuscarEmpleado.Text.Trim());
        }
        public void actualizarRegistroCita()
        {
            //Se toman todas la citass que se tienen en la base de datos
            //this.vistaCitasTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaCitas, "");

            //Se toma todas las citas que no tienen estado es decir que aun estan activos
            vistaCitasTableAdapter.FillByNulos(lucySpaDB.vistaCitas);

            int tamañoDgvCitas = dgvCitas.Rows.Count;
            //Con este for se toman todas aquellas citas que no a pasado los 15 minutos de tolerancia
            for (int c = 1; c < tamañoDgvCitas; c++)
            {
                DateTime fechacita = (DateTime)dgvCitas.Rows[c].Cells[4].Value;
                fechacita.AddMinutes(15);
                DateTime fechaHoy = DateTime.Now;
                if (fechacita > fechaHoy)
                {
                    dgvCitas.Rows[c].Visible = true;
                }
                else
                {
                    dgvCitas.Rows[c].Visible = false;
                }
            }
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            this.vistaCitasTableAdapter.FillByNombreApellido(this.lucySpaDB.vistaCitas, tbBuscarCita.Text.Trim());

        }

        private void btnBorrarCuarto_Click(object sender, EventArgs e)
        {
            int cuartoID;
            DataGridViewRow filaSeleccionada = dgvCuartos.SelectedRows[0];
            cuartoID = (int)filaSeleccionada.Cells[0].Value;
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Cuarto seleccionado?", "Eliminar Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ////Se ejecuta la elminación del cuarto seleccionado de la BD
                taCuarto.DeleteCuarto(cuartoID);
                this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);

            }
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {

        }

        private void monthViewAgenda_SelectionChanged(object sender, EventArgs e)
        {
            //Se establece el rango de vision de la agenda segun las fechas seleccionadas en el calendario izquierdo
            if (monthViewAgenda.SelectionEnd.Subtract(monthViewAgenda.SelectionStart).TotalDays > 0)
            {
                calendarAgenda.SetViewRange(monthViewAgenda.SelectionStart, monthViewAgenda.SelectionEnd);
                //Se determinan las citas agendadas dentro del rango de tiempo
                TablaCitas citasAgendadas = vistaCitasTableAdapter.GetDataByRangoDeFechas(calendarAgenda.ViewStart, calendarAgenda.ViewEnd);
                calendarAgenda.Items.Clear();//Se limpia la agenda
                //Por cada cita agendada, se genera un control para verlas en forma de calendario
                foreach (RowVistaCita cita in citasAgendadas.Rows)
                {
                    DateTime fechaCita = cita.Fecha;
                    //Se compone el texto que se mostrara dentro del control de cita agendada
                    String texto = cita.Nombre + " " + cita.Apellido + ", " + cita.NombreEmpleado + ", " + cita.Fecha.TimeOfDay.ToString() + "\n" + cita.NombreServicio;

                    //Se construye el control de cita agendada
                    System.Windows.Forms.Calendar.CalendarItem citaAgendada = new System.Windows.Forms.Calendar.CalendarItem(calendarAgenda, fechaCita, fechaCita.AddMinutes(60), texto);
                    citaAgendada.Tag = cita.CitaID;
                    try
                    {
                        int color = cita.ColorEmpleado;

                        if (color < 0)
                        {
                            //Se agrega a la vista de calendario
                            calendarAgenda.Items.Add(citaAgendada);

                            //Se colorea cada cita que se encuentra en el acalendario
                            citaAgendada.BackgroundColor = Color.FromArgb(color);//-16711936);
                        }
                        else
                        {
                            //Se agrega a la vista de calendario
                            calendarAgenda.Items.Add(citaAgendada);
                        }
                    }
                    catch
                    {
                        calendarAgenda.Items.Add(citaAgendada);
                    }

                }
            }
        }

        private void calendarAgenda_ItemDoubleClick(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            int citaID = (int)e.Item.Tag;
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarCita_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar la Cita seleccionada?",
                "Eliminar Registro de Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataGridViewRow filaSeleccionada = dgvCitas.SelectedRows[0];
                int citaID = (int)filaSeleccionada.Cells[0].Value;

                //Se ejecuta la elminación del empleado seleccionado de la BD
                taCitas.DeleteQueryCitaID(citaID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Eliminar Cita",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //****Se actualizan los datos de la ventana//
                actualizarRegistroCita();
            }
        }


        private void tpClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {

            // Se toma el ID del Cliente//
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            int clienteID = (int)filaSeleccionada.Cells[0].Value;

            //Se envia el ID del Cliente y esta ventana para poderlo actuaizar al finalizar la Modificacion//
            LucySpa.Citas.frmCitas frmCitas = new Citas.frmCitas(clienteID, this);
            frmCitas.Show();
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            //DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            //int clienteID = (int)filaSeleccionada.Cells[0].Value;
            //TabControl tabcontrol = new TabControl();
            //frmClientes fromclientes = new frmClientes(clienteID, this);
            //fromclientes.Show(this);
            DataGridViewRow filaSeleccionada = dgvEquipo.SelectedRows[0];
            equipoID = (int)filaSeleccionada.Cells[0].Value;
            Equipo.frmEquipo updateEquipo = new Equipo.frmEquipo(equipoID, this);
            updateEquipo.ShowDialog();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipo.frmEquipo NuevoEquipo = new Equipo.frmEquipo(0, this);
            NuevoEquipo.ShowDialog();
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            /// Se toma el ID de la Cita//
            DataGridViewRow filaSeleccionada = dgvCitas.SelectedRows[0];
            int citaID = (int)filaSeleccionada.Cells[0].Value;
            int clienteID = (int)filaSeleccionada.Cells[1].Value;

            //Se envia el ID del Cliente y esta ventana para poderlo actuaizar al finalizar la Modificacion//
            LucySpa.Citas.frmCitas frmCitas = new Citas.frmCitas(this, citaID, clienteID);
            frmCitas.Show();
        }

        private void tpEquipo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarTablaEquipo_Click(object sender, EventArgs e)
        {
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);
        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEquipo.SelectedRows[0];
            equipoID = (int)filaSeleccionada.Cells[0].Value;
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Equipo seleccionado?",
                "Eliminar Registro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                taEquipo.DeleteEquipo(equipoID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //****Se actualizan los datos de la ventana//
                actualizarRegistroClientes();
            }
        }

        private void btnNuevoTratamiento_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int cuartoID;
            DataGridViewRow filaSeleccionada = dgvCuartos.SelectedRows[0];
            cuartoID = (int)filaSeleccionada.Cells[0].Value;
            LucySpa.Cuartos.frmCuartos NuevoCuarto = new Cuartos.frmCuartos(cuartoID, this);
            NuevoCuarto.ShowDialog();
        }

        private void btnRelacionCuartoServicios_Click(object sender, EventArgs e)
        {
            int cuartoID;

            DataGridViewRow filaSeleccionada = dgvCuartos.SelectedRows[0];
            cuartoID = (int)filaSeleccionada.Cells[0].Value;
            LucySpa.Cuartos.frmRelacionCuartoServicios RelacionCuartos = new Cuartos.frmRelacionCuartoServicios(this, cuartoID);
            RelacionCuartos.ShowDialog();

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvTratamiento.SelectedRows[0];
                int tratamientoID = (int)r.Cells[0].Value;
                frmDetalleTratamiento v = new frmDetalleTratamiento(tratamientoID);
                v.ShowDialog();
            }
            catch { }
        }

        private void btnBuscarTratamiento_Click(object sender, EventArgs e)
        {
            this.tratamientoTableAdapter.FillByBuscarTratamiento(this.lucySpaDB.Tratamiento, tbBsucarTratamiento.Text.Trim());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTratamiento.SelectedRows[0];
            int TratamientoID = (int)filaSeleccionada.Cells[0].Value;



            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Tratamiento seleccionado?",
                "Eliminar Tratamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                taTratamiento.DeleteQueryTratamientoID(TratamientoID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //****Se actualizan los datos de la ventana//
                actualizarTratamiento();
            }

        }

        public void actualizarTratamiento()
        {
            this.tratamientoTableAdapter.FillByBuscarTratamiento(this.lucySpaDB.Tratamiento, "");
        }

        private void btnmodificarTratamiento_Click(object sender, EventArgs e)
        {
            //Se obtiene reglon seleccionado//
            DataGridViewRow filaSeleccionada = dgvTratamiento.SelectedRows[0];
            int TratamientoID = (int)filaSeleccionada.Cells[0].Value;

            frmTratamiento fromTratamiento = new frmTratamiento(TratamientoID, this);
            fromTratamiento.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTratamiento.SelectedRows[0];
            int TratamientoID = (int)filaSeleccionada.Cells[0].Value;
            decimal costo = (decimal)filaSeleccionada.Cells[3].Value;
            frmSeleccionarClienteYEmpleado v = new frmSeleccionarClienteYEmpleado(TratamientoID, costo);
            v.ShowDialog();
        }

        private void btnAsignarTarjeta_Click(object sender, EventArgs e)
        {
            //***Se identifica el ID del cliente//
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            int ClienteID = (int)filaSeleccionada.Cells[0].Value;
            //TODO: Abrir ventana de asignacion de tarjeta a cliente
            frmAsignarTarjetas frm = new frmAsignarTarjetas(this, ClienteID);
            frm.ShowDialog();

        }

        private void btnBuscarTarjetas_Click(object sender, EventArgs e)
        {
            //TODO: Crear una vista de tarjetas asociadas a clientes y hacer busqueda por cliente o ID
            if (string.IsNullOrWhiteSpace(tbBuscarTarjeta.Text) != true)
            {
                this.vistaClientesConTarjetasTableAdapter.FillByBusquedaClienteContarjeta(this.dSTarjetas.VistaClientesConTarjetas, tbBuscarTarjeta.Text);
            }
            else
            {
                this.vistaClientesConTarjetasTableAdapter.FillBy(this.dSTarjetas.VistaClientesConTarjetas);
            }
        }
        public void actualizarRegistroProducto()
        {
            this.productosTableAdapter.FillByBuscaProductos(this.lucySpaDB.Productos, "");
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            LucySpa.Productos.frmProductos frmProductos = new Productos.frmProductos(this);

            frmProductos.Show();

        }

        private void btnModificarProductos_Click(object sender, EventArgs e)
        {

            //*****Se Identifica el Reglon Seleccionado//
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            int ProductoID = (int)filaSeleccionada.Cells[0].Value;
            //TabControl tabcontrol = new TabControl();

            frmProductos fromProductos = new frmProductos(ProductoID, this);

            fromProductos.Show();

        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            //***Se identifica el ID del cliente//
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            int ProductoID = (int)filaSeleccionada.Cells[0].Value;

            //**Se pregunta si esta seguro dee eliminar el producto//
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Producto seleccionado?",
                "Eliminar Registro de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                //taProducto.DeleteQueryProductos(ProductoID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmProductos fromProductos = new frmProductos(this);
                int RegistrosBorrados = taProducto.DeleteQueryProductos(ProductoID);
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                MessageBox.Show("El registro se elimino con exito ", "Registro eliminado", MessageBoxButtons.OK);
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            //***Se identifica el ID del cliente//
            int ClienteID = Herramientas.dgvValorInt(dgvClientes, 0, 0);
            frmVenta frmventa = new frmVenta(ClienteID);
            frmventa.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            int empleadoID = Herramientas.dgvValorInt(dgvEmpleados, 0, 0);
            ReporteEmpleados reporte = new ReporteEmpleados();
            reporte.EmpleadoID = empleadoID;
            reporte.ShowDialog();
        }
        public void ActualizarTarjetas()
        {
            this.tarjetasTableAdapter.Fill(this.dSTarjetas.Tarjetas);
        }

        private void btnBorrarTarjeta_Click(object sender, EventArgs e)
        {

            //DataGridViewRow tipoDeTarjeta = dgvTarjetas.SelectedRows[0];
            //int tarjetaID = (int)tipoDeTarjeta.Cells[0].Value;
            //taTarjetas.DeleteTarjetas(tarjetaID);
            //ActualizarTarjetas();
            if (string.IsNullOrWhiteSpace(tbNuevasTarjetas.Text) != true)
            {
                if (rbVipCard.Checked == true)
                {
                    tipoTarjeta = "PREMIUM";
                }
                else if (rbGiftCard.Checked == true)
                {
                    tipoTarjeta = "GIFT CARD";
                }
                else
                {
                    tipoTarjeta = "LUCY FRIENDS";
                }
                taTarjetas.DeleteMuchasTarjetas(int.Parse(tbNuevasTarjetas.Text));
                MessageBox.Show("Se han eliminado " + tbNuevasTarjetas.Text + " Tarjetas");
                cargarDatosTarjetas(tipoTarjeta);
                tbNuevasTarjetas.Text = "";
            }
        }

        private void btnBorrarServicio_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows != null)
            {
                int servicioID = Herramientas.dgvValorInt(dgvServicios, 0, 0);

                //**Se pregunta si esta seguro dee eliminar al Cliente//
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Servicio seleccionado?",
                    "Eliminar Registro de Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //Se ejecuta la elminación del empleado seleccionado de la BD
                    taServicios.DeleteQueryServicioID(servicioID);

                    //Si se ha confirmado la eliminación//
                    MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //****Se actualizan los datos de la ventana//
                    actualizarRegistroServicios();
                }
            }
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            this.equipoTableAdapter.FillByNombre(this.lucySpaDB.Equipo, tbBuscarEquipo.Text);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Se busca por nombre de producto que se introdusco en el texbox
            this.productosTableAdapter.FillByBuscaProductos(this.lucySpaDB.Productos, tbBuscarProductos.Text.Trim());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            //Si el estado de la Lista de las citas esta en pendiente se muestran todas aquellas citas
            //que ya pasaron los 15 munutos del retraso y no se han cancelado
            if (btnAdministrar.Text == "Pendientes")
            {
                CitasVencidas();
                btnAdministrar.Text = "Activos";
            }
            //Se muestran todas aquellas citas que aun no llega la hora de su servicio y que no estan canceladas//
            else
            {
                actualizarRegistroCita();
                btnAdministrar.Text = "Pendientes";
            }
        }
        public void CitasVencidas()
        {
            vistaCitasTableAdapter.FillByNulos(lucySpaDB.vistaCitas);
            int tamañoDgvCitas = dgvCitas.Rows.Count;
            for (int c = 0; c < tamañoDgvCitas; c++)
            {
                DateTime fechacita = (DateTime)dgvCitas.Rows[c].Cells[4].Value;
                fechacita = fechacita.AddMinutes(15);
                DateTime fechaHoy = DateTime.Now;
                if (fechaHoy > fechacita)
                {
                    dgvCitas.Rows[c].Visible = true;
                }
                else
                {
                    this.dgvCitas.CurrentCell = null;
                    dgvCitas.Rows[c].Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    LucySpa.Usuarios.frmLogin VentanaLogin = new LucySpa.Usuarios.frmLogin(this);
        //    VentanaLogin.Show();
        //    btnLogin.Visible = false;

        //}

        private void tpTarjetas_Click(object sender, EventArgs e)
        {

        }

        private bool validarTarjetas()
        {
            bool boolcosto, boolcaantidad;
            boolcosto = !string.IsNullOrWhiteSpace(tbCostoTarjetas.Text);
            boolcaantidad = !string.IsNullOrWhiteSpace(tbNuevasTarjetas.Text);
            return boolcaantidad && boolcosto;
        }
        private void cargarDatosTarjetas(string tipo)
        {
            int cantidad;//= (int)taTarjetas.QueryCantidadTotalTarjetas();
            int tarjetasAsignadas;// = (int)taVentaTarjetas.QueryTarjetasAsignadas();
            int TarjetasSinAsignar;// = (int)taTarjetas.QueryTarjetasSinAsignar();
            string TipoTarjeta;

            TipoTarjeta = tipo;
            cantidad = (int)taTarjetas.QueryCantidadTotalTarjetas(TipoTarjeta);

            tarjetasAsignadas = (int)taVentaTarjetas.QueryTarjetasAsignadas(TipoTarjeta);
            //TarjetasSinAsignar = (int)taTarjetas.QueryTarjetasSinAsignar(TipoTarjeta);
            TarjetasSinAsignar = cantidad - tarjetasAsignadas;
            tbCantidadTarjetas.Text = cantidad.ToString();
            //tbCostoTarjetas.Text = costoTarjetas.ToString();
            tbCostoTarjetas.Text= String.Format("{0:C}", costoTarjetas);
            //tbCostoTarjetas.Text = costoTarjetas.ToString();
            tbTarjetasAsignadas.Text = tarjetasAsignadas.ToString();
            tbTarjetasLibres.Text = TarjetasSinAsignar.ToString();

            //if (rbVipCard.Checked == true)
            //{
            //    TipoTarjeta = "PREMIUM";
            //    cantidad = (int)taTarjetas.QueryCantidadTotalTarjetas(TipoTarjeta);

            //    tarjetasAsignadas = (int)taVentaTarjetas.QueryTarjetasAsignadas(TipoTarjeta);
            //    //TarjetasSinAsignar = (int)taTarjetas.QueryTarjetasSinAsignar(TipoTarjeta);
            //    TarjetasSinAsignar = cantidad - tarjetasAsignadas;
            //    tbCantidadTarjetas.Text = cantidad.ToString();
            //    tbCostoTarjetas.Text = costoTarjetas.ToString();
            //    tbTarjetasAsignadas.Text = tarjetasAsignadas.ToString();
            //    tbTarjetasLibres.Text = TarjetasSinAsignar.ToString();
            //}
            //else if (rbGiftCard.Checked == true)
            //{
            //    TipoTarjeta = "GIFT CARD";
            //    cantidad = (int)taTarjetas.QueryCantidadTotalTarjetas(TipoTarjeta);
            //    TarjetasSinAsignar = (int)taTarjetas.QueryTarjetasSinAsignar(TipoTarjeta);
            //    tarjetasAsignadas = (int)taVentaTarjetas.QueryTarjetasAsignadas(TipoTarjeta);
            //    tbCantidadTarjetas.Text = cantidad.ToString();
            //    tbCostoTarjetas.Text = costoTarjetas.ToString();
            //    tbTarjetasAsignadas.Text = tarjetasAsignadas.ToString();
            //    tbTarjetasLibres.Text = TarjetasSinAsignar.ToString();
            //}
            //else
            //{
            //    TipoTarjeta = "LUCY FRIENDS";
            //    cantidad = (int)taTarjetas.QueryCantidadTotalTarjetas(TipoTarjeta);
            //    TarjetasSinAsignar = (int)taTarjetas.QueryTarjetasSinAsignar(TipoTarjeta);
            //    tarjetasAsignadas = (int)taVentaTarjetas.QueryTarjetasAsignadas(TipoTarjeta);
            //    tbCantidadTarjetas.Text = cantidad.ToString();
            //    tbCostoTarjetas.Text = costoTarjetas.ToString();
            //    tbTarjetasAsignadas.Text = tarjetasAsignadas.ToString();
            //    tbTarjetasLibres.Text = TarjetasSinAsignar.ToString();
            //}
            //int cantidad = (int)taTarjetas.QueryCantidadTotalTarjetas();

            //int tarjetasAsignadas = (int)taVentaTarjetas.QueryTarjetasAsignadas();
            //int TarjetasSinAsignar = (int)taTarjetas.QueryTarjetasSinAsignar();
            //tbCantidadTarjetas.Text = cantidad.ToString();
            //tbCostoTarjetas.Text = costoTarjetas.ToString();
            //tbTarjetasAsignadas.Text = tarjetasAsignadas.ToString();
            //tbTarjetasLibres.Text = TarjetasSinAsignar.ToString();


        }

        private void btnModificarCostoTarjeta_Click(object sender, EventArgs e)
        {
            if (rbVipCard.Checked == true)
            {
                tipoTarjeta = "PREMIUM";
            }
            else if (rbGiftCard.Checked == true)
            {
                tipoTarjeta = "GIFT CARD";
            }
            else
            {
                tipoTarjeta = "LUCY FRIENDS";
            }
            if (string.IsNullOrWhiteSpace(tbCostoTarjetas.Text) != true)
            {
                if (costoTarjetas != decimal.Parse(tbCostoTarjetas.Text))
                {
                    taTarjetas.UpdateCostoTarjetas(decimal.Parse(tbCostoTarjetas.Text), costoTarjetas, tipoTarjeta);
                    MessageBox.Show("Se cambio el costo de las tarjetas");
                    costoTarjetas = decimal.Parse(tbCostoTarjetas.Text);
                }
            }
        }

        //private void btnCerrarSesion_Click_3(object sender, EventArgs e)
        //{
        //    hideFunciones();
        //    btnLogin.Visible = true;
        //    btnAgregarUsuario.Visible = false;
        //}

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {

            // Se crea table adapter para obtener los datos de la cita que se quiere modificar//
            int citaID = Herramientas.dgvValorInt(dgvCitas, 0, 0);
            RowCita Fila = taCitas.GetDataByCitaID(citaID)[0];
            int servicioID = Fila.ServicioID;
            int empleadoID = Fila.EmpleadoID;
            int clienteID = Fila.ClienteID;
            DateTime fechaCita = Fila.Fecha;
            //Estos campos se ocuparan mas adelante ya que este relacionado bien tratamiento y tarjeta con citas//
            //int tratamientoID = Fila.TratamientoID;
            //int tarjetaID = Fila.VentaTarjeta;
            taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, fechaCita, null, null, false, citaID);
            MessageBox.Show("Se ha cancelado la cita satisfactoriamente", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //se Actualiza la lista de las citas dependiendo del estado en que esten//
            if (btnAdministrar.Text == "Activos")
            {
                CitasVencidas();
            }
            else
            {
                actualizarRegistroCita();
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvCitas.SelectedRows[0];
            decimal costoServicio = (decimal)filaSeleccionada.Cells[6].Value;

            int citaID = Herramientas.dgvValorInt(dgvCitas, 0, 0);
            //decimal costoServicio = (decimal)dgvCitas.Rows[0].Cells[6].Value;
            LucySpa.Citas.frmCitaPago frmCitaPago = new Citas.frmCitaPago(citaID, costoServicio, this);
            frmCitaPago.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Iniciar Sesion")
            {
                if (boolLoin == false)
                {
                    LucySpa.Usuarios.frmLogin VentanaLogin = new LucySpa.Usuarios.frmLogin(this, boolLoin);
                    VentanaLogin.ShowDialog();
                    btnLogin.Text = "Cerrar Sesion";
                    //btnLogin.Visible = false;
                }
            }
            else
            if (btnLogin.Text == "Cerrar Sesion")
            {
                if (boolLoin == true)
                {
                    hideFunciones();
                    //btnLogin.Visible = true;
                    btnAgregarUsuario.Visible = false;
                    boolLoin = false;
                    btnLogin.Text = "Iniciar Sesion";
                }
            }
        }



        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];
            int UsuarioID = (int)filaSeleccionada.Cells[0].Value;

            //**Se pregunta si esta seguro dee eliminar el producto//
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el Usuario seleccionado?",
                "Eliminar Registro de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Se ejecuta la elminación del empleado seleccionado de la BD
                //taProducto.DeleteQueryProductos(ProductoID);

                //Si se ha confirmado la eliminación//
                MessageBox.Show("Registro borrado satisfactoriamente.", "Registro de Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmUsuarios fromUsuarios = new frmUsuarios();
                int RegistrosBorrados = taUsuarios.DeleteQueryUsuarios(UsuarioID);
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.CurrentRow.Index);
                MessageBox.Show("El registro se elimino con exito ", "Registro eliminado", MessageBoxButtons.OK);
            }


        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();

            frmUsuarios.Show();
        }

        private void tbBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void tpConfiguraciones_Click(object sender, EventArgs e)
        {

        }

        private void equipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tpConfiguraciones_Click_1(object sender, EventArgs e)
        {

        }


        private void tpTratamiento_Click(object sender, EventArgs e)
        {

        }

        private void tratamientosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvClientes.SelectedRows[0];
            int Clienteid = (int)r.Cells[0].Value;
            TratamientosVendidos v = new TratamientosVendidos(Clienteid);
            v.ShowDialog();
        }

        private void btnCrearTratamientoCliente_Click(object sender, EventArgs e)
        {
            //***Se identifica el ID del cliente//
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            int ClienteID = (int)filaSeleccionada.Cells[0].Value;
            string tipoTratamieno = "especifico";

            frmTratamiento CrearTratamientoCliente = new frmTratamiento(ClienteID, tipoTratamieno, this);
            CrearTratamientoCliente.ShowDialog();
        }

        private void tbBuscarCliente_Click_1(object sender, EventArgs e)
        {

        }

        private void calendarAgenda_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {

        }

        private void tbCantidadTarjetas_Click(object sender, EventArgs e)
        {

        }

        private void tbTarjetasAsignadas_Click(object sender, EventArgs e)
        {

        }

        private void rbVipCard_CheckedChanged(object sender, EventArgs e)
        {
            costoTarjetas = (decimal)taTarjetas.QueryCosto("PREMIUM");
            cargarDatosTarjetas("PREMIUM");
        }

        private void rbGiftCard_CheckedChanged(object sender, EventArgs e)
        {
            costoTarjetas = (decimal)taTarjetas.QueryCosto("GIFT CARD");
            cargarDatosTarjetas("GIFT CARD");
        }

        private void rbLucyFriends_CheckedChanged(object sender, EventArgs e)
        {
            costoTarjetas = (decimal)taTarjetas.QueryCosto("LUCY FRIENDS");
            cargarDatosTarjetas("LUCY FRIENDS");
        }

        private void tbNuevasTarjetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumerosSinDecimales(tbNuevasTarjetas, e, sender);
        }

        private void tbBuscarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
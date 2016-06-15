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

namespace LucySpa.Cuartos
{
    public partial class frmCuartos : MetroFramework.Forms.MetroForm
    {
        DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter taCuartos = new DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter taServicios = new DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
        DataAccess.LucySpaDBTableAdapters.CuartoServicioTableAdapter taDiseñoCuarto = new DataAccess.LucySpaDBTableAdapters.CuartoServicioTableAdapter();
        DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter taEquipo = new DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.VistaDiseñoCuartoServicioTableAdapter taVistaDiseñoCuartoServicio = new DataAccess.LucySpaDBTableAdapters.VistaDiseñoCuartoServicioTableAdapter();
        DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter taVistaCuartosConServicios = new DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter();
        bool valNumeroCuarto, valDescripcionCuarto;
        int intNumeroCuarto;
        int servicioID=1;
        int equipoID=1;
        int segundoServicioID = 1;
        int segundoEquipoID = 1;
        string NombreEquipo;
        string NombreServicio;
        Inicio PantallaPrincipal;
        public frmCuartos(int intNumCuarto, Inicio menuInicial)
        {
            PantallaPrincipal = menuInicial;
            InitializeComponent();
            if (intNumCuarto != 0)
            {
                btnGuardar.Text = "Modificar";
                tbNumeroCuarto.Text = intNumCuarto.ToString();
                tbNombre.Text = taCuartos.getNombreDelCuarto(intNumCuarto);
                tbDescripcionCuarto.Text = taCuartos.GetDescripcionCuarto(intNumCuarto);
                intNumeroCuarto = intNumCuarto;
                clonardatagrid();
                //dgvServicioSeleccionado.DataSource = this.taVistaDiseñoCuartoServicio.GetDataByRellenar(intNumeroCuarto);
                //dgvServicioSeleccionado.Columns[1].Visible = false;
                //dgvServicioSeleccionado.DataSource = taVistaCuartosConServicios.FillByCuarto(this.lucySpaDB.vistaCuartoconServicios, intNumeroCuarto);
                

                //dgvEquipoSeleccionado.Columns[1].Visible = false;
                //dgvEquipoSeleccionado.Columns[2].Visible = false;
                //dgvEquipoSeleccionado.Columns[3].Visible = false;
                //dgvEquipoSeleccionado.Columns[5].Visible = false;
            }
            else
            {
                intNumeroCuarto = (int)taCuartos.NumeroDeCuartoNuevo(1,1);
                tbNumeroCuarto.Text = intNumeroCuarto.ToString();
            }
        }

        private void frmCuartos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Equipo' Puede moverla o quitarla según sea necesario.
            //this.equipoTableAdapter.Fill(this.lucySpaDB.Equipo);
            taEquipo.FillByEquipoISNull(this.lucySpaDB.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.lucySpaDB.Servicio);
            //dgvServicioSeleccionado = taDiseñoCuarto.FillByRellenarTablaTemporal(this.lucySpaDB, intNumeroCuarto);
            //btnSeleccionarServicio.Font.Size = new  .Size(12);
            //btnSeleccionarServicio.Font=new Font("Microsoft Sans Serif", 30);
            //taVistaDiseñoCuartoServicio.FillRellenarDiseñoCuartoServicio(this.lucySpaDB.VistaDiseñoCuartoServicio, intNumeroCuarto);
            //this.vistaDiseñoCuartoServicioTableAdapter.Fill(this.lucySpaDB.VistaDiseñoCuartoServicio);
            //dgvtablatemporal.DataSource = this.vistaDiseñoCuartoServicioTableAdapter.GetData();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (entradaDeDatosValidas())
            {
                if (btnGuardar.Text=="Guardar")
                {
                    
                    taCuartos.Insert1(intNumeroCuarto, tbNombre.Text,tbDescripcionCuarto.Text);
                    
                    //int numServiciosNuevos = dgvServicioSeleccionado.RowCount - 1;
                    //for (int c = 0; c < numServiciosNuevos; c++)
                    //{
                    //    //int newservicioID = (int)dgvServicioSeleccionado.Rows[c].Cells[0].Value;
                        
                    //    //taDiseñoTratamiento.Insert(TratamientoID, servicioID, cantidad);//Se crea un alta de DiseñoTratamiento//
                    //    //taDiseñoCuarto.Insert(int.Parse(tbNumeroCuarto.Text), newservicioID);                      
                    //}
                    foreach (DataGridViewRow renglon in dgvServicioSeleccionado.Rows)
                    {
                        int newservicioID = (int)renglon.Cells[0].Value;
                        taDiseñoCuarto.Insert(int.Parse(tbNumeroCuarto.Text), newservicioID);
                        PantallaPrincipal.actualizarCuarto();
                    }

                    //int numEquiposNuevos = dgvEquipoSeleccionado.RowCount - 1;
                    //for (int c = 0; c < numServiciosNuevos; c++)
                    //{
                    //    try
                    //    {
                    //        int newequipoID = (int)dgvEquipoSeleccionado.Rows[c].Cells[0].Value;
                    //        taEquipo.UpdateEquipoConNuevoCuarto(int.Parse(tbNumeroCuarto.Text), newequipoID);
                    //    }
                    //    catch (Exception)
                    //    {
                            
                    //        throw;
                    //    }

                        
                    //}
                    foreach (DataGridViewRow renglon in dgvEquipoSeleccionado.Rows)
                    {
                        //int newequipoID = (int)dgvEquipoSeleccionado.Rows[c].Cells[0].Value;
                        
                            int newequipoID = (int)renglon.Cells[0].Value;
                            //taEquipo.UpdateEquipoConNuevoCuarto(int.Parse(tbNumeroCuarto.Text), newequipoID);
                        //taEquipo.UpdateEquipoConNuevoCuarto(int.Parse(tbNumeroCuarto.Text), newequipoID);
                        taEquipo.UpdateDelNuevoQueryConCuarto(int.Parse(tbNumeroCuarto.Text), newequipoID);
                        PantallaPrincipal.actualizarVentanaEquipo();
                        PantallaPrincipal.actualizarCuarto();
                            //MessageBox.Show("si entro");
                        
                    }

                    MessageBox.Show("Se guardo correctamente el Cuarto", Properties.Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //taCuartos.UpdateCuarto(tbDescripcionCuarto.Text,intNumeroCuarto);
                    taCuartos.UpdateCuarto(tbDescripcionCuarto.Text, tbNombre.Text, intNumeroCuarto);
                    PantallaPrincipal.actualizarVentanaEquipo();
                    PantallaPrincipal.actualizarCuarto();
                    MessageBox.Show("El cuarto se ha modificado exitosamente ", Properties.Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("No ha sido posible ejecutar la operación. "+Properties.Resources.strDatosIntroducidosInvalidos, Properties.Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Valida las entradas de datos en la pantalla de alta de cuartos
        private bool entradaDeDatosValidas()
        {
            valNumeroCuarto = Herramientas.validarTextBox(tbNumeroCuarto);
            valDescripcionCuarto = Herramientas.validarTextBox(tbDescripcionCuarto);

            return valNumeroCuarto && valDescripcionCuarto; 
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbNumeroCuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarServicio_Click(object sender, EventArgs e)
        {
            int numServiciosNuevos = dgvServicioSeleccionado.RowCount - 1;
            bool boolagregar = false;
            int intIdentificador = 0;
            //for (int c = 0; c < numServiciosNuevos; c++)
            //{

                int newservicioID = servicioID;
                foreach(DataGridViewRow renglon in dgvServicioSeleccionado.Rows){
                    
               
                if ((int)renglon.Cells[intIdentificador].Value==servicioID )
                {
                    boolagregar = true;
                    break;
                    
                }
                }
                               
                
           // }
            if (boolagregar == false)
            {
                dgvServicioSeleccionado.AllowUserToAddRows = true;
                DataGridViewRow filaSeleccionada = dgvServicios.SelectedRows[0];
                NombreServicio = (string)filaSeleccionada.Cells[1].Value;
                DataGridViewRow row = (DataGridViewRow)dgvServicioSeleccionado.Rows[0].Clone();

                row.Cells[intIdentificador].Value = servicioID;
                row.Cells[intIdentificador + 1].Value = NombreServicio;
                dgvServicioSeleccionado.Rows.Add(row);  
                dgvServicioSeleccionado.AllowUserToAddRows = false;
                
            }


            if (btnGuardar.Text == "Modificar")
            {
                intIdentificador = 2;
            }




        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvServicios.SelectedRows[0];
            servicioID = (int)filaSeleccionada.Cells[0].Value;
            
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEquipos.SelectedRows[0];
            equipoID= (int)filaSeleccionada.Cells[0].Value;
            
        }

        private void btnSeleccionarEquipo_Click(object sender, EventArgs e)
        {
            int numEquiposNuevos = dgvEquipoSeleccionado.RowCount - 1;
            bool boolagregar = false;
            //int identificador = 0;
            //for (int c = 0; c < numEquiposNuevos; c++)
            //{
            //    int newequipoID = (int)dgvEquipoSeleccionado.Rows[c].Cells[0].Value;

            //    if (newequipoID == equipoID)
            //    {
            //        boolagregar = true;

            //    }

            //}
            foreach (DataGridViewRow renglon in dgvEquipoSeleccionado.Rows)
            {
                int newequipoID = (int)renglon.Cells[0].Value;
                if (newequipoID == equipoID)
                {
                    boolagregar = true;

                }
            }
            if (boolagregar == false)
            {
                if (dgvEquipos.Rows.Count != 0)
                {
                                    
                DataGridViewRow filaSeleccionada = dgvEquipos.SelectedRows[0];
                NombreEquipo = (string)filaSeleccionada.Cells[1].Value;
                equipoID = (int)filaSeleccionada.Cells[0].Value;
                dgvEquipoSeleccionado.AllowUserToAddRows = true;
                DataGridViewRow row = (DataGridViewRow)dgvEquipoSeleccionado.Rows[0].Clone();
                row.Cells[0].Value = equipoID;
                row.Cells[1].Value = NombreEquipo;
                dgvEquipoSeleccionado.Rows.Add(row);//Se inserta al DataGridView de tratamiento un nuevo reglon//  
                dgvEquipoSeleccionado.AllowUserToAddRows = false;
                }
            }
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServicioSeleccionado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaSeleccionada = dgvServicioSeleccionado.SelectedRows[0];
                segundoServicioID = (int)filaSeleccionada.Cells[0].Value;
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void dgvEquipoSeleccionado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEquipoSeleccionado.SelectedRows[0];
            segundoEquipoID = (int)filaSeleccionada.Cells[0].Value;
        }

        private void pbRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgvServicioSeleccionado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clonardatagrid()
        {
            
            dgvModificarServicio.DataSource = taVistaCuartosConServicios.GetDataByCuarto(intNumeroCuarto);
            int intIDservicio;
            string stringNombre;
            foreach (DataGridViewRow renglon in dgvModificarServicio.Rows)
            {
                intIDservicio = (int)renglon.Cells[4].Value;
                stringNombre = (string)renglon.Cells[1].Value;

                dgvServicioSeleccionado.AllowUserToAddRows = true;
                DataGridViewRow row = (DataGridViewRow)dgvServicioSeleccionado.Rows[0].Clone();
                row.Cells[0].Value = intIDservicio;
                row.Cells[1].Value = stringNombre;
                dgvServicioSeleccionado.Rows.Add(row);  
                dgvServicioSeleccionado.AllowUserToAddRows = false;
             }
            dgvModificarServicio.DataSource = taEquipo.GetDataByEquiposDelCuerpo(intNumeroCuarto);
            foreach (DataGridViewRow renglon2 in dgvModificarServicio.Rows)
            {
                intIDservicio = (int)renglon2.Cells[1].Value;
                stringNombre = (string)renglon2.Cells[2].Value;

                dgvEquipoSeleccionado.AllowUserToAddRows = true;
                DataGridViewRow row2 = (DataGridViewRow)dgvEquipoSeleccionado.Rows[0].Clone();
                row2.Cells[0].Value = intIDservicio;
                row2.Cells[1].Value = stringNombre;
                dgvEquipoSeleccionado.Rows.Add(row2);//Se inserta al DataGridView de tratamiento un nuevo reglon//  
                dgvEquipoSeleccionado.AllowUserToAddRows = false;
            }
        }

        private void btnDesseleccionarServicio_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvServicioSeleccionado.Rows.RemoveAt(segundoServicioID);
            //    --segundoServicioID;
            //}
            //catch (Exception)
            //{
                
            //    //throw;
            //}
            foreach (DataGridViewRow item in this.dgvServicioSeleccionado.SelectedRows)
            {
                dgvServicioSeleccionado.Rows.RemoveAt(item.Index);
            }
        }

        private void btnDesseleccionarEquipo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvEquipoSeleccionado.SelectedRows)
            {
                dgvEquipoSeleccionado.Rows.RemoveAt(item.Index);
            }
        }

        private void dgvModificarServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

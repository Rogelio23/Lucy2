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
    using rowTratamiento = DataAccess.LucySpaDB.TratamientoRow;
    public partial class frmTratamiento : MetroFramework.Forms.MetroForm //Form
    {
        //Variables para alta de Tratamientos//
        int TratamientoID;
        Inicio inicioActualizar;
        string modoVentana = "Registro";
        //Varibles para validar los datos//
        bool boolNombre;
        bool boolDescripcion;
        bool boolPrecioCatalogo;
        bool booltamañoTratamiento;

        //Se crea el Table Adapter del tratamiento y diseño de tratamientos//
        DataAccess.LucySpaDBTableAdapters.DiseñoTratamientoTableAdapter taDiseñoTratamiento = new DataAccess.LucySpaDBTableAdapters.DiseñoTratamientoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.TratamientoTableAdapter taTratamiento = new DataAccess.LucySpaDBTableAdapters.TratamientoTableAdapter();
        DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter taServicio = new DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();

        public frmTratamiento(Inicio inicioActualizar)
        {
            InitializeComponent();
            this.inicioActualizar = inicioActualizar;
        }
        public frmTratamiento(int tratamientoID, Inicio inicioActualizar)
        {
            InitializeComponent();
            TratamientoID = tratamientoID;
            this.inicioActualizar = inicioActualizar;
            modoVentana = "Modificacion";
            // int nadaaa = nada.;
        }

        private void frmTratamiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.vistaDiseñoTrataConServicio' table. You can move, or remove it, as needed.
            //this.vistaDiseñoTrataConServicioTableAdapter.Fill(this.lucySpaDB.vistaDiseñoTrataConServicio);
            // TODO: This line of code loads data into the 'lucySpaDB.Servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.Fill(this.lucySpaDB.Servicio);
            if (modoVentana == "Modificacion")
            {
                //Se cambian nombre del boton y el titulo dee la ventana de Tratamiento//
                this.Text = "Modificacion de Tratamiento";
                btnGuardar.Text = "Modificar";
                rowTratamiento fila = taTratamiento.GetDataByTratamientoID(TratamientoID)[0];
                //rowServicio filaServicio = taServicio.GetDataByServicioID()[0];
                tbNombre.Text = fila.Nombre;
                tbDescripcion.Text = fila.Descripcion;
                try
                {
                    mtbPrecioCatalogo.Text = fila.precioCatalogo.ToString();
                    Herramientas.AcomodarCostoMkb(mtbPrecioCatalogo, fila.precioCatalogo);
                }
                catch { }
                int count = 0;
                foreach (var s in taDiseñoTratamiento.GetDataByTratamientoID(TratamientoID))
                {
                    int a = dgvTratamiento.Rows.Count;
                    DataGridViewRow row = (DataGridViewRow)dgvTratamiento.Rows[0].Clone();
                    int servicioId = (taDiseñoTratamiento.GetDataByTratamientoID(TratamientoID)[count]).ServicioID;
                    row.Cells[0].Value = servicioId;
                    row.Cells[1].Value = taServicio.GetDataByServicioID(servicioId)[0].Nombre;
                    row.Cells[2].Value = (taDiseñoTratamiento.GetDataByTratamientoID(TratamientoID)[count]).Cantidad;
                    row.Cells[3].Value = taServicio.GetDataByServicioID(servicioId)[0].Costo;
                    try
                    {
                        row.Cells[4].Value = (taDiseñoTratamiento.GetDataByTratamientoID(TratamientoID)[count]).Orden;
                    }
                    catch { }
                    dgvTratamiento.Rows.Add(row);
                    count = count + 1;
                }
                this.dgvTratamiento.Sort(this.dgvTratamiento.Columns["Orden"], ListSortDirection.Ascending);
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (mtbnCantidad.Text.Trim() != "")
            {
                // Se toma el ID y el nombre del Servicio//
                DataGridViewRow filaSeleccionada = dgvServicios.SelectedRows[0];
               int servicioID = (int)filaSeleccionada.Cells[0].Value;
                string NombreServicio = (string)filaSeleccionada.Cells[1].Value;
                decimal costo = (decimal)filaSeleccionada.Cells[2].Value;

                DataGridViewRow row = (DataGridViewRow)dgvTratamiento.Rows[0].Clone();
                row.Cells[0].Value = servicioID;
                row.Cells[1].Value = NombreServicio;
                int cantidad = int.Parse(mtbnCantidad.Text);
                row.Cells[2].Value = cantidad;
                row.Cells[3].Value = costo;
                dgvTratamiento.Rows.Add(row);//Se inserta al DataGridView de tratamiento un nuevo reglon//
                mtbnCantidad.Text = "";
            }

        }

        public bool validarDatos()
        {
            boolNombre = Herramientas.validarMetroTextBox(tbNombre);
            boolDescripcion = Herramientas.validarMetroTextBox(tbDescripcion);
            boolPrecioCatalogo = Herramientas.validarMascaraCosto(mtbPrecioCatalogo);
            //Se verifica que la lista de servicios que tendra el trataminto no este vacia//
            if (dgvTratamiento.Rows.Count>1)
            { booltamañoTratamiento = true; }
            return boolNombre && boolDescripcion && boolPrecioCatalogo && booltamañoTratamiento;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
           
        {
            if (validarDatos() == true)
            {
                if (modoVentana == "Registro")
                {
                    //Se crea un alta de Tratamiento el cual con un procedimiento alamcenado regresa el Tratamiento ID//
                    TratamientoID = (int)taTratamiento.AltaTratamiento(tbNombre.Text.Trim(), tbDescripcion.Text.Trim(), Decimal.Parse(mtbPrecioCatalogo.Text));
                }
                else
                {
                    //De lo contrario la ventana estara en modo Modificar por lo que solo borarra//
                    //los servicios asignados a ese Tratamiento para ingresar los nuevos//
                    taDiseñoTratamiento.DeleteQueryTratamientoID(TratamientoID);
                    decimal nada = Decimal.Parse(mtbPrecioCatalogo.Text);
                    taTratamiento.UpdateQueryTratamientoID(tbNombre.Text.Trim(), tbDescripcion.Text.Trim(), Decimal.Parse(mtbPrecioCatalogo.Text), TratamientoID);
                }
                //Se guarda el tamaño de la lista de tratamiento en una variable//
                int tamTratamiento = dgvTratamiento.RowCount - 1;
                //Si El tamaño de la lista de tratamiento no tiene nada no se podra guardar
                for (int c = 0; c < tamTratamiento; c++)
                {
                    int servicioID = (int)dgvTratamiento.Rows[c].Cells[0].Value;
                    int cantidad = (int)dgvTratamiento.Rows[c].Cells[2].Value;
                    taDiseñoTratamiento.Insert(TratamientoID, servicioID, cantidad, c);//Se crea un alta de DiseñoTratamiento//
                }
                if (modoVentana == "Registro")
                {
                    //Se muestra un mensaje de confirmacion del registro exitoso//
                    MessageBox.Show("Se ha registrado satisfactoriamente el tratamiento.", "Registro de Tratamiento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Se muestra un mensaje de Modificacion exitoso//
                    MessageBox.Show("Se ha modificado satisfactoriamente el tratamiento.", "Modificacion de Tratamiento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Se cierra la ventana de Tratamiento y se actualiza la tabla de Tratamientos
                this.Close();
                inicioActualizar.actualizarTratamiento();
            }
            else {
                //Los datos introducidos no tienen un formato correcto//
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try {
                if (this.dgvTratamiento.Rows.Count > 1)
                {
                    dgvTratamiento.Rows.RemoveAt(this.dgvTratamiento.SelectedRows[0].Index);

                }
            }
            catch { }
        }

        private void dgvServicios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class frmServicios : MetroFramework.Forms.MetroForm
    {
        //Variables para animacion de forma
        int Contador = 1350;
        bool ControlVentana = true;

        //Conexion con tabla de clientes
        DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter taServicos = new DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();

        //Variables para validaciones de campos introducidos
        private bool valNombreServicio, valCostoServicio, valDescripcionServicio,valTiempoServicio,valRepreparacion;
        int intServicioIDOriginal;

        //Representa ventana padre en esta clase
        Inicio ventanaPadre;

        public frmServicios(Inicio ventanaPadre, int intServicioID)
        {
            InitializeComponent();
            if (intServicioID != 0)
            {
                DataAccess.LucySpaDB.ServicioDataTable datosServicio = taServicos.GetDataByServicioID(intServicioID);
                //datosServicio[0].costo
                tbNombre.Text = datosServicio[0].Nombre;
                tbDescripcionServicio.Text = datosServicio[0].Descripcion;
                //adaptarCosto(mtbCosto,datosServicio[0].Costo);//Se adapta el costo dentro de la mascara
                Herramientas.AcomodarCostoMkb(mtbCosto, datosServicio[0].Costo);
                btnGuardar.Text = "Modificar";
                intServicioIDOriginal = intServicioID;
                try
                {
                    mtbTiempoServicio.Text = datosServicio[0].TiempoServicio.ToString();
                    mtbRepreparacion.Text = datosServicio[0].Repreparacion.ToString();
                }
                catch { }
            }
            this.ventanaPadre = ventanaPadre;
            
        }

        /// <summary>
        /// Adapta numeros decimal a cajas de texto con formato 0000.00
        /// </summary>
        /// <param name="mtb">Caja de texto donde se introducira la cadena de caracteres que representa el costo.</param>
        /// <param name="costo">Costo en formato decimal</param>
        private void adaptarCosto(MaskedTextBox mtb, decimal costo)
        {
            String strCosto = (costo*100).ToString();
            int posPunto = strCosto.IndexOf(".");
            strCosto = strCosto.Substring(0, posPunto + 1);
            mtb.Text = strCosto;
            Herramientas.validarMascaraCosto(mtb);
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Cuarto' Puede moverla o quitarla según sea necesario.
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);

        }

        private void tbDireccionCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (entradaDeDatosValidas())//Si toda la informacion introducida es valida
            {
                decimal varcosto = 0;
                varcosto = decimal.Parse(mtbCosto.Text);
                if (btnGuardar.Text == "Guardar")
                {
                    taServicos.Insert(tbNombre.Text, varcosto, tbDescripcionServicio.Text, TimeSpan.Parse(mtbTiempoServicio.Text), TimeSpan.Parse(mtbRepreparacion.Text));
                    
                }
                else
                {
                    taServicos.UpdateServicio(tbNombre.Text, varcosto, tbDescripcionServicio.Text,mtbTiempoServicio.Text,mtbRepreparacion.Text, intServicioIDOriginal);
                }
                MessageBox.Show(Resources.strRegistroAlmacenadoSatisfactoriamente, Properties.Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ventanaPadre.actualizarRegistroServicios();
                this.Close();
            }
            else
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Properties.Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para validar todas los campos de la forma
        private bool entradaDeDatosValidas()
        {
            valNombreServicio = Herramientas.validarTextBox(tbNombre);
            valCostoServicio = Herramientas.validarMaskedTextBox(mtbCosto);
            valDescripcionServicio = Herramientas.validarTextBox(tbDescripcionServicio);
            valTiempoServicio = Herramientas.validarMascaraCosto(mtbTiempoServicio);
            valRepreparacion = Herramientas.validarMascaraCosto(mtbRepreparacion);
            //Se valida que el tiempo de Servicio y preparacion no este en ceros//
            String strTiempoMinimoServicio = "00:00";
            String strTiempoServicio = "\"" + mtbTiempoServicio.ToString() + "\"";
            String strTiempoMinimoPreparacion = "00:00";
            String strTiempoPreparacion = "\"" + mtbTiempoServicio.ToString() + "\"";
            if (strTiempoServicio == strTiempoMinimoServicio || strTiempoMinimoPreparacion == strTiempoPreparacion)
            {
                valTiempoServicio = false;
                valRepreparacion = false;
            }
            return valNombreServicio && valCostoServicio && valDescripcionServicio && valTiempoServicio && valRepreparacion;
        }

        private void mtbCosto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mtbCosto_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarMascaraCosto(mtbCosto);
        }

        private void chbCuarto_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pbRegreso_Click(object sender, EventArgs e)
        {
            ControlVentana = false;
            tmServicios.Start();
        }

        private void tmServicios_Tick(object sender, EventArgs e)
        {
            Contador = Herramientas.slide(Contador, ControlVentana, this, tmServicios);
        }
    }
}

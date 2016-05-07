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
    using TATarjetas = LucySpa.DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter;

    public partial class frmCrearNuevasTarjetas : MetroFramework.Forms.MetroForm
    {
        Inicio menuInicial;
        public frmCrearNuevasTarjetas(Inicio menuInicial)
        {
            this.menuInicial = menuInicial;
            InitializeComponent();
        }

        private void frmTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCajasDeTexto())//Se validan todos los campos
            {
                //Se adquiere todos los campos introducidos en el GUI
                int cantidad = int.Parse(mtbCantidad.Text);
                decimal costo = decimal.Parse(mtbCosto.Text);
                string strTipoDeTarjetas;
                strTipoDeTarjetas = (string)cbTipo.SelectedItem;
                TATarjetas taTarjetas = new TATarjetas();//Instancia de acceso a BD
                //Se registan cierta cantidad de tarjetas con el mismo tipo y costo.
                int cantidadRegistrada = (int)taTarjetas.registrarNuevasTarjetas(strTipoDeTarjetas, costo, cantidad);
                if (cantidadRegistrada == cantidad)//Si se han registrado todas las cantidades registradas
                {
                   
                    MessageBox.Show(cantidad + "tarjetas fueron registradas satisfactoriamente.", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menuInicial.ActualizarTarjetas();
                    this.Close();
                    
                }
                else//No se registro completamente la cantidad indicada
                {
                    MessageBox.Show("Solamente se registraron, verifique la tabla de tarjetas registradas para ver mas detalles." + cantidadRegistrada, "No se registraron todas las tarjetas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    menuInicial.ActualizarTarjetas();
                    this.Close();
                }
                
            }
            else//Alguno de los campos es invalido.
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCajasDeTexto()
        {
            bool valCantidad, valCosto, valTipoTarjeta;
            valCantidad = Herramientas.validarMaskedTextBox(mtbCantidad); ;
            valCosto = Herramientas.validarMaskedTextBox(mtbCosto);
            //valTipoTarjeta = Herramientas.validarTextBox(tbTipoTarjeta); ;
            valTipoTarjeta =! string.IsNullOrWhiteSpace((string)cbTipo.Text);
            return valCosto && valCantidad && valTipoTarjeta;
        }

        private void mtbCantidad_TextChanged(object sender, EventArgs e)
        {
            Herramientas.validarMaskedTextBox(mtbCantidad);
        }

        private void mtbCosto_TextChanged(object sender, EventArgs e)
        {
            Herramientas.validarMaskedTextBox(mtbCosto);
        }

        private void tbTipoTarjeta_TextChanged_1(object sender, EventArgs e)
        {
            //Herramientas.validarTextBox(tbTipoTarjeta);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

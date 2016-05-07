using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Productos
{
    using LucySpa.Properties;
    using MetroFramework;
    using rowProductos = DataAccess.LucySpaDB.ProductosRow;

    public partial class frmProductos : MetroFramework.Forms.MetroForm
    {
        //string strCantidad;
        //Conexion con tabla de productos
        DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter taProducto = new DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter();


        //variable para modificar el Producto//
        int ProductoID;
        string MododelaVentana = "Insertar";
        Inicio actualizarRegistroProducto;
       
     
        //Variables para validaciones de campos introducidos
        private bool valNombreProducto, valPrecioProducto, valCostoProducto, valCantidadProducto, valDescripcionProducto;

        public frmProductos(Inicio frmproducto)
        {
            InitializeComponent();
         this.actualizarRegistroProducto = frmproducto;
        }
        public frmProductos(int productoID, Inicio frmproducto)
        {
            InitializeComponent();
            this.ProductoID = productoID;
            this.actualizarRegistroProducto = frmproducto;
            MododelaVentana = "Modificar";
            btnGuardarProductos.Text = "Modificar";
            this.Text = "Modificar Producto";

            //***Buscar los datos que le corresponden al empleado y Obteniendo resultados de la busqueda//
            rowProductos reglon = taProducto.GetDataBy1(ProductoID)[0];

            //Rellenar los controles con el resultado
            tbNombreProducto.Text = reglon.Nombre;

            mtbCantidad.Text = reglon.Cantidad.ToString();
            tbDescripcion.Text = reglon.Descripcion;
            Herramientas.AcomodarCostoMkb(mtbCosto, reglon.Costo);
            Herramientas.AcomodarCostoMkb(mtbPrecio, reglon.Precio);

        }
        private void frmProductos_Load(object sender, EventArgs e)
        {

        }
        public bool entradaDeDatosValidas()
        {
            valNombreProducto = Herramientas.validarTextBox(tbNombreProducto);
            valPrecioProducto = Herramientas.validarMascaraCosto(mtbPrecio);
            valCostoProducto = Herramientas.validarMascaraCosto(mtbCosto);
            valCantidadProducto = Herramientas.validarMaskedTextBox(mtbCantidad);
            valDescripcionProducto = Herramientas.validarTextBox(tbDescripcion);


            return valNombreProducto && valPrecioProducto && valCostoProducto && valCantidadProducto && valDescripcionProducto;
        }

        private void btnGuardarProductos_Click(object sender, EventArgs e)
        {
            btnGuardarProductos.Style = MetroColorStyle.Red;


            if (entradaDeDatosValidas()==true)
            {
               
                            int varCantidad = 0;
            varCantidad = int.Parse(mtbCantidad.Text);
            decimal varPrecio = 0;
            varPrecio = decimal.Parse(mtbPrecio.Text);
            decimal varcosto = 0;
            varcosto = decimal.Parse(mtbCosto.Text);
                if (MododelaVentana == "Modificar")
                {
                    taProducto.UpdateQueryProductoID(tbNombreProducto.Text, varPrecio, varcosto, varCantidad, tbDescripcion.Text, ProductoID);
                    MessageBox.Show("Registro Modificado Satisfactoriamente.", "MODIFICAR REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarRegistroProducto.actualizarRegistroProducto();
                    this.Close();
                }

                else
                {
                    taProducto.Insert(tbNombreProducto.Text, varPrecio, varcosto, varCantidad, tbDescripcion.Text);
                    MessageBox.Show(Resources.strRegistroAlmacenadoSatisfactoriamente, Properties.Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarRegistroProducto.actualizarRegistroProducto();
                    this.Close();

                }
            }
                

            else
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Properties.Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           


        }
        //Valida cierta caja de texto dada como parametro.
        private bool validarMascaraCajaTexto(MaskedTextBox tb)
        {
            double num = 0;
            if (String.IsNullOrWhiteSpace(tb.Text) || !double.TryParse(tb.Text.Replace(" ", ""), out num) || num == 0)
            {
                //Cuando la caja de texto es invalida
                tb.BackColor = Color.Pink;
                return false;
            }
            else
            {
                //Cuando la caja de texto es valida
                tb.BackColor = Color.White;
                return true;
            }
        }

        private void mtbPrecio_Validating(object sender, CancelEventArgs e)
        {
            //Se elimina caracteres de la mascara y espacios dentro de la cadena de caracteres
            String str = mtbPrecio.Text.Replace(".", "").Trim().Replace(" ", "");
            //Se concantenan ceros a la izquierda hasta rellenar la mascara
            while (str.Length < mtbPrecio.Mask.Length - 1)
            {
                str = "0" + str;
            }
            mtbCosto.Text = str;
            //Se valida el resultado
            valPrecioProducto = validarMascaraCajaTexto(mtbPrecio);
        }

        private void mtbCosto_Validating(object sender, CancelEventArgs e)
        {
            //Se elimina caracteres de la mascara y espacios dentro de la cadena de caracteres
            String str = mtbCosto.Text.Replace(".", "").Trim().Replace(" ", "");
            //Se concantenan ceros a la izquierda hasta rellenar la mascara
            while (str.Length < mtbCosto.Mask.Length - 1)
            {
                str = "0" + str;
            }
            mtbCosto.Text = str;
            //Se valida el resultado
            valCostoProducto = validarMascaraCajaTexto(mtbCosto);
        }

       
    }


}


    


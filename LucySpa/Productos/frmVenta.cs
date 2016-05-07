using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucySpa.Properties;
using MetroFramework;
namespace LucySpa.Productos
{
    public partial class frmVenta : MetroFramework.Forms.MetroForm
    {
        
        DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter taProducto = new DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter();
        //se inicializan variables globales para poderlas usar donde se necesiten
        decimal TotalDeLaVenta = 0, ResultadoCompra = 0, Precio = 0;
        int CantidadProductos = 0, CantidadDeRenglones = 0, CantidadDeProductosACoprar = 0, CantidadEnExistencia = 0, NuevaCantidad = 0, ProductoID = 0;
        int ClienteID;
        //Color colorTitulo = System.Drawing.ColorTranslator.FromHtml("#00FF00");
        //Color colorBotones = System.Drawing.ColorTranslator.FromHtml("#CCFFCC");
        //Color colorFondo = System.Drawing.ColorTranslator.FromHtml("#99FF99");
        
        Color colorAdvertenciaTerminado = System.Drawing.ColorTranslator.FromHtml("#FF1437");
        Color colorAdvertenciaXTerminado = System.Drawing.ColorTranslator.FromHtml("#FF3B58");
        //Construye la ventana


        public frmVenta(int clienteID)
        {

            this.ClienteID = clienteID;
            InitializeComponent();
            
            

        }
        //Carga la Ventana
        private void frmVenta_Load(object sender, EventArgs e){
            //Se rellena la tabla de productos
            this.productosTableAdapter.Fill(this.lucySpaDB.Productos);

            //se inicializa el combobox Cantidad en la pocicion 0 para que aparesca el numero 1 al abrirse la ventana
            cbCantidad.SelectedIndex = 0;
            tbAPagar.Text = "0.0";
            tbTotal.Text = "0.0";
            printTablaProductos();
        }

        /// <summary>
        /// Recorre cada uno de los productos de la tabla y colorea los renglones
        /// en rojo si estan a punto de agotar existencias.
        /// </summary>
        public void printTablaProductos()
        {
            CantidadDeRenglones = dataGridView1.Rows.Count;
            DataAccess.LucySpaDB.ProductosRow RenglonProductos;
            //Por cada renglon de la fuente de datos y de la tabla de productos
            for (int z = 0; z < CantidadDeRenglones; z++)
            {
                RenglonProductos = this.lucySpaDB.Productos[z];//Fuente de datos
                DataGridViewRow Renglon = dataGridView1.Rows[z];//Renglon de cada tabla de productos
                int CantidadE = (int)Renglon.Cells[3].Value;
                int CantidadMaxima = RenglonProductos.Cantidad;

                //Si estan a punto de agotarse
                if (CantidadE < (CantidadMaxima * .3))
                {
                    Color colorAdvertenciaXTerminado = System.Drawing.ColorTranslator.FromHtml("#FF3B58");
                    dataGridView1.Rows[z].DefaultCellStyle.BackColor = colorAdvertenciaXTerminado;
                }
                //Si se han agotado existencias
                if (CantidadE == 0)
                {
                    Color clrSeleted = System.Drawing.ColorTranslator.FromHtml("#FF353A");
                    dataGridView1.Rows[z].DefaultCellStyle.BackColor = clrSeleted;
                }
            }
        }

        //Evento que selecciona el producto que se desea comprar
        private void btnSeleccionar_Click(object sender, EventArgs e){
            SeleccionarProducto();
        }

        //Evento que selecciona el producto que se desea comprar
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) {
            SeleccionarProducto();
        }

        //metodo para seleccionar los productos que se quieran vender
        public void SeleccionarProducto()
        {
            try
            {
                //se selcciona la cantidad que hay en el combobox que es la cantidad de procutos que se desean vender
                CantidadProductos = cbCantidad.SelectedIndex + 1;
                //se obtiene la cantidad e productos en existencia
                CantidadEnExistencia = (int)dataGridView1.SelectedCells[3].Value;

                if(CantidadEnExistencia > 0) //Se compran la cantidad de productosen existencia
                {
                    if (CantidadProductos > CantidadEnExistencia) //Si la cantidad de productos a comprar es mayor que la que esta en existencia
                        CantidadProductos = CantidadEnExistencia;

                    //Se determina el ID del producto seleccionado
                    String idSeleccionado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    DataGridViewRow productoExistente = null;
                    //Se busca el producto en la lista de productos a comprar
                    foreach (DataGridViewRow dgvr in dataGridView2.Rows)
                        if (dgvr.Cells[0].Value.ToString() == idSeleccionado){
                            productoExistente = dgvr;
                            break;
                        }

                    //Si ya existe el producto en la lista de seleccion a comprar
                    if (productoExistente != null)
                    {
                        //Se acumula la cantidad de producto seleccionado para ser comprado
                        int cantidadDeProductoComprando = int.Parse(productoExistente.Cells[3].Value.ToString());
                        cantidadDeProductoComprando += CantidadProductos;
                        dataGridView2.Rows[productoExistente.Index]
                            .Cells[3].Value = cantidadDeProductoComprando;
                    }
                    else { //Si el producto no se habia seleccionado antes
                        dataGridView2.Rows.Add(new object[] {
                            Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), //ID
                            Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value), //Nombre
                            Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value), //Precio
                           CantidadProductos //Cantidad
                        });
                    }

                    //Se calcula el total a pagar actual
                    decimal costoTotal = calcularTotal();
                    tbTotal.Text = costoTotal.ToString();
                    
                    //se le resta a cantidad en existencia la cantidad de prductos que se compraran
                    CantidadEnExistencia = CantidadEnExistencia - CantidadProductos;


                    //se muestra en el datagridview la nueva cantidad en existencia (mas no se gurada en la base de datos)
                    dataGridView1.SelectedCells[3].Value = CantidadEnExistencia;
                    cbCantidad.SelectedIndex = 0;

                    printTablaProductos();
                }
            }
            catch(Exception exc) { }
        }

        //metodo para quitar productso que ya no se quieran vender
        public void QuitarProducto() 
        {
            try
            {
                //se obtiene el precio del datagri2
                string strPrecio = (string)dataGridView2.SelectedCells[2].Value;

                //se convierte el precio de string a decimal
                Precio = decimal.Parse(strPrecio);


                int id = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                int CantidadAComprar = Convert.ToInt32(dataGridView2.SelectedCells[3].Value);
                //se quita el renglon que se selecciono de la lista del datagrid2
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

                //obtiene el valor de la celda celeccionada en este caso la cantidad en existencia de productos que hay
                int renglones = dataGridView1.Rows.Count;
                for (int c = 0; c < renglones; c++)
                {
                    DataGridViewRow RenglonDatagrid1 = dataGridView1.Rows[c];
                    int idDatagrid1 = Convert.ToInt32(RenglonDatagrid1.Cells[0].Value);
                    int CanidadDeProductosEnExistencia = Convert.ToInt32(RenglonDatagrid1.Cells[3].Value);
                    if (id == idDatagrid1)
                    {
                        //se le resta a cantidad de productos en existencia la cantidad de productos que se compraran (mas no se guarda en la base de datos aun)
                        CanidadDeProductosEnExistencia = CanidadDeProductosEnExistencia + CantidadAComprar;
                        //se le asigna a la celda en la pocicion 3 la cantidad en existencia y se muestra en el datagridview
                        RenglonDatagrid1.Cells[3].Value = CanidadDeProductosEnExistencia;
                    }


                }
                //se resta el total de la compra al total de la venta
                TotalDeLaVenta = calcularTotal();

                //se muestra el resultado de la resta en el textbox
                tbTotal.Text = TotalDeLaVenta.ToString();
            }
            catch { }
        }
        //Evento que quita el producto que ya no se desea comprar
        private void btnQuitar_Click(object sender, EventArgs e) {

            QuitarProducto();

        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            if (dataGridView1.SortOrder == SortOrder.Ascending || dataGridView1.SortOrder == SortOrder.Descending)
            {
                printTablaProductos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (validarVenta())
            {
                //se crea la conexion a la tabla de compras
                DataAccess.LucySpaDBTableAdapters.CompraTableAdapter taCompra = new DataAccess.LucySpaDBTableAdapters.CompraTableAdapter();
                //se crea la conexion a la tabla de ventas
                DataAccess.LucySpaDBTableAdapters.VentasTableAdapter taVentas = new DataAccess.LucySpaDBTableAdapters.VentasTableAdapter();
                //se crea la conexion a la tabla de productos
                DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter taProductos = new DataAccess.LucySpaDBTableAdapters.ProductosTableAdapter();

                //se insertan los datos en la tabla de ventas
                DateTime dtFechaHoy = DateTime.Today;
                string strFechaHoy = Convert.ToString(dtFechaHoy);
                taVentas.Insert(ClienteID, dtFechaHoy);
                int VentaID = (int)taVentas.ReturnLastVentaID();

                CantidadDeProductosACoprar = dataGridView2.Rows.Count;
                //se obtiene la cantidad de productos a comprar(por producto)

                /*se crea un for para poder introducir todos los productos comprados con el mismo id de 
                 * la venta pero productos separados con sus respectivos precios y cantidades */
                int i = 0;
                int CantidadDeProductos = 0;

                for (i = 0; i < CantidadDeProductosACoprar; i++)
                {
                    //se selecciona el renglon del datagridview2
                    DataGridViewRow RenglonSeleccionado = dataGridView2.Rows[i];
                    //se toma el id del producto a comprar
                    string r = (string)RenglonSeleccionado.Cells[0].Value;
                    //se selecciona el nombre del producto a vender
                    string Nombre = (string)RenglonSeleccionado.Cells[1].Value;
                    //se convierte el precio del producto a deccimal
                    decimal PrecioDelProducto = decimal.Parse((string)RenglonSeleccionado.Cells[2].Value);
                    //se convierte el id del producto a entero
                    ProductoID = int.Parse(r);
                    //se convierte la cantidad de productos a comprar a entero
                    CantidadDeProductos = (int)RenglonSeleccionado.Cells[3].Value;
                    //se hace la multiplicacion de la cantidad de productos a comprar por el precio del producto para que de el resultado de la compra realizada
                    ResultadoCompra = PrecioDelProducto * CantidadDeProductos;
                    //se obtiene el renglon de la tabla de productos 
                    DataAccess.LucySpaDB.ProductosRow RenglonDeProductos = taProductos.GetDataBy1(ProductoID)[0];
                    //se hace la operacion donde a la cantidad de productos en existencia se le resta la cantidad de productos comprados
                    NuevaCantidad = RenglonDeProductos.Cantidad - CantidadDeProductos;
                    //se insertan los datos en la tabla de compras
                    taCompra.Insert(VentaID, ProductoID, CantidadDeProductos);
                    //se crea la modificacion donde se actualiza la cantidad de productos en existencia
                    taProductos.UpdateQueryCantidadProducto(NuevaCantidad, ProductoID);
                    //se muestra el mensaje de que se insertaron correctamente
                }
                MessageBox.Show("Se ha realizado la venta correctamente", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //se cierra esta ventana
                this.Close();
            }
        }

        private bool validarVenta()
        {
            //Se valida si se ha seleccionado productos
            bool valCantidadProductos = dataGridView2.Rows.Count > 0;

            decimal total = decimal.Parse(tbTotal.Text);
            bool pagoSuficiente = decimal.Parse(tbAPagar.Text) > total;

            if (!valCantidadProductos) //Si No se ha seleccionado ningún producto para comprar
            {
                MessageBox.Show("Seleccione al menos un producto de la lista para poder procesar la compra.",
                    Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!pagoSuficiente) //Si no alcanza el efectivo entregado
            {
                MessageBox.Show("Pago insuficiente.",
                    Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return valCantidadProductos && pagoSuficiente;
        }

        private decimal calcularTotal()
        {
            decimal total = 0, costoProducto;
            int cantidad;
            //Se recorren todos los productos a comprar
            foreach (DataGridViewRow dgvr in dataGridView2.Rows)
            {
                cantidad = int.Parse(dgvr.Cells[3].Value.ToString());//Cantidad por producto
                costoProducto = decimal.Parse(dgvr.Cells[2].Value.ToString());//Precio unitario
                total += costoProducto * cantidad;//Se calcula el total producto por producto
            }

            return total;
        }

        private void btnProducTerminado_Click(object sender, EventArgs e)
        {

        }

        private void lblProductoporTerminar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnProduPorTerminar_Click(object sender, EventArgs e)
        {

        }

        private void lblProductoTerminado_Click(object sender, EventArgs e)
        {

        }

        private void tbAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Herramientas.keyPressNumeros(e, sender);
        }

        private void tbAPagar_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(tbAPagar.Text))
                tbAPagar.Text = "0.0";

            //se obtiene el dinero con el que se pagara
            decimal dinero = decimal.Parse(tbAPagar.Text);
            //se obtiene el dinero con el que se pagara
            decimal totalDeLaVenta = decimal.Parse(tbTotal.Text);

            decimal cambio;
            //Se calcula el cambio
            if (dinero > totalDeLaVenta)
                cambio = dinero - totalDeLaVenta;
            else
                cambio = 0;

            //se muestra en el textbox el cambio que se deve de dar al cliente
            tbCambio.Text = cambio.ToString();
        }
    }
}

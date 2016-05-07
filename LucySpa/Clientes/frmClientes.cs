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
    //Conexion con la base de datos//
    using rowCliente = DataAccess.LucySpaDB.ClientesRow;
    using taFotografiaCliente = DataAccess.LucySpaDBTableAdapters.FotografiaClienteTableAdapter;

    public partial class frmClientes : MetroFramework.Forms.MetroForm
    {
        //Variables para animacion de forma
        int Contador = 1350;
        bool ControlVentana = true;

        //***variable para las fotos//
        Image fotografiaCliente;
        
        //variable para modificar el cliente//
        int ClienteID;
        string MododelaVentana = "Insertar";
        Inicio menuInicial;

        //Variables para validaciones de campos introducidos
        private bool valNombreCliente,valApellidoCliente, valDireccionCliente,valTelefonoCliente,valEmailCliente;

        //Conexion con tabla de clientes
        DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter taClientes = new DataAccess.LucySpaDBTableAdapters.ClientesTableAdapter();

        //El constructor en modo de Insertar
        public frmClientes(Inicio menuInicial)
        {
            this.menuInicial = menuInicial;
            InitializeComponent();
        }

        //El constructor en modo de modificacion
        public frmClientes(int clienteID, Inicio menuInicial)
        {
            //***Guardando en una variable global la variable que entro al constructor
            this.ClienteID = clienteID;
            MododelaVentana = "Modificar";
            this.menuInicial = menuInicial;
            InitializeComponent();

            btnGuardarCliente.Text = "Modificar";

            //***Buscar los datos que le corresponden al empleado y Obteniendo resultados de la busqueda//
            rowCliente reglon = taClientes.GetDataByClienteID(ClienteID)[0];
            
            //Rellenar los controles con el resultado
            tbNombreCliente.Text = reglon.Nombre;
            tbApellidoCliente.Text = reglon.Apellido;
            tbDireccionCliente.Text = reglon.Direccion;
            mtbTelefonoCliente.Text = reglon.Telefono;
            dtpCumpleañosCliente.Text = reglon.Cumpleaños.ToString();
            try
            {
                tbEmailCliente.Text = reglon.Email;
                
            }
            catch
            {
            }
            taFotografiaCliente tafotografiacliente = new taFotografiaCliente();
            try
            { //Se intenta adquirir la foto, en caso de que exista.
                Byte[] imagenEnBytes = tafotografiacliente.GetDataByClienteID(ClienteID)[0].fotografiaCliente;
                fotografiaCliente = Herramientas.byteArrayToImage(imagenEnBytes);
                pbCliente.Image = fotografiaCliente;
            }
            catch { }
        }

        
        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void tbNombreCliente_Click(object sender, EventArgs e)
        {

        }

        //Animacion de ventana
        private void TimerClientes_Tick(object sender, EventArgs e)
        {
            Contador = Herramientas.slide(Contador, ControlVentana, this, TimerClientes);
        }

        private void pbRegreso_Click(object sender, EventArgs e)
        {
            ControlVentana = false;
            TimerClientes.Start();
        }
        // evento boton guardar
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            btnGuardarCliente.Style = MetroColorStyle.Red;
            string nombreCompleto= tbNombreCliente.Text+" "+tbApellidoCliente.Text;
            if (entradaDeDatosValidas())
            {
                if (MododelaVentana == "Modificar")//Modo de modificacion de cliente
                {
                    //Se actualiza el registro del cliente
                    taClientes.UpdateQueryClienteID(tbNombreCliente.Text.Trim(), tbApellidoCliente.Text.Trim(),dtpCumpleañosCliente.Value,mtbTelefonoCliente.Text.Trim(),tbDireccionCliente.Text.Trim(),tbEmailCliente.Text.Trim(),nombreCompleto,ClienteID);
                    
                    if (fotografiaCliente != null)//Se ha introducido una fotografia
                    {
                        Byte[] imagenEnBytes = Herramientas.imageToByteArray(fotografiaCliente);//Se transforma a arreglo de bytes
                        taFotografiaCliente taFotoCliente = new taFotografiaCliente();
                        taFotoCliente.RelacionarFotografiaClientes(ClienteID, imagenEnBytes);//Se almacena la foto en BD relacionada con el cliente
                    }
                    MessageBox.Show("Registro Modificado Satisfactoriamente.", "MODIFICAR REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Se da de alta un nueveo cliente
                    ClienteID = (int)taClientes.AltaDeCliente(tbNombreCliente.Text.Trim(),tbApellidoCliente.Text.Trim(),tbDireccionCliente.Text.Trim(),dtpCumpleañosCliente.Value,mtbTelefonoCliente.Text.Trim(),tbEmailCliente.Text.Trim(),nombreCompleto);

                    if (fotografiaCliente != null && ClienteID > 0)//Se ha introducido una fotografia
                    {
                        Byte[] imagenEnBytes = Herramientas.imageToByteArray(fotografiaCliente);//Se transforma a arreglo de bytes
                        taFotografiaCliente taFotoCliente = new taFotografiaCliente();
                        taFotoCliente.RelacionarFotografiaClientes(ClienteID, imagenEnBytes);//Se almacena en BD
                    }

                    //Si ha sido registrada una fotografía y el Cliente ha sido registado satisfactoriamente
                    MessageBox.Show(Resources.strRegistroAlmacenadoSatisfactoriamente, Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Se actualiza el Registro de Clientes
                menuInicial.actualizarRegistroClientes();
                //Se cierra la ventana actual
                this.Close();

            }
            else
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Valida las entradas de datos en la pantalla de alta de clientes
        private bool entradaDeDatosValidas()
        {
            valNombreCliente = Herramientas.validarTextBox(tbNombreCliente);
            valApellidoCliente = Herramientas.validarTextBox(tbApellidoCliente);
            valDireccionCliente = Herramientas.validarTextBox(tbDireccionCliente);
            valTelefonoCliente = Herramientas.validarMaskedTextBox(mtbTelefonoCliente);
            valEmailCliente = Herramientas.validarTextBoxEmail(tbEmailCliente);

            return valNombreCliente && valApellidoCliente && valDireccionCliente && valTelefonoCliente && valEmailCliente;
        }

        private void btnExaminarCliente_Click(object sender, EventArgs e)
        {
            ofdFoto.ShowDialog(); 
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            //Se toma la ubicacion en disco duro de la fotografia
            String nombreFoto = ofdFoto.FileName;
            //Se crea y almacena una instancia de la imagen a partir de su ubicación y se muestra en pantalla
            fotografiaCliente = Image.FromFile(nombreFoto);//Se toma la foto del disco duro del cliente
            pbCliente.Image = fotografiaCliente;//Se muestra la foto en pantalla
        }

        private void tbDireccionCliente_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbTelefonoCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbNombreCliente);
        }

        private void tbApellidoCliente_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbApellidoCliente);
        }

        private void tbDireccionCliente_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbDireccionCliente);
        }

        private void mtbTelefonoCliente_Validating(object sender, CancelEventArgs e)
        {
           valNombreCliente = Herramientas.validarMaskedTextBox(mtbTelefonoCliente);

            //Se valida el tamaño del numero de telefono//
           int contador;
           contador = mtbTelefonoCliente.Text.Count();
           if (contador < 10)
           {
               mtbTelefonoCliente.BackColor = Color.Pink;
               valNombreCliente = false;
           }
        }

        private void tbEmailCliente_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBoxEmail(tbEmailCliente);
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {

        }


    }
}

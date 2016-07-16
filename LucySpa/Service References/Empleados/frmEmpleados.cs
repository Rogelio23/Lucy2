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
    using rowEmpleado = DataAccess.LucySpaDB.EmpleadosRow;
    using taFotografiaEmpleado = DataAccess.LucySpaDBTableAdapters.FotografiaEmpleadoTableAdapter;

    public partial class frmEmpleados : MetroFramework.Forms.MetroForm
    {
        //Conexion con tabla de clientes
        DataAccess.LucySpaDBTableAdapters.EmpleadosTableAdapter taEmpleados = new DataAccess.LucySpaDBTableAdapters.EmpleadosTableAdapter();
        int Contador = 1350;
        bool ControlVentana = true;

        //****Variable para Insertar Imagen//
        Image fotografiaEmpleados;

        //variable para modificar el cliente//
        int EmpleadoID;
        string MododelaVentana = "Insertar";
        Inicio empleadoactualizar;
        int colorNumeroEmpleado;
        

        //Variables para validaciones de campos introducidos
        private bool valNombreEmpleado, valApellidoEmpleado, valDireccionEmpleado, valTelefonoEmpleado, valEmailEmpleado;
        public frmEmpleados()
        {
            InitializeComponent();
        }
        public frmEmpleados(int empleadoID,Inicio frmempleados)
        {
            this.EmpleadoID = empleadoID;
            MododelaVentana = "Modificar";
            empleadoactualizar = frmempleados;
            InitializeComponent();

            btnGuardarEmpleado.Text = "Modificar";
            this.Text = "Modificar Empleado";

            //***Buscar los datos que le corresponden al empleado y Obteniendo resultados de la busqueda//
            rowEmpleado renglon = taEmpleados.GetDataByEmpleadoID(EmpleadoID)[0];

            //Rellenar los controles con el resultado
            tbNombreEmpleado.Text = renglon.Nombre;
            tbApellidoEmpleado.Text = renglon.Apellido;
            tbDireccionEmpleado.Text = renglon.Direccion;
            mtbTelefonoEmpleado.Text = renglon.Telefono;
            dtCumpleañosEmpleado.Text = renglon.Cumpleaños.ToString();
            colorNumeroEmpleado = renglon.ColorEmpleado;
            tbColor.BackColor = Color.FromArgb(colorNumeroEmpleado);
            try
            {
                tbEmailEmpleado.Text = renglon.Email;

            }
            catch
            {

            }
            taFotografiaEmpleado tafotografiaEmpleado = new taFotografiaEmpleado();
            try
            { //Se intenta adquirir la foto, en caso de que exista.
                Byte[] imagenEnBytes = tafotografiaEmpleado.GetDataByEmpleadoID(EmpleadoID)[0].fotografiaEmppleado;
                fotografiaEmpleados = Herramientas.byteArrayToImage(imagenEnBytes);
                pbEmpleado.Image = fotografiaEmpleados;
            }
            catch { }

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void TimerClientes_Tick(object sender, EventArgs e)
        {
            /*Contador = Contador - 80;

            if (Contador <= 350)
            {
                TimerEmpleados.Stop();
            }
            this.Location = new Point(Contador, 150);*/

            Contador = Herramientas.slide(Contador, ControlVentana, this, TimerEmpleados);
        }

        private void btnExaminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {

        }

        //Metodo para validar todos los campos introducidos
        public bool entradaDeDatosValidas()
        {
            valNombreEmpleado = Herramientas.validarTextBox(tbNombreEmpleado);
            valApellidoEmpleado = Herramientas.validarTextBox(tbApellidoEmpleado);
            valDireccionEmpleado = Herramientas.validarTextBox(tbDireccionEmpleado);
            valTelefonoEmpleado = Herramientas.validarMaskedTextBox(mtbTelefonoEmpleado);
            valEmailEmpleado = Herramientas.validarTextBox(tbDireccionEmpleado);

            return valNombreEmpleado && valApellidoEmpleado && valDireccionEmpleado && valTelefonoEmpleado && valEmailEmpleado;
        }

        private void btnGuardarEmpleado_Click_1(object sender, EventArgs e)
        {
            btnGuardarEmpleado.Style = MetroColorStyle.Red;

            if (entradaDeDatosValidas())
            {
                string nombreCompleto = tbNombreEmpleado.Text+" "+ tbApellidoEmpleado.Text;
                if (MododelaVentana == "Modificar")
                {
                    taEmpleados.UpdateQueryEmpleadoID(tbNombreEmpleado.Text.Trim(), tbApellidoEmpleado.Text.Trim(), dtCumpleañosEmpleado.Value, mtbTelefonoEmpleado.Text.Trim(), tbDireccionEmpleado.Text.Trim(), tbEmailEmpleado.Text.Trim(), nombreCompleto, colorNumeroEmpleado, EmpleadoID);
                    MessageBox.Show("Registro Modificado Satisfactoriamente.", "MODIFICAR REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (fotografiaEmpleados != null)//Se registra la fotografia
                    {
                        Byte[] imagenEnBytes = Herramientas.imageToByteArray(fotografiaEmpleados);//Se transforma a arreglo de bytes
                        taFotografiaEmpleado taFotoEmpleado = new taFotografiaEmpleado();
                        taFotoEmpleado.FotografiaEmpleados(EmpleadoID, imagenEnBytes);//Se almacena en BD
                    }
                    //***Se actualiza el Regstro//
                    empleadoactualizar.ActualizarRegistroEmpleado();
                }
                else
                {


                    //******Es recomendable manejar las imagenes en en una tabla diferente a las de datos, se debera crear una relacion 1 a 1********//
                    EmpleadoID= (int)taEmpleados.AltaEmpleado(tbNombreEmpleado.Text.Trim(), tbApellidoEmpleado.Text.Trim(),tbDireccionEmpleado.Text.Trim(),dtCumpleañosEmpleado.Value,mtbTelefonoEmpleado.Text.Trim(),tbEmailEmpleado.Text.Trim(),nombreCompleto, colorNumeroEmpleado);
                    MessageBox.Show(Resources.strRegistroAlmacenadoSatisfactoriamente, Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (fotografiaEmpleados != null)//Se registra la fotografia
                    {
                        Byte[] imagenEnBytes = Herramientas.imageToByteArray(fotografiaEmpleados);//Se transforma a arreglo de bytes
                        taFotografiaEmpleado taFotoEmpleado = new taFotografiaEmpleado();
                        taFotoEmpleado.FotografiaEmpleados(EmpleadoID, imagenEnBytes);//Se almacena en BD
                    }
                }
                this.Close();//Se cierra la ventana
            }
            else
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNombreEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbNombreEmpleado);
        }

        private void tbApellidoEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbApellidoEmpleado);
        }

        private void tbDireccionEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbDireccionEmpleado);
        }

        private void mtbTelefonoEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarMaskedTextBox(mtbTelefonoEmpleado);

            //Se valida el tamaño del numero de telefono//
            int contador;
            contador = mtbTelefonoEmpleado.Text.Count();
            if (contador < 10)
            {
                mtbTelefonoEmpleado.BackColor = Color.Pink;
                valNombreEmpleado = false;
            }
        }


        private void tbEmailEmpleado_Validating(object sender, CancelEventArgs e)
        {
            Herramientas.validarTextBox(tbEmailEmpleado);
        }

        private void btnColorEmpleado_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            Color colorSeleccionado = new Color();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
            }

            colorNumeroEmpleado = colorSeleccionado.ToArgb();
            tbColor.BackColor = Color.FromArgb(colorNumeroEmpleado);
            
        }

        private void btnExaminarEmpleado_Click_1(object sender, EventArgs e)
        {
            opfEmpleados.ShowDialog();
        }

        private void opfEmpleados_FileOk(object sender, CancelEventArgs e)
        {
            //Se toma la ubicacion en disco duro de la fotografia
            String nombreFoto = opfEmpleados.FileName;
            //Se crea y almacena una instancia de la imagen a partir de su ubicación y se muestra en pantalla
            fotografiaEmpleados = Image.FromFile(nombreFoto);//Se toma la foto del disco duro del cliente
            pbEmpleado.Image = fotografiaEmpleados;//Se muestra la foto en pantalla
        }

        private void TimerEmpleados_Tick(object sender, EventArgs e)
        {
            Contador = Herramientas.slide(Contador, ControlVentana, this, TimerEmpleados);
        }

        private void pbRegreso_Click(object sender, EventArgs e)
        {
            ControlVentana = false;
            TimerEmpleados.Start();
        }
    }
}

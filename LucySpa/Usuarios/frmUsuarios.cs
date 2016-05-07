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
    using rowUsuarios = DataAccess.LucySpaDB.UsuariosRow;
    public partial class frmUsuarios : MetroFramework.Forms.MetroForm
    {
        
        DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter taUsuarios = new DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter();
        private bool valNombreUsuario, valConstraseñaUsuario;
      

        public frmUsuarios()
        {
           
            InitializeComponent();
        }

        
        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        //private void tbNombre_Click(object sender, EventArgs e)
        //{

        //}
        private bool entradaDeDatosValidas()
        {

            valNombreUsuario = Herramientas.validarTextBox(tbNombreUsuario);
            valConstraseñaUsuario = Herramientas.validarTextBox(tbContraseña);

            return valConstraseñaUsuario && valNombreUsuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
       //string strNombreUsuario = tbNombreUsuario.Text;
       //     string strContraseña = tbContraseña.Text;


            //    //string Nombre = tbNombreUsuario.Text;
            //    //  string Contraseña = tbContraseña.Text;
            if (entradaDeDatosValidas())
            {
                if (btnGuardar.Text == "Guardar")
                {


                    taUsuarios.Insert(tbNombreUsuario.Text, tbContraseña.Text);
                    MessageBox.Show(Resources.strRegistroAlmacenadoSatisfactoriamente, Properties.Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }

            else
            {
                MessageBox.Show(Resources.strDatosIntroducidosInvalidos, Properties.Resources.strError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

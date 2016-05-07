using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  MetroFramework;
namespace LucySpa.Usuarios
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        Inicio formaPadre;
        bool boolLogin;
        public frmLogin(Inicio formaPadre,bool boolLogin)
        {
            InitializeComponent();
            this.formaPadre = formaPadre;
            this.boolLogin = boolLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                        DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter taUsuario = new DataAccess.LucySpaDBTableAdapters.UsuariosTableAdapter();
            DataAccess.LucySpaDB.UsuariosRow renglon = taUsuario.GetData()[0];

            String strNombre = tbNombreUsuarios.Text;
            String strPassword = tbPassword.Text;

            int intCountUsuario = (int)taUsuario.ScalarQueryIdentificaUsuario(strNombre, strPassword);

            if (intCountUsuario >= 1)
            {
                formaPadre.showPages();
                this.Close();
            }
            else
            {
                MessageBox.Show("Inicio de sesion incorrecta","Usuario incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                 btnLogin_Click(btnLogin,null);
            }
        }



        }
    }

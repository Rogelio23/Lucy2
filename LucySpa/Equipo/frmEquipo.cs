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

namespace LucySpa.Equipo
{
    public partial class frmEquipo : MetroFramework.Forms.MetroForm
    {
        
        DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter taEquipo = new DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter();
        int idEquipo = 0;
        Inicio FormaPadre;
        public frmEquipo(int equipoID, Inicio FormaPadre)
        {
            
            InitializeComponent();
            this.FormaPadre = FormaPadre;
            idEquipo = equipoID;
            if (idEquipo != 0)
            {
                btnAgregar.Text = "Modificar";
                tbNombreEquipo.Text = taEquipo.GetNombreEquipo(idEquipo);
                tbDescripcionEquipo.Text = taEquipo.GetDescripcionEquipo(idEquipo);
            }
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.Cuarto' Puede moverla o quitarla según sea necesario.
            this.cuartoTableAdapter.Fill(this.lucySpaDB.Cuarto);

        }

        private void cbCuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
                if (string.IsNullOrWhiteSpace(tbNombreEquipo.Text) || string.IsNullOrWhiteSpace(tbDescripcionEquipo.Text))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {

                    if (idEquipo==0)
                    {
                        if (chbCuarto.Checked == true)
                        {
                            taEquipo.Insert((int)cbCuarto.SelectedValue, tbNombreEquipo.Text, tbDescripcionEquipo.Text);
                            MessageBox.Show("Se ha guardado exitosamente el equipo");
                        FormaPadre.actualizarVentanaEquipo();
                            this.Close();
                        }
                        else
                        {
                            taEquipo.Insert(null, tbNombreEquipo.Text, tbDescripcionEquipo.Text);
                            MessageBox.Show("Se ha insertado exitosamente el equipo");
                        FormaPadre.actualizarVentanaEquipo();
                        this.Close();
                        } 
                    }
                    else
                    {
                        if (chbCuarto.Checked == true)
                        {
                            taEquipo.UpdateEquipo((int)cbCuarto.SelectedValue, tbNombreEquipo.Text, tbDescripcionEquipo.Text,idEquipo);
                            MessageBox.Show("Se ha modificado exitosamente el equipo");
                        FormaPadre.actualizarVentanaEquipo();
                        this.Close();
                        }
                        else
                        {
                            taEquipo.UpdateEquipo(null, tbNombreEquipo.Text, tbDescripcionEquipo.Text, idEquipo);
                            MessageBox.Show("Se ha modificado exitosamente el registro");
                        FormaPadre.actualizarVentanaEquipo();
                        this.Close();

                        }
                    }
                } 
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCuarto.Checked == true)
            {
                cbCuarto.Enabled = true;
            }
            else
            {
                cbCuarto.Enabled = false;
            }
        }
    }
}

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

namespace LucySpa.Cuartos
{
    public partial class frmRelacionCuartoServicios : MetroFramework.Forms.MetroForm
    {
        DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter taServicios=new DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
        DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter taVistaCuartos = new DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter();
        int CuartoID;
        
        //Representa forma padre dentro de la forma
        Inicio formaPadre;

        public frmRelacionCuartoServicios(Inicio formaPadre, int NumCuarto)
        {
            InitializeComponent();
            CuartoID = NumCuarto;

            this.formaPadre = formaPadre;

        }

        private void frmRelacionCuartoServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lucySpaDB.vistaCuartoconServicios' Puede moverla o quitarla según sea necesario.
            //this.vistaCuartoconServiciosTableAdapter.Fill(this.lucySpaDB.vistaCuartoconServicios,CuartoID);
            taVistaCuartos.FillByCuarto(this.lucySpaDB.vistaCuartoconServicios, CuartoID);

        }

        private void btnBorrarServicio_Click(object sender, EventArgs e)
        {
            int intServicioID;
            DataGridViewRow filaSeleccionada = dgvVistaCuartos.SelectedRows[0];
            intServicioID = (int)filaSeleccionada.Cells[0].Value;
            taServicios.UpdateQuitarCuartoaServicio(null, intServicioID);
            this.vistaCuartoconServiciosTableAdapter.FillByCuarto(this.lucySpaDB.vistaCuartoconServicios, CuartoID);
            
            
        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            int intServicioID;
            DataGridViewRow filaSeleccionada = dgvVistaCuartos.SelectedRows[0];
            intServicioID = (int)filaSeleccionada.Cells[0].Value;
            LucySpa.frmServicios updateServicio = new frmServicios(formaPadre,intServicioID);
            updateServicio.ShowDialog();
            this.Close();
        }
    }
}

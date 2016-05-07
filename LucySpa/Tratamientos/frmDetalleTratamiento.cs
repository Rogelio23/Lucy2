using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Tratamientos
{
    public partial class frmDetalleTratamiento : MetroFramework.Forms.MetroForm
    {
        int ServicioID;
        int tratamientoID = 0;
        public frmDetalleTratamiento(int TratamientoID)
        {
            InitializeComponent();
            this.tratamientoID = TratamientoID;
        }

        private void frmDetalleTratamiento_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'lucySpaDB.vistaDiseñoTrataConServicio' table. You can move, or remove it, as needed.
            this.vistaDiseñoTrataConServicioTableAdapter.FillByTratamientoID(this.lucySpaDB.vistaDiseñoTrataConServicio,tratamientoID);
            // TODO: This line of code loads data into the 'lucySpaDB.VistaDiseñoCuartoServicio' table. You can move, or remove it, as needed.




        }
    }
}

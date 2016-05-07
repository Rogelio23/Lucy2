using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Reportes
{
    public partial class Reportes : MetroFramework.Forms.MetroForm
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lucySpaDB.vistaCitas' table. You can move, or remove it, as needed.
            this.vistaCitasTableAdapter.Fill(this.lucySpaDB.vistaCitas);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

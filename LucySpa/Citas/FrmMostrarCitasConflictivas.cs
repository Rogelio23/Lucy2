using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Citas
{
    using VistaCitas = LucySpa.DataAccess.LucySpaDB.vistaCitasDataTable;
    public partial class FrmMostrarCitasConflictivas : MetroFramework.Forms.MetroForm
    {
        public FrmMostrarCitasConflictivas()
        {
            InitializeComponent();
        }

        public FrmMostrarCitasConflictivas(VistaCitas citasConflictivas)
        {
            InitializeComponent();
            dgvCitasConflictivas.DataSource = citasConflictivas;
        }

        private void FrmMostrarCitasConflictivas_Load(object sender, EventArgs e)
        {
            pbWarning.Image = SystemIcons.Warning.ToBitmap();
            tbLeyenda.Text = LucySpa.Properties.Resources.strLeyendaCitasConflictivas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

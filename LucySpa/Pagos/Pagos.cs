using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucySpa.Pagos
{
    public partial class Pagos : MetroFramework.Forms.MetroForm
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {

        }

        private void pbRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbPago_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumeros(e, sender);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumeros(e, sender);
        }

        private void tbPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.keyPressNumeros(e, sender);
        }
    }
}

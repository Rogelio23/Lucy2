using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.IO;
using MetroFramework.Controls;



namespace LucySpa
{
    class Herramientas
    {
        /// <summary>
        /// Anima una forma dada con un desplazamiento lineal marcado por un vector, segun sea el estado marcado para cerrar o abrir. Se utiliza un control de tiempo para marcar
        /// la velocidad de la animación.
        /// </summary>
        /// <param name="vectorx">Marca la posicion inicial de la forma</param>
        /// <param name="estado">Indica si el formulario entra (true) o sale (false) de pantalla.</param>
        /// <param name="formulario">Formulario que se desea animar.</param>
        /// <param name="TimerControl">Controlador de tiempo de animación.</param>
        /// <returns></returns>
        public static int slide(int vectorx, bool estado,MetroFramework.Forms.MetroForm formulario,Timer TimerControl )
        {
            
            if (estado == true)
            {
                vectorx = vectorx - 80;

                if (vectorx <= 350)
                {
                    TimerControl.Stop();
                    

                }
                 formulario.Location = new Point(vectorx, 150);
                 return vectorx;
            }
            else
            {
                vectorx = vectorx + 80;

                if (vectorx >= 1350)
                {
                    TimerControl.Stop();
                    formulario.Close();
                    return vectorx;
                    

                }
                formulario.Location = new Point(vectorx, 150);
                return vectorx;
            }
            
        }

        /// <summary>
        /// Determina si una caja de texto es valida. Es invalida al no contener informacion.
        /// </summary>
        /// <param name="tb">Caja de texto que sera verificada. Su color cambiara a rosa en caso de ser invalida.</param>
        /// <returns>Valor boleano, "true" si el texto intoducido es valido, de lo contrario, "false.</returns>
        public static bool validarTextBox(TextBox tb)
        {
            bool val = String.IsNullOrEmpty(tb.Text);
            tb.BackColor = val ? Color.Pink : SystemColors.MenuBar;
            return !val;
        }
        public static bool validarMetroTextBox(MetroTextBox mtb)
        {
            bool val = String.IsNullOrEmpty(mtb.Text);
            mtb.BackColor = val ? Color.Pink : SystemColors.MenuBar;
            return !val;
        }

        public static bool validarMaskedTextBox(MaskedTextBox mtb)
        {
            bool val = String.IsNullOrEmpty(mtb.Text);
            mtb.BackColor = val ? Color.Pink : SystemColors.MenuBar;
            return !val;
        }

        public static bool validarMascaraCosto(MaskedTextBox mtb)
        {
            //Se elimina caracteres de la mascara y espacios dentro de la cadena de caracteres
            String str = mtb.Text.Trim();
            //Se concantenan ceros a la izquierda hasta rellenar la mascara
            while (str.Length < mtb.Mask.Length)
            {
                str = "0" + str;
            }
            mtb.Text = str;
            //Se valida el resultado
            return validarMaskedTextBox(mtb);
        }
        public static void AcomodarCostoMkb(MaskedTextBox mtb,decimal dec)
        {
            //se coonvierte el decimal en string
            string strDescimal =dec.ToString();
            //se tomael tamaño del string
            int tamañostrDescimal = strDescimal.Length;
            //se toma el tamaño del maskedtexbox
            int tamañoMtb = mtb.TextLength;

            if (strDescimal.Contains(".0000"))
            {

                strDescimal = strDescimal.Replace(".0000", ".00");
                int tamañostrDescimal2 = strDescimal.Length;

                for (int c = tamañostrDescimal2; c < tamañoMtb; c++)
                {
                    strDescimal = "0" + strDescimal;
                }
                mtb.Text = strDescimal;
                
            }
            else 
            {
                mtb.Text = dec + "";
                for (int c = tamañostrDescimal; c < tamañoMtb; c++)
                {
                    strDescimal = "0" + strDescimal;
                }
            }
            
        }

        /// <summary>
        /// Pinta de color correspondiente a valido a invalido segun sea el email introducido en la caja de texto.
        /// </summary>
        /// <param name="tbEmailCliente">Caja de texto con correo electronico introducido</param>
        /// <returns></returns>
        internal static bool validarTextBoxEmail(TextBox tbEmailCliente)
        {
            bool val = validarCorreoElectronico(tbEmailCliente.Text);
            tbEmailCliente.BackColor = val ? Color.White : Color.Pink;
            return val;
        }

        /// <summary>
        /// Determina la validez del correo electronico introducido
        /// </summary>
        /// <param name="email">Cadena de caracteres que representa el correo electronico.</param>
        /// <returns>"true" si el correo electronico posee un formato valido, "false" en caso contrario.</returns>
        public static bool validarCorreoElectronico(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                try
                {
                    MailAddress m = new MailAddress(email);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            else
                return false;
        }

        /// <summary>
        /// Convierte una archivo en formato de arreglo de bytes a Imagen. Util para implementar tomar fotografias almacenadas en la base de 
        /// datos.
        /// </summary>
        /// <param name="byteArrayIn">Arreglo de bytes que representa la fotografia que se desea convertir a una instancia de la clase Image.</param>
        /// <returns></returns>
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        /// <summary>
        /// Convierte un objeto de imagen a arreglo de bytes con el proposito de ser almacenado en un campo de base de datos.
        /// </summary>
        /// <param name="imageIn">Imagen que se convertirá a arreglo de bytes</param>
        /// <returns>Arreglo de bytes que representa la imagen.</returns>
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        /// <summary>
        /// Pinta de color correspondiente a valido a invalido segun sea el costo introducido en el MaskedTexbox.
        /// </summary>
        /// <param name="mtbCosto">MaskedTexbox con el costo introducido</param>
        /// <returns></returns>

        public static string dgvValorString(DataGridView dgv, int row, int cell)
        {
            DataGridViewRow filaseleccionada = dgv.SelectedRows[row];
            string valor = (string)filaseleccionada.Cells[cell].Value;
            return valor;
        }
        public static int dgvValorInt(DataGridView dgv, int row, int cell)
        {
            DataGridViewRow filaseleccionada = dgv.SelectedRows[row];
            int valor = (int)filaseleccionada.Cells[cell].Value;
            return valor;
        }


        /// <summary>
        /// Método que despliega en pantalla una ventana para la captura de algún dato mediante un texbox.
        /// </summary>
        /// <param name="title">Recibe un texto que se mostrará como título de la ventana emergente.</param>
        /// <param name="promptText">Mensaje principal del cuerpo de la ventana emergente.</param>
        /// <param name="value">Paso de valor por referencia que almacenará el dato introducido por el usuario en la caja de texto dentro de la ventana emergente.</param>
        /// <returns></returns>
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }


        /// <summary>
        /// Evento para validar la introduccion de caracteres de tipo numero y punto dentro de una caja de texto.
        /// </summary>
        /// <param name="e">Objeto de argumentos del evento de presionado de tecla.</param>
        /// <param name="sender">MaskedTextBox que se desea validar.</param>
        public static void keyPressNumeros(KeyPressEventArgs e, object sender)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

    
}

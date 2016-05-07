namespace LucySpa
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbEmailCliente = new MetroFramework.Controls.MetroTextBox();
            this.mtbTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtpCumpleañosCliente = new System.Windows.Forms.DateTimePicker();
            this.tbDireccionCliente = new MetroFramework.Controls.MetroTextBox();
            this.tbApellidoCliente = new MetroFramework.Controls.MetroTextBox();
            this.tbNombreCliente = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardarCliente = new MetroFramework.Controls.MetroButton();
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.btnExaminarCliente = new MetroFramework.Controls.MetroButton();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.lblCumpleaños = new MetroFramework.Controls.MetroLabel();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.TimerClientes = new System.Windows.Forms.Timer(this.components);
            this.pbRegreso = new System.Windows.Forms.PictureBox();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.gbCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.CustomBackground = false;
            this.tbEmailCliente.CustomForeColor = false;
            this.tbEmailCliente.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbEmailCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbEmailCliente.Location = new System.Drawing.Point(101, 270);
            this.tbEmailCliente.Multiline = false;
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.SelectedText = "";
            this.tbEmailCliente.Size = new System.Drawing.Size(300, 33);
            this.tbEmailCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmailCliente.StyleManager = null;
            this.tbEmailCliente.TabIndex = 29;
            this.tbEmailCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmailCliente.UseStyleColors = false;
            // 
            // mtbTelefonoCliente
            // 
            this.mtbTelefonoCliente.Location = new System.Drawing.Point(101, 242);
            this.mtbTelefonoCliente.Name = "mtbTelefonoCliente";
            this.mtbTelefonoCliente.Size = new System.Drawing.Size(300, 20);
            this.mtbTelefonoCliente.TabIndex = 28;
            // 
            // dtpCumpleañosCliente
            // 
            this.dtpCumpleañosCliente.Location = new System.Drawing.Point(101, 214);
            this.dtpCumpleañosCliente.Name = "dtpCumpleañosCliente";
            this.dtpCumpleañosCliente.Size = new System.Drawing.Size(300, 20);
            this.dtpCumpleañosCliente.TabIndex = 27;
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.CustomBackground = false;
            this.tbDireccionCliente.CustomForeColor = false;
            this.tbDireccionCliente.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbDireccionCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbDireccionCliente.Location = new System.Drawing.Point(101, 171);
            this.tbDireccionCliente.Multiline = false;
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.SelectedText = "";
            this.tbDireccionCliente.Size = new System.Drawing.Size(300, 33);
            this.tbDireccionCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDireccionCliente.StyleManager = null;
            this.tbDireccionCliente.TabIndex = 26;
            this.tbDireccionCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDireccionCliente.UseStyleColors = false;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.CustomBackground = false;
            this.tbApellidoCliente.CustomForeColor = false;
            this.tbApellidoCliente.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbApellidoCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbApellidoCliente.Location = new System.Drawing.Point(101, 130);
            this.tbApellidoCliente.Multiline = false;
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.SelectedText = "";
            this.tbApellidoCliente.Size = new System.Drawing.Size(300, 33);
            this.tbApellidoCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbApellidoCliente.StyleManager = null;
            this.tbApellidoCliente.TabIndex = 25;
            this.tbApellidoCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbApellidoCliente.UseStyleColors = false;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.CustomBackground = false;
            this.tbNombreCliente.CustomForeColor = false;
            this.tbNombreCliente.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbNombreCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbNombreCliente.Location = new System.Drawing.Point(101, 91);
            this.tbNombreCliente.Multiline = false;
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.SelectedText = "";
            this.tbNombreCliente.Size = new System.Drawing.Size(300, 33);
            this.tbNombreCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombreCliente.StyleManager = null;
            this.tbNombreCliente.TabIndex = 24;
            this.tbNombreCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombreCliente.UseStyleColors = false;
            this.tbNombreCliente.Click += new System.EventHandler(this.tbNombreCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Highlight = false;
            this.btnGuardarCliente.Location = new System.Drawing.Point(226, 354);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(162, 71);
            this.btnGuardarCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardarCliente.StyleManager = null;
            this.btnGuardarCliente.TabIndex = 23;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // gbCaja
            // 
            this.gbCaja.Controls.Add(this.btnExaminarCliente);
            this.gbCaja.Controls.Add(this.pbCliente);
            this.gbCaja.Location = new System.Drawing.Point(437, 63);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(194, 267);
            this.gbCaja.TabIndex = 22;
            this.gbCaja.TabStop = false;
            this.gbCaja.Text = "Fotografia";
            // 
            // btnExaminarCliente
            // 
            this.btnExaminarCliente.Highlight = false;
            this.btnExaminarCliente.Location = new System.Drawing.Point(37, 215);
            this.btnExaminarCliente.Name = "btnExaminarCliente";
            this.btnExaminarCliente.Size = new System.Drawing.Size(124, 36);
            this.btnExaminarCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExaminarCliente.StyleManager = null;
            this.btnExaminarCliente.TabIndex = 1;
            this.btnExaminarCliente.Text = "Examinar";
            this.btnExaminarCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExaminarCliente.Click += new System.EventHandler(this.btnExaminarCliente_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.CustomBackground = false;
            this.lblEmail.CustomForeColor = false;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEmail.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEmail.Location = new System.Drawing.Point(12, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmail.StyleManager = null;
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmail.UseStyleColors = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.CustomBackground = false;
            this.lblDireccion.CustomForeColor = false;
            this.lblDireccion.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDireccion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDireccion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDireccion.Location = new System.Drawing.Point(12, 175);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 19);
            this.lblDireccion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDireccion.StyleManager = null;
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDireccion.UseStyleColors = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.CustomBackground = false;
            this.lblTelefono.CustomForeColor = false;
            this.lblTelefono.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblTelefono.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTelefono.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTelefono.Location = new System.Drawing.Point(12, 245);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 19);
            this.lblTelefono.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTelefono.StyleManager = null;
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTelefono.UseStyleColors = false;
            // 
            // lblCumpleaños
            // 
            this.lblCumpleaños.AutoSize = true;
            this.lblCumpleaños.CustomBackground = false;
            this.lblCumpleaños.CustomForeColor = false;
            this.lblCumpleaños.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblCumpleaños.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCumpleaños.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCumpleaños.Location = new System.Drawing.Point(12, 210);
            this.lblCumpleaños.Name = "lblCumpleaños";
            this.lblCumpleaños.Size = new System.Drawing.Size(85, 19);
            this.lblCumpleaños.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCumpleaños.StyleManager = null;
            this.lblCumpleaños.TabIndex = 18;
            this.lblCumpleaños.Text = "Cumpleaños:";
            this.lblCumpleaños.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCumpleaños.UseStyleColors = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.CustomBackground = false;
            this.lblApellido.CustomForeColor = false;
            this.lblApellido.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblApellido.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblApellido.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblApellido.Location = new System.Drawing.Point(12, 140);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 19);
            this.lblApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblApellido.StyleManager = null;
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblApellido.UseStyleColors = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(12, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            // 
            // TimerClientes
            // 
            this.TimerClientes.Enabled = true;
            this.TimerClientes.Interval = 10;
            this.TimerClientes.Tick += new System.EventHandler(this.TimerClientes_Tick);
            // 
            // pbRegreso
            // 
            this.pbRegreso.Image = global::LucySpa.Properties.Resources.back_button;
            this.pbRegreso.Location = new System.Drawing.Point(12, 22);
            this.pbRegreso.Name = "pbRegreso";
            this.pbRegreso.Size = new System.Drawing.Size(162, 63);
            this.pbRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegreso.TabIndex = 30;
            this.pbRegreso.TabStop = false;
            this.pbRegreso.Click += new System.EventHandler(this.pbRegreso_Click);
            // 
            // pbCliente
            // 
            this.pbCliente.Location = new System.Drawing.Point(21, 19);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(153, 190);
            this.pbCliente.TabIndex = 0;
            this.pbCliente.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = "PNG|*.png|GIF|*.gif|JPG|*.jpg;*.jpeg";
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFoto_FileOk);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 472);
            this.ControlBox = false;
            this.Controls.Add(this.pbRegreso);
            this.Controls.Add(this.tbEmailCliente);
            this.Controls.Add(this.mtbTelefonoCliente);
            this.Controls.Add(this.dtpCumpleañosCliente);
            this.Controls.Add(this.tbDireccionCliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.gbCaja);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCumpleaños);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(1350, 1800);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.gbCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbEmailCliente;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoCliente;
        private System.Windows.Forms.DateTimePicker dtpCumpleañosCliente;
        private MetroFramework.Controls.MetroTextBox tbDireccionCliente;
        private MetroFramework.Controls.MetroTextBox tbApellidoCliente;
        private MetroFramework.Controls.MetroTextBox tbNombreCliente;
        private MetroFramework.Controls.MetroButton btnGuardarCliente;
        private System.Windows.Forms.GroupBox gbCaja;
        private MetroFramework.Controls.MetroButton btnExaminarCliente;
        private System.Windows.Forms.PictureBox pbCliente;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private MetroFramework.Controls.MetroLabel lblCumpleaños;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Timer TimerClientes;
        private System.Windows.Forms.PictureBox pbRegreso;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}
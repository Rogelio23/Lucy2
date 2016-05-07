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
            this.mtbTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtpCumpleañosCliente = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarCliente = new MetroFramework.Controls.MetroButton();
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.btnExaminarCliente = new MetroFramework.Controls.MetroButton();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.lblCumpleaños = new MetroFramework.Controls.MetroLabel();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.TimerClientes = new System.Windows.Forms.Timer(this.components);
            this.pbRegreso = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.compraTableAdapter1 = new LucySpa.DataAccess.LucySpaDBTableAdapters.CompraTableAdapter();
            this.gbCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbTelefonoCliente
            // 
            this.mtbTelefonoCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefonoCliente.Location = new System.Drawing.Point(154, 182);
            this.mtbTelefonoCliente.Mask = "000-000-0000";
            this.mtbTelefonoCliente.Name = "mtbTelefonoCliente";
            this.mtbTelefonoCliente.Size = new System.Drawing.Size(253, 26);
            this.mtbTelefonoCliente.TabIndex = 4;
            this.mtbTelefonoCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefonoCliente_MaskInputRejected);
            this.mtbTelefonoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTelefonoCliente_Validating);
            // 
            // dtpCumpleañosCliente
            // 
            this.dtpCumpleañosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCumpleañosCliente.Location = new System.Drawing.Point(154, 216);
            this.dtpCumpleañosCliente.MaxDate = new System.DateTime(2015, 9, 6, 0, 0, 0, 0);
            this.dtpCumpleañosCliente.Name = "dtpCumpleañosCliente";
            this.dtpCumpleañosCliente.Size = new System.Drawing.Size(253, 26);
            this.dtpCumpleañosCliente.TabIndex = 5;
            this.dtpCumpleañosCliente.Value = new System.DateTime(2015, 9, 6, 0, 0, 0, 0);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Highlight = false;
            this.btnGuardarCliente.Location = new System.Drawing.Point(23, 298);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(180, 60);
            this.btnGuardarCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardarCliente.StyleManager = null;
            this.btnGuardarCliente.TabIndex = 8;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // gbCaja
            // 
            this.gbCaja.AutoSize = true;
            this.gbCaja.Controls.Add(this.btnExaminarCliente);
            this.gbCaja.Controls.Add(this.pbCliente);
            this.gbCaja.Location = new System.Drawing.Point(413, 106);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(200, 271);
            this.gbCaja.TabIndex = 8;
            this.gbCaja.TabStop = false;
            // 
            // btnExaminarCliente
            // 
            this.btnExaminarCliente.Highlight = false;
            this.btnExaminarCliente.Location = new System.Drawing.Point(11, 192);
            this.btnExaminarCliente.Name = "btnExaminarCliente";
            this.btnExaminarCliente.Size = new System.Drawing.Size(180, 60);
            this.btnExaminarCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExaminarCliente.StyleManager = null;
            this.btnExaminarCliente.TabIndex = 7;
            this.btnExaminarCliente.Text = "Subir Foto";
            this.btnExaminarCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExaminarCliente.Click += new System.EventHandler(this.btnExaminarCliente_Click);
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::LucySpa.Properties.Resources.clienteSinFoto;
            this.pbCliente.Location = new System.Drawing.Point(21, 19);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(160, 165);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCliente.TabIndex = 1;
            this.pbCliente.TabStop = false;
            this.pbCliente.Click += new System.EventHandler(this.pbCliente_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(154, 80);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(253, 26);
            this.tbNombreCliente.TabIndex = 1;
            this.tbNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombreCliente_Validating);
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoCliente.Location = new System.Drawing.Point(154, 113);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(253, 26);
            this.tbApellidoCliente.TabIndex = 2;
            this.tbApellidoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellidoCliente_Validating);
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailCliente.Location = new System.Drawing.Point(152, 250);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(253, 26);
            this.tbEmailCliente.TabIndex = 6;
            this.tbEmailCliente.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmailCliente_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.CustomBackground = false;
            this.lblEmail.CustomForeColor = false;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEmail.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEmail.Location = new System.Drawing.Point(23, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmail.StyleManager = null;
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmail.UseStyleColors = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.CustomBackground = false;
            this.lblDireccion.CustomForeColor = false;
            this.lblDireccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDireccion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDireccion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDireccion.Location = new System.Drawing.Point(23, 145);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(100, 23);
            this.lblDireccion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDireccion.StyleManager = null;
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDireccion.UseStyleColors = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.CustomBackground = false;
            this.lblTelefono.CustomForeColor = false;
            this.lblTelefono.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTelefono.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTelefono.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTelefono.Location = new System.Drawing.Point(23, 179);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTelefono.StyleManager = null;
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTelefono.UseStyleColors = false;
            // 
            // lblCumpleaños
            // 
            this.lblCumpleaños.CustomBackground = false;
            this.lblCumpleaños.CustomForeColor = false;
            this.lblCumpleaños.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCumpleaños.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCumpleaños.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCumpleaños.Location = new System.Drawing.Point(23, 213);
            this.lblCumpleaños.Name = "lblCumpleaños";
            this.lblCumpleaños.Size = new System.Drawing.Size(125, 23);
            this.lblCumpleaños.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCumpleaños.StyleManager = null;
            this.lblCumpleaños.TabIndex = 12;
            this.lblCumpleaños.Text = "Cumple Años:";
            this.lblCumpleaños.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCumpleaños.UseStyleColors = false;
            // 
            // lblApellido
            // 
            this.lblApellido.CustomBackground = false;
            this.lblApellido.CustomForeColor = false;
            this.lblApellido.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblApellido.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblApellido.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblApellido.Location = new System.Drawing.Point(23, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblApellido.StyleManager = null;
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblApellido.UseStyleColors = false;
            // 
            // lblNombre
            // 
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(23, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 14;
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
            this.pbRegreso.Image = global::LucySpa.Properties.Resources.back4;
            this.pbRegreso.Location = new System.Drawing.Point(450, 20);
            this.pbRegreso.Name = "pbRegreso";
            this.pbRegreso.Size = new System.Drawing.Size(143, 80);
            this.pbRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegreso.TabIndex = 4;
            this.pbRegreso.TabStop = false;
            this.pbRegreso.Click += new System.EventHandler(this.pbRegreso_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFoto_FileOk);
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccionCliente.Location = new System.Drawing.Point(154, 148);
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(253, 26);
            this.tbDireccionCliente.TabIndex = 3;
            this.tbDireccionCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbDireccionCliente.Validating += new System.ComponentModel.CancelEventHandler(this.tbDireccionCliente_Validating);
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 394);
            this.ControlBox = false;
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.pbRegreso);
            this.Controls.Add(this.dtpCumpleañosCliente);
            this.Controls.Add(this.mtbTelefonoCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.tbEmailCliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.gbCaja);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tbDireccionCliente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCumpleaños);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmClientes";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.gbCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbTelefonoCliente;
        private System.Windows.Forms.DateTimePicker dtpCumpleañosCliente;
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
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private DataAccess.LucySpaDBTableAdapters.CompraTableAdapter compraTableAdapter1;
    }
}
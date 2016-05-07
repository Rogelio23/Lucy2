namespace LucySpa
{
    partial class frmEmpleados
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
            this.mtbTelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.dtCumpleañosEmpleado = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarEmpleado = new MetroFramework.Controls.MetroButton();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.btnExaminarEmpleado = new MetroFramework.Controls.MetroButton();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.lblEmailEmpleado = new MetroFramework.Controls.MetroLabel();
            this.lblDireccionEmpleado = new MetroFramework.Controls.MetroLabel();
            this.lblTelefonoEmpleado = new MetroFramework.Controls.MetroLabel();
            this.lblCumpleañosEmpleado = new MetroFramework.Controls.MetroLabel();
            this.lblApellidoEmpleado = new MetroFramework.Controls.MetroLabel();
            this.lblNombreEmpleado = new MetroFramework.Controls.MetroLabel();
            this.TimerEmpleados = new System.Windows.Forms.Timer(this.components);
            this.tbNombreEmpleado = new System.Windows.Forms.TextBox();
            this.tbApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.tbDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.tbEmailEmpleado = new System.Windows.Forms.TextBox();
            this.opfEmpleados = new System.Windows.Forms.OpenFileDialog();
            this.pbRegreso = new System.Windows.Forms.PictureBox();
            this.gbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbTelefonoEmpleado
            // 
            this.mtbTelefonoEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbTelefonoEmpleado.Location = new System.Drawing.Point(140, 214);
            this.mtbTelefonoEmpleado.Mask = "0000000000";
            this.mtbTelefonoEmpleado.Name = "mtbTelefonoEmpleado";
            this.mtbTelefonoEmpleado.Size = new System.Drawing.Size(200, 20);
            this.mtbTelefonoEmpleado.TabIndex = 4;
            this.mtbTelefonoEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTelefonoEmpleado_Validating);
            // 
            // dtCumpleañosEmpleado
            // 
            this.dtCumpleañosEmpleado.Location = new System.Drawing.Point(140, 183);
            this.dtCumpleañosEmpleado.Name = "dtCumpleañosEmpleado";
            this.dtCumpleañosEmpleado.Size = new System.Drawing.Size(200, 20);
            this.dtCumpleañosEmpleado.TabIndex = 3;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Highlight = false;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(23, 332);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(180, 60);
            this.btnGuardarEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardarEmpleado.StyleManager = null;
            this.btnGuardarEmpleado.TabIndex = 7;
            this.btnGuardarEmpleado.Text = "Guardar";
            this.btnGuardarEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click_1);
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.btnExaminarEmpleado);
            this.gbEmpleado.Controls.Add(this.pbEmpleado);
            this.gbEmpleado.Location = new System.Drawing.Point(373, 131);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(194, 277);
            this.gbEmpleado.TabIndex = 36;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Fotografia";
            // 
            // btnExaminarEmpleado
            // 
            this.btnExaminarEmpleado.Highlight = false;
            this.btnExaminarEmpleado.Location = new System.Drawing.Point(6, 201);
            this.btnExaminarEmpleado.Name = "btnExaminarEmpleado";
            this.btnExaminarEmpleado.Size = new System.Drawing.Size(180, 60);
            this.btnExaminarEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExaminarEmpleado.StyleManager = null;
            this.btnExaminarEmpleado.TabIndex = 6;
            this.btnExaminarEmpleado.Text = "Examinar";
            this.btnExaminarEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExaminarEmpleado.Click += new System.EventHandler(this.btnExaminarEmpleado_Click_1);
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Image = global::LucySpa.Properties.Resources.clienteSinFoto;
            this.pbEmpleado.Location = new System.Drawing.Point(17, 19);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(160, 165);
            this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpleado.TabIndex = 0;
            this.pbEmpleado.TabStop = false;
            // 
            // lblEmailEmpleado
            // 
            this.lblEmailEmpleado.AutoSize = true;
            this.lblEmailEmpleado.CustomBackground = false;
            this.lblEmailEmpleado.CustomForeColor = false;
            this.lblEmailEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmailEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEmailEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEmailEmpleado.Location = new System.Drawing.Point(23, 241);
            this.lblEmailEmpleado.Name = "lblEmailEmpleado";
            this.lblEmailEmpleado.Size = new System.Drawing.Size(57, 25);
            this.lblEmailEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmailEmpleado.StyleManager = null;
            this.lblEmailEmpleado.TabIndex = 35;
            this.lblEmailEmpleado.Text = "Email:";
            this.lblEmailEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmailEmpleado.UseStyleColors = false;
            // 
            // lblDireccionEmpleado
            // 
            this.lblDireccionEmpleado.AutoSize = true;
            this.lblDireccionEmpleado.CustomBackground = false;
            this.lblDireccionEmpleado.CustomForeColor = false;
            this.lblDireccionEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDireccionEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDireccionEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDireccionEmpleado.Location = new System.Drawing.Point(23, 142);
            this.lblDireccionEmpleado.Name = "lblDireccionEmpleado";
            this.lblDireccionEmpleado.Size = new System.Drawing.Size(87, 25);
            this.lblDireccionEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDireccionEmpleado.StyleManager = null;
            this.lblDireccionEmpleado.TabIndex = 34;
            this.lblDireccionEmpleado.Text = "Dirección:";
            this.lblDireccionEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDireccionEmpleado.UseStyleColors = false;
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.CustomBackground = false;
            this.lblTelefonoEmpleado.CustomForeColor = false;
            this.lblTelefonoEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTelefonoEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTelefonoEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(23, 212);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(79, 25);
            this.lblTelefonoEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTelefonoEmpleado.StyleManager = null;
            this.lblTelefonoEmpleado.TabIndex = 33;
            this.lblTelefonoEmpleado.Text = "Telefono:";
            this.lblTelefonoEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTelefonoEmpleado.UseStyleColors = false;
            // 
            // lblCumpleañosEmpleado
            // 
            this.lblCumpleañosEmpleado.AutoSize = true;
            this.lblCumpleañosEmpleado.CustomBackground = false;
            this.lblCumpleañosEmpleado.CustomForeColor = false;
            this.lblCumpleañosEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCumpleañosEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCumpleañosEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCumpleañosEmpleado.Location = new System.Drawing.Point(23, 177);
            this.lblCumpleañosEmpleado.Name = "lblCumpleañosEmpleado";
            this.lblCumpleañosEmpleado.Size = new System.Drawing.Size(111, 25);
            this.lblCumpleañosEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCumpleañosEmpleado.StyleManager = null;
            this.lblCumpleañosEmpleado.TabIndex = 32;
            this.lblCumpleañosEmpleado.Text = "Cumpleaños:";
            this.lblCumpleañosEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCumpleañosEmpleado.UseStyleColors = false;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.CustomBackground = false;
            this.lblApellidoEmpleado.CustomForeColor = false;
            this.lblApellidoEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblApellidoEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblApellidoEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(23, 107);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(78, 25);
            this.lblApellidoEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblApellidoEmpleado.StyleManager = null;
            this.lblApellidoEmpleado.TabIndex = 31;
            this.lblApellidoEmpleado.Text = "Apellido:";
            this.lblApellidoEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblApellidoEmpleado.UseStyleColors = false;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.CustomBackground = false;
            this.lblNombreEmpleado.CustomForeColor = false;
            this.lblNombreEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNombreEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombreEmpleado.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(23, 72);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(79, 25);
            this.lblNombreEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombreEmpleado.StyleManager = null;
            this.lblNombreEmpleado.TabIndex = 30;
            this.lblNombreEmpleado.Text = "Nombre:";
            this.lblNombreEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombreEmpleado.UseStyleColors = false;
            // 
            // TimerEmpleados
            // 
            this.TimerEmpleados.Enabled = true;
            this.TimerEmpleados.Interval = 1;
            this.TimerEmpleados.Tick += new System.EventHandler(this.TimerClientes_Tick);
            // 
            // tbNombreEmpleado
            // 
            this.tbNombreEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombreEmpleado.Location = new System.Drawing.Point(140, 74);
            this.tbNombreEmpleado.Name = "tbNombreEmpleado";
            this.tbNombreEmpleado.Size = new System.Drawing.Size(200, 20);
            this.tbNombreEmpleado.TabIndex = 0;
            this.tbNombreEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombreEmpleado_Validating);
            // 
            // tbApellidoEmpleado
            // 
            this.tbApellidoEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbApellidoEmpleado.Location = new System.Drawing.Point(140, 109);
            this.tbApellidoEmpleado.Name = "tbApellidoEmpleado";
            this.tbApellidoEmpleado.Size = new System.Drawing.Size(200, 20);
            this.tbApellidoEmpleado.TabIndex = 1;
            this.tbApellidoEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellidoEmpleado_Validating);
            // 
            // tbDireccionEmpleado
            // 
            this.tbDireccionEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDireccionEmpleado.Location = new System.Drawing.Point(140, 147);
            this.tbDireccionEmpleado.Name = "tbDireccionEmpleado";
            this.tbDireccionEmpleado.Size = new System.Drawing.Size(200, 20);
            this.tbDireccionEmpleado.TabIndex = 2;
            this.tbDireccionEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.tbDireccionEmpleado_Validating);
            // 
            // tbEmailEmpleado
            // 
            this.tbEmailEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbEmailEmpleado.Location = new System.Drawing.Point(140, 240);
            this.tbEmailEmpleado.Name = "tbEmailEmpleado";
            this.tbEmailEmpleado.Size = new System.Drawing.Size(200, 20);
            this.tbEmailEmpleado.TabIndex = 5;
            this.tbEmailEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmailEmpleado_Validating);
            // 
            // opfEmpleados
            // 
            this.opfEmpleados.FileName = "openFileDialog1";
            this.opfEmpleados.FileOk += new System.ComponentModel.CancelEventHandler(this.opfEmpleados_FileOk);
            // 
            // pbRegreso
            // 
            this.pbRegreso.Image = global::LucySpa.Properties.Resources.back4;
            this.pbRegreso.Location = new System.Drawing.Point(424, 45);
            this.pbRegreso.Name = "pbRegreso";
            this.pbRegreso.Size = new System.Drawing.Size(143, 80);
            this.pbRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegreso.TabIndex = 37;
            this.pbRegreso.TabStop = false;
            this.pbRegreso.Click += new System.EventHandler(this.pbRegreso_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 423);
            this.Controls.Add(this.pbRegreso);
            this.Controls.Add(this.tbEmailEmpleado);
            this.Controls.Add(this.tbDireccionEmpleado);
            this.Controls.Add(this.tbApellidoEmpleado);
            this.Controls.Add(this.tbNombreEmpleado);
            this.Controls.Add(this.mtbTelefonoEmpleado);
            this.Controls.Add(this.dtCumpleañosEmpleado);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.gbEmpleado);
            this.Controls.Add(this.lblEmailEmpleado);
            this.Controls.Add(this.lblDireccionEmpleado);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblCumpleañosEmpleado);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Location = new System.Drawing.Point(1350, 150);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.Click += new System.EventHandler(this.TimerEmpleados_Tick);
            this.gbEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbTelefonoEmpleado;
        private System.Windows.Forms.DateTimePicker dtCumpleañosEmpleado;
        private MetroFramework.Controls.MetroButton btnGuardarEmpleado;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private MetroFramework.Controls.MetroButton btnExaminarEmpleado;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private MetroFramework.Controls.MetroLabel lblEmailEmpleado;
        private MetroFramework.Controls.MetroLabel lblDireccionEmpleado;
        private MetroFramework.Controls.MetroLabel lblTelefonoEmpleado;
        private MetroFramework.Controls.MetroLabel lblCumpleañosEmpleado;
        private MetroFramework.Controls.MetroLabel lblApellidoEmpleado;
        private MetroFramework.Controls.MetroLabel lblNombreEmpleado;
        private System.Windows.Forms.Timer TimerEmpleados;
        private System.Windows.Forms.TextBox tbNombreEmpleado;
        private System.Windows.Forms.TextBox tbApellidoEmpleado;
        private System.Windows.Forms.TextBox tbDireccionEmpleado;
        private System.Windows.Forms.TextBox tbEmailEmpleado;
        private System.Windows.Forms.OpenFileDialog opfEmpleados;
        private System.Windows.Forms.PictureBox pbRegreso;
    }
}
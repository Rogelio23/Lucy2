namespace LucySpa
{
    partial class frmUsuarios
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
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(208, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 61);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.CustomBackground = false;
            this.lblPassword.CustomForeColor = false;
            this.lblPassword.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPassword.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPassword.Location = new System.Drawing.Point(23, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPassword.StyleManager = null;
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPassword.UseStyleColors = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(2, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre Usuario:";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.Location = new System.Drawing.Point(130, 72);
            this.tbNombreUsuario.Multiline = true;
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(226, 40);
            this.tbNombreUsuario.TabIndex = 43;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(130, 133);
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(226, 41);
            this.tbContraseña.TabIndex = 44;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 280);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
    }
}
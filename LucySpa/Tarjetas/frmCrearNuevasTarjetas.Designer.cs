namespace LucySpa
{
    partial class frmCrearNuevasTarjetas
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
            this.mtbCosto = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.lblNumTarjeta = new MetroFramework.Controls.MetroLabel();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(23, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 60);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mtbCosto
            // 
            this.mtbCosto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCosto.Location = new System.Drawing.Point(93, 188);
            this.mtbCosto.Name = "mtbCosto";
            this.mtbCosto.Size = new System.Drawing.Size(159, 26);
            this.mtbCosto.TabIndex = 40;
            this.mtbCosto.TextChanged += new System.EventHandler(this.mtbCosto_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.CustomBackground = false;
            this.lblTipo.CustomForeColor = false;
            this.lblTipo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTipo.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTipo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTipo.Location = new System.Drawing.Point(14, 141);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 25);
            this.lblTipo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTipo.StyleManager = null;
            this.lblTipo.TabIndex = 37;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTipo.UseStyleColors = false;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.CustomBackground = false;
            this.lblCosto.CustomForeColor = false;
            this.lblCosto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCosto.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCosto.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCosto.Location = new System.Drawing.Point(14, 188);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(73, 25);
            this.lblCosto.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCosto.StyleManager = null;
            this.lblCosto.TabIndex = 36;
            this.lblCosto.Text = "Costo: $";
            this.lblCosto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCosto.UseStyleColors = false;
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.CustomBackground = false;
            this.lblNumTarjeta.CustomForeColor = false;
            this.lblNumTarjeta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumTarjeta.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNumTarjeta.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNumTarjeta.Location = new System.Drawing.Point(14, 91);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(84, 25);
            this.lblNumTarjeta.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNumTarjeta.StyleManager = null;
            this.lblNumTarjeta.TabIndex = 35;
            this.lblNumTarjeta.Text = "Cantidad:";
            this.lblNumTarjeta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNumTarjeta.UseStyleColors = false;
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCantidad.Location = new System.Drawing.Point(93, 90);
            this.mtbCantidad.Mask = "000";
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(159, 26);
            this.mtbCantidad.TabIndex = 42;
            this.mtbCantidad.TextChanged += new System.EventHandler(this.mtbCantidad_TextChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "PREMIUM",
            "REGALO",
            "CORTESIA"});
            this.cbTipo.Location = new System.Drawing.Point(93, 144);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(159, 21);
            this.cbTipo.TabIndex = 43;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCrearNuevasTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 349);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.mtbCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtbCosto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblNumTarjeta);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCrearNuevasTarjetas";
            this.Resizable = false;
            this.Text = "Crear Nuevas Tarjetas";
            this.Load += new System.EventHandler(this.frmTarjetas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox mtbCosto;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroLabel lblCosto;
        private MetroFramework.Controls.MetroLabel lblNumTarjeta;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}
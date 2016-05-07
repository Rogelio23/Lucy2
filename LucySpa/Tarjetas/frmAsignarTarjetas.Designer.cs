namespace LucySpa
{
    partial class frmAsignarTarjetas
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
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.lblNumTarjeta = new MetroFramework.Controls.MetroLabel();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.tarjetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTarjetas = new LucySpa.DataAccess.DSTarjetas();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lblFechaCompra = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tarjetasTableAdapter = new LucySpa.DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbCortesia = new System.Windows.Forms.RadioButton();
            this.rbRegalo = new System.Windows.Forms.RadioButton();
            this.lblTipoTarjeta = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(163, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 60);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.CustomBackground = false;
            this.lblNumTarjeta.CustomForeColor = false;
            this.lblNumTarjeta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumTarjeta.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNumTarjeta.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNumTarjeta.Location = new System.Drawing.Point(14, 163);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(114, 25);
            this.lblNumTarjeta.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNumTarjeta.StyleManager = null;
            this.lblNumTarjeta.TabIndex = 35;
            this.lblNumTarjeta.Text = "Num. Tarjeta:";
            this.lblNumTarjeta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNumTarjeta.UseStyleColors = false;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbTarjeta.DataSource = this.tarjetasBindingSource;
            this.cbTarjeta.DisplayMember = "TarjetaID";
            this.cbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Location = new System.Drawing.Point(176, 160);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(296, 28);
            this.cbTarjeta.TabIndex = 42;
            this.cbTarjeta.ValueMember = "TarjetaID";
            // 
            // tarjetasBindingSource
            // 
            this.tarjetasBindingSource.DataMember = "Tarjetas";
            this.tarjetasBindingSource.DataSource = this.dSTarjetas;
            // 
            // dSTarjetas
            // 
            this.dSTarjetas.DataSetName = "DSTarjetas";
            this.dSTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.CustomBackground = false;
            this.lblCliente.CustomForeColor = false;
            this.lblCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCliente.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCliente.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCliente.Location = new System.Drawing.Point(14, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 25);
            this.lblCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCliente.StyleManager = null;
            this.lblCliente.TabIndex = 43;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCliente.UseStyleColors = false;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(173, 68);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(299, 26);
            this.tbCliente.TabIndex = 44;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.CustomBackground = false;
            this.lblFechaCompra.CustomForeColor = false;
            this.lblFechaCompra.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFechaCompra.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblFechaCompra.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblFechaCompra.Location = new System.Drawing.Point(14, 216);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(155, 25);
            this.lblFechaCompra.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblFechaCompra.StyleManager = null;
            this.lblFechaCompra.TabIndex = 45;
            this.lblFechaCompra.Text = "Fecha de Compra: ";
            this.lblFechaCompra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblFechaCompra.UseStyleColors = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2015, 10, 26, 0, 0, 0, 0);
            // 
            // tarjetasTableAdapter
            // 
            this.tarjetasTableAdapter.ClearBeforeFill = true;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Checked = true;
            this.rbPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremium.Location = new System.Drawing.Point(176, 116);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(89, 24);
            this.rbPremium.TabIndex = 47;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            this.rbPremium.CheckedChanged += new System.EventHandler(this.rbPremium_CheckedChanged);
            // 
            // rbCortesia
            // 
            this.rbCortesia.AutoSize = true;
            this.rbCortesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCortesia.Location = new System.Drawing.Point(290, 117);
            this.rbCortesia.Name = "rbCortesia";
            this.rbCortesia.Size = new System.Drawing.Size(86, 24);
            this.rbCortesia.TabIndex = 48;
            this.rbCortesia.Text = "Cortesia";
            this.rbCortesia.UseVisualStyleBackColor = true;
            this.rbCortesia.CheckedChanged += new System.EventHandler(this.rbCortesia_CheckedChanged);
            // 
            // rbRegalo
            // 
            this.rbRegalo.AutoSize = true;
            this.rbRegalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegalo.Location = new System.Drawing.Point(394, 116);
            this.rbRegalo.Name = "rbRegalo";
            this.rbRegalo.Size = new System.Drawing.Size(78, 24);
            this.rbRegalo.TabIndex = 49;
            this.rbRegalo.Text = "Regalo";
            this.rbRegalo.UseVisualStyleBackColor = true;
            this.rbRegalo.CheckedChanged += new System.EventHandler(this.rbRegalo_CheckedChanged);
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.CustomBackground = false;
            this.lblTipoTarjeta.CustomForeColor = false;
            this.lblTipoTarjeta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTipoTarjeta.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTipoTarjeta.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(14, 116);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(129, 25);
            this.lblTipoTarjeta.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTipoTarjeta.StyleManager = null;
            this.lblTipoTarjeta.TabIndex = 50;
            this.lblTipoTarjeta.Text = "Tipo de Tarjeta:";
            this.lblTipoTarjeta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTipoTarjeta.UseStyleColors = false;
            // 
            // frmAsignarTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 386);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.rbRegalo);
            this.Controls.Add(this.rbCortesia);
            this.Controls.Add(this.rbPremium);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbTarjeta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNumTarjeta);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAsignarTarjetas";
            this.Text = "Asignar Tarjeta";
            this.Load += new System.EventHandler(this.frmTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblNumTarjeta;
        private System.Windows.Forms.ComboBox cbTarjeta;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private MetroFramework.Controls.MetroLabel lblFechaCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataAccess.DSTarjetas dSTarjetas;
        private System.Windows.Forms.BindingSource tarjetasBindingSource;
        private DataAccess.DSTarjetasTableAdapters.TarjetasTableAdapter tarjetasTableAdapter;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbCortesia;
        private System.Windows.Forms.RadioButton rbRegalo;
        private MetroFramework.Controls.MetroLabel lblTipoTarjeta;
    }
}
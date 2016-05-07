namespace LucySpa
{
    partial class frmTratamiento
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
            this.btnSeleccionar = new MetroFramework.Controls.MetroButton();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.servicioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.dgvTratamiento = new System.Windows.Forms.DataGridView();
            this.tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNombre = new MetroFramework.Controls.MetroTextBox();
            this.tbDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.mtbnCantidad = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrecioCatalogo = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecioCatalogo = new MetroFramework.Controls.MetroLabel();
            this.servicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Highlight = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(681, 247);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(77, 33);
            this.btnSeleccionar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSeleccionar.StyleManager = null;
            this.btnSeleccionar.TabIndex = 41;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CustomBackground = false;
            this.lblDescripcion.CustomForeColor = false;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDescripcion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDescripcion.Location = new System.Drawing.Point(597, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 19);
            this.lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescripcion.StyleManager = null;
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Tratamiento";
            this.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescripcion.UseStyleColors = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(588, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Lista de servicios";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicioIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvServicios.DataSource = this.servicioBindingSource;
            this.dgvServicios.Location = new System.Drawing.Point(419, 91);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(445, 150);
            this.dgvServicios.TabIndex = 42;
            this.dgvServicios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvServicios_MouseDoubleClick);
            // 
            // servicioIDDataGridViewTextBoxColumn
            // 
            this.servicioIDDataGridViewTextBoxColumn.DataPropertyName = "ServicioID";
            this.servicioIDDataGridViewTextBoxColumn.HeaderText = "ServicioID";
            this.servicioIDDataGridViewTextBoxColumn.Name = "servicioIDDataGridViewTextBoxColumn";
            this.servicioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTratamiento
            // 
            this.dgvTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tratamiento,
            this.servicioID,
            this.cantidad,
            this.Costo,
            this.Orden});
            this.dgvTratamiento.Location = new System.Drawing.Point(424, 301);
            this.dgvTratamiento.MultiSelect = false;
            this.dgvTratamiento.Name = "dgvTratamiento";
            this.dgvTratamiento.ReadOnly = true;
            this.dgvTratamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamiento.Size = new System.Drawing.Size(440, 150);
            this.dgvTratamiento.TabIndex = 43;
            // 
            // tratamiento
            // 
            this.tratamiento.HeaderText = "ServicioID";
            this.tratamiento.Name = "tratamiento";
            this.tratamiento.ReadOnly = true;
            // 
            // servicioID
            // 
            this.servicioID.HeaderText = "Nombre";
            this.servicioID.Name = "servicioID";
            this.servicioID.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.CustomBackground = false;
            this.tbNombre.CustomForeColor = false;
            this.tbNombre.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbNombre.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbNombre.Location = new System.Drawing.Point(16, 103);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.SelectedText = "";
            this.tbNombre.Size = new System.Drawing.Size(362, 40);
            this.tbNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombre.StyleManager = null;
            this.tbNombre.TabIndex = 46;
            this.tbNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombre.UseStyleColors = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.CustomBackground = false;
            this.tbDescripcion.CustomForeColor = false;
            this.tbDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbDescripcion.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.tbDescripcion.Location = new System.Drawing.Point(24, 189);
            this.tbDescripcion.Multiline = false;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.SelectedText = "";
            this.tbDescripcion.Size = new System.Drawing.Size(354, 40);
            this.tbDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescripcion.StyleManager = null;
            this.tbDescripcion.TabIndex = 47;
            this.tbDescripcion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescripcion.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(120, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Descripcion del Tratamiento";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(144, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(153, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Nombre del tratamiento";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(120, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 60);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar Tratamiento";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Highlight = false;
            this.btnRemover.Location = new System.Drawing.Point(588, 457);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(148, 33);
            this.btnRemover.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRemover.StyleManager = null;
            this.btnRemover.TabIndex = 52;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // mtbnCantidad
            // 
            this.mtbnCantidad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbnCantidad.Location = new System.Drawing.Point(588, 260);
            this.mtbnCantidad.Mask = "00";
            this.mtbnCantidad.Name = "mtbnCantidad";
            this.mtbnCantidad.Size = new System.Drawing.Size(77, 20);
            this.mtbnCantidad.TabIndex = 53;
            // 
            // mtbPrecioCatalogo
            // 
            this.mtbPrecioCatalogo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbPrecioCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecioCatalogo.Location = new System.Drawing.Point(44, 299);
            this.mtbPrecioCatalogo.Mask = "000000.00";
            this.mtbPrecioCatalogo.Name = "mtbPrecioCatalogo";
            this.mtbPrecioCatalogo.Size = new System.Drawing.Size(253, 26);
            this.mtbPrecioCatalogo.TabIndex = 54;
            // 
            // lblPrecioCatalogo
            // 
            this.lblPrecioCatalogo.CustomBackground = false;
            this.lblPrecioCatalogo.CustomForeColor = false;
            this.lblPrecioCatalogo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrecioCatalogo.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPrecioCatalogo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPrecioCatalogo.Location = new System.Drawing.Point(98, 259);
            this.lblPrecioCatalogo.Name = "lblPrecioCatalogo";
            this.lblPrecioCatalogo.Size = new System.Drawing.Size(168, 23);
            this.lblPrecioCatalogo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrecioCatalogo.StyleManager = null;
            this.lblPrecioCatalogo.TabIndex = 55;
            this.lblPrecioCatalogo.Text = "Precio de Catalogo";
            this.lblPrecioCatalogo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrecioCatalogo.UseStyleColors = false;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // frmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 513);
            this.Controls.Add(this.mtbPrecioCatalogo);
            this.Controls.Add(this.lblPrecioCatalogo);
            this.Controls.Add(this.mtbnCantidad);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dgvTratamiento);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTratamiento";
            this.Text = "Diseño de Tratamiento";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.frmTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSeleccionar;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridView dgvTratamiento;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox tbNombre;
        private MetroFramework.Controls.MetroTextBox tbDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnRemover;
        private System.Windows.Forms.MaskedTextBox mtbnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.MaskedTextBox mtbPrecioCatalogo;
        private MetroFramework.Controls.MetroLabel lblPrecioCatalogo;
    }
}
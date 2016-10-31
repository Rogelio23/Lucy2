namespace LucySpa.Cuartos
{
    partial class frmCuartos
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
            this.tbDescripcionCuarto = new System.Windows.Forms.TextBox();
            this.tbNumeroCuarto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.btnSeleccionarServicio = new MetroFramework.Controls.MetroButton();
            this.btnDesseleccionarServicio = new MetroFramework.Controls.MetroButton();
            this.lblServicio = new MetroFramework.Controls.MetroLabel();
            this.lblEquipos = new MetroFramework.Controls.MetroLabel();
            this.btnDesseleccionarEquipo = new MetroFramework.Controls.MetroButton();
            this.btnSeleccionarEquipo = new MetroFramework.Controls.MetroButton();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvServicioSeleccionado = new System.Windows.Forms.DataGridView();
            this.dgvEquipoSeleccionado = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvModificarServicio = new System.Windows.Forms.DataGridView();
            this.servicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
            this.equipoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter();
            this.servicioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescripcionCuarto
            // 
            this.tbDescripcionCuarto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDescripcionCuarto.Location = new System.Drawing.Point(608, 72);
            this.tbDescripcionCuarto.Multiline = true;
            this.tbDescripcionCuarto.Name = "tbDescripcionCuarto";
            this.tbDescripcionCuarto.Size = new System.Drawing.Size(268, 33);
            this.tbDescripcionCuarto.TabIndex = 43;
            // 
            // tbNumeroCuarto
            // 
            this.tbNumeroCuarto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNumeroCuarto.Location = new System.Drawing.Point(8, 72);
            this.tbNumeroCuarto.Multiline = true;
            this.tbNumeroCuarto.Name = "tbNumeroCuarto";
            this.tbNumeroCuarto.ReadOnly = true;
            this.tbNumeroCuarto.Size = new System.Drawing.Size(204, 33);
            this.tbNumeroCuarto.TabIndex = 41;
            this.tbNumeroCuarto.TextChanged += new System.EventHandler(this.tbNumeroCuarto_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(337, 495);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 61);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CustomBackground = false;
            this.lblDescripcion.CustomForeColor = false;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDescripcion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDescripcion.Location = new System.Drawing.Point(701, 50);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescripcion.StyleManager = null;
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescripcion.UseStyleColors = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.CustomBackground = false;
            this.lblNumero.CustomForeColor = false;
            this.lblNumero.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNumero.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNumero.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNumero.Location = new System.Drawing.Point(66, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(61, 19);
            this.lblNumero.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNumero.StyleManager = null;
            this.lblNumero.TabIndex = 44;
            this.lblNumero.Text = "Numero:";
            this.lblNumero.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNumero.UseStyleColors = false;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombre.Location = new System.Drawing.Point(325, 72);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(204, 33);
            this.tbNombre.TabIndex = 42;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(403, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToResizeColumns = false;
            this.dgvServicios.AllowUserToResizeRows = false;
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicioIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvServicios.DataSource = this.servicioBindingSource;
            this.dgvServicios.Location = new System.Drawing.Point(8, 158);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(343, 136);
            this.dgvServicios.TabIndex = 48;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            this.dgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
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
            // btnSeleccionarServicio
            // 
            this.btnSeleccionarServicio.Highlight = false;
            this.btnSeleccionarServicio.Location = new System.Drawing.Point(389, 175);
            this.btnSeleccionarServicio.Name = "btnSeleccionarServicio";
            this.btnSeleccionarServicio.Size = new System.Drawing.Size(51, 39);
            this.btnSeleccionarServicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSeleccionarServicio.StyleManager = null;
            this.btnSeleccionarServicio.TabIndex = 49;
            this.btnSeleccionarServicio.Text = ">";
            this.btnSeleccionarServicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSeleccionarServicio.Click += new System.EventHandler(this.btnSeleccionarServicio_Click);
            // 
            // btnDesseleccionarServicio
            // 
            this.btnDesseleccionarServicio.Highlight = false;
            this.btnDesseleccionarServicio.Location = new System.Drawing.Point(389, 235);
            this.btnDesseleccionarServicio.Name = "btnDesseleccionarServicio";
            this.btnDesseleccionarServicio.Size = new System.Drawing.Size(51, 39);
            this.btnDesseleccionarServicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDesseleccionarServicio.StyleManager = null;
            this.btnDesseleccionarServicio.TabIndex = 50;
            this.btnDesseleccionarServicio.Text = "<";
            this.btnDesseleccionarServicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDesseleccionarServicio.Click += new System.EventHandler(this.btnDesseleccionarServicio_Click);
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.CustomBackground = false;
            this.lblServicio.CustomForeColor = false;
            this.lblServicio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblServicio.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblServicio.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblServicio.Location = new System.Drawing.Point(66, 130);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(188, 25);
            this.lblServicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblServicio.StyleManager = null;
            this.lblServicio.TabIndex = 51;
            this.lblServicio.Text = "Seleccione los Servicios";
            this.lblServicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblServicio.UseStyleColors = false;
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.CustomBackground = false;
            this.lblEquipos.CustomForeColor = false;
            this.lblEquipos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEquipos.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEquipos.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEquipos.Location = new System.Drawing.Point(66, 313);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(187, 25);
            this.lblEquipos.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEquipos.StyleManager = null;
            this.lblEquipos.TabIndex = 52;
            this.lblEquipos.Text = "Seleccione los Equipos:";
            this.lblEquipos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEquipos.UseStyleColors = false;
            // 
            // btnDesseleccionarEquipo
            // 
            this.btnDesseleccionarEquipo.Highlight = false;
            this.btnDesseleccionarEquipo.Location = new System.Drawing.Point(389, 435);
            this.btnDesseleccionarEquipo.Name = "btnDesseleccionarEquipo";
            this.btnDesseleccionarEquipo.Size = new System.Drawing.Size(51, 39);
            this.btnDesseleccionarEquipo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDesseleccionarEquipo.StyleManager = null;
            this.btnDesseleccionarEquipo.TabIndex = 54;
            this.btnDesseleccionarEquipo.Text = "<";
            this.btnDesseleccionarEquipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDesseleccionarEquipo.Click += new System.EventHandler(this.btnDesseleccionarEquipo_Click);
            // 
            // btnSeleccionarEquipo
            // 
            this.btnSeleccionarEquipo.Highlight = false;
            this.btnSeleccionarEquipo.Location = new System.Drawing.Point(389, 375);
            this.btnSeleccionarEquipo.Name = "btnSeleccionarEquipo";
            this.btnSeleccionarEquipo.Size = new System.Drawing.Size(51, 39);
            this.btnSeleccionarEquipo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSeleccionarEquipo.StyleManager = null;
            this.btnSeleccionarEquipo.TabIndex = 53;
            this.btnSeleccionarEquipo.Text = ">";
            this.btnSeleccionarEquipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSeleccionarEquipo.Click += new System.EventHandler(this.btnSeleccionarEquipo_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.AutoGenerateColumns = false;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvEquipos.DataSource = this.equipoBindingSource;
            this.dgvEquipos.Location = new System.Drawing.Point(8, 353);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(343, 136);
            this.dgvEquipos.TabIndex = 55;
            this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EquipoID";
            this.Column5.HeaderText = "EquipoID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.lucySpaDB;
            // 
            // dgvServicioSeleccionado
            // 
            this.dgvServicioSeleccionado.AllowUserToAddRows = false;
            this.dgvServicioSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicioSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvServicioSeleccionado.Location = new System.Drawing.Point(492, 157);
            this.dgvServicioSeleccionado.Name = "dgvServicioSeleccionado";
            this.dgvServicioSeleccionado.ReadOnly = true;
            this.dgvServicioSeleccionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicioSeleccionado.Size = new System.Drawing.Size(368, 137);
            this.dgvServicioSeleccionado.TabIndex = 56;
            this.dgvServicioSeleccionado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicioSeleccionado_CellClick);
            // 
            // dgvEquipoSeleccionado
            // 
            this.dgvEquipoSeleccionado.AllowUserToAddRows = false;
            this.dgvEquipoSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipoSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvEquipoSeleccionado.Location = new System.Drawing.Point(492, 352);
            this.dgvEquipoSeleccionado.Name = "dgvEquipoSeleccionado";
            this.dgvEquipoSeleccionado.ReadOnly = true;
            this.dgvEquipoSeleccionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipoSeleccionado.Size = new System.Drawing.Size(368, 137);
            this.dgvEquipoSeleccionado.TabIndex = 57;
            this.dgvEquipoSeleccionado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipoSeleccionado_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "EquipoID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre del Equipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // dgvModificarServicio
            // 
            this.dgvModificarServicio.AllowUserToAddRows = false;
            this.dgvModificarServicio.AllowUserToDeleteRows = false;
            this.dgvModificarServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarServicio.Location = new System.Drawing.Point(573, 324);
            this.dgvModificarServicio.Name = "dgvModificarServicio";
            this.dgvModificarServicio.Size = new System.Drawing.Size(240, 150);
            this.dgvModificarServicio.TabIndex = 58;
            this.dgvModificarServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificarServicio_CellContentClick);
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
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
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreDataGridViewTextBoxColumn.Width = 300;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ServicioID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Servicio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // frmCuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 562);
            this.Controls.Add(this.dgvModificarServicio);
            this.Controls.Add(this.dgvEquipoSeleccionado);
            this.Controls.Add(this.dgvServicioSeleccionado);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.btnDesseleccionarEquipo);
            this.Controls.Add(this.btnSeleccionarEquipo);
            this.Controls.Add(this.lblEquipos);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.btnDesseleccionarServicio);
            this.Controls.Add(this.btnSeleccionarServicio);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbDescripcionCuarto);
            this.Controls.Add(this.tbNumeroCuarto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNumero);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCuartos";
            this.Text = "Diseño de Cuartos";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.frmCuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcionCuarto;
        private System.Windows.Forms.TextBox tbNumeroCuarto;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private System.Windows.Forms.TextBox tbNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.DataGridView dgvServicios;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private MetroFramework.Controls.MetroButton btnSeleccionarServicio;
        private MetroFramework.Controls.MetroButton btnDesseleccionarServicio;
        private MetroFramework.Controls.MetroLabel lblServicio;
        private MetroFramework.Controls.MetroLabel lblEquipos;
        private MetroFramework.Controls.MetroButton btnDesseleccionarEquipo;
        private MetroFramework.Controls.MetroButton btnSeleccionarEquipo;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.DataGridView dgvServicioSeleccionado;
        private System.Windows.Forms.DataGridView dgvEquipoSeleccionado;
        private System.Windows.Forms.DataGridView dgvModificarServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
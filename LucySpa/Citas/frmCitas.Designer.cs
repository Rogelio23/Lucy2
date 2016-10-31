namespace LucySpa.Citas
{
    partial class frmCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.vistaCLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.vistaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.tbBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.mbtnBuscarCliente = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.mbtnAgendar = new MetroFramework.Controls.MetroButton();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lbBuscaCliente = new System.Windows.Forms.Label();
            this.lbBuscarEmpleado = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.vistaCLienteTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter();
            this.vistaEmpleadoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter();
            this.fotografiaClienteTableAdapter1 = new LucySpa.DataAccess.LucySpaDBTableAdapters.FotografiaClienteTableAdapter();
            this.servicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
            this.servicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCuarto = new System.Windows.Forms.Label();
            this.cbCuartos = new System.Windows.Forms.ComboBox();
            this.cuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuartoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
            this.chbDosPersonas = new System.Windows.Forms.CheckBox();
            this.ServicioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuartoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServicioID,
            this.nombreDataGridViewTextBoxColumn,
            this.Costo,
            this.Descripcion,
            this.CuartoID});
            this.dgvServicios.DataSource = this.servicioBindingSource;
            this.dgvServicios.Location = new System.Drawing.Point(26, 107);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(442, 248);
            this.dgvServicios.TabIndex = 0;
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
            // vistaCLienteBindingSource
            // 
            this.vistaCLienteBindingSource.DataMember = "vistaCLiente";
            this.vistaCLienteBindingSource.DataSource = this.lucySpaDB;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AutoGenerateColumns = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidoDataGridViewTextBoxColumn1,
            this.telefonoDataGridViewTextBoxColumn1});
            this.dgvEmpleado.DataSource = this.vistaEmpleadoBindingSource;
            this.dgvEmpleado.Location = new System.Drawing.Point(483, 107);
            this.dgvEmpleado.MultiSelect = false;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(474, 248);
            this.dgvEmpleado.TabIndex = 1;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            // 
            // vistaEmpleadoBindingSource
            // 
            this.vistaEmpleadoBindingSource.DataMember = "vistaEmpleado";
            this.vistaEmpleadoBindingSource.DataSource = this.lucySpaDB;
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarCliente.Location = new System.Drawing.Point(157, 71);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(205, 26);
            this.tbBuscarCliente.TabIndex = 2;
            // 
            // tbBuscarEmpleado
            // 
            this.tbBuscarEmpleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBuscarEmpleado.Location = new System.Drawing.Point(622, 74);
            this.tbBuscarEmpleado.Name = "tbBuscarEmpleado";
            this.tbBuscarEmpleado.Size = new System.Drawing.Size(189, 26);
            this.tbBuscarEmpleado.TabIndex = 3;
            // 
            // mbtnBuscarCliente
            // 
            this.mbtnBuscarCliente.Highlight = false;
            this.mbtnBuscarCliente.Location = new System.Drawing.Point(368, 69);
            this.mbtnBuscarCliente.Name = "mbtnBuscarCliente";
            this.mbtnBuscarCliente.Size = new System.Drawing.Size(100, 29);
            this.mbtnBuscarCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.mbtnBuscarCliente.StyleManager = null;
            this.mbtnBuscarCliente.TabIndex = 4;
            this.mbtnBuscarCliente.Text = "Buscar..";
            this.mbtnBuscarCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnBuscarCliente.Click += new System.EventHandler(this.mbtnBuscarCliente_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(817, 71);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Buscar..";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // mbtnAgendar
            // 
            this.mbtnAgendar.Highlight = false;
            this.mbtnAgendar.Location = new System.Drawing.Point(777, 369);
            this.mbtnAgendar.Name = "mbtnAgendar";
            this.mbtnAgendar.Size = new System.Drawing.Size(180, 60);
            this.mbtnAgendar.Style = MetroFramework.MetroColorStyle.Green;
            this.mbtnAgendar.StyleManager = null;
            this.mbtnAgendar.TabIndex = 6;
            this.mbtnAgendar.Text = "Guardar";
            this.mbtnAgendar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnAgendar.Click += new System.EventHandler(this.mbtnAgendar_Click);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpFechaCita.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCita.Location = new System.Drawing.Point(167, 369);
            this.dtpFechaCita.MinDate = new System.DateTime(2015, 9, 16, 0, 0, 0, 0);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(205, 26);
            this.dtpFechaCita.TabIndex = 7;
            this.dtpFechaCita.Value = new System.DateTime(2016, 8, 25, 0, 0, 0, 0);
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // lbBuscaCliente
            // 
            this.lbBuscaCliente.AutoSize = true;
            this.lbBuscaCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscaCliente.Location = new System.Drawing.Point(33, 75);
            this.lbBuscaCliente.Name = "lbBuscaCliente";
            this.lbBuscaCliente.Size = new System.Drawing.Size(118, 18);
            this.lbBuscaCliente.TabIndex = 8;
            this.lbBuscaCliente.Text = "Buscar Servicio";
            // 
            // lbBuscarEmpleado
            // 
            this.lbBuscarEmpleado.AutoSize = true;
            this.lbBuscarEmpleado.Font = new System.Drawing.Font("Arial", 12F);
            this.lbBuscarEmpleado.Location = new System.Drawing.Point(483, 75);
            this.lbBuscarEmpleado.Name = "lbBuscarEmpleado";
            this.lbBuscarEmpleado.Size = new System.Drawing.Size(133, 18);
            this.lbBuscarEmpleado.TabIndex = 9;
            this.lbBuscarEmpleado.Text = "Buscar Empleado";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.lbFecha.Location = new System.Drawing.Point(23, 375);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(102, 18);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "Fecha / Hora:";
            // 
            // vistaCLienteTableAdapter
            // 
            this.vistaCLienteTableAdapter.ClearBeforeFill = true;
            // 
            // vistaEmpleadoTableAdapter
            // 
            this.vistaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // fotografiaClienteTableAdapter1
            // 
            this.fotografiaClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // servicioBindingSource1
            // 
            this.servicioBindingSource1.DataMember = "Servicio";
            this.servicioBindingSource1.DataSource = this.lucySpaDB;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCliente.Location = new System.Drawing.Point(23, 407);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 18);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente: ";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(167, 403);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.ReadOnly = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(301, 26);
            this.tbNombreCliente.TabIndex = 2;
            // 
            // lblCuarto
            // 
            this.lblCuarto.AutoSize = true;
            this.lblCuarto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuarto.Location = new System.Drawing.Point(33, 26);
            this.lblCuarto.Name = "lblCuarto";
            this.lblCuarto.Size = new System.Drawing.Size(59, 18);
            this.lblCuarto.TabIndex = 12;
            this.lblCuarto.Text = "Cuarto:";
            // 
            // cbCuartos
            // 
            this.cbCuartos.DataSource = this.cuartoBindingSource;
            this.cbCuartos.DisplayMember = "CuartoID";
            this.cbCuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuartos.FormattingEnabled = true;
            this.cbCuartos.Location = new System.Drawing.Point(98, 22);
            this.cbCuartos.Name = "cbCuartos";
            this.cbCuartos.Size = new System.Drawing.Size(121, 28);
            this.cbCuartos.TabIndex = 13;
            this.cbCuartos.ValueMember = "CuartoID";
            this.cbCuartos.SelectedIndexChanged += new System.EventHandler(this.cbCuartos_SelectedIndexChanged);
            // 
            // cuartoBindingSource
            // 
            this.cuartoBindingSource.DataMember = "Cuarto";
            this.cuartoBindingSource.DataSource = this.lucySpaDB;
            // 
            // cuartoTableAdapter
            // 
            this.cuartoTableAdapter.ClearBeforeFill = true;
            // 
            // chbDosPersonas
            // 
            this.chbDosPersonas.AutoSize = true;
            this.chbDosPersonas.Location = new System.Drawing.Point(554, 380);
            this.chbDosPersonas.Name = "chbDosPersonas";
            this.chbDosPersonas.Size = new System.Drawing.Size(98, 17);
            this.chbDosPersonas.TabIndex = 14;
            this.chbDosPersonas.Text = "Dos Personas?";
            this.chbDosPersonas.UseVisualStyleBackColor = true;
            this.chbDosPersonas.CheckedChanged += new System.EventHandler(this.chbDosPersonas_CheckedChanged);
            // 
            // ServicioID
            // 
            this.ServicioID.DataPropertyName = "ServicioID";
            this.ServicioID.HeaderText = "ServicioID";
            this.ServicioID.Name = "ServicioID";
            this.ServicioID.ReadOnly = true;
            this.ServicioID.Visible = false;
            this.ServicioID.Width = 70;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Costo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // CuartoID
            // 
            this.CuartoID.DataPropertyName = "CuartoID";
            this.CuartoID.HeaderText = "CuartoID";
            this.CuartoID.Name = "CuartoID";
            this.CuartoID.ReadOnly = true;
            this.CuartoID.Visible = false;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            this.empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            this.empleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID";
            this.empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            this.empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empleadoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn1
            // 
            this.apellidoDataGridViewTextBoxColumn1.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn1.Name = "apellidoDataGridViewTextBoxColumn1";
            this.apellidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn1
            // 
            this.telefonoDataGridViewTextBoxColumn1.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.Name = "telefonoDataGridViewTextBoxColumn1";
            this.telefonoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // frmCitas
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 466);
            this.Controls.Add(this.chbDosPersonas);
            this.Controls.Add(this.cbCuartos);
            this.Controls.Add(this.lblCuarto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbBuscarEmpleado);
            this.Controls.Add(this.lbBuscaCliente);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.mbtnAgendar);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.mbtnBuscarCliente);
            this.Controls.Add(this.tbBuscarEmpleado);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.dgvServicios);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCitas";
            this.Resizable = false;
            this.Text = "Registro de Citas";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.TextBox tbBuscarEmpleado;
        private MetroFramework.Controls.MetroButton mbtnBuscarCliente;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton mbtnAgendar;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lbBuscaCliente;
        private System.Windows.Forms.Label lbBuscarEmpleado;
        private System.Windows.Forms.Label lbFecha;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCLienteBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter vistaCLienteTableAdapter;
        private System.Windows.Forms.BindingSource vistaEmpleadoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter vistaEmpleadoTableAdapter;
        private DataAccess.LucySpaDBTableAdapters.FotografiaClienteTableAdapter fotografiaClienteTableAdapter1;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.BindingSource servicioBindingSource1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblCuarto;
        private System.Windows.Forms.ComboBox cbCuartos;
        private System.Windows.Forms.BindingSource cuartoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter cuartoTableAdapter;
        private System.Windows.Forms.CheckBox chbDosPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuartoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn1;
    }
}
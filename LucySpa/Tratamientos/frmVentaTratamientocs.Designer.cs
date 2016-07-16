namespace LucySpa.Tratamientos
{
    partial class frmVentaTratamientocs
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.servicioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaDiseñoTrataConServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.empleadoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaEmppleadoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.vistaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgendar = new MetroFramework.Controls.MetroButton();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vistaCLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCLienteTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter();
            this.vistaEmpleadoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter();
            this.vistaDiseñoTrataConServicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaDiseñoTrataConServicioTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCuartos = new System.Windows.Forms.ComboBox();
            this.cuartoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuartoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cuartoServicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicioIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvServicios.DataSource = this.vistaDiseñoTrataConServicioBindingSource;
            this.dgvServicios.Location = new System.Drawing.Point(41, 32);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowTemplate.Height = 40;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(412, 342);
            this.dgvServicios.TabIndex = 2;
            this.dgvServicios.SelectionChanged += new System.EventHandler(this.dgvServicios_SelectionChanged);
            // 
            // servicioIDDataGridViewTextBoxColumn
            // 
            this.servicioIDDataGridViewTextBoxColumn.DataPropertyName = "ServicioID";
            this.servicioIDDataGridViewTextBoxColumn.HeaderText = "ServicioID";
            this.servicioIDDataGridViewTextBoxColumn.Name = "servicioIDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // vistaDiseñoTrataConServicioBindingSource
            // 
            this.vistaDiseñoTrataConServicioBindingSource.DataMember = "vistaDiseñoTrataConServicio";
            this.vistaDiseñoTrataConServicioBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvServicios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 381);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoIDDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.fotografiaEmppleadoDataGridViewImageColumn});
            this.dgvEmpleados.DataSource = this.vistaEmpleadoBindingSource;
            this.dgvEmpleados.Location = new System.Drawing.Point(41, 32);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 40;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(412, 342);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            this.empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            this.empleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID";
            this.empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            this.empleadoIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 170;
            // 
            // fotografiaEmppleadoDataGridViewImageColumn
            // 
            this.fotografiaEmppleadoDataGridViewImageColumn.DataPropertyName = "fotografiaEmppleado";
            this.fotografiaEmppleadoDataGridViewImageColumn.HeaderText = "fotografiaEmppleado";
            this.fotografiaEmppleadoDataGridViewImageColumn.Name = "fotografiaEmppleadoDataGridViewImageColumn";
            this.fotografiaEmppleadoDataGridViewImageColumn.Width = 170;
            // 
            // vistaEmpleadoBindingSource
            // 
            this.vistaEmpleadoBindingSource.DataMember = "vistaEmpleado";
            this.vistaEmpleadoBindingSource.DataSource = this.lucySpaDB;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgendar.Highlight = false;
            this.btnAgendar.Location = new System.Drawing.Point(884, 458);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(180, 60);
            this.btnAgendar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAgendar.StyleManager = null;
            this.btnAgendar.TabIndex = 14;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.lbFecha.Location = new System.Drawing.Point(276, 487);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(102, 18);
            this.lbFecha.TabIndex = 16;
            this.lbFecha.Text = "Fecha / Hora:";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpFechaCita.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCita.Location = new System.Drawing.Point(420, 481);
            this.dtpFechaCita.MinDate = new System.DateTime(2015, 9, 16, 0, 0, 0, 0);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(205, 26);
            this.dtpFechaCita.TabIndex = 15;
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(64, 487);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(161, 20);
            this.tbPago.TabIndex = 17;
            this.tbPago.TextChanged += new System.EventHandler(this.tbPago_TextChanged);
            this.tbPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPago_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pago";
            // 
            // vistaCLienteBindingSource
            // 
            this.vistaCLienteBindingSource.DataMember = "vistaCLiente";
            this.vistaCLienteBindingSource.DataSource = this.lucySpaDB;
            // 
            // vistaCLienteTableAdapter
            // 
            this.vistaCLienteTableAdapter.ClearBeforeFill = true;
            // 
            // vistaEmpleadoTableAdapter
            // 
            this.vistaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaDiseñoTrataConServicioTableAdapter
            // 
            this.vistaDiseñoTrataConServicioTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "$";
            // 
            // cbCuartos
            // 
            this.cbCuartos.DataSource = this.cuartoServicioBindingSource;
            this.cbCuartos.DisplayMember = "CuartoID";
            this.cbCuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuartos.FormattingEnabled = true;
            this.cbCuartos.Location = new System.Drawing.Point(741, 477);
            this.cbCuartos.Name = "cbCuartos";
            this.cbCuartos.Size = new System.Drawing.Size(121, 28);
            this.cbCuartos.TabIndex = 20;
            this.cbCuartos.ValueMember = "CuartoID";
            this.cbCuartos.SelectedIndexChanged += new System.EventHandler(this.cbCuartos_SelectedIndexChanged);
            // 
            // cuartoServicioBindingSource
            // 
            this.cuartoServicioBindingSource.DataMember = "CuartoServicio";
            this.cuartoServicioBindingSource.DataSource = this.lucySpaDB;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cuarto";
            // 
            // cuartoServicioTableAdapter
            // 
            this.cuartoServicioTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentaTratamientocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCuartos);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmVentaTratamientocs";
            this.Text = "Venta De Tratamiento";
            this.Load += new System.EventHandler(this.frmVentaTratamientocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCLienteBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter vistaCLienteTableAdapter;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.BindingSource vistaEmpleadoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter vistaEmpleadoTableAdapter;
        private MetroFramework.Controls.MetroButton btnAgendar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vistaDiseñoTrataConServicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaDiseñoTrataConServicioTableAdapter vistaDiseñoTrataConServicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografiaEmppleadoDataGridViewImageColumn;
        private System.Windows.Forms.ComboBox cbCuartos;
        private System.Windows.Forms.BindingSource cuartoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter cuartoTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cuartoServicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoServicioTableAdapter cuartoServicioTableAdapter;
    }
}
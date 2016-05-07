namespace LucySpa.Tratamientos
{
    partial class frmSeleccionarClienteYEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaClienteDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.vistaCLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.vistaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCLienteTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter();
            this.vistaEmpleadoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter();
            this.btnSeleccionar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fotografiaClienteDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.vistaCLienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "nombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fotografiaClienteDataGridViewImageColumn
            // 
            this.fotografiaClienteDataGridViewImageColumn.DataPropertyName = "fotografiaCliente";
            this.fotografiaClienteDataGridViewImageColumn.HeaderText = "fotografiaCliente";
            this.fotografiaClienteDataGridViewImageColumn.Name = "fotografiaClienteDataGridViewImageColumn";
            // 
            // vistaCLienteBindingSource
            // 
            this.vistaCLienteBindingSource.DataMember = "vistaCLiente";
            this.vistaCLienteBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaEmpleadoBindingSource
            // 
            this.vistaEmpleadoBindingSource.DataMember = "vistaEmpleado";
            this.vistaEmpleadoBindingSource.DataSource = this.lucySpaDB;
            // 
            // vistaCLienteTableAdapter
            // 
            this.vistaCLienteTableAdapter.ClearBeforeFill = true;
            // 
            // vistaEmpleadoTableAdapter
            // 
            this.vistaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSeleccionar.Highlight = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(337, 445);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(180, 60);
            this.btnSeleccionar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSeleccionar.StyleManager = null;
            this.btnSeleccionar.TabIndex = 12;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmSeleccionarClienteYEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 518);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSeleccionarClienteYEmpleado";
            this.Text = "Seleccionar Cliente";
            this.Load += new System.EventHandler(this.frmSeleccionarClienteYEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCLienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCLienteBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCLienteTableAdapter vistaCLienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografiaClienteDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource vistaEmpleadoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaEmpleadoTableAdapter vistaEmpleadoTableAdapter;
        private MetroFramework.Controls.MetroButton btnSeleccionar;
    }
}
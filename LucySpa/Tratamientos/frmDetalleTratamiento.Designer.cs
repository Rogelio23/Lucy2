namespace LucySpa.Tratamientos
{
    partial class frmDetalleTratamiento
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TratamientoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaDiseñoTrataConServicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter();
            this.cuartoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
            this.vistaDiseñoTrataConServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaDiseñoTrataConServicioTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaDiseñoTrataConServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TratamientoID,
            this.servicioIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vistaDiseñoTrataConServicioBindingSource1;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(31, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(625, 246);
            this.dataGridView2.TabIndex = 1;
            // 
            // TratamientoID
            // 
            this.TratamientoID.DataPropertyName = "TratamientoID";
            this.TratamientoID.HeaderText = "TratamientoID";
            this.TratamientoID.Name = "TratamientoID";
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
            // vistaDiseñoTrataConServicioBindingSource1
            // 
            this.vistaDiseñoTrataConServicioBindingSource1.DataMember = "vistaDiseñoTrataConServicio";
            this.vistaDiseñoTrataConServicioBindingSource1.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // cuartoBindingSource
            // 
            this.cuartoBindingSource.DataMember = "Cuarto";
            this.cuartoBindingSource.DataSource = this.lucySpaDB;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.lucySpaDB;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // cuartoTableAdapter
            // 
            this.cuartoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaDiseñoTrataConServicioBindingSource
            // 
            this.vistaDiseñoTrataConServicioBindingSource.DataMember = "vistaDiseñoTrataConServicio";
            this.vistaDiseñoTrataConServicioBindingSource.DataSource = this.lucySpaDB;
            // 
            // vistaDiseñoTrataConServicioTableAdapter
            // 
            this.vistaDiseñoTrataConServicioTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetalleTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 375);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDetalleTratamiento";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.frmDetalleTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiseñoTrataConServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.BindingSource cuartoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter cuartoTableAdapter;
        private System.Windows.Forms.BindingSource vistaDiseñoTrataConServicioBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaDiseñoTrataConServicioTableAdapter vistaDiseñoTrataConServicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamientoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vistaDiseñoTrataConServicioBindingSource1;
    }
}
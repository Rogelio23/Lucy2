namespace LucySpa.Cuartos
{
    partial class frmRelacionCuartoServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVistaCuartos = new System.Windows.Forms.DataGridView();
            this.vistaCuartoconServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.btnBorrarServicio = new MetroFramework.Controls.MetroButton();
            this.btnModificarServicio = new MetroFramework.Controls.MetroButton();
            this.vistaCuartoconServiciosTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter();
            this.cuartoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaCuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCuartoconServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaCuartos
            // 
            this.dgvVistaCuartos.AllowUserToAddRows = false;
            this.dgvVistaCuartos.AllowUserToDeleteRows = false;
            this.dgvVistaCuartos.AutoGenerateColumns = false;
            this.dgvVistaCuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaCuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuartoIDDataGridViewTextBoxColumn,
            this.Nombre,
            this.Descripcion,
            this.Costo});
            this.dgvVistaCuartos.DataSource = this.vistaCuartoconServiciosBindingSource;
            this.dgvVistaCuartos.Location = new System.Drawing.Point(23, 63);
            this.dgvVistaCuartos.Name = "dgvVistaCuartos";
            this.dgvVistaCuartos.ReadOnly = true;
            this.dgvVistaCuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaCuartos.Size = new System.Drawing.Size(638, 326);
            this.dgvVistaCuartos.TabIndex = 0;
            // 
            // vistaCuartoconServiciosBindingSource
            // 
            this.vistaCuartoconServiciosBindingSource.DataMember = "vistaCuartoconServicios";
            this.vistaCuartoconServiciosBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBorrarServicio
            // 
            this.btnBorrarServicio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrarServicio.Highlight = false;
            this.btnBorrarServicio.Location = new System.Drawing.Point(193, 421);
            this.btnBorrarServicio.Name = "btnBorrarServicio";
            this.btnBorrarServicio.Size = new System.Drawing.Size(180, 60);
            this.btnBorrarServicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBorrarServicio.StyleManager = null;
            this.btnBorrarServicio.TabIndex = 5;
            this.btnBorrarServicio.Text = "Quitar Servicio";
            this.btnBorrarServicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBorrarServicio.Click += new System.EventHandler(this.btnBorrarServicio_Click);
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarServicio.Highlight = false;
            this.btnModificarServicio.Location = new System.Drawing.Point(403, 421);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(180, 60);
            this.btnModificarServicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnModificarServicio.StyleManager = null;
            this.btnModificarServicio.TabIndex = 6;
            this.btnModificarServicio.Text = "Modificar Servicio";
            this.btnModificarServicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnModificarServicio.Click += new System.EventHandler(this.btnModificarServicio_Click);
            // 
            // vistaCuartoconServiciosTableAdapter
            // 
            this.vistaCuartoconServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // cuartoIDDataGridViewTextBoxColumn
            // 
            this.cuartoIDDataGridViewTextBoxColumn.DataPropertyName = "CuartoID";
            this.cuartoIDDataGridViewTextBoxColumn.HeaderText = "Numero de Cuarto";
            this.cuartoIDDataGridViewTextBoxColumn.Name = "cuartoIDDataGridViewTextBoxColumn";
            this.cuartoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuartoIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre del servicio";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion del servicio";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Costo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Costo.HeaderText = "Costo del servicio";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // frmRelacionCuartoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 492);
            this.Controls.Add(this.btnModificarServicio);
            this.Controls.Add(this.btnBorrarServicio);
            this.Controls.Add(this.dgvVistaCuartos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmRelacionCuartoServicios";
            this.Text = "Relación de cuartos con servicios.";
            this.Load += new System.EventHandler(this.frmRelacionCuartoServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaCuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCuartoconServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVistaCuartos;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCuartoconServiciosBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCuartoconServiciosTableAdapter vistaCuartoconServiciosTableAdapter;
        private MetroFramework.Controls.MetroButton btnBorrarServicio;
        private MetroFramework.Controls.MetroButton btnModificarServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDelServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuartoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}
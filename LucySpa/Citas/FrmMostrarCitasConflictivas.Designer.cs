namespace LucySpa.Citas
{
    partial class FrmMostrarCitasConflictivas
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
            this.dgvCitasConflictivas = new System.Windows.Forms.DataGridView();
            this.vistaCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.tbLeyenda = new System.Windows.Forms.TextBox();
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.vistaCitasTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.citaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuartoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasConflictivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitasConflictivas
            // 
            this.dgvCitasConflictivas.AutoGenerateColumns = false;
            this.dgvCitasConflictivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasConflictivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citaIDDataGridViewTextBoxColumn,
            this.CuartoID,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.apellidoEmpleadoDataGridViewTextBoxColumn,
            this.nombreServicioDataGridViewTextBoxColumn});
            this.dgvCitasConflictivas.DataSource = this.vistaCitasBindingSource;
            this.dgvCitasConflictivas.Location = new System.Drawing.Point(23, 131);
            this.dgvCitasConflictivas.Name = "dgvCitasConflictivas";
            this.dgvCitasConflictivas.Size = new System.Drawing.Size(688, 257);
            this.dgvCitasConflictivas.TabIndex = 0;
            // 
            // vistaCitasBindingSource
            // 
            this.vistaCitasBindingSource.DataMember = "vistaCitas";
            this.vistaCitasBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLeyenda
            // 
            this.tbLeyenda.BackColor = System.Drawing.SystemColors.Window;
            this.tbLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeyenda.Location = new System.Drawing.Point(87, 63);
            this.tbLeyenda.Multiline = true;
            this.tbLeyenda.Name = "tbLeyenda";
            this.tbLeyenda.ReadOnly = true;
            this.tbLeyenda.Size = new System.Drawing.Size(624, 62);
            this.tbLeyenda.TabIndex = 1;
            // 
            // pbWarning
            // 
            this.pbWarning.Location = new System.Drawing.Point(23, 63);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(58, 62);
            this.pbWarning.TabIndex = 2;
            this.pbWarning.TabStop = false;
            // 
            // vistaCitasTableAdapter
            // 
            this.vistaCitasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(531, 394);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(180, 60);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // citaIDDataGridViewTextBoxColumn
            // 
            this.citaIDDataGridViewTextBoxColumn.DataPropertyName = "CitaID";
            this.citaIDDataGridViewTextBoxColumn.HeaderText = "CitaID";
            this.citaIDDataGridViewTextBoxColumn.Name = "citaIDDataGridViewTextBoxColumn";
            // 
            // CuartoID
            // 
            this.CuartoID.DataPropertyName = "CuartoID";
            this.CuartoID.HeaderText = "CuartoID";
            this.CuartoID.Name = "CuartoID";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            // 
            // apellidoEmpleadoDataGridViewTextBoxColumn
            // 
            this.apellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Name = "apellidoEmpleadoDataGridViewTextBoxColumn";
            // 
            // nombreServicioDataGridViewTextBoxColumn
            // 
            this.nombreServicioDataGridViewTextBoxColumn.DataPropertyName = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.HeaderText = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.Name = "nombreServicioDataGridViewTextBoxColumn";
            // 
            // FrmMostrarCitasConflictivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 472);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbWarning);
            this.Controls.Add(this.tbLeyenda);
            this.Controls.Add(this.dgvCitasConflictivas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmMostrarCitasConflictivas";
            this.Resizable = false;
            this.Text = "Citas ya agendadas";
            this.Load += new System.EventHandler(this.FrmMostrarCitasConflictivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasConflictivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitasConflictivas;
        private System.Windows.Forms.TextBox tbLeyenda;
        private System.Windows.Forms.PictureBox pbWarning;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaCitasBindingSource;
        private DataAccess.LucySpaDBTableAdapters.vistaCitasTableAdapter vistaCitasTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn citaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuartoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicioDataGridViewTextBoxColumn;
    }
}
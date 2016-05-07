namespace LucySpa.Tratamientos
{
    partial class TratamientosVendidos
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
            this.dgTratamientosVenidos = new System.Windows.Forms.DataGridView();
            this.ventaTratamientoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaVentaDeTratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.cmsAbonos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbonar = new MetroFramework.Controls.MetroButton();
            this.vistaVentaDeTratamientosTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.VistaVentaDeTratamientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgTratamientosVenidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentaDeTratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.cmsAbonos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTratamientosVenidos
            // 
            this.dgTratamientosVenidos.AllowUserToAddRows = false;
            this.dgTratamientosVenidos.AutoGenerateColumns = false;
            this.dgTratamientosVenidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTratamientosVenidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventaTratamientoIDDataGridViewTextBoxColumn,
            this.clienteIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.costoTratamientoDataGridViewTextBoxColumn});
            this.dgTratamientosVenidos.DataSource = this.vistaVentaDeTratamientosBindingSource;
            this.dgTratamientosVenidos.Location = new System.Drawing.Point(34, 90);
            this.dgTratamientosVenidos.Name = "dgTratamientosVenidos";
            this.dgTratamientosVenidos.RowTemplate.ContextMenuStrip = this.cmsAbonos;
            this.dgTratamientosVenidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTratamientosVenidos.Size = new System.Drawing.Size(846, 254);
            this.dgTratamientosVenidos.TabIndex = 0;
            // 
            // ventaTratamientoIDDataGridViewTextBoxColumn
            // 
            this.ventaTratamientoIDDataGridViewTextBoxColumn.DataPropertyName = "VentaTratamientoID";
            this.ventaTratamientoIDDataGridViewTextBoxColumn.HeaderText = "VentaTratamiento ID";
            this.ventaTratamientoIDDataGridViewTextBoxColumn.Name = "ventaTratamientoIDDataGridViewTextBoxColumn";
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Tratamiento";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            // 
            // costoTratamientoDataGridViewTextBoxColumn
            // 
            this.costoTratamientoDataGridViewTextBoxColumn.DataPropertyName = "CostoTratamiento";
            this.costoTratamientoDataGridViewTextBoxColumn.HeaderText = "CostoTratamiento";
            this.costoTratamientoDataGridViewTextBoxColumn.Name = "costoTratamientoDataGridViewTextBoxColumn";
            // 
            // vistaVentaDeTratamientosBindingSource
            // 
            this.vistaVentaDeTratamientosBindingSource.DataMember = "VistaVentaDeTratamientos";
            this.vistaVentaDeTratamientosBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmsAbonos
            // 
            this.cmsAbonos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonosToolStripMenuItem});
            this.cmsAbonos.Name = "contextMenuStrip1";
            this.cmsAbonos.Size = new System.Drawing.Size(116, 26);
            // 
            // abonosToolStripMenuItem
            // 
            this.abonosToolStripMenuItem.Name = "abonosToolStripMenuItem";
            this.abonosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.abonosToolStripMenuItem.Text = "Abonos";
            // 
            // btnAbonar
            // 
            this.btnAbonar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbonar.Highlight = false;
            this.btnAbonar.Location = new System.Drawing.Point(700, 350);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(180, 60);
            this.btnAbonar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAbonar.StyleManager = null;
            this.btnAbonar.TabIndex = 14;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // vistaVentaDeTratamientosTableAdapter
            // 
            this.vistaVentaDeTratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // TratamientosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 428);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.dgTratamientosVenidos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TratamientosVendidos";
            this.Text = "TratamientosVendidos";
            this.Load += new System.EventHandler(this.TratamientosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTratamientosVenidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentaDeTratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.cmsAbonos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTratamientosVenidos;
        private System.Windows.Forms.ContextMenuStrip cmsAbonos;
        private MetroFramework.Controls.MetroButton btnAbonar;
        private System.Windows.Forms.ToolStripMenuItem abonosToolStripMenuItem;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaVentaDeTratamientosBindingSource;
        private DataAccess.LucySpaDBTableAdapters.VistaVentaDeTratamientosTableAdapter vistaVentaDeTratamientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTratamientoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTratamientoDataGridViewTextBoxColumn;
    }
}
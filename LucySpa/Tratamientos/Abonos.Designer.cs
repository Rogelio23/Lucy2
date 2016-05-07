namespace LucySpa.Tratamientos
{
    partial class Abonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAbono = new System.Windows.Forms.TextBox();
            this.btnAbonar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ventaTratamientoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaAbonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.vistaAbonosTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.VistaAbonosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAbonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // tbAbono
            // 
            this.tbAbono.Location = new System.Drawing.Point(524, 418);
            this.tbAbono.Multiline = true;
            this.tbAbono.Name = "tbAbono";
            this.tbAbono.Size = new System.Drawing.Size(134, 29);
            this.tbAbono.TabIndex = 3;
            this.tbAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAbono_KeyPress);
            // 
            // btnAbonar
            // 
            this.btnAbonar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbonar.Highlight = false;
            this.btnAbonar.Location = new System.Drawing.Point(683, 400);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(180, 60);
            this.btnAbonar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAbonar.StyleManager = null;
            this.btnAbonar.TabIndex = 15;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventaTratamientoIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoTratamientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaAbonosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 314);
            this.dataGridView1.TabIndex = 16;
            // 
            // ventaTratamientoIDDataGridViewTextBoxColumn
            // 
            this.ventaTratamientoIDDataGridViewTextBoxColumn.DataPropertyName = "VentaTratamientoID";
            this.ventaTratamientoIDDataGridViewTextBoxColumn.HeaderText = "VentaTratamientoID";
            this.ventaTratamientoIDDataGridViewTextBoxColumn.Name = "ventaTratamientoIDDataGridViewTextBoxColumn";
            this.ventaTratamientoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Tratamiento";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoTratamientoDataGridViewTextBoxColumn
            // 
            this.costoTratamientoDataGridViewTextBoxColumn.DataPropertyName = "CostoTratamiento";
            this.costoTratamientoDataGridViewTextBoxColumn.HeaderText = "CostoTratamiento";
            this.costoTratamientoDataGridViewTextBoxColumn.Name = "costoTratamientoDataGridViewTextBoxColumn";
            this.costoTratamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaAbonosBindingSource
            // 
            this.vistaAbonosBindingSource.DataMember = "VistaAbonos";
            this.vistaAbonosBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaAbonosTableAdapter
            // 
            this.vistaAbonosTableAdapter.ClearBeforeFill = true;
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAbono);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Abonos";
            this.Text = "Abonos";
            this.Load += new System.EventHandler(this.Abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAbonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAbono;
        private MetroFramework.Controls.MetroButton btnAbonar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource vistaAbonosBindingSource;
        private DataAccess.LucySpaDBTableAdapters.VistaAbonosTableAdapter vistaAbonosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTratamientoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTratamientoDataGridViewTextBoxColumn;
    }
}
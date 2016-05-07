namespace LucySpa.Equipo
{
    partial class frmEquipo
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
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.tbDescripcionEquipo = new System.Windows.Forms.TextBox();
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.cuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuartoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
            this.cuartoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuartoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbCuarto = new System.Windows.Forms.ComboBox();
            this.chbCuarto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Highlight = false;
            this.btnAgregar.Location = new System.Drawing.Point(154, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 48);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAgregar.StyleManager = null;
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Equipo";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(12, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del equipo:";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CustomBackground = false;
            this.lblDescripcion.CustomForeColor = false;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDescripcion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescripcion.StyleManager = null;
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescripcion.UseStyleColors = false;
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombreEquipo.Location = new System.Drawing.Point(154, 81);
            this.tbNombreEquipo.Multiline = true;
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(204, 33);
            this.tbNombreEquipo.TabIndex = 42;
            // 
            // tbDescripcionEquipo
            // 
            this.tbDescripcionEquipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDescripcionEquipo.Location = new System.Drawing.Point(154, 134);
            this.tbDescripcionEquipo.Multiline = true;
            this.tbDescripcionEquipo.Name = "tbDescripcionEquipo";
            this.tbDescripcionEquipo.Size = new System.Drawing.Size(204, 33);
            this.tbDescripcionEquipo.TabIndex = 43;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cuartoBindingSource1
            // 
            this.cuartoBindingSource1.DataMember = "Cuarto";
            this.cuartoBindingSource1.DataSource = this.lucySpaDB;
            // 
            // cuartoBindingSource2
            // 
            this.cuartoBindingSource2.DataMember = "Cuarto";
            this.cuartoBindingSource2.DataSource = this.lucySpaDB;
            // 
            // cbCuarto
            // 
            this.cbCuarto.DataSource = this.cuartoBindingSource1;
            this.cbCuarto.DisplayMember = "Nombre";
            this.cbCuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuarto.Enabled = false;
            this.cbCuarto.FormattingEnabled = true;
            this.cbCuarto.Location = new System.Drawing.Point(154, 185);
            this.cbCuarto.Name = "cbCuarto";
            this.cbCuarto.Size = new System.Drawing.Size(206, 21);
            this.cbCuarto.TabIndex = 44;
            this.cbCuarto.ValueMember = "CuartoID";
            this.cbCuarto.SelectedIndexChanged += new System.EventHandler(this.cbCuarto_SelectedIndexChanged);
            // 
            // chbCuarto
            // 
            this.chbCuarto.AutoSize = true;
            this.chbCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCuarto.Location = new System.Drawing.Point(23, 185);
            this.chbCuarto.Name = "chbCuarto";
            this.chbCuarto.Size = new System.Drawing.Size(69, 20);
            this.chbCuarto.TabIndex = 45;
            this.chbCuarto.Text = "Cuarto:";
            this.chbCuarto.UseVisualStyleBackColor = true;
            this.chbCuarto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.chbCuarto);
            this.Controls.Add(this.cbCuarto);
            this.Controls.Add(this.tbDescripcionEquipo);
            this.Controls.Add(this.tbNombreEquipo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmEquipo";
            this.Load += new System.EventHandler(this.frmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.TextBox tbDescripcionEquipo;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource cuartoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter cuartoTableAdapter;
        private System.Windows.Forms.BindingSource cuartoBindingSource1;
        private System.Windows.Forms.BindingSource cuartoBindingSource2;
        private System.Windows.Forms.ComboBox cbCuarto;
        private System.Windows.Forms.CheckBox chbCuarto;
    }
}
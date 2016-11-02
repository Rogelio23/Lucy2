namespace LucySpa
{
    partial class frmServicios
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
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcionServicio = new System.Windows.Forms.TextBox();
            this.pbRegreso = new System.Windows.Forms.PictureBox();
            this.tmServicios = new System.Windows.Forms.Timer(this.components);
            this.cuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucySpaDB = new LucySpa.DataAccess.LucySpaDB();
            this.cuartoTableAdapter = new LucySpa.DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter();
            this.mtbTiempoServicio = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbRepreparacion = new System.Windows.Forms.MaskedTextBox();
            this.mtbCosto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CustomBackground = false;
            this.lblDescripcion.CustomForeColor = false;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDescripcion.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 163);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescripcion.StyleManager = null;
            this.lblDescripcion.TabIndex = 29;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescripcion.UseStyleColors = false;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.CustomBackground = false;
            this.lblCosto.CustomForeColor = false;
            this.lblCosto.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblCosto.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCosto.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCosto.Location = new System.Drawing.Point(18, 128);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(46, 19);
            this.lblCosto.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCosto.StyleManager = null;
            this.lblCosto.TabIndex = 28;
            this.lblCosto.Text = "Costo:";
            this.lblCosto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCosto.UseStyleColors = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = false;
            this.lblNombre.CustomForeColor = false;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNombre.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNombre.Location = new System.Drawing.Point(18, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNombre.StyleManager = null;
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNombre.UseStyleColors = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Highlight = false;
            this.btnGuardar.Location = new System.Drawing.Point(107, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 61);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.StyleManager = null;
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombre.Location = new System.Drawing.Point(107, 81);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(204, 33);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcionServicio
            // 
            this.tbDescripcionServicio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDescripcionServicio.Location = new System.Drawing.Point(107, 159);
            this.tbDescripcionServicio.Multiline = true;
            this.tbDescripcionServicio.Name = "tbDescripcionServicio";
            this.tbDescripcionServicio.Size = new System.Drawing.Size(204, 75);
            this.tbDescripcionServicio.TabIndex = 3;
            // 
            // pbRegreso
            // 
            this.pbRegreso.Image = global::LucySpa.Properties.Resources.back_button;
            this.pbRegreso.Location = new System.Drawing.Point(9, 12);
            this.pbRegreso.Name = "pbRegreso";
            this.pbRegreso.Size = new System.Drawing.Size(162, 63);
            this.pbRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegreso.TabIndex = 39;
            this.pbRegreso.TabStop = false;
            this.pbRegreso.Click += new System.EventHandler(this.pbRegreso_Click);
            // 
            // tmServicios
            // 
            this.tmServicios.Interval = 10;
            this.tmServicios.Tick += new System.EventHandler(this.tmServicios_Tick);
            // 
            // cuartoBindingSource
            // 
            this.cuartoBindingSource.DataMember = "Cuarto";
            this.cuartoBindingSource.DataSource = this.lucySpaDB;
            // 
            // lucySpaDB
            // 
            this.lucySpaDB.DataSetName = "LucySpaDB";
            this.lucySpaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuartoTableAdapter
            // 
            this.cuartoTableAdapter.ClearBeforeFill = true;
            // 
            // mtbTiempoServicio
            // 
            this.mtbTiempoServicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtbTiempoServicio.Location = new System.Drawing.Point(206, 252);
            this.mtbTiempoServicio.Mask = "00:00";
            this.mtbTiempoServicio.Name = "mtbTiempoServicio";
            this.mtbTiempoServicio.Size = new System.Drawing.Size(49, 20);
            this.mtbTiempoServicio.TabIndex = 40;
            this.mtbTiempoServicio.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(23, 252);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Tiempo de Servicio";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(23, 292);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(166, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Tiempo de re-preparacion";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            this.metroLabel2.Visible = false;
            // 
            // mtbRepreparacion
            // 
            this.mtbRepreparacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtbRepreparacion.Location = new System.Drawing.Point(206, 292);
            this.mtbRepreparacion.Mask = "00:00";
            this.mtbRepreparacion.Name = "mtbRepreparacion";
            this.mtbRepreparacion.Size = new System.Drawing.Size(49, 20);
            this.mtbRepreparacion.TabIndex = 42;
            this.mtbRepreparacion.ValidatingType = typeof(System.DateTime);
            this.mtbRepreparacion.Visible = false;
            // 
            // mtbCosto
            // 
            this.mtbCosto.BackColor = System.Drawing.SystemColors.Menu;
            this.mtbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCosto.Location = new System.Drawing.Point(107, 121);
            this.mtbCosto.Name = "mtbCosto";
            this.mtbCosto.Size = new System.Drawing.Size(204, 26);
            this.mtbCosto.TabIndex = 44;
            this.mtbCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCosto_KeyPress_1);
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 405);
            this.Controls.Add(this.mtbCosto);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbRepreparacion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbTiempoServicio);
            this.Controls.Add(this.pbRegreso);
            this.Controls.Add(this.tbDescripcionServicio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblNombre);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucySpaDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblCosto;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcionServicio;
        private System.Windows.Forms.PictureBox pbRegreso;
        private System.Windows.Forms.Timer tmServicios;
        private DataAccess.LucySpaDB lucySpaDB;
        private System.Windows.Forms.BindingSource cuartoBindingSource;
        private DataAccess.LucySpaDBTableAdapters.CuartoTableAdapter cuartoTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtbTiempoServicio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox mtbRepreparacion;
        private System.Windows.Forms.TextBox mtbCosto;
    }
}
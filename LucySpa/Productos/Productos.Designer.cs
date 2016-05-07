namespace LucySpa.Productos
{
    partial class frmProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mtbCosto = new System.Windows.Forms.MaskedTextBox();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarProductos = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombreProducto.Location = new System.Drawing.Point(137, 63);
            this.tbNombreProducto.Multiline = true;
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(253, 30);
            this.tbNombreProducto.TabIndex = 5;
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbPrecio.Location = new System.Drawing.Point(137, 113);
            this.mtbPrecio.Mask = "0000.00";
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(253, 20);
            this.mtbPrecio.TabIndex = 6;
            this.mtbPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPrecio_Validating);
            // 
            // mtbCosto
            // 
            this.mtbCosto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbCosto.Location = new System.Drawing.Point(137, 171);
            this.mtbCosto.Mask = "0000.00";
            this.mtbCosto.Name = "mtbCosto";
            this.mtbCosto.Size = new System.Drawing.Size(253, 20);
            this.mtbCosto.TabIndex = 7;
            this.mtbCosto.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCosto_Validating);
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mtbCantidad.Location = new System.Drawing.Point(137, 232);
            this.mtbCantidad.Mask = "999";
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(253, 20);
            this.mtbCantidad.TabIndex = 8;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDescripcion.Location = new System.Drawing.Point(137, 276);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(253, 70);
            this.tbDescripcion.TabIndex = 9;
            // 
            // btnGuardarProductos
            // 
            this.btnGuardarProductos.Highlight = false;
            this.btnGuardarProductos.Location = new System.Drawing.Point(168, 367);
            this.btnGuardarProductos.Name = "btnGuardarProductos";
            this.btnGuardarProductos.Size = new System.Drawing.Size(180, 60);
            this.btnGuardarProductos.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardarProductos.StyleManager = null;
            this.btnGuardarProductos.TabIndex = 10;
            this.btnGuardarProductos.Text = "Guardar";
            this.btnGuardarProductos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardarProductos.Click += new System.EventHandler(this.btnGuardarProductos_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 429);
            this.Controls.Add(this.btnGuardarProductos);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.mtbCantidad);
            this.Controls.Add(this.mtbCosto);
            this.Controls.Add(this.mtbPrecio);
            this.Controls.Add(this.tbNombreProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProductos";
            this.Text = " Registro de productos";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbCosto;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.TextBox tbDescripcion;
        private MetroFramework.Controls.MetroButton btnGuardarProductos;
    }
}
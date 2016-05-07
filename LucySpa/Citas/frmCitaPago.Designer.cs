namespace LucySpa.Citas
{
    partial class frmCitaPago
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
            this.btnPagar = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCambio = new System.Windows.Forms.TextBox();
            this.tbAPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gbEfectivo = new System.Windows.Forms.GroupBox();
            this.btnTarjeta = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPagar.Highlight = false;
            this.btnPagar.Location = new System.Drawing.Point(80, 302);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(180, 53);
            this.btnPagar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPagar.StyleManager = null;
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cambio:";
            // 
            // tbCambio
            // 
            this.tbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCambio.Location = new System.Drawing.Point(94, 145);
            this.tbCambio.Name = "tbCambio";
            this.tbCambio.ReadOnly = true;
            this.tbCambio.Size = new System.Drawing.Size(172, 26);
            this.tbCambio.TabIndex = 38;
            // 
            // tbAPagar
            // 
            this.tbAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAPagar.Location = new System.Drawing.Point(90, 94);
            this.tbAPagar.Name = "tbAPagar";
            this.tbAPagar.Size = new System.Drawing.Size(176, 26);
            this.tbAPagar.TabIndex = 37;
            this.tbAPagar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAPagar_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Costo del Servicio:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTotal.Location = new System.Drawing.Point(166, 38);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 26);
            this.tbTotal.TabIndex = 35;
            // 
            // gbEfectivo
            // 
            this.gbEfectivo.Controls.Add(this.label2);
            this.gbEfectivo.Controls.Add(this.tbAPagar);
            this.gbEfectivo.Controls.Add(this.label4);
            this.gbEfectivo.Controls.Add(this.tbTotal);
            this.gbEfectivo.Controls.Add(this.tbCambio);
            this.gbEfectivo.Controls.Add(this.label1);
            this.gbEfectivo.Controls.Add(this.label3);
            this.gbEfectivo.Location = new System.Drawing.Point(23, 72);
            this.gbEfectivo.Name = "gbEfectivo";
            this.gbEfectivo.Size = new System.Drawing.Size(286, 209);
            this.gbEfectivo.TabIndex = 41;
            this.gbEfectivo.TabStop = false;
            this.gbEfectivo.Text = "Pago en efectivo";
            this.gbEfectivo.Enter += new System.EventHandler(this.gbEfectivo_Enter);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTarjeta.Highlight = false;
            this.btnTarjeta.Location = new System.Drawing.Point(216, 25);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(93, 53);
            this.btnTarjeta.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnTarjeta.StyleManager = null;
            this.btnTarjeta.TabIndex = 42;
            this.btnTarjeta.Text = "Tarjeta";
            this.btnTarjeta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 43;
            // 
            // frmCitaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 378);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.gbEfectivo);
            this.Controls.Add(this.btnPagar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCitaPago";
            this.Text = "Forma de pago";
            this.Load += new System.EventHandler(this.CitaPago_Load);
            this.gbEfectivo.ResumeLayout(false);
            this.gbEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCambio;
        private System.Windows.Forms.TextBox tbAPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.GroupBox gbEfectivo;
        private MetroFramework.Controls.MetroButton btnTarjeta;
        private System.Windows.Forms.Label label2;
    }
}
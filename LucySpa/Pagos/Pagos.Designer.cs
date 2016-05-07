namespace LucySpa.Pagos
{
    partial class Pagos
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
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.lblPago = new MetroFramework.Controls.MetroLabel();
            this.lblCambio = new MetroFramework.Controls.MetroLabel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.pbRegreso = new System.Windows.Forms.PictureBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.tbCambio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.CustomBackground = false;
            this.lblCosto.CustomForeColor = false;
            this.lblCosto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCosto.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCosto.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCosto.Location = new System.Drawing.Point(19, 74);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(59, 25);
            this.lblCosto.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCosto.StyleManager = null;
            this.lblCosto.TabIndex = 0;
            this.lblCosto.Text = "Costo:";
            this.lblCosto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCosto.UseStyleColors = false;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.CustomBackground = false;
            this.lblPago.CustomForeColor = false;
            this.lblPago.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPago.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPago.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPago.Location = new System.Drawing.Point(19, 115);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(55, 25);
            this.lblPago.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPago.StyleManager = null;
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "Pago:";
            this.lblPago.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPago.UseStyleColors = false;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.CustomBackground = false;
            this.lblCambio.CustomForeColor = false;
            this.lblCambio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCambio.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCambio.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCambio.Location = new System.Drawing.Point(19, 153);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(75, 25);
            this.lblCambio.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCambio.StyleManager = null;
            this.lblCambio.TabIndex = 2;
            this.lblCambio.Text = "Cambio:";
            this.lblCambio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCambio.UseStyleColors = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(48, 248);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(151, 81);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // pbRegreso
            // 
            this.pbRegreso.Image = global::LucySpa.Properties.Resources.back4;
            this.pbRegreso.Location = new System.Drawing.Point(204, 5);
            this.pbRegreso.Name = "pbRegreso";
            this.pbRegreso.Size = new System.Drawing.Size(81, 80);
            this.pbRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegreso.TabIndex = 8;
            this.pbRegreso.TabStop = false;
            this.pbRegreso.Click += new System.EventHandler(this.pbRegreso_Click);
            // 
            // tbCosto
            // 
            this.tbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCosto.Location = new System.Drawing.Point(90, 74);
            this.tbCosto.Multiline = true;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(108, 30);
            this.tbCosto.TabIndex = 9;
            this.tbCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbPago
            // 
            this.tbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPago.Location = new System.Drawing.Point(90, 115);
            this.tbPago.Multiline = true;
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(108, 30);
            this.tbPago.TabIndex = 10;
            this.tbPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPago_KeyPress);
            // 
            // tbCambio
            // 
            this.tbCambio.BackColor = System.Drawing.SystemColors.Window;
            this.tbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCambio.Location = new System.Drawing.Point(91, 153);
            this.tbCambio.Multiline = true;
            this.tbCambio.Name = "tbCambio";
            this.tbCambio.ReadOnly = true;
            this.tbCambio.Size = new System.Drawing.Size(108, 30);
            this.tbCambio.TabIndex = 11;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.ControlBox = false;
            this.Controls.Add(this.tbCambio);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.pbRegreso);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblCosto);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCosto;
        private MetroFramework.Controls.MetroLabel lblPago;
        private MetroFramework.Controls.MetroLabel lblCambio;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.PictureBox pbRegreso;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.TextBox tbCambio;
    }
}
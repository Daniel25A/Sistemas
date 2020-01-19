namespace Sistema_Marcelo.Formularios
{
    partial class frmmenureporte
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
            this.btnventas = new System.Windows.Forms.Button();
            this.btncaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnventas
            // 
            this.btnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnventas.Image = global::Sistema_Marcelo.Properties.Resources.icons8_investment_portfolio_64;
            this.btnventas.Location = new System.Drawing.Point(282, 26);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(169, 117);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "Reporte Ventas";
            this.btnventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btncaja
            // 
            this.btncaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncaja.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaja.Image = global::Sistema_Marcelo.Properties.Resources.icons8_cash_register_64;
            this.btncaja.Location = new System.Drawing.Point(65, 26);
            this.btncaja.Name = "btncaja";
            this.btncaja.Size = new System.Drawing.Size(169, 117);
            this.btncaja.TabIndex = 0;
            this.btncaja.Text = "Corte de Caja";
            this.btncaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncaja.UseVisualStyleBackColor = true;
            this.btncaja.Click += new System.EventHandler(this.btncaja_Click);
            // 
            // frmmenureporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 155);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btncaja);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmenureporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenureporte";
            this.Load += new System.EventHandler(this.frmmenureporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncaja;
        private System.Windows.Forms.Button btnventas;
    }
}
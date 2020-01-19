namespace Sistema_Marcelo
{
    partial class frmInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcodigobarras = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.btntouch = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmarcar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btntickets = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigobarras
            // 
            this.txtcodigobarras.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtcodigobarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigobarras.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarras.ForeColor = System.Drawing.Color.Yellow;
            this.txtcodigobarras.Location = new System.Drawing.Point(161, 8);
            this.txtcodigobarras.Name = "txtcodigobarras";
            this.txtcodigobarras.Size = new System.Drawing.Size(779, 96);
            this.txtcodigobarras.TabIndex = 0;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla.Location = new System.Drawing.Point(161, 112);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(1017, 379);
            this.grilla.TabIndex = 5;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo de Barras";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Importe Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calculator", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Green;
            this.lbltotal.Location = new System.Drawing.Point(265, 500);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(486, 93);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "999.000.000.00";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Calculator", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.Green;
            this.lblcantidad.Location = new System.Drawing.Point(943, 499);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(77, 93);
            this.lblcantidad.TabIndex = 13;
            this.lblcantidad.Text = "0";
            this.lblcantidad.Click += new System.EventHandler(this.lblcantidad_Click);
            // 
            // btntouch
            // 
            this.btntouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntouch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntouch.Image = global::Sistema_Marcelo.Properties.Resources.touch_48;
            this.btntouch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntouch.Location = new System.Drawing.Point(12, 513);
            this.btntouch.Name = "btntouch";
            this.btntouch.Size = new System.Drawing.Size(145, 79);
            this.btntouch.TabIndex = 15;
            this.btntouch.Text = "Touch";
            this.btntouch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntouch.UseVisualStyleBackColor = true;
            this.btntouch.Click += new System.EventHandler(this.btntouch_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagar.Image = global::Sistema_Marcelo.Properties.Resources.cash_in_hand_80px;
            this.btnpagar.Location = new System.Drawing.Point(1099, 10);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(83, 95);
            this.btnpagar.TabIndex = 14;
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_Marcelo.Properties.Resources.open_box_80px;
            this.pictureBox3.Location = new System.Drawing.Point(822, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_Marcelo.Properties.Resources.money_100px;
            this.pictureBox2.Location = new System.Drawing.Point(161, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Sistema_Marcelo.Properties.Resources.deleteicono;
            this.button1.Location = new System.Drawing.Point(1024, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 95);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmarcar
            // 
            this.btnmarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmarcar.Image = global::Sistema_Marcelo.Properties.Resources.loadicon;
            this.btnmarcar.Location = new System.Drawing.Point(940, 10);
            this.btnmarcar.Name = "btnmarcar";
            this.btnmarcar.Size = new System.Drawing.Size(87, 95);
            this.btnmarcar.TabIndex = 8;
            this.btnmarcar.UseVisualStyleBackColor = true;
            this.btnmarcar.Click += new System.EventHandler(this.btnmarcar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Marcelo.Properties.Resources.barcode_scanner_100px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = global::Sistema_Marcelo.Properties.Resources.icons8_shutdown_48;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(12, 412);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(145, 79);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btntickets
            // 
            this.btntickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntickets.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntickets.Image = global::Sistema_Marcelo.Properties.Resources.icons8_print_address_label_48;
            this.btntickets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntickets.Location = new System.Drawing.Point(12, 310);
            this.btntickets.Name = "btntickets";
            this.btntickets.Size = new System.Drawing.Size(145, 79);
            this.btntickets.TabIndex = 2;
            this.btntickets.Text = "Comprobantes";
            this.btntickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntickets.UseVisualStyleBackColor = true;
            this.btntickets.Click += new System.EventHandler(this.btntickets_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreportes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.Image = global::Sistema_Marcelo.Properties.Resources.icons8_pie_chart_48;
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreportes.Location = new System.Drawing.Point(12, 213);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(145, 79);
            this.btnreportes.TabIndex = 1;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreportes.UseVisualStyleBackColor = true;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = global::Sistema_Marcelo.Properties.Resources.icons8_data_configuration_48;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproductos.Location = new System.Drawing.Point(12, 112);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(145, 79);
            this.btnproductos.TabIndex = 0;
            this.btnproductos.Text = "Mantenimiento";
            this.btnproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 607);
            this.Controls.Add(this.btntouch);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmarcar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.txtcodigobarras);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btntickets);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btnproductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btntickets;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtcodigobarras;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmarcar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btntouch;
    }
}


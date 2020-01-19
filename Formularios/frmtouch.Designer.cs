namespace Sistema_Marcelo.Formularios
{
    partial class frmtouch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.calculadora = new System.Windows.Forms.GroupBox();
            this.txtled = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.FlowLayoutPanel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.calculadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla.DefaultCellStyle = dataGridViewCellStyle3;
            this.grilla.Location = new System.Drawing.Point(12, 12);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grilla.RowHeadersVisible = false;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(528, 247);
            this.grilla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "COD.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CANT.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESC.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECIO.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IMPORTE.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // calculadora
            // 
            this.calculadora.Controls.Add(this.txtled);
            this.calculadora.Controls.Add(this.button10);
            this.calculadora.Controls.Add(this.button8);
            this.calculadora.Controls.Add(this.button11);
            this.calculadora.Controls.Add(this.button12);
            this.calculadora.Controls.Add(this.button9);
            this.calculadora.Controls.Add(this.button6);
            this.calculadora.Controls.Add(this.button7);
            this.calculadora.Controls.Add(this.button5);
            this.calculadora.Controls.Add(this.button4);
            this.calculadora.Controls.Add(this.button3);
            this.calculadora.Controls.Add(this.button2);
            this.calculadora.Controls.Add(this.button1);
            this.calculadora.Location = new System.Drawing.Point(668, 12);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(224, 247);
            this.calculadora.TabIndex = 2;
            this.calculadora.TabStop = false;
            this.calculadora.Text = "BUTTONS";
            this.calculadora.Enter += new System.EventHandler(this.calculadora_Enter);
            // 
            // txtled
            // 
            this.txtled.BackColor = System.Drawing.Color.Black;
            this.txtled.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtled.ForeColor = System.Drawing.Color.Yellow;
            this.txtled.Location = new System.Drawing.Point(13, 19);
            this.txtled.Name = "txtled";
            this.txtled.Size = new System.Drawing.Size(198, 33);
            this.txtled.TabIndex = 13;
            this.txtled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(149, 199);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 42);
            this.button10.TabIndex = 12;
            this.button10.Text = "OK";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(149, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 42);
            this.button8.TabIndex = 9;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(81, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 42);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 199);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 42);
            this.button12.TabIndex = 10;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(81, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 42);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(149, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 42);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(81, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.Productos.AutoScroll = true;
            this.Productos.Location = new System.Drawing.Point(12, 276);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(528, 196);
            this.Productos.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calculator", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbltotal.Location = new System.Drawing.Point(546, 325);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(379, 72);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "999.000.000.00";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Calculator", 48F, System.Drawing.FontStyle.Bold);
            this.lblcantidad.ForeColor = System.Drawing.Color.Red;
            this.lblcantidad.Location = new System.Drawing.Point(640, 400);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(59, 72);
            this.lblcantidad.TabIndex = 15;
            this.lblcantidad.Text = "0";
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Image = global::Sistema_Marcelo.Properties.Resources.icons8_refresh_48;
            this.btnupdate.Location = new System.Drawing.Point(548, 164);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 61);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = global::Sistema_Marcelo.Properties.Resources.delete_481;
            this.btneliminar.Location = new System.Drawing.Point(546, 86);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 61);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Image = global::Sistema_Marcelo.Properties.Resources.broom_80px1;
            this.btncancelar.Location = new System.Drawing.Point(546, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 61);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_Marcelo.Properties.Resources.open_box_80px;
            this.pictureBox3.Location = new System.Drawing.Point(548, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_Marcelo.Properties.Resources.money_100px;
            this.pictureBox2.Location = new System.Drawing.Point(546, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmtouch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 484);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.calculadora);
            this.Controls.Add(this.grilla);
            this.Name = "frmtouch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtouch";
            this.Load += new System.EventHandler(this.txtled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.calculadora.ResumeLayout(false);
            this.calculadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox calculadora;
        private System.Windows.Forms.TextBox txtled;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel Productos;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnupdate;
    }
}
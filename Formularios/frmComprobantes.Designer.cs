namespace Sistema_Marcelo.Formularios
{
    partial class frmComprobantes
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
            this.listnumbers = new System.Windows.Forms.ListBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnumeroventa = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnanular = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listnumbers
            // 
            this.listnumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listnumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listnumbers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listnumbers.FormattingEnabled = true;
            this.listnumbers.ItemHeight = 20;
            this.listnumbers.Location = new System.Drawing.Point(18, 54);
            this.listnumbers.Name = "listnumbers";
            this.listnumbers.Size = new System.Drawing.Size(264, 522);
            this.listnumbers.TabIndex = 0;
            this.listnumbers.SelectedIndexChanged += new System.EventHandler(this.listnumbers_SelectedIndexChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(18, 9);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(150, 31);
            this.txtnumero.TabIndex = 0;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
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
            this.grilla.Location = new System.Drawing.Point(288, 54);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(1017, 522);
            this.grilla.TabIndex = 6;
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
            // lblnumeroventa
            // 
            this.lblnumeroventa.AutoSize = true;
            this.lblnumeroventa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroventa.Location = new System.Drawing.Point(373, 9);
            this.lblnumeroventa.Name = "lblnumeroventa";
            this.lblnumeroventa.Size = new System.Drawing.Size(31, 32);
            this.lblnumeroventa.TabIndex = 8;
            this.lblnumeroventa.Text = "0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(540, 8);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 32);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_Marcelo.Properties.Resources.icons8_time_32;
            this.pictureBox3.Location = new System.Drawing.Point(756, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnanular
            // 
            this.btnanular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanular.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnanular.Image = global::Sistema_Marcelo.Properties.Resources.icons8_cancel_subscription_32;
            this.btnanular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanular.Location = new System.Drawing.Point(1051, 4);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(117, 41);
            this.btnanular.TabIndex = 12;
            this.btnanular.Text = "An. Venta";
            this.btnanular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnanular.UseVisualStyleBackColor = true;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // btnprint
            // 
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Image = global::Sistema_Marcelo.Properties.Resources.icons8_print_48;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(1174, 5);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(131, 41);
            this.btnprint.TabIndex = 11;
            this.btnprint.Text = "       Reimprimir";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_Marcelo.Properties.Resources.icons8_money_bag_321;
            this.pictureBox2.Location = new System.Drawing.Point(502, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Marcelo.Properties.Resources.numero_32;
            this.pictureBox1.Location = new System.Drawing.Point(335, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = global::Sistema_Marcelo.Properties.Resources.buscaricon_161;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(174, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(108, 31);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(794, 9);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(31, 32);
            this.lblfecha.TabIndex = 14;
            this.lblfecha.Text = "0";
            // 
            // frmComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 603);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnanular);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblnumeroventa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.listnumbers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComprobantes";
            this.Load += new System.EventHandler(this.frmComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listnumbers;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnumeroventa;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblfecha;
    }
}
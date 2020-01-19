namespace Sistema_Marcelo.Formularios
{
    partial class frmproductos
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
            this.tabproductos = new System.Windows.Forms.TabControl();
            this.tablistado = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.tabregistro = new System.Windows.Forms.TabPage();
            this.gbotones = new System.Windows.Forms.GroupBox();
            this.gdatos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtminimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmayorista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtbuscarcateogoria = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grillacategorias = new System.Windows.Forms.DataGridView();
            this.tabusers = new System.Windows.Forms.TabPage();
            this.gpermisos = new System.Windows.Forms.GroupBox();
            this.cantouch = new System.Windows.Forms.CheckBox();
            this.canmantenimiento = new System.Windows.Forms.CheckBox();
            this.cancomprobante = new System.Windows.Forms.CheckBox();
            this.canreporte = new System.Windows.Forms.CheckBox();
            this.canventa = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbuscarusuario = new System.Windows.Forms.TextBox();
            this.grillausuarios = new System.Windows.Forms.DataGridView();
            this.gdatosuser = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminarusuario = new System.Windows.Forms.Button();
            this.btnguardarusuario = new System.Windows.Forms.Button();
            this.tabproductos.SuspendLayout();
            this.tablistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.tabregistro.SuspendLayout();
            this.gbotones.SuspendLayout();
            this.gdatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.txtbuscarcateogoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillacategorias)).BeginInit();
            this.tabusers.SuspendLayout();
            this.gpermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillausuarios)).BeginInit();
            this.gdatosuser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabproductos
            // 
            this.tabproductos.Controls.Add(this.tablistado);
            this.tabproductos.Controls.Add(this.tabregistro);
            this.tabproductos.Controls.Add(this.txtbuscarcateogoria);
            this.tabproductos.Controls.Add(this.tabusers);
            this.tabproductos.Location = new System.Drawing.Point(2, 12);
            this.tabproductos.Name = "tabproductos";
            this.tabproductos.SelectedIndex = 0;
            this.tabproductos.Size = new System.Drawing.Size(874, 436);
            this.tabproductos.TabIndex = 0;
            // 
            // tablistado
            // 
            this.tablistado.Controls.Add(this.label1);
            this.tablistado.Controls.Add(this.txtbuscar);
            this.tablistado.Controls.Add(this.grilla);
            this.tablistado.Location = new System.Drawing.Point(4, 22);
            this.tablistado.Name = "tablistado";
            this.tablistado.Padding = new System.Windows.Forms.Padding(3);
            this.tablistado.Size = new System.Drawing.Size(866, 410);
            this.tablistado.TabIndex = 0;
            this.tablistado.Text = "Listado de Productos";
            this.tablistado.UseVisualStyleBackColor = true;
            this.tablistado.Click += new System.EventHandler(this.tablistado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Descripcion";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(189, 17);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(671, 27);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grilla.Location = new System.Drawing.Point(6, 50);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(854, 323);
            this.grilla.TabIndex = 0;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            this.grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellDoubleClick);
            // 
            // tabregistro
            // 
            this.tabregistro.Controls.Add(this.gbotones);
            this.tabregistro.Controls.Add(this.gdatos);
            this.tabregistro.Location = new System.Drawing.Point(4, 22);
            this.tabregistro.Name = "tabregistro";
            this.tabregistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabregistro.Size = new System.Drawing.Size(866, 410);
            this.tabregistro.TabIndex = 1;
            this.tabregistro.Text = "Registrar/Actualizar";
            this.tabregistro.UseVisualStyleBackColor = true;
            // 
            // gbotones
            // 
            this.gbotones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbotones.Controls.Add(this.btneliminar);
            this.gbotones.Controls.Add(this.btncancelar);
            this.gbotones.Controls.Add(this.btnguardar);
            this.gbotones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbotones.Location = new System.Drawing.Point(736, 27);
            this.gbotones.Name = "gbotones";
            this.gbotones.Size = new System.Drawing.Size(124, 352);
            this.gbotones.TabIndex = 1;
            this.gbotones.TabStop = false;
            this.gbotones.Text = "Opciones";
            // 
            // gdatos
            // 
            this.gdatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdatos.Controls.Add(this.label9);
            this.gdatos.Controls.Add(this.cmbcategoria);
            this.gdatos.Controls.Add(this.label10);
            this.gdatos.Controls.Add(this.panel1);
            this.gdatos.Controls.Add(this.label8);
            this.gdatos.Controls.Add(this.txtminimo);
            this.gdatos.Controls.Add(this.label7);
            this.gdatos.Controls.Add(this.txtstock);
            this.gdatos.Controls.Add(this.label6);
            this.gdatos.Controls.Add(this.txtmayorista);
            this.gdatos.Controls.Add(this.label5);
            this.gdatos.Controls.Add(this.txtprecio);
            this.gdatos.Controls.Add(this.label4);
            this.gdatos.Controls.Add(this.txtcosto);
            this.gdatos.Controls.Add(this.label3);
            this.gdatos.Controls.Add(this.txtdescripcion);
            this.gdatos.Controls.Add(this.label2);
            this.gdatos.Controls.Add(this.txtcodigo);
            this.gdatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gdatos.Location = new System.Drawing.Point(6, 27);
            this.gdatos.Name = "gdatos";
            this.gdatos.Size = new System.Drawing.Size(724, 352);
            this.gdatos.TabIndex = 0;
            this.gdatos.TabStop = false;
            this.gdatos.Text = "Datos del Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Categoria";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbcategoria.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(124, 262);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(209, 27);
            this.cmbcategoria.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Bar Code.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Location = new System.Drawing.Point(446, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 74);
            this.panel1.TabIndex = 15;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("barcode font", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(3, 4);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(83, 65);
            this.lblcodigo.TabIndex = 14;
            this.lblcodigo.Text = "12345";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Minimo";
            // 
            // txtminimo
            // 
            this.txtminimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtminimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtminimo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminimo.ForeColor = System.Drawing.Color.Blue;
            this.txtminimo.Location = new System.Drawing.Point(450, 215);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(209, 27);
            this.txtminimo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.ForeColor = System.Drawing.Color.Blue;
            this.txtstock.Location = new System.Drawing.Point(124, 215);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(209, 27);
            this.txtstock.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mayorista";
            // 
            // txtmayorista
            // 
            this.txtmayorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmayorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmayorista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmayorista.ForeColor = System.Drawing.Color.Blue;
            this.txtmayorista.Location = new System.Drawing.Point(525, 150);
            this.txtmayorista.Name = "txtmayorista";
            this.txtmayorista.Size = new System.Drawing.Size(134, 27);
            this.txtmayorista.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.Color.Blue;
            this.txtprecio.Location = new System.Drawing.Point(329, 150);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(107, 27);
            this.txtprecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo";
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcosto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.ForeColor = System.Drawing.Color.Blue;
            this.txtcosto.Location = new System.Drawing.Point(124, 150);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(140, 27);
            this.txtcosto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.Blue;
            this.txtdescripcion.Location = new System.Drawing.Point(124, 95);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(535, 27);
            this.txtdescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod. Barras";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Blue;
            this.txtcodigo.Location = new System.Drawing.Point(124, 38);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(535, 27);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtbuscarcateogoria
            // 
            this.txtbuscarcateogoria.Controls.Add(this.label12);
            this.txtbuscarcateogoria.Controls.Add(this.txtcategoria);
            this.txtbuscarcateogoria.Controls.Add(this.label11);
            this.txtbuscarcateogoria.Controls.Add(this.textBox1);
            this.txtbuscarcateogoria.Controls.Add(this.grillacategorias);
            this.txtbuscarcateogoria.Controls.Add(this.btnsave);
            this.txtbuscarcateogoria.Controls.Add(this.btndelete);
            this.txtbuscarcateogoria.Location = new System.Drawing.Point(4, 22);
            this.txtbuscarcateogoria.Name = "txtbuscarcateogoria";
            this.txtbuscarcateogoria.Padding = new System.Windows.Forms.Padding(3);
            this.txtbuscarcateogoria.Size = new System.Drawing.Size(866, 410);
            this.txtbuscarcateogoria.TabIndex = 2;
            this.txtbuscarcateogoria.Text = "Categoria";
            this.txtbuscarcateogoria.UseVisualStyleBackColor = true;
            this.txtbuscarcateogoria.Click += new System.EventHandler(this.txtbuscarcateogoria_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nuevo";
            // 
            // txtcategoria
            // 
            this.txtcategoria.BackColor = System.Drawing.Color.Silver;
            this.txtcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.ForeColor = System.Drawing.Color.Black;
            this.txtcategoria.Location = new System.Drawing.Point(261, 294);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(265, 26);
            this.txtcategoria.TabIndex = 7;
            this.txtcategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(187, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(261, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grillacategorias
            // 
            this.grillacategorias.AllowUserToAddRows = false;
            this.grillacategorias.AllowUserToDeleteRows = false;
            this.grillacategorias.BackgroundColor = System.Drawing.Color.White;
            this.grillacategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillacategorias.Location = new System.Drawing.Point(261, 86);
            this.grillacategorias.Name = "grillacategorias";
            this.grillacategorias.ReadOnly = true;
            this.grillacategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillacategorias.Size = new System.Drawing.Size(265, 202);
            this.grillacategorias.TabIndex = 0;
            // 
            // tabusers
            // 
            this.tabusers.Controls.Add(this.btnlimpiar);
            this.tabusers.Controls.Add(this.gdatosuser);
            this.tabusers.Controls.Add(this.btneliminarusuario);
            this.tabusers.Controls.Add(this.btnguardarusuario);
            this.tabusers.Controls.Add(this.gpermisos);
            this.tabusers.Controls.Add(this.label13);
            this.tabusers.Controls.Add(this.txtbuscarusuario);
            this.tabusers.Controls.Add(this.grillausuarios);
            this.tabusers.Location = new System.Drawing.Point(4, 22);
            this.tabusers.Name = "tabusers";
            this.tabusers.Padding = new System.Windows.Forms.Padding(3);
            this.tabusers.Size = new System.Drawing.Size(866, 410);
            this.tabusers.TabIndex = 3;
            this.tabusers.Text = "Usuarios";
            this.tabusers.UseVisualStyleBackColor = true;
            // 
            // gpermisos
            // 
            this.gpermisos.Controls.Add(this.cantouch);
            this.gpermisos.Controls.Add(this.canmantenimiento);
            this.gpermisos.Controls.Add(this.cancomprobante);
            this.gpermisos.Controls.Add(this.canreporte);
            this.gpermisos.Controls.Add(this.canventa);
            this.gpermisos.Location = new System.Drawing.Point(305, 124);
            this.gpermisos.Name = "gpermisos";
            this.gpermisos.Size = new System.Drawing.Size(375, 71);
            this.gpermisos.TabIndex = 14;
            this.gpermisos.TabStop = false;
            this.gpermisos.Text = "PERMISOS";
            // 
            // cantouch
            // 
            this.cantouch.AutoSize = true;
            this.cantouch.Location = new System.Drawing.Point(6, 42);
            this.cantouch.Name = "cantouch";
            this.cantouch.Size = new System.Drawing.Size(125, 17);
            this.cantouch.TabIndex = 4;
            this.cantouch.Text = "Ventas Tactil(Touch)";
            this.cantouch.UseVisualStyleBackColor = true;
            // 
            // canmantenimiento
            // 
            this.canmantenimiento.AutoSize = true;
            this.canmantenimiento.Location = new System.Drawing.Point(246, 19);
            this.canmantenimiento.Name = "canmantenimiento";
            this.canmantenimiento.Size = new System.Drawing.Size(95, 17);
            this.canmantenimiento.TabIndex = 3;
            this.canmantenimiento.Text = "Mantenimiento";
            this.canmantenimiento.UseVisualStyleBackColor = true;
            // 
            // cancomprobante
            // 
            this.cancomprobante.AutoSize = true;
            this.cancomprobante.Location = new System.Drawing.Point(146, 19);
            this.cancomprobante.Name = "cancomprobante";
            this.cancomprobante.Size = new System.Drawing.Size(94, 17);
            this.cancomprobante.TabIndex = 2;
            this.cancomprobante.Text = "Comprobantes";
            this.cancomprobante.UseVisualStyleBackColor = true;
            // 
            // canreporte
            // 
            this.canreporte.AutoSize = true;
            this.canreporte.Location = new System.Drawing.Point(71, 19);
            this.canreporte.Name = "canreporte";
            this.canreporte.Size = new System.Drawing.Size(69, 17);
            this.canreporte.TabIndex = 1;
            this.canreporte.Text = "Reportes";
            this.canreporte.UseVisualStyleBackColor = true;
            // 
            // canventa
            // 
            this.canventa.AutoSize = true;
            this.canventa.Location = new System.Drawing.Point(6, 19);
            this.canventa.Name = "canventa";
            this.canventa.Size = new System.Drawing.Size(59, 17);
            this.canventa.TabIndex = 0;
            this.canventa.Text = "Ventas";
            this.canventa.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(51, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Buscar Usuario";
            // 
            // txtbuscarusuario
            // 
            this.txtbuscarusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarusuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarusuario.Location = new System.Drawing.Point(155, 223);
            this.txtbuscarusuario.Name = "txtbuscarusuario";
            this.txtbuscarusuario.Size = new System.Drawing.Size(672, 23);
            this.txtbuscarusuario.TabIndex = 4;
            this.txtbuscarusuario.TextChanged += new System.EventHandler(this.txtbuscarusuario_TextChanged);
            // 
            // grillausuarios
            // 
            this.grillausuarios.AllowUserToAddRows = false;
            this.grillausuarios.AllowUserToDeleteRows = false;
            this.grillausuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grillausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillausuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grillausuarios.Location = new System.Drawing.Point(54, 256);
            this.grillausuarios.Name = "grillausuarios";
            this.grillausuarios.ReadOnly = true;
            this.grillausuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillausuarios.Size = new System.Drawing.Size(773, 138);
            this.grillausuarios.TabIndex = 3;
            this.grillausuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillausuarios_CellClick);
            this.grillausuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillausuarios_CellContentClick);
            // 
            // gdatosuser
            // 
            this.gdatosuser.Controls.Add(this.label17);
            this.gdatosuser.Controls.Add(this.txtcontraseña);
            this.gdatosuser.Controls.Add(this.label16);
            this.gdatosuser.Controls.Add(this.txtusuario);
            this.gdatosuser.Controls.Add(this.label15);
            this.gdatosuser.Controls.Add(this.txtapellido);
            this.gdatosuser.Controls.Add(this.label14);
            this.gdatosuser.Controls.Add(this.txtnombre);
            this.gdatosuser.Location = new System.Drawing.Point(155, 6);
            this.gdatosuser.Name = "gdatosuser";
            this.gdatosuser.Size = new System.Drawing.Size(525, 112);
            this.gdatosuser.TabIndex = 17;
            this.gdatosuser.TabStop = false;
            this.gdatosuser.Text = "DATOS DEL USUARIO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(283, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 18);
            this.label17.TabIndex = 21;
            this.label17.Text = "CONTRASEÑA";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontraseña.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(378, 77);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(134, 23);
            this.txtcontraseña.TabIndex = 20;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(67, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "USUARIO";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(137, 77);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(140, 23);
            this.txtusuario.TabIndex = 18;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Apellido Completo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(137, 48);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(375, 23);
            this.txtapellido.TabIndex = 16;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nombre Completo";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(137, 19);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(375, 23);
            this.txtnombre.TabIndex = 14;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = global::Sistema_Marcelo.Properties.Resources.icons8_delete_481;
            this.btneliminar.Location = new System.Drawing.Point(6, 155);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 62);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Image = global::Sistema_Marcelo.Properties.Resources.icons8_cancel_2_48;
            this.btncancelar.Location = new System.Drawing.Point(6, 87);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(112, 62);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Image = global::Sistema_Marcelo.Properties.Resources.icons8_save_48;
            this.btnguardar.Location = new System.Drawing.Point(6, 19);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(112, 62);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsave
            // 
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Image = global::Sistema_Marcelo.Properties.Resources.icons8_refresh_16;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(551, 124);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 32);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Gurdar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Image = global::Sistema_Marcelo.Properties.Resources.icons8_close_window_16;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(551, 86);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 32);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.Image = global::Sistema_Marcelo.Properties.Resources.icons8_document_48;
            this.btnlimpiar.Location = new System.Drawing.Point(715, 149);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(112, 62);
            this.btnlimpiar.TabIndex = 18;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminarusuario
            // 
            this.btneliminarusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarusuario.Image = global::Sistema_Marcelo.Properties.Resources.icons8_delete_481;
            this.btneliminarusuario.Location = new System.Drawing.Point(715, 81);
            this.btneliminarusuario.Name = "btneliminarusuario";
            this.btneliminarusuario.Size = new System.Drawing.Size(112, 62);
            this.btneliminarusuario.TabIndex = 16;
            this.btneliminarusuario.UseVisualStyleBackColor = true;
            this.btneliminarusuario.Click += new System.EventHandler(this.btneliminarusuario_Click);
            // 
            // btnguardarusuario
            // 
            this.btnguardarusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarusuario.Image = global::Sistema_Marcelo.Properties.Resources.icons8_save_48;
            this.btnguardarusuario.Location = new System.Drawing.Point(715, 13);
            this.btnguardarusuario.Name = "btnguardarusuario";
            this.btnguardarusuario.Size = new System.Drawing.Size(112, 62);
            this.btnguardarusuario.TabIndex = 15;
            this.btnguardarusuario.UseVisualStyleBackColor = true;
            this.btnguardarusuario.Click += new System.EventHandler(this.btnguardarusuario_Click);
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 460);
            this.Controls.Add(this.tabproductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmproductos";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            this.tabproductos.ResumeLayout(false);
            this.tablistado.ResumeLayout(false);
            this.tablistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.tabregistro.ResumeLayout(false);
            this.gbotones.ResumeLayout(false);
            this.gdatos.ResumeLayout(false);
            this.gdatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txtbuscarcateogoria.ResumeLayout(false);
            this.txtbuscarcateogoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillacategorias)).EndInit();
            this.tabusers.ResumeLayout(false);
            this.tabusers.PerformLayout();
            this.gpermisos.ResumeLayout(false);
            this.gpermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillausuarios)).EndInit();
            this.gdatosuser.ResumeLayout(false);
            this.gdatosuser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabproductos;
        private System.Windows.Forms.TabPage tablistado;
        private System.Windows.Forms.TabPage tabregistro;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox gbotones;
        private System.Windows.Forms.GroupBox gdatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtminimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmayorista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TabPage txtbuscarcateogoria;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grillacategorias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TabPage tabusers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbuscarusuario;
        private System.Windows.Forms.DataGridView grillausuarios;
        private System.Windows.Forms.GroupBox gpermisos;
        private System.Windows.Forms.CheckBox canreporte;
        private System.Windows.Forms.CheckBox canventa;
        private System.Windows.Forms.CheckBox cancomprobante;
        private System.Windows.Forms.CheckBox cantouch;
        private System.Windows.Forms.CheckBox canmantenimiento;
        private System.Windows.Forms.Button btneliminarusuario;
        private System.Windows.Forms.Button btnguardarusuario;
        private System.Windows.Forms.GroupBox gdatosuser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnlimpiar;
    }
}
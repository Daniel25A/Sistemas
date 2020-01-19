using Sistema_Marcelo.Data;
using Sistema_Marcelo.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Marcelo.Formularios
{
    public partial class frmproductos : Form
    {
        public frmproductos()
        {
            InitializeComponent();
        }
        //Mensajes
        string isCodigoBalanza = "El Codigo que esta Ingresando podria corresponder al codigo de una balanza, Asegurese de  ingresar otro tipo de codigo de barras",
               isEmptyControls = "Asegurese que todos los campos no esten vacios",
               isCostoMayorPrecioCompra = "Asegurese que el precio de costo no sea mayor que el precio a vender";
               
        private void frmproductos_Load(object sender, EventArgs e)
        {
            LoadStartedData();
            LoadCategorias();
            cargarGrillaCategorias();
            Data.Usuarios.CargarGrilla(grillausuarios);
        }
        #region Usuarios
        //check empty Controls...
        private bool ControlesVacios()
        {
            bool Vacio = false;
            foreach(TextBox control in gdatosuser.Controls.OfType<TextBox>().Where(x => x.Text == string.Empty))
            {
                Vacio = true;
            }
            return Vacio;
        }
        private void LimpiarControles()
        {
            foreach (TextBox control in gdatosuser.Controls.OfType<TextBox>().Where(x => x.Text != string.Empty))
            {
                control.Text = string.Empty;
            }
            txtnombre.Focus();
            foreach(CheckBox chk in gpermisos.Controls.OfType<CheckBox>().Where(x => x.Checked))
            {
                chk.Checked = false;
            }
        }
        #endregion
        //Fast Code
        void LoadCategorias()
        {
            if (cmbcategoria.Items.Count != 0) cmbcategoria.Items.Clear();
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                //Lo Hago de esta forma, ya que si le pongo como datasource, al hacer Dispose, se me van a borrar todos los datos
                // del ComboBox
                foreach (var item in db.Table<Entidades.Categoria>())
                    cmbcategoria.Items.Add(item.Name);
            }
        }
        void Limpiar()
        {
            foreach (var control in gdatos.Controls.OfType<TextBox>().Where(x => x.Text != string.Empty))
            {
                control.Clear();
            }
            tabproductos.SelectTab(0);
        }
        void LoadStartedData()
        {
            this.Text = ".:. Mantenimiento del Sistema .:.";
            CargarGrilla();
            txtprecio.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            txtcosto.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            txtmayorista.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            txtstock.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            txtminimo.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            btnguardar.Click += (a, b) => SaveProductos();
            txtbuscar.TextChanged += (a, b) => CargarGrilla((a as TextBox).Text);
        }
        void CargarGrilla(string Criterio="")
        {
            if (Criterio != string.Empty)
                Productos.CargarGrilla(grilla, true, Criterio);
            else
                Productos.CargarGrilla(grilla);
        }
        void SaveProductos()
        {
            int Contador = 0;
            foreach(var control in gdatos.Controls.OfType<Control>().Where(x => (x is TextBox || x is ComboBox) && x.Text == string.Empty))
            {
                Contador++;
            }
            if (Contador > 0)
            {
                MessageBox.Show(isEmptyControls, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (decimal.Parse(txtcosto.Text.Trim()) > (decimal.Parse(txtprecio.Text.Trim())))
            {
                MessageBox.Show(isCostoMayorPrecioCompra, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtcodigo.Text.StartsWith("2"))
            {
                MessageBox.Show(isCodigoBalanza, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodigo.Clear();
                txtcodigo.Focus();
                return;
            }
            Productos.SaveProductos(txtcodigo.Text, txtdescripcion.Text, decimal.Parse(txtcosto.Text),
                decimal.Parse(txtprecio.Text), decimal.Parse(txtmayorista.Text), int.Parse(txtstock.Text), int.Parse(txtminimo.Text),cmbcategoria.Text);
            CargarGrilla();
        }
        private void tablistado_Click(object sender, EventArgs e)
        {

        }

        private void grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = grilla.Rows[e.RowIndex];
                txtcodigo.Text = data.Cells[1].Value.ToString();
                txtdescripcion.Text = data.Cells[2].Value.ToString();
                txtcosto.Text = data.Cells[3].Value.ToString();
                txtprecio.Text = data.Cells[4].Value.ToString();
                txtmayorista.Text = data.Cells[5].Value.ToString();
                txtstock.Text = data.Cells[6].Value.ToString();
                txtminimo.Text = data.Cells[7].Value.ToString();
                cmbcategoria.Text= data.Cells[8].Value.ToString(); 
                tabproductos.SelectTab(1);
            }
            catch (Exception)
            {
                MessageBox.Show("Vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Productos.EliminarProducto(txtcodigo);
            Limpiar();
            CargarGrilla();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty)
                lblcodigo.Text = "123456789";
            else
                lblcodigo.Text = (sender as TextBox).Text;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) => cargarGrillaCategorias((sender as TextBox).Text);
        void cargarGrillaCategorias(string criterio="")
        {
            var db = new SQLiteConnection(AppConfig.UrlDataBase);
            if (criterio == string.Empty)
            {
                grillacategorias.DataSource = db.Table<Entidades.Categoria>().Select(x=> new {ID=x.id,NOMBRE=x.Name }).ToList();
            }
            else
            {
                grillacategorias.DataSource = db.Table<Entidades.Categoria>().Where(n=>n.Name.ToLower().Contains(criterio.ToLower()))
                .Select(x => new {
                    ID = x.id,
                    NOMBRE = x.Name
                }).ToList();
            }
           
          
        }
        void CargarDatos(string Criterio = "")
        {
            if (Criterio != string.Empty)
                Productos.CargarGrilla(grilla, true, Criterio);
            else
                Productos.CargarGrilla(grilla);
        }

        private void txtbuscarcateogoria_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e) => GuardarCategoria();
        void GuardarCategoria()
        {
            if (txtcategoria.Text == string.Empty) return;
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var temp = new Entidades.Categoria();
                temp.Name = txtcategoria.Text;
                db.Insert(temp, typeof(Entidades.Categoria));
            }
            cargarGrillaCategorias();
            txtcategoria.Text = string.Empty;
            LoadCategorias();
        }

        private void btndelete_Click(object sender, EventArgs e) => EliminarCategoria();

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            Data.Usuarios.GuardarUsuario(txtnombre.Text, txtapellido.Text,
                txtusuario.Text, txtcontraseña.Text,
                canventa.Checked ? 1 : 0,
                canreporte.Checked ? 1 : 0,
                cancomprobante.Checked ? 1 : 0,
                canmantenimiento.Checked ? 1 : 0,
                cantouch.Checked ? 1 : 0);
            Data.Usuarios.CargarGrilla(grillausuarios);
        }

        private void txtbuscarusuario_TextChanged(object sender, EventArgs e) => Usuarios.CargarGrilla(grillausuarios, (sender as TextBox).Text);

        private void grillausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btneliminarusuario_Click(object sender, EventArgs e)
        {
            Usuarios.EliminarUsuario(txtusuario.Text);
            Usuarios.CargarGrilla(grillausuarios);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void grillausuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtnombre.Text = grillausuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtapellido.Text = grillausuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtusuario.Text = grillausuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtcontraseña.Text = grillausuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                canventa.Checked = grillausuarios.Rows[e.RowIndex].Cells[5].Value.ToString() == "1" ? true : false;
                canreporte.Checked = grillausuarios.Rows[e.RowIndex].Cells[6].Value.ToString() == "1" ? true : false;
                cancomprobante.Checked = grillausuarios.Rows[e.RowIndex].Cells[7].Value.ToString() == "1" ? true : false;
                canmantenimiento.Checked = grillausuarios.Rows[e.RowIndex].Cells[8].Value.ToString() == "1" ? true : false;
                cantouch.Checked = grillausuarios.Rows[e.RowIndex].Cells[9].Value.ToString() == "1" ? true : false;

            }
            catch (Exception)
            {
                MessageBox.Show("Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EliminarCategoria()
        {
            try
            {
                if (grillacategorias.Rows.Count == 0) return;
                var ID = int.Parse(grillacategorias.Rows[grillacategorias.CurrentRow.Index].Cells[0].Value.ToString());
                using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var item = db.Table<Entidades.Categoria>().First(x => x.id == ID);
                    db.Delete(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegurece de seleccionar el elemento a eliminar\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cargarGrillaCategorias();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

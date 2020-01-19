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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.Text = "Iniciar Sesion";
            txtcontraseña.KeyPress += (a, b) => { if (b.KeyChar == Convert.ToChar(Keys.Enter)) btnlogin.PerformClick(); };
            CargarUsuarios();
        }
        void CargarUsuarios()
        {
            Data.Usuarios.CargarUsuarios(cmbusuarios);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtcontraseña.Text==string.Empty || cmbusuarios.Text == string.Empty)
            {
                MessageBox.Show("Ingrese los datos de inicio de sesion correctamente", "Atencion Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Data.Usuarios.IniciarSesion(cmbusuarios.Text, txtcontraseña.Text))
            {
                using(var venta= new frmInicio())
                {
                    venta.CurrentUser = (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Usuarios>()
                        .First(x => x.Usuario == cmbusuarios.Text && x.Password == txtcontraseña.Text);

                    venta.ShowDialog();
                    this.Close();
                }
            }
            else { MessageBox.Show("Usuario o contraseña incorrectos", "Atencion Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

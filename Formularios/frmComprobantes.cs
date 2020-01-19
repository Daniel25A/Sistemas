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
    public partial class frmComprobantes : Form
    {
        public frmComprobantes()
        {
            InitializeComponent();
        }

        private void frmComprobantes_Load(object sender, EventArgs e)
        {
            LoadHandlers().LoadCOnfig();
        }
        frmComprobantes LoadHandlers()
        {
            listnumbers.DataSource = Data.Reportes.GetNumbers();
            return this;
        }
        public void LoadCOnfig()
        {
            this.Text = "Gestion de Comprobantes";
        }

        private void listnumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grilla.Rows.Clear();
            try
            {
                Data.Reportes.GetInfo(grilla, int.Parse(listnumbers.Items[listnumbers.SelectedIndex].ToString()), lblnumeroventa, lbltotal,lblfecha);
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog(ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text == string.Empty)
            {
                listnumbers.DataSource = Data.Reportes.GetNumbers();
                txtnumero.Focus();
                return;
            }
            listnumbers.DataSource = Data.Reportes.GetNumbers(int.Parse(txtnumero.Text));
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnbuscar.PerformClick();
        }
        void Reimprimir()
        {
            try
            {
                int numero = int.Parse(listnumbers.Items[listnumbers.SelectedIndex].ToString());
                using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var temp = db.Table<Entidades.Ventas>().First(x => x.numeroVenta == numero);
                    Utilidades.ImprimirTicket.CrearTicket(ref grilla, temp.Total, temp.Entrega, grilla.Rows.Cast<DataGridViewRow>().Where(x=>x.Cells[0].Value.ToString().Length>6)
                        .Sum(x => decimal.Parse(x.Cells[2].Value.ToString())), numero, temp.Fecha, true);
                }
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog(ex.Message);
            }
        }
        void AnularVenta()
        {
            try
            {
                int numero = int.Parse(listnumbers.Items[listnumbers.SelectedIndex].ToString());
                if(MessageBox.Show("¿Quieres Devolver Los Productos a Inventario?","Atención Usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach(var Item in grilla.Rows.Cast<DataGridViewRow>().Select(g=>
                    new { Codigo=g.Cells[0].Value.ToString(),Cantidad=float.Parse(g.Cells[2].Value.ToString())}))
                    {
                        Data.Productos.DevolverInventario(Item.Codigo, (int)Item.Cantidad);
                    }
                }
                Data.Ventas.AnularVenta(numero);
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog(ex.Message);
            }
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            Reimprimir();
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            AnularVenta();
            LoadHandlers();
        }
    }
}

using Sistema_Marcelo.Data;
using Sistema_Marcelo.Entidades;
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

namespace Sistema_Marcelo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        public Entidades.Usuarios CurrentUser { get; set; } = null;
        private decimal total { get; set; }
        private decimal cantidad { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                VerificarPermisos();
            }
            AppConfig.CheckTables();
            LoadHandlers();
        }
        void VerificarPermisos()
        {
            if (CurrentUser.Venta == 0)
            {
                btnpagar.Enabled = false;
                btnmarcar.Enabled = false;
                button1.Enabled = false;
            }
            if (CurrentUser.Reporte == 0)
            {
                btnreportes.Enabled = false;
            }
            if (CurrentUser.Touch == 0)
            {
                btntouch.Enabled = false;
            }
            if (CurrentUser.Comprobantes == 0)
            {
                btntickets.Enabled = false;
            }
            if (CurrentUser.Mantenimiento == 0)
            {
                btnproductos.Enabled = false;
            }
        }
        private void LoadHandlers()
        {
            txtcodigobarras.KeyPress += (a,b) => {
                if (b.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnmarcar.PerformClick();
                }
            };
            lbltotal.Text = "$0.00";
            lblcantidad.Text = "0.00";
            this.Text = "Inicio Sistema - Ventas";
        }

        private void btnmarcar_Click_1(object sender, EventArgs e)
        {
            if (Data.Ventas.CheckCaja())
            {
                MessageBox.Show("La Caja ya esta Cerrada, Las Ventas de hoy ya estan Suspendidas", "Atención Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Productos.getProducto(txtcodigobarras, ref grilla);
            CalcularValores();
        }
        private void DeleteRow()
        {
            if (grilla.Rows.Count == 0) return;
            try
            {
                Int32 index = grilla.CurrentRow.Index;
                DataGridViewRow fila = grilla.Rows[index];
                var msg = $"¿Desea Remover el Siguiente Produco?\n" +
                    $"Codigo: {fila.Cells[0].Value} Descripción:{fila.Cells[1].Value} Precio:{fila.Cells[3].Value}";
                if (MessageBox.Show(msg, "Atención Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                grilla.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog(ex.Message);
            }
        }
        private void CalcularValores()
        {
            if (grilla.Rows.Count == 0)
            {
                cantidad = 0;
                total = 0;
                lblcantidad.Text = "0.00";
                lbltotal.Text = "$0.00";
            }
            else
            {
                total = grilla.Rows.Cast<DataGridViewRow>().Sum(x => decimal.Parse(x.Cells[4].Value.ToString()));
                cantidad = grilla.Rows.Cast<DataGridViewRow>().Sum(x => decimal.Parse(x.Cells[2].Value.ToString()));
                lbltotal.Text = total.ToString("###,###,###.00");
                lblcantidad.Text = cantidad.ToString("######.00");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteRow();
            CalcularValores();
            txtcodigobarras.Focus();
        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }
        private frmInicio RefreshNumeroVenta()
        {
            ImprimirTicket.UpdateNumVenta();
            return this;
        }
        private frmInicio PrintTicket(decimal total,decimal cantidad,decimal entrega)
        {
            Data.Ventas.SaveVenta(ImprimirTicket.GetNumberVenta(), total, entrega, DateTime.Now.ToShortDateString() + "|" + DateTime.Now.ToShortTimeString());
            ImprimirTicket.CrearTicket(ref grilla, total, entrega, cantidad);
                return this;
        }
            private frmInicio Limpiar()
        {
            grilla.Rows.Clear();
            return this;
        }
        private void btnpagar_Click(object sender, EventArgs e)
        {
            if (grilla.Rows.Count == 0)
            {
                txtcodigobarras.Focus();
                return;
            }
            using(var pago= new Formularios.frmpagar(total))
            {
                pago.ShowDialog();
                if (pago.DialogResult == DialogResult.OK)
                {
                    cantidad = grilla.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString().Length > 6)
                  .Sum(x => decimal.Parse(x.Cells[2].Value.ToString()));
                    PrintTicket(total, cantidad, pago.entrega);
                    RefreshNumeroVenta();
                    Limpiar();
                    CalcularValores();
                }
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            using(var menu= new Formularios.frmmenureporte())
            {
                menu.ShowDialog();
            }
        }

        private void btntickets_Click(object sender, EventArgs e)
        {
            using(var boletas=new Formularios.frmComprobantes())
            {
                boletas.ShowDialog();
            }
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            using (var productos = new Formularios.frmproductos())
                productos.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Desea Salir del Sistema?", "Atencion Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btntouch_Click(object sender, EventArgs e)
        {
            using(var touch= new Formularios.frmtouch())
            {
                touch.ShowDialog();
            }
        }
    }
}

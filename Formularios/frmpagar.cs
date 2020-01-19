using Sistema_Marcelo.Utilidades;
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
    public partial class frmpagar : Form
    {
        public frmpagar()
        {
            InitializeComponent();
        }
        private decimal totalPagar=0;
        public decimal entrega = 0;
        public frmpagar(decimal total)
        {
            InitializeComponent();
            this.totalPagar = total;
            lbltotal.Text = totalPagar.ToString("###,###,###.00");
        }
        private void frmpagar_Load(object sender, EventArgs e)
        {
            LoadHandlers();
        
        }
        private void LoadHandlers()
        {
            foreach(var x in gbuttons.Controls.OfType<PictureBox>().Where(x=>x.Name.Contains("btn")))
            {
                x.Click += (a, b) => { txtentrega.Text += (a as PictureBox).Tag.ToString(); };
            }
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            if (txtentrega.Text == string.Empty) return;
            try
            {
                txtentrega.Text = txtentrega.Text.Substring(0, txtentrega.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                txtentrega.Clear();
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            txtentrega.Clear();
        }

        private void txtentrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnpagar.PerformClick();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            if (txtentrega.Text == string.Empty)
            {
                txtentrega.Focus();
                return;
            }
            entrega = decimal.Parse(txtentrega.Text);
            lblcambio.Text = (entrega - totalPagar).ToString("###,###,###.00");
            var mensaje = $"Total de Ventas:{totalPagar.ToString("###,###,###.00")}\n" +
                $"Entrega:{entrega.ToString("###,###,###.00")}\n" +
                $"Cambio:{lblcambio.Text}";
            MessageBox.Show(mensaje, "¡Venta Con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void txtentrega_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

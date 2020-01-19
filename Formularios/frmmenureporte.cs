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
    public partial class frmmenureporte : Form
    {
        public frmmenureporte()
        {
            InitializeComponent();
        }

        private void frmmenureporte_Load(object sender, EventArgs e)
        {
            this.Text = "Reportes";
        }

        private void btncaja_Click(object sender, EventArgs e)
        {
            using(var caja=new Formularios.frmcortecaja())
            {
                caja.ShowDialog();
            }
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            using(var ventas=new Formularios.frmReporteVentas())
            {
                ventas.ShowDialog();
            }
        }
    }
}

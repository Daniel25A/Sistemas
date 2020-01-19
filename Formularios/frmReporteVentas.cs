using Sistema_Marcelo.Data;
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
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas.ReporteVentas(grilla, datedesde.Value.ToShortDateString(), datehasta.Value.ToShortDateString());
            Calcular();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            LoadConfig();
            
        }
        void Calcular()
        {
            if (grilla.Rows.Count == 0)
                LoadConfig();
            else
            {
                var Total = grilla.Rows.Cast<DataGridViewRow>().Sum(x => double.Parse(x.Cells[2].Value.ToString()));
                var Cantidad = grilla.Rows.Count;
                lbltotal.Text = Total.ToString("###,###,###.00");
                lblcantventas.Text = Cantidad.ToString();
            }
        }
        void LoadConfig()
        {
            this.Text = "Consulta de Ventas por Rango de Fecha";
            lblcantventas.Text = "0.00";
            lbltotal.Text = "$0.00";
        }
    }
}

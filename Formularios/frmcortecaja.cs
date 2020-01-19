using Sistema_Marcelo.Data;
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
    public partial class frmcortecaja : Form
    {
        public frmcortecaja()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmcortecaja_Load(object sender, EventArgs e)
        {
            if (Ventas.CheckCaja())
            {
                Ventas.EstadoDeCaja(false, lblestado);
                btncerrar.Enabled = false;
                return;
            }
            StartedConfig();
          
        }
        void StartedConfig()
        {
            this.Text = $"Corte de Caja del Dia {DateTime.Now.ToShortDateString()}";
            Ventas.EstadoCaja(lblestado, lblcantventas, lblcantart, lblefectivo, lblbeneficios);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Reportes.CorteCaja.CrearReport(AppConfig.Totalventas, AppConfig.CantArtVendidos, AppConfig.Ganacias);
        }
    }
}

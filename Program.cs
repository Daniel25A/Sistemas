using Sistema_Marcelo.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Marcelo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var Formato = $"{AppConfig.FechadeValido.ToString().Substring(0, 2)}" +
            //    $"/{AppConfig.FechadeValido.ToString().Substring(2, 2)}" +
            //    $"/{AppConfig.FechadeValido.ToString().Substring(4, 4)}";
            //if (Formato == DateTime.Now.ToShortDateString())
            //{
            //    MessageBox.Show("Su Licencia ha Expirado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.frmlogin());
            
        }
    }
}

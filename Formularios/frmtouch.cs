using Sistema_Marcelo.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sistema_Marcelo.Formularios
{
    public partial class frmtouch : Form
    {
        public frmtouch()
        {
            InitializeComponent();
        }
        decimal total = 0; int cantidad = 0;
        private void txtled_Load(object sender, EventArgs e)
        {
            LoadHandlersButtons();
            LoadProductos();
            StartedConfig();
            this.Text = "TOUCH - Sistema de punto de Venta";
        }
        private frmtouch PrintTicket(decimal total, decimal cantidad, decimal entrega)
        {
            Data.Ventas.SaveVenta(ImprimirTicket.GetNumberVenta(), total, entrega, DateTime.Now.ToShortDateString() + "|" + DateTime.Now.ToShortTimeString());
            ImprimirTicket.CrearTicketTouch(ref grilla, total, entrega, cantidad);
            return this;
        }
        private frmtouch RefreshNumeroVenta()
        {
            ImprimirTicket.UpdateNumVenta();
            return this;
        }
        void CancelarVenta()
        {
            grilla.Rows.Clear();
            CalcularValoresdeGrilla();
            txtled.Text = string.Empty;
        }
        void PagarVenta()
        {
            try
            {
                if (grilla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Ninguna venta en curso", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtled.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el Valor para Pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(decimal.TryParse(txtled.Text,out var entrega))
                {
                    if (entrega < total)
                    {
                        MessageBox.Show("Por favor, Ingrese un pago correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var mensaje = $"Total de Ventas:{total.ToString("###,###,###.00")}\n" +
                                  $"Entrega:{entrega.ToString("###,###,###.00")}\n" +
                                  $"Cambio:{(entrega-total).ToString("###,###,###.00")}";
                    MessageBox.Show(mensaje, "¡Venta Con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrintTicket(total, cantidad, entrega).RefreshNumeroVenta().CancelarVenta();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadHandlersButtons()
        {
            foreach(var x in calculadora.Controls.OfType<Button>())
            {
                x.Cursor = Cursors.Hand;
                if (x.Text.ToLower() == "c")
                {
                    x.Click += (a, b) => txtled.Text = string.Empty;
                }
            }
            foreach(Button x in calculadora.Controls.OfType<Button>().Where(n=>int.TryParse(n.Text,out var number)))
            {
                x.Click += (a, b) => {
                    var control = a as Button;
                    txtled.Text += control.Text;
                };
            }
        }
        void StartedConfig()
        {
            txtled.KeyPress += (a, b) => AppConfig.SoloNumeros(b);
            lbltotal.Text = "$0.00";
            lblcantidad.Text = "0.00";
        }
        void LoadProductos()
        {
            Productos.Controls.Clear();
            int contador = 0;
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                foreach(var x in db.Table<Entidades.ProductosInv>().ToList().Where(x => x.codigoDeBarras.Length > 6))
                {
                    var tempButton = new Button()
                    {
                        Text = x.Descripcion + "\n" + $"Precio:{x.Precio.ToString("###,###,###")}",
                        Name = "BUTTON" + contador++.ToString(),
                        Width = 200,
                        Font = new Font("calibri", 10),
                        Height = 80,
                        Cursor = Cursors.Hand,
                        Tag = x,
                        Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "iconoProductos_48.png")),
                        ImageAlign=ContentAlignment.MiddleLeft

                    };
                    tempButton.Click += (a, b) => {
                        if (Data.Ventas.CheckCaja())
                        {
                            MessageBox.Show("La Caja ya esta Cerrada, Las Ventas de hoy ya estan Suspendidas", "Atención Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var producto = (a as Button).Tag as Entidades.ProductosInv;
                        if (grilla.Rows.Count == 0)
                        {
                            if (Data.Productos.BajoEnStock(0, producto.codigoDeBarras))
                            {
                                return;
                            }
                        }
                        else
                        {
                            var Row = grilla.Rows.Cast<DataGridViewRow>().FirstOrDefault(g => g.Cells[0].Value.ToString() == producto.codigoDeBarras);
                            int CantidadUsada = 0;
                            if (Row == null)
                            {
                                CantidadUsada = 0;
                            }
                            else
                            {
                                CantidadUsada = int.Parse(Row.Cells[1].Value.ToString());
                            }
                            if (Data.Productos.BajoEnStock(CantidadUsada, producto.codigoDeBarras))
                            {
                                return;
                            }
                        }
                        //Calculo
                        if (grilla.Rows.Count == 0)
                        {
                            grilla.Rows.Add(new object[] { producto.codigoDeBarras,1,producto.Descripcion,
                        producto.Precio,producto.Precio});
                        }
                        else if (!grilla.Rows.Cast<DataGridViewRow>().Any(c => c.Cells[0].Value.ToString() == producto.codigoDeBarras)) {
                            grilla.Rows.Add(new object[] { producto.codigoDeBarras,1,producto.Descripcion,
                        producto.Precio,producto.Precio});
                        }
                        else
                        {
                            var Fila = grilla.Rows.Cast<DataGridViewRow>().First(c => c.Cells[0].Value.ToString() == producto.codigoDeBarras);
                            Fila.Cells[1].Value = int.Parse(Fila.Cells[1].Value.ToString()) + 1;
                            Fila.Cells[4].Value = decimal.Parse(Fila.Cells[4].Value.ToString()) + producto.Precio;
                        }
                        CalcularValoresdeGrilla();
                    };
                    Productos.Controls.Add(
                         tempButton
                    );
                }
            }
        }
        void CalcularValoresdeGrilla()
        {
            if (grilla.Rows.Count == 0) StartedConfig();
            else
            {
                 total = grilla.Rows.Cast<DataGridViewRow>().Sum(x => decimal.Parse(x.Cells[4].Value.ToString()));
                 cantidad = grilla.Rows.Cast<DataGridViewRow>().Sum(x => int.Parse(x.Cells[1].Value.ToString()));
                lbltotal.Text = total.ToString("###,###,###.00");
                lblcantidad.Text = cantidad.ToString("###,##.00");
            }
        }
        void EliminarArticulo()
        {
            if (grilla.Rows.Count == 0) return;
            try
            {
                Int32 index = grilla.CurrentRow.Index;
                DataGridViewRow fila = grilla.Rows[index];
                var msg = $"¿Desea Remover el Siguiente Produco?\n" +
                    $"Codigo: {fila.Cells[0].Value} Descripción:{fila.Cells[2].Value} Precio:{fila.Cells[3].Value}";
                if (MessageBox.Show(msg, "Atención Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                grilla.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog(ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void calculadora_Enter(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            LoadProductos();
            CalcularValoresdeGrilla();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            CancelarVenta();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PagarVenta();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarArticulo();
            CalcularValoresdeGrilla();
        }
    }
}

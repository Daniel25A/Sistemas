using Sistema_Marcelo.Entidades;
using Sistema_Marcelo.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Marcelo.Data
{
   public class Ventas
    {
        public static void SaveDetails(int NumeroVenta,string CodigoBarras,string Descripcion,Decimal cantidad,Decimal Precio,decimal Importe)
        {
            try
            {
                using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var Temp = new Ventas_Detalle();
                    Temp.NumeroVenta = NumeroVenta;
                    Temp.CodigoBarras = CodigoBarras;
                    Temp.Descripcion = Descripcion;
                    Temp.Cantidad = cantidad;
                    Temp.Precio = Precio;
                    Temp.Importe = Importe;
                    db.Insert(Temp);
                    Temp = null;
                }
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}");
            }
        }
        public static bool CheckCaja()
        {
            bool Cerrado = false;
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                Cerrado = db.Table<Entidades.Cortes>().Any(x => x.Fecha == DateTime.Now.ToShortDateString());
            }
            return Cerrado;
        }
        public static void AnularVenta(int numero)
        {
            try
            {
               using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var temp = db.Table<Entidades.Ventas>().First(x => x.numeroVenta == numero);
                    db.Query<Entidades.Ventas>("delete from Ventas where numeroVenta=?", numero);
                    db.Query<Entidades.Ventas_Detalle>("delete from Ventas_Detalle where NumeroVenta=?", numero);
                    MessageBox.Show($"La venta Nº {numero} Fue Anulada", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Anular la venta Nº {numero}", "Operación Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}");
            }
        }
        public static void EstadoCaja(Label estado,Label ventas,
            Label artVendidos,Label EfeCaja,Label Beneficio)
        {
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                string TodayDate = DateTime.Now.ToShortDateString();
                int cantVentas = 0;
                var Consulta = db.Table<Entidades.Cortes>().Any(x => x.Fecha == TodayDate);
                if (Consulta)
                {
                            EstadoDeCaja(false, estado);
                            ventas.Text = "Nan/Nan";
                            artVendidos.Text= "Nan/Nan";
                            EfeCaja.Text = "Nan/Nan";
                            Beneficio.Text = "Nan/Nan";
                    return;
                }
                var VentasToday = db.Table<Entidades.Ventas>().ToList().Where(x => x.Fecha.Split('|')[0] == TodayDate);
                List<Entidades.Ventas_Detalle> Detalles = new List<Ventas_Detalle>();
                foreach(var Venta in VentasToday)
                {
                    foreach(var detalle in db.Table<Entidades.Ventas_Detalle>().Where(x => x.NumeroVenta == Venta.numeroVenta))
                    {
                        Detalles.Add(detalle);
                    }
                }
                AppConfig.Totalventas = VentasToday.Sum(x => x.Total);
                cantVentas = VentasToday.Count();
                AppConfig.CantArtVendidos = Detalles.Where(x=>x.CodigoBarras.Length>6).Sum(x => x.Cantidad);

                AppConfig.Ganacias = Detalles.Where(x=>x.CodigoBarras.Length>6)
                    .Sum(x =>  (x.Precio - (db.Table<Entidades.ProductosInv>().First(c => c.codigoDeBarras == x.CodigoBarras)).Costo) * x.Cantidad);
                AppConfig.Ganacias += Detalles.Where(x => x.CodigoBarras.Length <= 6)
                    .Sum(x => x.Precio - (db.Table<Entidades.ProductosInv>().First(c => c.codigoDeBarras == x.CodigoBarras).Costo) * x.Cantidad);
                EstadoDeCaja(true, estado);
                ventas.Text = cantVentas.ToString();
                artVendidos.Text = AppConfig.CantArtVendidos.ToString();
                EfeCaja.Text = AppConfig.Totalventas.ToString("###,###,###.00");
                Beneficio.Text= AppConfig.Ganacias.ToString("###,###,###.00");
            }
        }
        public static void EstadoDeCaja(bool abierta,Label lblestado)
        {
            if (abierta)
            {
                lblestado.Text = "Abierta";
                lblestado.ForeColor = Color.Lime;
            }
            else
            {
                lblestado.Text = "Cerrada";
                lblestado.ForeColor = Color.Red;
            }
        }
        public static void ReporteVentas(DataGridView grilla, String Desde, String Hasta)
        {
            try
            {
                using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var Date1 = DateTime.Parse(Desde);
                    var Date2 = DateTime.Parse(Hasta);
                    var Resultado = from Venta in db.Table<Entidades.Ventas>().ToList()
                                    where DateTime.Parse(Venta.Fecha.Split('|')[0]) >= Date1
                                    && DateTime.Parse(Venta.Fecha.Split('|')[0]) <= Date2
                                    select Venta;
                    grilla.DataSource = Resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}");
            }
        }
        public static void SaveVenta(int NumeroVenta,decimal Total,decimal Entrega,string Fecha)
        {
            try
            {
                   using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var Temp = new Entidades.Ventas();
                    Temp.numeroVenta = NumeroVenta;
                    Temp.Total = Total;
                    Temp.Entrega = Entrega;
                    Temp.Cambio = Entrega - Total;
                    Temp.Fecha = Fecha;
                    db.Insert(Temp);
                    Temp = null;
                } 
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}");
            }
        }
    }
}

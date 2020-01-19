using Sistema_Marcelo.Entidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketPrinter;
namespace Sistema_Marcelo.Utilidades
{
   public class ImprimirTicket
    {
        public static void UpdateNumVenta()
        {
            using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var Data = db.Table<VentasCounter>().First(x => x.id == 1);
                Data.NumVenta += 1;
                db.Update(Data);
            }
        }
        public static int GetNumberVenta()
        {
            int Numero = 0;
            using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var Data = db.Table<VentasCounter>().First(x => x.id == 1);
                Numero = Data.NumVenta;
            }
            return Numero;
        }
        public static void CrearTicket(ref DataGridView grilla,decimal total, decimal entrega,decimal cantidad,int numeroVenta=-1,string fecha="",bool isReprinter=false)
        {
            using(var ticket=new Ticket())
            {
                ticket.TextoCentro("Supermercado Nanda");
                ticket.TextoCentro("Barrio Jerusalen II - Dr. Raul Peña");
                if (fecha != string.Empty)
                {
                    ticket.textoizquieda($"Fecha:{fecha.Split('|')[0]}");
                    ticket.textoizquieda($"Hora:{fecha.Split('|')[1]}");
                }
                else
                {
                    ticket.textoizquieda($"Fecha:{DateTime.Now.ToLongDateString()}");
                    ticket.textoizquieda($"Hora:{DateTime.Now.ToShortTimeString()}");
                }
               
                if (numeroVenta != -1)
                {
                    ticket.textoizquieda($"Numero de Venta:{numeroVenta}");
                }
                else
                {
                    ticket.textoizquieda($"Numero de Venta:{GetNumberVenta()}");
                }
                ticket.lineasGuion();
                ticket.encabezado();
               
                foreach(DataGridViewRow x in grilla.Rows)
                {
                    ticket.AgregaArticulo(x.Cells[1].Value.ToString(),(decimal)float.Parse(x.Cells[2].Value.ToString()), decimal.Parse(x.Cells[3].Value.ToString()),
                       Math.Round(decimal.Parse(x.Cells[4].Value.ToString())));
                    if (isReprinter) continue;
                    Data.Ventas.SaveDetails(GetNumberVenta(), (string)x.Cells[0].Value, (string)x.Cells[1].Value, decimal.Parse(x.Cells[2].Value.ToString()),
                        decimal.Parse(x.Cells[3].Value.ToString()), decimal.Parse(x.Cells[4].Value.ToString())
                        );
                    DescontarStock((int)decimal.Parse(x.Cells[2].Value.ToString()), (string)x.Cells[0].Value);
                }
                ticket.lineasGuion();
                ticket.agregartotales("Total", total);
                ticket.agregartotales("Entrega", entrega);
                ticket.agregartotales("Cambio", entrega - total);
                ticket.lineasGuion();
                ticket.agregartotales("Cantidad de Articulos", cantidad);
                if (grilla.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[0].Value.ToString().Length <= 6))
                {
                    var kilos = grilla.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString().Length <= 6)
                        .Sum(x => decimal.Parse(x.Cells[2].Value.ToString()));
                    ticket.agregartotales("Cantidad de Art. Kg", kilos);
                }
                ticket.textoizquieda("Tipo de Pago:Efectivo");
                ticket.textoizquieda("Cliente: Publico En General");
                ticket.lineasGuion();
                ticket.TextoCentro("¡Gracias por Su Preferencia!");
                ticket.ImprimirTicket(AppConfig.Impresora());
            }
        }
        public static void DescontarStock(int cantidad, String codigo)
        {
            using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var producto = db.Table<Entidades.ProductosInv>().First(x => x.codigoDeBarras == codigo);
                producto.Stock -= cantidad;
                db.Update(producto, typeof(Entidades.ProductosInv));
            }
        }
        public static void CrearTicketTouch(ref DataGridView grilla, decimal total, decimal entrega, decimal cantidad, int numeroVenta = -1, string fecha = "", bool isReprinter = false)
        {
            using (var ticket = new Ticket())
            {
                ticket.TextoCentro("Supermercado Nanda");
                ticket.TextoCentro("Barrio Jerusalen II - Dr. Raul Peña");
                if (fecha != string.Empty)
                {
                    ticket.textoizquieda($"Fecha:{fecha.Split('|')[0]}");
                    ticket.textoizquieda($"Hora:{fecha.Split('|')[1]}");
                }
                else
                {
                    ticket.textoizquieda($"Fecha:{DateTime.Now.ToLongDateString()}");
                    ticket.textoizquieda($"Hora:{DateTime.Now.ToShortTimeString()}");
                }

                if (numeroVenta != -1)
                {
                    ticket.textoizquieda($"Numero de Venta:{numeroVenta}");
                }
                else
                {
                    ticket.textoizquieda($"Numero de Venta:{GetNumberVenta()}");
                }
                ticket.lineasGuion();
                ticket.encabezado();

                foreach (DataGridViewRow x in grilla.Rows)
                {
                    ticket.AgregaArticulo(x.Cells[2].Value.ToString(), (decimal)float.Parse(x.Cells[1].Value.ToString()), decimal.Parse(x.Cells[3].Value.ToString()),
                       Math.Round(decimal.Parse(x.Cells[4].Value.ToString())));
                    if (isReprinter) continue;
                    Data.Ventas.SaveDetails(GetNumberVenta(), (string)x.Cells[0].Value, (string)x.Cells[2].Value, decimal.Parse(x.Cells[1].Value.ToString()),
                        decimal.Parse(x.Cells[3].Value.ToString()), decimal.Parse(x.Cells[4].Value.ToString())
                        );
                    DescontarStock((int)decimal.Parse(x.Cells[1].Value.ToString()), (string)x.Cells[0].Value);
                }
                ticket.lineasGuion();
                ticket.agregartotales("Total", total);
                ticket.agregartotales("Entrega", entrega);
                ticket.agregartotales("Cambio", entrega - total);
                ticket.lineasGuion();
                ticket.agregartotales("Cantidad de Articulos", cantidad);
                if (grilla.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[0].Value.ToString().Length <= 6))
                {
                    var kilos = grilla.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString().Length <= 6)
                        .Sum(x => decimal.Parse(x.Cells[2].Value.ToString()));
                    ticket.agregartotales("Cantidad de Art. Kg", kilos);
                }
                ticket.textoizquieda("Tipo de Pago:Efectivo");
                ticket.textoizquieda("Cliente: Publico En General");
                ticket.lineasGuion();
                ticket.TextoCentro("¡Gracias por Su Preferencia!");
                ticket.ImprimirTicket(AppConfig.Impresora());
            }
        }
    }
}

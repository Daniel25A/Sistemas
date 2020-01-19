using Sistema_Marcelo.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketPrinter;

namespace Sistema_Marcelo.Reportes
{
   public class CorteCaja
    {
        public static void CrearReport(decimal totalVentas,decimal ArticulosVendidos,decimal Ganancia)
        {
            Ticket ticket = new Ticket();
            ticket.TextoCentro("Nombre Mercado");
            ticket.TextoCentro($"Corte de caja del Dia:{DateTime.Now.ToShortDateString()}");
            ticket.lineasGuion();
            ticket.TextoCentro("Datos de las ventas de hoy(Resumido)");
            ticket.lineasGuion();
            ticket.textoizquieda($"Total de Ventas:{totalVentas.ToString("###,###,###.00")}");
            ticket.textoizquieda($"Articulos Vendidos:{ArticulosVendidos.ToString("###,###,###.00")}");
            ticket.textoizquieda($"Beneficios:{Ganancia.ToString("###,###,###.00")}");
            ticket.lineasGuion();
            ticket.TextoCentro("--- Datos Oficiales del Sistema ---");
            ticket.ImprimirTicket(AppConfig.Impresora());
            GuardarDatos(totalVentas, ArticulosVendidos, Ganancia);
        }
        protected static void GuardarDatos(decimal totalVentas, decimal ArticulosVendidos, decimal Ganancia)
        {
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var temp = new Entidades.Cortes();
                temp.TotalVentas = totalVentas;
                temp.ArticulosVendidos = ArticulosVendidos;
                temp.Ganancia = Ganancia;
                temp.Fecha = DateTime.Now.ToShortDateString();
                db.Insert(temp, typeof(Entidades.Cortes));
            }
        }
    }
}

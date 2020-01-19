using Sistema_Marcelo.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Marcelo.Data
{
   public class Reportes
    {
        public static void GetInfo(DataGridView Grilla,int NumeroTicket,Label numero,Label total,Label fecha)
        {
            using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
            {
                foreach (var item in db.Table<Entidades.Ventas_Detalle>().Where(x => x.NumeroVenta == NumeroTicket))
                {
                    Grilla.Rows.Add(new string[] { item.CodigoBarras,item.Descripcion,item.Cantidad.ToString(),item.Precio.ToString()
                    ,item.Importe.ToString()});
                }
                var temp = db.Table<Entidades.Ventas>().First(x => x.numeroVenta == NumeroTicket);
                numero.Text = temp.numeroVenta.ToString();
                total.Text = temp.Total.ToString("###,###,###.00");
                fecha.Text = temp.Fecha;
            }
        }
        public static List<int> GetNumbers(int numero=-1)
        {
            if (numero != -1)
            {
                return (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Ventas>().Select(x => x.numeroVenta).Where(n => n.ToString().Contains(numero.ToString())).ToList();
            }
            return (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Ventas>().Select(x => x.numeroVenta).ToList();
        }
    }
}

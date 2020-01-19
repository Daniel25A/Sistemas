using Sistema_Marcelo.Entidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Marcelo.Utilidades
{
   public static class AppConfig
    {
        public static string UrlDataBase = Path.Combine(Environment.CurrentDirectory + @"\DataBase", "DBTienda.db");
        public static string UrlLogs = Environment.CurrentDirectory + @"\Logs";
        public static string urlImpresora = Environment.CurrentDirectory + @"\ImpresoraTicket.txt";
        public static decimal Totalventas = 0;
        public static decimal Ganacias = 0;
        public static decimal CantArtVendidos = 0;
        //Serial
        public static int SerialOne = 0xB2,
                          SerialTwo = 0x1C8, 
                          SerialTre = 0x3C3;
        //Fecha
        public static int FechadeValido = 0xE510B4;
        public  static void CheckTables()
        {
            using(var db= new SQLiteConnection(UrlDataBase))
            {
                foreach (var table in Tablas.TablasSys)
                {
                    var result = db.CreateTable(table);
                    if ( result== CreateTableResult.Created)
                    {
                        WriteLog($"Se Creo la tabla {table.Name}");
                    }
                    else if (result == CreateTableResult.Migrated)
                    {
                        WriteLog($"Se Migro la tabla {table.Name}");
                    }
                }
            }
        }
        public static void WriteLog(string log)
        {
            var Aleatorio = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
           var Data= File.CreateText(Path.Combine(UrlLogs, "Log Date - " + DateTime.Now.ToLongDateString()+" "+Aleatorio+".txt"));
            Data.WriteLine($"[{DateTime.Now.ToShortDateString()}][{DateTime.Now.ToShortTimeString()}] {log}");
            Data.Close();
        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public static string Impresora()
        {
            return File.ReadAllText(urlImpresora).Split(':')[1];
        }
    }
}

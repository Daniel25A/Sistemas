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
   public static class Usuarios
    {
        public static void GuardarUsuario(string nombre,string apellido,string usuario
            ,string pass,int canventas,int canreportes,int cancomprobantes,int canmantenimiento
            ,int cantouch)
        {
           using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var tabla = db.Table<Entidades.Usuarios>();
                if (tabla.Any(x => x.Usuario == usuario))
                {
                    var pregunta = MessageBox.Show("Ya Existe este usuario,¿Desea Actualizar los Datos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pregunta == DialogResult.Yes)
                    {
                        var temp = tabla.First(x => x.Usuario == usuario);
                        temp.Password = pass;
                        temp.Venta = canventas;
                        temp.Touch = cantouch;
                        temp.Comprobantes = cancomprobantes;
                        temp.Mantenimiento = canmantenimiento;
                        temp.Reporte = canreportes;
                        temp.Nombre = nombre;
                        temp.Apellido = apellido;
                        if(db.Update(temp, typeof(Entidades.Usuarios)) == 1)
                        {
                            MessageBox.Show("Operacion Exitosa", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    return;
                }
                var Usuario = new Entidades.Usuarios();
                Usuario.Password = pass;
                Usuario.Venta = canventas;
                Usuario.Touch = cantouch;
                Usuario.Comprobantes = cancomprobantes;
                Usuario.Mantenimiento = canmantenimiento;
                Usuario.Reporte = canreportes;
                Usuario.Nombre = nombre;
                Usuario.Apellido = apellido;
                Usuario.Usuario = usuario;
                if (db.Insert(Usuario, typeof(Entidades.Usuarios)) == 1)
                {
                    MessageBox.Show("Usuario Guardado con Exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static void EliminarUsuario(string Usuario)
        {
            using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var tabla = db.Table<Entidades.Usuarios>();
                if (tabla.Any(x => x.Usuario == Usuario))
                {
                    var deletedata = tabla.First(x => x.Usuario == Usuario);
                    var pregunta= MessageBox.Show("¿Desea Eliminar este Usuario?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pregunta != DialogResult.Yes) return;
                    if (db.Delete(deletedata)==1){
                        MessageBox.Show("Usuario Eliminado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public static void CargarGrilla(DataGridView grilla,string filter="")
        {
            if (filter != string.Empty)
            {
                grilla.DataSource = (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Usuarios>().Where(x=>x.Usuario.Contains(filter) 
                || x.Nombre.Contains(filter)).ToList();
                return;
            }
            grilla.DataSource = (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Usuarios>().ToList();
        }
        public static bool IniciarSesion(string Usuario,String Password)
        {
            bool Valido = false;
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                Valido = db.Table<Entidades.Usuarios>().Any(x => x.Usuario == Usuario && x.Password == Password);
            }
            return Valido;
        }
        public static void CargarUsuarios(ComboBox cmbUsuarios)
        {
            cmbUsuarios.DataSource = (new SQLiteConnection(AppConfig.UrlDataBase)).Table<Entidades.Usuarios>().Select(x => x.Usuario).ToList();
        }
    }
}

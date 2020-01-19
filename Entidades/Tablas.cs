using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Marcelo.Entidades
{
   public static class Tablas
    {
        public static List<Type> TablasSys = new List<Type>() {
            typeof(ProductosInv),
            typeof(VentasCounter),
            typeof(Cortes),
            typeof(Categoria),
            typeof(Usuarios),
            typeof(Ventas_Detalle),
        };
    }
    [Table("ProductosInv")]
    public class ProductosInv
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public string codigoDeBarras { get; set; }
        [NotNull]
        public string Descripcion { get; set; }
        [NotNull]
        public decimal Costo { get; set; }
        [NotNull]
        public decimal Precio { get; set; }
        [NotNull]
        public decimal Mayorista { get; set; }
        [NotNull]
        public int Stock { get; set; }
        [NotNull]
        public int Minimo { get; set; }
        [NotNull]
        public string Categoria { get; set; }
    }
    [Table("Categoria")]
    public class Categoria
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public string Name { get; set; }
    }
    [Table("Cortes")]
    public class Cortes
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public decimal TotalVentas { get; set; }
        [NotNull]
        public decimal ArticulosVendidos { get; set; }
        [NotNull]
        public decimal Ganancia { get; set; }
        [NotNull]
        public string Fecha { get; set; }
    }
    [Table("VentasCounter")]
    public class VentasCounter
    {
        [PrimaryKey]
        public int id { get; set; }
        [NotNull]
        public int NumVenta { get; set; }
    }
    [Table("Usuarios")]
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public string Apellido { get; set; }
        [NotNull]
        public string Usuario { get; set; }
        [NotNull]
        public string Password { get; set; }
        [NotNull]
        public int Venta { get; set; }
        [NotNull]
        public int Reporte { get; set; }
        [NotNull]
        public int Comprobantes { get; set; }
        [NotNull]
        public int Mantenimiento { get; set; }
        [NotNull]
        public int Touch { get; set; }
    }

    [Table("Ventas")]
    public class Ventas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public int numeroVenta { get; set; }
        [NotNull]
        public decimal Total { get; set; }
        [NotNull]
        public decimal Entrega { get; set; }
        [NotNull]
        public decimal Cambio { get; set; }
        [NotNull]
        public string Fecha { get; set; }
    }
    [Table("Ventas_Detalle")]
    public class Ventas_Detalle
    {
        [NotNull]
       public int NumeroVenta { get; set; }
        [NotNull]
        public string CodigoBarras { get; set; }
        [NotNull]
        public string Descripcion { get; set; }
        [NotNull]
        public decimal Cantidad { get; set; }
        [NotNull]
        public decimal Precio { get; set; }
        [NotNull]
        public decimal Importe { get; set; }
    }
}

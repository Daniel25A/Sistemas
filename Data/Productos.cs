using Sistema_Marcelo.Entidades;
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
   public class Productos
    {
        public static void getProducto(TextBox codigo,ref DataGridView grilla)
        {
            if (codigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el Codigo de Barras o la Expresión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codigo.Focus();
                return;
            }
            //Check Codigo Balanza
            if (codigo.Text.StartsWith("2"))
            {
                if (codigo.Text.Length < 13)
                {
                    MessageBox.Show("Codigo de Balanza No Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var Temp = DataBalanza(codigo.Text);
                if (Temp != null)
                {
                    using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
                    {
                        var Item = db.Table<Entidades.ProductosInv>().FirstOrDefault(x => x.codigoDeBarras == Temp.Codigo);
                        if (Item == null) return;
                        grilla.Rows.Add(new object[] { Item.codigoDeBarras, Item.Descripcion, Temp.Peso, Item.Precio, Item.Precio * (Decimal)Temp.Peso });
                    }
                    codigo.Clear();
                    codigo.Focus();
                }
                return;
            }
           using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var FindProducto = db.Table<ProductosInv>().FirstOrDefault(x => x.codigoDeBarras == codigo.Text);
                if (FindProducto == null)
                {
                    MessageBox.Show($"El Codigo({codigo.Text}) No Existe en la Base de Datos", "Atención Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (grilla.Rows.Count == 0)
                {
                    if (BajoEnStock(0, codigo.Text))
                    {
                        return;
                    }
                }
                else
                {
                    var Row = grilla.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == codigo.Text);
                    int CantidadUsada = 0;
                    if (Row == null)
                    {
                        CantidadUsada = 0;
                    }
                    else
                    {
                        CantidadUsada = int.Parse(Row.Cells[2].Value.ToString());
                    }
                    if (BajoEnStock(CantidadUsada, codigo.Text))
                    {
                        return;
                    }
                }
                if(grilla.Rows.Count==0 || !(grilla.Rows.Cast<DataGridViewRow>().
                    Any(x => x.Cells[0].Value!=null && x.Cells[0].Value.ToString() == codigo.Text)))
                {
                    grilla.Rows.Add(new string[] { FindProducto.codigoDeBarras,FindProducto.Descripcion,"1",FindProducto.Precio.ToString()
                    ,FindProducto.Precio.ToString()});
                }
                else
                {
                    DataGridViewRow Fila = grilla.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == codigo.Text);
                    if (Fila == null) throw new InvalidOperationException("Error al Actualizar los datos de la grilla");
                    Fila.Cells[4].Value = decimal.Parse(Fila.Cells[4].Value.ToString()) + FindProducto.Precio;
                    Fila.Cells[2].Value = int.Parse(Fila.Cells[2].Value.ToString()) + 1;
                }
                codigo.Clear();
                codigo.Focus();
            }
        }
        public static void DevolverInventario(string codigo, int cantidad)
        {
            if (codigo.Length <= 6) return;
            using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var Item = db.Table<Entidades.ProductosInv>().FirstOrDefault(x => x.codigoDeBarras == codigo);
                if (Item == null) return;
                Item.Stock = Item.Stock + cantidad;
                db.Update(Item, typeof(Entidades.ProductosInv));
            }
        }
        public static void EliminarProducto(TextBox codigo)
        {
            if (codigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el codigo del producto que desea Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var db = new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var DeletePro = db.Table<Entidades.ProductosInv>().FirstOrDefault(x => x.codigoDeBarras == codigo.Text);
                    if (DeletePro ==null)
                    {
                        MessageBox.Show("No existe el codigo de barras que esta deseando eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(MessageBox.Show("¿Desea Eliminar este producto?","Atencion Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Delete(DeletePro);
                        MessageBox.Show("Producto Eliminado con exito", "Exito :D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}"); }
        }
        public static bool BajoEnStock(int CantUsada,string codigo)
        {
            Boolean bajo = false;
            using(var db= new SQLiteConnection(AppConfig.UrlDataBase))
            {
                var Producto = db.Table<Entidades.ProductosInv>().FirstOrDefault(x => x.codigoDeBarras == codigo);
                if (Producto == null)
                {
                    ShowMessage("Estas Intentando calcular el stock de un producto que no existe");
                    return false;
                }
                var Minimo = Producto.Minimo;
                var Stock = Producto.Stock - CantUsada;
                if (Stock <= Minimo)
                {
                    var Texto = new StringBuilder()
                        .AppendLine("======= STOCK INSUFICIENTE =======")
                        .AppendLine($"PRODUCTO: {Producto.Descripcion}")
                         .AppendLine($"COD. BARRAS: {Producto.codigoDeBarras}")
                        .AppendLine($"CANTIDAD EN STOCK: {Stock.ToString("####,##.00")}")
                        .AppendLine($"CANTIDAD BAJO STOCK: {Minimo.ToString("####,##.00")}")
                        .AppendLine("======= STOCK INSUFICIENTE =======");
                    ShowMessage(Texto.ToString());
                     bajo = true;
                }
                else{
                    bajo = false;
                }
            }
            return bajo;
        }
       protected static void ShowMessage(string Mensaje,string Caption = "Atención")
        {
            MessageBox.Show(Mensaje, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void SaveProductos(string codigo, string descripcion,
            decimal precioCosto,decimal precioVenta,decimal precioMayorista,int stock,int minimo, string categoria)
        {
            try
            {
                using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
                {
                    var temp = new Entidades.ProductosInv();
                    temp.codigoDeBarras = codigo;
                    temp.Descripcion = descripcion;
                    temp.Costo = precioCosto;
                    temp.Precio = precioVenta;
                    temp.Mayorista = precioMayorista;
                    temp.Stock = stock;
                    temp.Minimo = minimo;
                    temp.Categoria = categoria;
                    if (db.Table<Entidades.ProductosInv>().Any(x => x.codigoDeBarras == codigo))
                    {
                        var result = MessageBox.Show("Ya Existe el Producto,¿Desea Actualizarlo?","Atención Usuario" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var UpdateData = db.Table<Entidades.ProductosInv>().First(x => x.codigoDeBarras == temp.codigoDeBarras);
                            UpdateData.Descripcion = temp.Descripcion;
                            UpdateData.Costo = temp.Costo;
                            UpdateData.Precio = temp.Precio;
                            UpdateData.Mayorista = temp.Mayorista;
                            UpdateData.Stock = temp.Stock;
                            UpdateData.Minimo = temp.Minimo;
                            UpdateData.Categoria = temp.Categoria;
                            db.Update(UpdateData);
                            MessageBox.Show("Producto Actualizado con exito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateData = null;
                        }
                    }
                    else
                    {
                        db.Insert(temp, typeof(Entidades.ProductosInv));
                        MessageBox.Show("Producto Registrado con Exito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    temp = null;
                }
            }
            catch (Exception ex)
            {
                AppConfig.WriteLog($"[{DateTime.Now.ToShortDateString()}]{ex.Message}");
            }
        }
        public static void CargarGrilla(DataGridView grilla, bool Filter=false,string Criterio="")
        {
            using(var db=new SQLiteConnection(AppConfig.UrlDataBase))
            {
                IEnumerable<Entidades.ProductosInv> Source;
                if (Filter)
                    Source = db.Table<Entidades.ProductosInv>().Where(x => x.Descripcion.ToLower().Contains(Criterio.ToLower()));
                else
                    Source = db.Table<Entidades.ProductosInv>();
                grilla.DataSource = Source.ToList<Entidades.ProductosInv>();
            }
        }
        public static DatosBalanza DataBalanza(string codigo)
        {
            string CodigoProducto = codigo.Substring(1, 6);
            string Kilogramos = codigo.Substring(7, 5);
            float kilos = float.NaN;
            bool findFirstNumber = false;
            string FinalValue = "";
            for (int i = 0; i < Kilogramos.Length; i++)
            {
                if (!findFirstNumber)
                {
                    if (Kilogramos[i] != '0')
                    {
                        findFirstNumber = true;
                        FinalValue += Kilogramos[i];
                    }
                }
                else
                    FinalValue += Kilogramos[i];
            }
            int Longitud = FinalValue.Length;

            if (Longitud <= 3)
            {
                if (Longitud == 2)
                    kilos = float.Parse($"0,0{FinalValue}");
                else
                    kilos = float.Parse($"0,{FinalValue}");
            }
            else if (Longitud == 4)
            {
                kilos = float.Parse($"{FinalValue.Substring(0, 1)},{FinalValue.Substring(1, FinalValue.Length - 2)}");
            }
            else
            {
                kilos = float.Parse($"{FinalValue.Substring(0, 2)},{FinalValue.Substring(2, FinalValue.Length - 3)}");
            }
            return new DatosBalanza() { Peso = kilos, Codigo = CodigoProducto };
        }
    }
    public class DatosBalanza
    {
        public float Peso { get; set; }
        public string Codigo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrinter
{
    public class Ticket:IDisposable
    {
       public  StringBuilder linea = new StringBuilder();
        int maxCar = 40, cortar;
        public string lineasGuion()
        {
            string lineasguio = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasguio += "-";
            }
            return linea.AppendLine(lineasguio).ToString();
        }
        public string lineasasterisco()
        {
            string lineasasteriscos = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasasteriscos += "*";
            }
            return linea.AppendLine(lineasasteriscos).ToString();
        }
        public string lineasigual()
        {
            string lineasiguales = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasiguales += "=";
            }
            return linea.AppendLine(lineasiguales).ToString();
        }
        public void encabezado()
        {
            linea.AppendLine("ARTICULO            |CANT|PRECIO|IMPORTE");
        }
        public void textoizquieda(string texto)
        {
            if (texto.Length > maxCar)
            {
                int CaracterActual = 0;
                for (int longitud = texto.Length; longitud > maxCar; longitud -= maxCar)
                {
                    linea.AppendLine(texto.Substring(CaracterActual, maxCar));
                    CaracterActual += maxCar;
                }
                linea.AppendLine(texto.Substring(CaracterActual, texto.Length - CaracterActual));
            }
            else
            {
                linea.AppendLine(texto);
            }
        }
        public void textoderecha(string texto)
        {
            if (texto.Length > maxCar)
            {
                int CaracterActual = 0;
                for (int longitud = texto.Length; longitud > maxCar; longitud -= maxCar)
                {
                    linea.AppendLine(texto.Substring(CaracterActual, maxCar));
                    CaracterActual += maxCar;
                }
                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Substring(CaracterActual, texto.Length - CaracterActual).Length); i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto.Substring(CaracterActual, texto.Length - CaracterActual));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }

        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int CaracterActual = 0;
                for (int longitud = texto.Length; longitud > maxCar; longitud -= maxCar)
                {
                    linea.AppendLine(texto.Substring(CaracterActual, maxCar));
                    CaracterActual += maxCar;
                }
                string espacios = "";
                int centrar = (maxCar - texto.Substring(CaracterActual, texto.Length - CaracterActual).Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto.Substring(CaracterActual, texto.Length - CaracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCar - texto.Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }
        public void TextoExtremo(string textoizquierdo, string textoderecho)
        {
            string textoIzq, textoDer, textocompleto = "", espacios = "";
            if (textoizquierdo.Length > 18)
            {
                cortar = textoizquierdo.Length - 18;
                textoIzq = textoizquierdo.Remove(18, cortar);

            }
            else
            {
                textoIzq = textoizquierdo;
            }
            if (textoderecho.Length > 20)
            {
                cortar = textoderecho.Length - 20;
                textoDer = textoderecho.Remove(20, cortar);
            }
            else
            {
                textoDer = textoderecho;
            }
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textocompleto += espacios + textoderecho;
            linea.AppendLine(textocompleto);
        }
        public void agregartotales(string texto, decimal total)
        {
            string resumen, valor, textocompleto, espacios = "";
            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }
            textocompleto = resumen;
            valor = total.ToString("###,###,###.00");
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";

            }
            textocompleto += espacios + valor;
            linea.AppendLine(textocompleto);
        }

        public void AgregaArticulo(string articulo, decimal cant, decimal precio, decimal importe)
        {

            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false;
                int nroEspacios = 0;


                if (articulo.Length > 20)
                {

                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();


                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }

                    elemento += espacios + precio.ToString();


                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    int caracterActual = 0;


                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)
                        {

                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true;
                        }
                        else
                            linea.AppendLine(articulo.Substring(caracterActual, 20));

                        caracterActual += 20;
                    }

                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));

                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;


                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();


                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();


                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportdas por éste.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportdas por éste.");
            }
        }


        public void CortaTicket()
        {
            linea.AppendLine("\x1B" + "m");
            linea.AppendLine("\x1B" + "d" + "\x09");
        }

        public void AbreCajon()
        {

            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");

        }

        public void ImprimirTicket(string impresora)
        {


            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            linea.Clear();
        }

        public void Dispose()
        {
            linea.Clear();
            linea = null;
            if (this != null)
            {
                GC.Collect();
            }
        }

        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false;

                di.pDocName = "Ticket de Venta";
                di.pDataType = "RAW";


                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {

                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }

                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;

                dwCount = szString.Length;

                pBytes = Marshal.StringToCoTaskMemAnsi(szString);

                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
    }
}

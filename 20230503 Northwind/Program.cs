using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230503_Northwind
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DSNorthwind ds = new DSNorthwind();
            ProgramaController controller = new ProgramaController(ds);

        }
    }
}

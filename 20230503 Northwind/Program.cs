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
            //Creem un string per connectar a BBDD (nom cadena de conexió a servidor)
            string conexionBaseDatos = "Data Source=DESKTOP-N4T4UJL\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            
            SqlConnection conexion = new SqlConnection(conexionBaseDatos);
            conexion.Open();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DSNorthwind ds = new DSNorthwind();
            ProgramaController controller = new ProgramaController(conexion,ds);

            //instrucció per conectar a BBDD            
            //Application.Run(new ProgramaController(conexion));
        }
    }
}

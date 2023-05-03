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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

//Creem un string per connectar a BBDD (nom cadena de conexió a servidor)
            string conexionBaseDatos = "Data Source=DESKTOP-N4T4UJL\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
           
            //instrucció per conectar a BBDD
            SqlConnection conexion = new SqlConnection(conexionBaseDatos);
            conexion.Open();

            Application.Run(new FormClients(conexion));
        }
    }
}

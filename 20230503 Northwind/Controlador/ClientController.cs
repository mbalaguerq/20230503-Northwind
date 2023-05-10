using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230503_Northwind.Vista;
using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;

namespace _20230503_Northwind.Controlador
{
    internal class ClientController
    {
        SqlConnection conection;
        DSNorthwind ds;
        public ClientController(SqlConnection pconection, DSNorthwind pds)
        {
            conection = pconection;
            ds = pds;
        }
        public DSNorthwind consultaClients(string cli)
        {
            string clientes = "select * from customers where CustomerID='" + cli + "';";
            SqlCommand comando = new SqlCommand(clientes, conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(ds.Customers);
            return ds;
        }
        public int altaClient(string customer, string nombre, string direccion, string ciudad,string pais, string company)
        {
            int nRows;
            string insert = "INSERT INTO customers (CustomerID, ContactName, Address, City, Country, CompanyName) VALUES ";
            insert += "('" + customer + "', '" + nombre + "', '" + direccion + "', '" + ciudad + "', '" +
                     pais + "','" + company + "');";

            SqlCommand comando = new SqlCommand(insert, conection);
            nRows = comando.ExecuteNonQuery();

            return nRows;
        }
        public int eliminaClient(string customer)
        {
            int nRows;
            string delete = $"DELETE FROM  Customers where CustomerID ='{customer}'";
            SqlCommand comando = new SqlCommand(delete, conection);
            nRows = comando.ExecuteNonQuery();
            return nRows;



        }
    }
}

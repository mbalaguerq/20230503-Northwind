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
        public int modifiClient(string id, string mNom, string mAdreça, string mCiutat, string mPais, string mCompany)
        {
            int nRows=0;
            if(!mNom.Equals(""))
            {
                string update = $"UPDATE Customers SET ContactName= '{mNom}' where CustomerID = '{id}'";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
            if(!mAdreça.Equals(""))
            {
                string update = $"UPDATE Customers SET Address= '{mAdreça}' where CustomerID = '{id}'";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
            if(!mCiutat.Equals(""))
            {
                string update = $"UPDATE Customers SET City= '{mCiutat}' where CustomerID = '{id}'";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
            if(!mPais.Equals(""))
            {
                string update = $"UPDATE Customers SET Country= '{mPais}' where CustomerID = '{id}'";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
            if(!mCompany.Equals(""))
            {
                string update = $"UPDATE Customers SET CompanyName= '{mCompany}' where CustomerID = '{id}'";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
            return nRows;          
        }
    }
}

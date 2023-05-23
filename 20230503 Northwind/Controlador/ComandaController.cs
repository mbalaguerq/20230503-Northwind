using _20230503_Northwind.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230503_Northwind.Controlador
{
    internal class ComandaController
    {
        SqlConnection conection;
        DSNorthwind ds;
        private static int _comanda= 1;
        public ComandaController(SqlConnection pconection, DSNorthwind pds) 
        {
            conection = pconection;
            ds = pds;
        }
        public int getNumComanda()
        {
            _comanda++;
            return _comanda;
        }

        public DSNorthwind getVenedor(int nVenedor)
        {
            string Employee = $"select * from Employees where EmployeeID = {nVenedor}";
            SqlCommand comando = new SqlCommand(Employee, conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DSNorthwind ds = new DSNorthwind();
            adaptador.Fill(ds.Employees);
            return ds;
        }
        DSNorthwind dsProdu = new DSNorthwind();
        public DSNorthwind getProduByCodi( int producteID)
        {
            string produ = $"select * from Products where ProductID = {producteID}";
            SqlCommand comando = new SqlCommand(produ, conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            
            dsProdu.Products.Clear();
            adaptador.Fill(dsProdu.Products);
            return dsProdu;
        }
        public void finalComanda(DsView dsfactura)
        {
            int stock = 0;
            int nRows = 0;
            string update = $"UPDATE Products SET UnitsInStock= '{stock}' where CustomerID = {dsfactura.DetallComandes[i].Codi}";
            


            for (int i = 0; i < dsfactura.DetallComandes.Rows.Count; i++)
            {
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();
            }
        }

    }
}

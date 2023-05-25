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
        private static int _comanda = 1;
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
        public DSNorthwind getProduByCodi(int producteID)
        {
            string produ = $"select * from Products where ProductID = {producteID}";
            SqlCommand comando = new SqlCommand(produ, conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            dsProdu.Products.Clear();
            adaptador.Fill(dsProdu.Products);
            return dsProdu;
        }
        public int CreateOrder(DsView dsfactura)
        {
            int nRows = 0;
            int venedor = dsfactura.DetallComandes[0].Venedor;
            int orderID = 0;

            string insert = $"INSERT into Orders (EmployeeID) VALUES({venedor})";
            SqlCommand command = new SqlCommand(insert, conection);
            nRows = command.ExecuteNonQuery();

            string newOrder = $"SELECT max(OrderID) from Orders";
            SqlCommand command2 = new SqlCommand(newOrder, conection);            
            int idNewOrder = Convert.ToInt32(command2.ExecuteScalar());
            //retorna el valor pel que has preguntat a la BBDD.
            //Només vàlid per un sol valor.
            return idNewOrder;
        }
        public int CreateOrderDetail(DsView dsfactura, int orderID)
        { 
            int nRows = 0;
            for (int i = 0; i < dsfactura.DetallComandes.Rows.Count; i++)
            {
                int productID = dsfactura.DetallComandes[i].Codi;
                decimal unitPrice = dsfactura.DetallComandes[i].PreuUnitat;
                int quantity = dsfactura.DetallComandes[i].Unitats;
                
                string detallComanda = $"INSERT into [Order Details] (OrderID,ProductID,UnitPrice,Quantity) VALUES (";
                detallComanda += $"{orderID},{productID},{unitPrice.ToString().Replace(",",".")},{quantity});";
                SqlCommand command3 = new SqlCommand(detallComanda, conection);
                nRows = command3.ExecuteNonQuery();
                return nRows;
            }
            return nRows;
        }
        public int actualitzaStock(DsView dsfactura)//actualitza l'stock.
        {
            int nRows = 0;

            for (int i = 0; i < dsfactura.DetallComandes.Rows.Count; i++)
            {
                int stock = (dsfactura.DetallComandes[i].Stock - dsfactura.DetallComandes[i].Unitats);
                string update = $"UPDATE Products SET UnitsInStock= '{stock}' where ProductID = {dsfactura.DetallComandes[i].Codi}";
                SqlCommand comando = new SqlCommand(update, conection);
                nRows = comando.ExecuteNonQuery();

                return nRows;
            }
            return nRows;
        }


    }
}

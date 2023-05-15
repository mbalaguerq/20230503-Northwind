using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230503_Northwind.Vista;
using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System.Data.SqlClient;
using System.Data;

namespace _20230503_Northwind.Controlador
{
    internal class ProducteController
    {
        SqlConnection conection;
        DSNorthwind ds;
        public ProducteController(SqlConnection pconection, DSNorthwind pds)
        {
            conection = pconection;
            ds = pds;
        }
        public int altaProducte(string nom, string prodID, string categoria, string quantitat, string preu)
        {
            int rows = 0;

            string insert = $"Insert into Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,Discontinued) VALUES(";
            insert += $"'{nom}',{prodID},{categoria},";
            insert += $"'{quantitat}',{preu},0);";
            SqlCommand command = new SqlCommand(insert, conection);
            rows = command.ExecuteNonQuery();
            return rows;
        }
        public DSNorthwind consultaProducte(string cli)
        {
            string productes = $"select * from Products where ProductID = {cli}";
            SqlCommand comando = new SqlCommand(productes, conection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DSNorthwind ds = new DSNorthwind();
            adaptador.Fill(ds.Products);
            return ds;
        }
        public int eliminaProducte(string product)
        {
            int nRows = 0;
            string delete = $"DELETE FROM  Products where ProductID ='{product}'";
            SqlCommand comando = new SqlCommand(delete, conection);
            nRows = comando.ExecuteNonQuery();
            return nRows;
        }
        public DSNorthwind cbDistribuidors()
        {
            string queryd = "SELECT SupplierID, CompanyName FROM Suppliers;";
            SqlCommand commandd = new SqlCommand(queryd, conection);
            SqlDataAdapter adapterd = new SqlDataAdapter(commandd);
            DSNorthwind dsNd = new DSNorthwind();
            DataRow rowd = dsNd.Suppliers.NewRow();
            rowd[0] = 0;
            rowd[1] = "Tria categoria";
            dsNd.Suppliers.Rows.InsertAt(rowd, 0);
            adapterd.Fill(dsNd.Suppliers);
            return dsNd;
        }
        public DSNorthwind cbCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories;";
            SqlCommand command = new SqlCommand(query, conection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DSNorthwind dsN = new DSNorthwind();
            DataRow row = dsN.Categories.NewRow();
            row[0] = 0;
            row[1] = "Tria categoria";
            dsN.Categories.Rows.InsertAt(row, 0);
            adapter.Fill(dsN.Categories);
            return dsN;
        }
    }
}

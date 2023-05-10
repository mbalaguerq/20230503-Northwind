using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230503_Northwind.Vista;
using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System.Data.SqlClient;

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
    }
}

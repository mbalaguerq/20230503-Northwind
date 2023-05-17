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
        public ComandaController(SqlConnection pconection, DSNorthwind pds) 
        {
            conection = pconection;
            ds = pds;
        }

    }
}

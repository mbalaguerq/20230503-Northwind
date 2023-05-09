using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230503_Northwind.Vista;
using _20230503_Northwind.Model;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace _20230503_Northwind.Controlador
{
    internal class ProgramaController
    {
        SqlConnection conection;
        public ProgramaController(SqlConnection pconection)
        {
            this.conection = pconection;
            Application.Run(new MenuView(conection, this));
            
        }
    }
}

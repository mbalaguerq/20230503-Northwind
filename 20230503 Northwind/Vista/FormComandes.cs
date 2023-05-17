using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _20230503_Northwind.Vista
{
    public partial class FormComandes : Form
    {
        SqlConnection connection;
        DSNorthwind ds;
        ComandaController comandaController;
        ProducteController producteController;
        ClientController clientController;
                
        public FormComandes(SqlConnection pconnection, DSNorthwind pds, object  pcomandaController, object pclientController, object pproducteController)
        {
            InitializeComponent();
            connection = pconnection;
            ds = pds;
            comandaController = (ComandaController)pcomandaController;
            clientController =(ClientController) pclientController;
            producteController = (ProducteController)pproducteController;


        }
    }
}

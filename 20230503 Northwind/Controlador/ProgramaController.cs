﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230503_Northwind.Vista;
using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20230503_Northwind.Controlador
{
    internal class ProgramaController
    {
        SqlConnection conection;
        DSNorthwind ds;
        public ProgramaController(SqlConnection pconection, DSNorthwind pds)
        {
            this.ds = pds;
            this.conection = pconection;
            Application.Run(new MenuView(conection, this, ds));
        }
        public void menuClients(int opcio)
        {
            ClientController clientController = new ClientController(conection, ds);
            FormClients formClients = new FormClients(conection, clientController, ds, opcio);
            formClients.Show();
        }
        public void menuProductes(int opcio)
        {
            ProducteController producteController = new ProducteController(conection,ds);
            FormProductes formProductes = new FormProductes(conection, producteController, ds, opcio);  
            formProductes.Show();
        }
        public void menuComandes()
        {
            ComandaController comandaController = new ComandaController(conection, ds);
            ClientController clientController = new ClientController(conection, ds);
            ProducteController producteController = new ProducteController(conection, ds);
            FormComandes formComandes = new FormComandes(conection, ds, comandaController, clientController, producteController);
            formComandes.Show();
        }



    }
}

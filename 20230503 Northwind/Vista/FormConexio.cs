using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20230503_Northwind.Controlador;

namespace _20230503_Northwind.Vista
{
    public partial class FormConexio : Form
    {
        ProgramaController programaController;
        public FormConexio(Object pprogramaController)
        {
            InitializeComponent();
            this.programaController =(ProgramaController) pprogramaController;
        }


        private void buttonCasa_Click(object sender, EventArgs e)
        {
            string conexionBaseDatos = "Data Source = MARCIMONI\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True";

            programaController.setConexio(conexionBaseDatos) ;
            programaController.crearConexion();
            this.Visible = false ;
        }
        private void buttonIlerna_Click(object sender, EventArgs e)
        {
            string conexionBaseDatos = "Data Source=DESKTOP-N4T4UJL\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            programaController.setConexio(conexionBaseDatos);
            programaController.crearConexion();
            this.Visible = false;
        }
    }
}

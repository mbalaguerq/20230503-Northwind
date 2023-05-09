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
using _20230503_Northwind.Controlador;


namespace _20230503_Northwind.Vista
{
    public partial class MenuView : Form
    {
        SqlConnection conection;
        ProgramaController programaController;
        public MenuView(SqlConnection pconection, Object controlador)
        {
            InitializeComponent();
            conection = pconection;
            programaController = (ProgramaController) controlador;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

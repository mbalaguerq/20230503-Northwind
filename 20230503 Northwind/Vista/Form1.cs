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

namespace _20230503_Northwind
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM customers where City = '" + this.tbCiutat.Text + "';";
            //en la BBDD la consulta seria així:
            // select * from dbo.Customers where City ='Madrid';

            // Creació del command per executar la consulta
            SqlCommand command = new SqlCommand(select, conexion);

            // Creació del data adapter per obtenir les dades
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Creació del dataset per emmagatzemar les dades
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-N4T4UJL\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            conexion = connection;

            //         connection.Open();
            // Do work here; connection closed on following line.
            string query = "SELECT * FROM customers;";

            // Creació del command per executar la consulta
            SqlCommand command = new SqlCommand(query, connection);

            // Creació del data adapter per obtenir les dades
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Creació del dataset per emmagatzemar les dades
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            // Assignació del dataset al DataGridView del formulari
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
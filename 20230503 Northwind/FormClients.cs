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
    public partial class FormClients : Form
    {        
        SqlConnection conection;
        public FormClients(SqlConnection pconection)
        {
            InitializeComponent();
            conection = pconection;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {            
            //instrucción que ejecutará el programa
            string clientes = "select * from customers where CustomerID='" + this.textBoxCustomer.Text + "';";
            //aq this va entre cometes xq recull un string com fariem en un select
            //select * from customers where customerID='Madrid';

            //creació del comando per ejecutar la consulta
            SqlCommand comando = new SqlCommand(clientes, conection);

            //creació del data adapter per obtenir dades(es el que executa la instrucció anterior)
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);//tengo los datos aqui BBDD

            DSNorthwind ds = new DSNorthwind();
            adaptador.Fill(ds.Customers);//los paso aquí

            if (ds.Customers.Rows.Count == 0)
            {
                MessageBox.Show("El cliente no existe");
                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
            }
            else
            {
                this.textBoxCustomer.Text = ds.Customers[0].CompanyName;
                this.textBoxNombre.Text = ds.Customers[0].ContactName;
                this.textBoxDireccion.Text = ds.Customers[0].Address;
                this.textBoxCiudad.Text = ds.Customers[0].City;
                this.textBoxPais.Text = ds.Customers[0].Country;

            }

        }
        private void FormClients_Load(object sender, EventArgs e)
        {
            this.btAlta.Visible = false;
            this.btCancelar.Visible = false;
        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxNombre.Text.Equals(""))
                {
                    string query = "INSERT INTO customers (CustomerID, ContactName, Address, City, Country) VALUES ";
                    query += "('" + this.textBoxCustomer.Text + "', '" + this.textBoxNombre.Text + "', '" + this.textBoxDireccion.Text + "', '" + this.textBoxCiudad.Text + "', '" + this.textBoxPais.Text + "');";

                    SqlCommand command = new SqlCommand(query, conection);
                    nRows = command.ExecuteNonQuery();
                    if (nRows > 0)
                    {
                        MessageBox.Show("Se ha grabado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            this.btAlta.Visible = false;
            this.btCancelar.Visible = false;
        }

        private void btEsborrar_Click(object sender, EventArgs e)
        {
            this.textBoxCustomer.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxDireccion.Text = "";
            this.textBoxCiudad.Text = "";
            this.textBoxPais.Text = "";

        }
    }
}

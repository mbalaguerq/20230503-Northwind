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

            Model.DSNorthwind ds = new Model.DSNorthwind();
            adaptador.Fill(ds.Customers);//los paso aquí

            if (ds.Customers.Rows.Count == 0)
            {
                MessageBox.Show("El cliente no existe");
                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
                this.lcCompanyia2.Visible = true;
                this.textBoxCompany.Visible= true;
            }
            else
            {
                this.textBoxCustomer.Text = ds.Customers[0].CompanyName;
                this.lbclient.Visible = false;
                this.LbCompanyia.Visible = true;
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
            this.LbCompanyia.Visible = false;
            this.textBoxCompany.Visible = false;
            this.LbCompanyia.Visible = false;
            this.lcCompanyia2.Visible = false;
        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxCompany.Visible = true;
                this.LbCompanyia.Visible=true;

                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxNombre.Text.Equals(""))
                {
                    string query = "INSERT INTO customers (CustomerID, ContactName, Address, City, Country, CompanyName) VALUES ";
                    query += "('" + this.textBoxCustomer.Text + "', '" + this.textBoxNombre.Text + "', '" +
                          this.textBoxDireccion.Text + "', '" + this.textBoxCiudad.Text + "', '" +
                          this.textBoxPais.Text + "','" + this.textBoxCompany.Text + "');";

                    SqlCommand command = new SqlCommand(query, conection);
                    nRows = command.ExecuteNonQuery();
                    if (nRows > 0)
                    {
                        MessageBox.Show("Se ha grabado correctamente");
                    }
                    this.textBoxCustomer.Text = "";
                    this.textBoxNombre.Text = "";
                    this.textBoxDireccion.Text = "";
                    this.textBoxCiudad.Text = "";
                    this.textBoxPais.Text = "";
                    this.lbclient.Visible = true;
                    this.LbCompanyia.Visible = false;
                    this.lcCompanyia2.Visible = false;
                    this.textBoxCompany.Visible = false;

                }
                else if (this.textBoxCustomer.Text.Equals("") || this.textBoxNombre.Text.Equals("")
                         || this.textBoxCompany.Text.Equals(""))
                {
                    MessageBox.Show("Els camps -ClientId, Nom i Companyia- són obligatoris");
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
            this.lbclient.Visible = true;
            this.LbCompanyia.Visible = false;

        }
    }
}

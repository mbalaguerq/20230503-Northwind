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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _20230503_Northwind
{
    public partial class FormClients : Form
    {
        SqlConnection conection;
        ClientController clientController;
        DSNorthwind ds;
        int opcio;
        public FormClients(SqlConnection pconection, Object pclientController, DSNorthwind pds, int popcio)
        {
            InitializeComponent();
            ds = pds;
            conection = pconection;
            clientController = (ClientController)pclientController;
            opcio = popcio;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {
            string cli = this.textBoxCustomer.Text;

            ds = clientController.consultaClients(cli);

            if (ds.Customers.Rows.Count == 0)
            {
                MessageBox.Show("El cliente no existe");

                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
                this.lcCompanyia2.Visible = true;
                this.textBoxCompany.Visible = true;
            }
            else
            {
                this.textBoxCustomer.Text = ds.Customers[0].CustomerID;                
                this.lbclient.Visible = true;
                this.LbCompanyia.Visible = true;
                this.textBoxNombre.Text = ds.Customers[0].ContactName;
                this.textBoxDireccion.Text = ds.Customers[0].Address;
                this.textBoxCiudad.Text = ds.Customers[0].City;
                this.textBoxPais.Text = ds.Customers[0].Country;
                this.btModificarCli.Visible = true;
                this.btEliminarCli.Visible = true;                
                this.textBoxCompany.Visible = true;
                this.textBoxCompany.Text = ds.Customers[0].CompanyName;
            }
            ds.Customers.Clear();
        }
        private void FormClients_Load(object sender, EventArgs e)
        {
            if (opcio == 1)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.LbCompanyia.Visible = false;
                this.textBoxCompany.Visible = false;
                this.LbCompanyia.Visible = false;
                this.lcCompanyia2.Visible = false;
                this.btEliminarCli.Visible = false;
                this.btModificarCli.Visible = false;
            }
            if (opcio == 2)
            {
                this.textBoxCompany.Visible = true;
                this.LbCompanyia.Visible = true;
                this.btconsultar.Visible = false;
                this.btEsborrar.Visible = false;
                this.btEliminarCli.Visible = false;
                this.btModificarCli.Visible = false;
                this.btCancelar.Visible = true;
            }
            if (opcio == 3)
            {
                this.textBoxCompany.Visible = false;
                this.LbCompanyia.Visible = false;
                this.lcCompanyia2.Visible = false;
                this.btconsultar.Visible = true;
                this.btEsborrar.Visible = true;
                this.btEliminarCli.Visible = true;
                this.btModificarCli.Visible = false;
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
            }
            if(opcio ==4)
            {
                this.textBoxCompany.Visible = false;
                this.LbCompanyia.Visible = false;
                this.lcCompanyia2.Visible = false;
                this.btconsultar.Visible = true;
                this.btEsborrar.Visible = true;
                this.btEliminarCli.Visible = false;
                this.btModificarCli.Visible = true;
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
            }

        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxCompany.Visible = true;
                this.LbCompanyia.Visible = true;

                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxNombre.Text.Equals(""))
                {
                    string customer = this.textBoxCustomer.Text;
                    string nombre = this.textBoxNombre.Text;
                    string direccion = this.textBoxDireccion.Text;
                    string ciudad = this.textBoxCiudad.Text;
                    string company = this.textBoxCompany.Text;
                    string pais = this.textBoxPais.Text;

                    string message = "Vol confirmar l'Alta?";
                    string caption = "Alta Client";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {                       
                        nRows = clientController.altaClient(customer, nombre, direccion, ciudad, pais, company);

                        if (nRows > 0)
                        {
                            MessageBox.Show("S'ha gravat correctament");
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
                        this.btCancelar.Visible = true;
                    }
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
        private void btEliminarCli_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxCompany.Visible = true;
                this.LbCompanyia.Visible = true;

                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxNombre.Text.Equals(""))
                {
                    string client = this.textBoxNombre.Text;

                    ds = clientController.consultaClients(client);




                    string message = "Confirma que vol eliminar aquest client?";
                    string caption = "Eliminar Client";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string customer = this.textBoxCustomer.Text;

                        nRows = clientController.eliminaClient(customer);

                        if (nRows > 0)
                        {
                            MessageBox.Show("S'ha eliminat el client correctament");
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
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btModificarCli_Click(object sender, EventArgs e)
        {
            this.btAlta.Enabled = false;
            this.btEsborrar.Enabled = false;
        }


    }
}

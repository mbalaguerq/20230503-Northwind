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
        DsView dsfactura;
        public FormComandes(SqlConnection pconnection, DSNorthwind pds, object pcomandaController, object pclientController, object pproducteController)
        {
            InitializeComponent();
            connection = pconnection;
            ds = pds;
            comandaController = (ComandaController)pcomandaController;
            clientController = (ClientController)pclientController;
            producteController = (ProducteController)pproducteController;
        }

        private void textBoxNVenedor_MouseHover(object sender, EventArgs e)
        {
            this.textBoxNVenedor.BackColor = Color.Beige;
        }
        private void textBoxNVenedor_MouseLeave(object sender, EventArgs e)
        {
            this.textBoxNVenedor.BackColor = Color.White;
        }
        private void buttonAfegir_MouseHover(object sender, EventArgs e)
        {
            this.buttonAfegir.BackColor = SystemColors.Window;
        }
        private void buttonAfegir_MouseLeave(object sender, EventArgs e)
        {
            this.buttonAfegir.BackColor = Color.White;
        }


        private void FormComandes_Load(object sender, EventArgs e)
        {
            this.textBoxData.Text = DateTime.Now.ToShortDateString();            
            this.textBoxNVenedor.Text = string.Empty;
            dsfactura = new DsView();
        }
        private void buttonBuscarVenedor_Click(object sender, EventArgs e)
        {
            string vene = this.textBoxNVenedor.Text;
            if (Regex.IsMatch(vene, @"^\d+$"))
            {
                int nVenedor = int.Parse(this.textBoxNVenedor.Text);
                ds = comandaController.getVenedor(nVenedor);

                if (ds.Employees.Rows.Count == 0)
                {
                    MessageBox.Show("No hi ha cap venedor amb aquest número");
                    this.textBoxNVenedor.Text = string.Empty;
                }
                else
                {
                    this.textBoxVenedorNom.Text = ds.Employees[0].FirstName;
                    this.textBoxVenedorCognom.Text = ds.Employees[0].LastName;
                }
            }
            else
            {
                MessageBox.Show("Número de venedor no vàlid");
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string produ = textBoxCodiProdu.Text;
            if (Regex.IsMatch(produ, @"^\d+$"))
            {
                ds.Clear();
                int producteID = int.Parse(textBoxCodiProdu.Text);
                ds = comandaController.getProduByCodi(producteID);

                if (ds.Products.Rows.Count == 0)
                {
                    MessageBox.Show("No hi ha cap producte amb aquest codi");
                    textBoxCodiProdu.Text = string.Empty;
                }
                else
                {
                    this.textBoxDescripProdu.Text = ds.Products[0].ProductName;
                    this.textBoxStock.Text = ds.Products[0].UnitsInStock.ToString();
                    this.textBoxPreuUnit.Text = ds.Products[0].UnitPrice.ToString();                   
                    cBoxUnitats.Items.Clear();
                    int stockMax = int.Parse(textBoxStock.Text);
                    for (int i = 1; i <= stockMax; i++)
                    {
                        cBoxUnitats.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("ID de producte no vàlid");
            }
        }
        private void buttonAfegir_Click(object sender, EventArgs e)
        {            
            decimal preu = decimal.Parse(this.textBoxPreuUnit.Text);
            int unitats = int.Parse(this.cBoxUnitats.SelectedItem.ToString());
            int stock = int.Parse(textBoxStock.Text);

            if (stock > 0)
            {
                DataRow row = dsfactura.DetallComandes.NewRow();
                dsfactura.DetallComandes.Rows.InsertAt(row, 0);
                dsfactura.DetallComandes[0].Codi = int.Parse(this.textBoxCodiProdu.Text);
                dsfactura.DetallComandes[0].Descripció = this.textBoxDescripProdu.Text;
                dsfactura.DetallComandes[0].PreuUnitat = decimal.Parse(this.textBoxPreuUnit.Text);
                dsfactura.DetallComandes[0].Unitats = int.Parse(this.cBoxUnitats.SelectedItem.ToString());
                dsfactura.DetallComandes[0].Total_ = (unitats * preu).ToString();
                dsfactura.DetallComandes[0].Stock = int.Parse(this.textBoxStock.Text);
                dsfactura.DetallComandes[0].Venedor = int.Parse(this.textBoxNVenedor.Text);

                decimal preuFinal = 0;
                decimal preuLinea = 0;

                for (int i = 0; i < dsfactura.DetallComandes.Rows.Count; i++)
                {
                    preuLinea = decimal.Parse(dsfactura.DetallComandes[i].Total_);

                    preuFinal += preuLinea;
                }
                this.textBoxPreuFinal.Text = preuFinal.ToString();

                dataGridView1.DataSource = dsfactura.DetallComandes;

                this.textBoxCodiProdu.Text = String.Empty;
                this.textBoxDescripProdu.Text = String.Empty;
                this.textBoxPreuUnit.Text = String.Empty;
                this.textBoxStock.Text = String.Empty;
                this.cBoxUnitats.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("No hi ha stock de l'article seleccionat");
            }
        }
        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            this.textBoxCodiProdu.Text = String.Empty;
            this.textBoxDescripProdu.Text = String.Empty;
            this.textBoxPreuUnit.Text = String.Empty;
            this.textBoxStock.Text = String.Empty;
            this.cBoxUnitats.SelectedItem = null;
        }
        private void textBoxPreuFinal_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonFinalComanda_Click(object sender, EventArgs e)
        {
            int orderID = comandaController.CreateOrder(dsfactura);
            int nFilas =comandaController.CreateOrderDetail(dsfactura, orderID);

            if (nFilas > 0)
            {
                int nRows = comandaController.actualitzaStock(dsfactura);
                if (nRows > 0)
                {
                    this.textBoxCodiProdu.Text = String.Empty;
                    this.textBoxDescripProdu.Text = String.Empty;
                    this.textBoxPreuUnit.Text = String.Empty;
                    this.textBoxStock.Text = String.Empty;
                    this.cBoxUnitats.SelectedItem = null;
                    this.textBoxNVenedor.Text = String.Empty;
                    this.textBoxPreuFinal.Text = String.Empty;
                    dsfactura.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error al processar la comanda");
            }
        }
    }
}

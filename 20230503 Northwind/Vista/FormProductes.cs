using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20230503_Northwind.Controlador;
using _20230503_Northwind.Model;
using System.Text.RegularExpressions;


namespace _20230503_Northwind
{
    public partial class FormProductes : Form
    {
        SqlConnection connection;
        ProducteController producteController;
        DSNorthwind ds;
        int opcio;

        public FormProductes(SqlConnection pconection, Object pproducteController, DSNorthwind pds, int popcio)
        {
            InitializeComponent();
            connection = pconection;
            ds = pds;
            producteController = (ProducteController)pproducteController;
            opcio = popcio;
        }
        private void FormProductes_Load(object sender, EventArgs e)
        {
            if(opcio==1)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = false;
                this.botoMidifiProd.Visible = false;
                this.cbCategorias.Enabled = false;
                this.cbDistribuidors.Enabled = false;
            }
            if(opcio==2)
            {
                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = false;
                this.botoMidifiProd.Visible = false;
                this.btconsultar.Enabled = false;
            }
            if(opcio==3)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = true;
                this.botoMidifiProd.Visible = false;
                this.btconsultar.Enabled = true;
            }
            if(opcio==4)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = true;
                this.botoMidifiProd.Visible = true;
                this.btconsultar.Enabled = true;
                this.botoEliminarProd.Visible = false;
            }
            DSNorthwind dsNd = new DSNorthwind();
            dsNd = producteController.cbDistribuidors();            
            this.cbDistribuidors.DataSource = dsNd.Suppliers;
            this.cbDistribuidors.DisplayMember = "CompanyName";
            this.cbDistribuidors.ValueMember = "SupplierID";
            this.cbDistribuidors.SelectedIndex = 0;
            this.textboxDistribuidorID.Text = string.Empty;
            this.textBoxCompanyName.Text = string.Empty;
            this.textboxDistribuidorID.Visible = true;
            this.textBoxCompanyName.Visible = true;

            DSNorthwind dsN = new DSNorthwind();
            dsN=producteController.cbCategories();

            this.cbCategorias.DataSource = dsN.Categories;
            this.cbCategorias.DisplayMember = "CategoryName";
            this.cbCategorias.ValueMember = "CategoryID";
            this.cbCategorias.SelectedIndex = 0;
            this.textBoxCategoryID.Text = string.Empty;
            this.textBoxCategoryName.Text = string.Empty;
            this.textBoxCategoryID.Visible = true;
            this.textBoxCategoryName.Visible = true;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {
            
            string prod = this.textBoxProductID.Text;
            if (Regex.IsMatch(prod, @"^\d+$"))
            {
                ds = producteController.consultaProducte(prod);

                if (ds.Products.Rows.Count == 0)
                {
                    MessageBox.Show("El producte no existeix");
                    this.btAlta.Visible = true;
                    this.btCancelar.Visible = true;
                    this.btconsultar.Enabled = false;
                    this.label2.Visible = false;
                    this.label3.Visible = true;
                    this.cbCategorias.Enabled = true;
                    this.cbDistribuidors.Enabled = true;
                }
                else
                {
                    this.textBoxProductID.Text = ds.Products[0].ProductID.ToString();
                    this.textBoxNombre.Text = ds.Products[0].ProductName;
                    //this.textBoxSupplierID.Text = ds.Products[0].SupplierID.ToString();
                    this.cbDistribuidors.Text = ds.Products[0].SupplierID.ToString();
                    this.cbCategorias.Text = ds.Products[0].CategoryID.ToString();
                    this.textBoxQxU.Text = ds.Products[0].QuantityPerUnit;
                    this.textBoxPrice.Text = $" {ds.Products[0].UnitPrice.ToString()} €";
                }
            }
            else
            {
                MessageBox.Show("El camp Producte ID només pot contenir números.");
            }
        }
        private void btEsborrar_Click(object sender, EventArgs e)
        {
            this.textBoxProductID.Text = string.Empty;
            this.textBoxNombre.Text = string.Empty;           
            this.cbCategorias.Text = string.Empty;
            this.cbDistribuidors.Text = string.Empty;
            this.textBoxQxU.Text = string.Empty;
            this.textBoxPrice.Text = string.Empty;
            this.textBoxCategoryID.Text = string.Empty;
            this.textBoxCategoryName.Text = string.Empty;
            this.textBoxCategoryID.Text = string.Empty;
            this.textBoxCategoryName.Text = string.Empty;
        }
        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex > 0)
            {
                this.textBoxCategoryID.Text = cbCategorias.SelectedValue.ToString();
                this.textBoxCategoryName.Text = cbCategorias.Text;
            }
            else
            {
                this.textBoxProductID.Text = string.Empty;
                this.textBoxCategoryName.Text = string.Empty;
            }
        }
        private void cbDistribuidors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbDistribuidors.SelectedIndex > 0)
            {
                this.textboxDistribuidorID.Text = cbDistribuidors.SelectedValue.ToString();
                this.textBoxCompanyName.Text = cbDistribuidors.Text;
            }
            else
            {
                this.textBoxCategoryID.Text = string.Empty;
                this.textBoxCategoryName.Text = string.Empty;
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int nRows;
                if (!this.textBoxNombre.Text.Equals(string.Empty))
                {
                    string nom = this.textBoxNombre.Text;
                    string prodID = this.textboxDistribuidorID.Text;
                    string categoria = this.textBoxCategoryID.Text;
                    string quantitat = this.textBoxQxU.Text;
                    string preu = this.textBoxPrice.Text;

                    string message = "Vol confirmar l'Alta?";
                    string caption = "Alta Producte";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        nRows = producteController.altaProducte(nom, prodID, categoria, quantitat, preu);

                        if (nRows > 0)
                        {
                            MessageBox.Show("S'ha gravat correctament");
                        }
                    }                                                               
                    this.textBoxProductID.Text = string.Empty;
                    this.textBoxNombre.Text = string.Empty;                  
                    this.cbCategorias.Text = string.Empty;
                    this.textBoxQxU.Text = string.Empty;
                    this.textBoxPrice.Text = string.Empty;
                    this.textBoxCategoryID.Text = string.Empty;
                    this.textBoxCategoryName.Text = string.Empty;
                    this.textboxDistribuidorID.Text = string.Empty;
                    this.textBoxCompanyName.Text = string.Empty;
                    this.textBoxCategoryID.Text = string.Empty;                   
                }
                else
                {
                    MessageBox.Show("El Nom és obligatori!");
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void botoEliminarProd_Click(object sender, EventArgs e)
        {
            try
            {
                int nRows;
                if (!this.textBoxProductID.Text.Equals(string.Empty))
                {
                    string prod = this.textBoxProductID.Text;

                    ds = producteController.consultaProducte(prod);

                    if (ds.Products.Rows.Count == 0)
                    {
                        MessageBox.Show("El producte no existeix");
                    }
                    else
                    {
                        this.textBoxProductID.Text = ds.Products[0].ProductID.ToString();
                        this.textBoxNombre.Text = ds.Products[0].ProductName;
                        this.cbDistribuidors.Text = ds.Products[0].SupplierID.ToString();
                        this.cbCategorias.Text = ds.Products[0].CategoryID.ToString();
                        this.textBoxQxU.Text = ds.Products[0].QuantityPerUnit;
                        this.textBoxPrice.Text = $" {ds.Products[0].UnitPrice.ToString()} €";

                        string message = "Vol Eliminar el producte?";
                        string caption = "Eliminar Producte";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            string producte = this.textBoxProductID.Text;

                            nRows = producteController.eliminaProducte(producte);
                            if (nRows > 0)
                            {
                                MessageBox.Show("S'ha eliminat el producte correctament");
                            }
                            this.textBoxProductID.Text = string.Empty;
                            this.textBoxNombre.Text = string.Empty;
                            this.cbCategorias.Text = string.Empty;
                            this.textBoxQxU.Text = string.Empty;
                            this.textBoxPrice.Text = string.Empty;
                            this.textBoxCategoryID.Text = string.Empty;
                            this.textBoxCategoryName.Text = string.Empty;
                            this.textboxDistribuidorID.Text = string.Empty;
                            this.textBoxCompanyName.Text = string.Empty;
                            this.textBoxCategoryID.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

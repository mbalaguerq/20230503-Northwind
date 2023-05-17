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
using System.ComponentModel.Design.Serialization;

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
                this.label2.Visible = true;
            }
            if(opcio==2)
            {
                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = false;
                this.botoMidifiProd.Visible = false;
                this.btconsultar.Enabled = false;
                this.textBoxProductID.Enabled = false;
                this.label3.Visible = true;
            }
            if(opcio==3)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = true;
                this.botoMidifiProd.Visible = false;
                this.btconsultar.Enabled = true;
                this.label4ElimiProd.Visible = true;
            }
            if(opcio==4)
            {
                this.btAlta.Visible = false;
                this.btCancelar.Visible = true;
                this.botoEliminarProd.Visible = true;
                this.botoMidifiProd.Visible = true;
                this.btconsultar.Enabled = true;
                this.botoEliminarProd.Visible = false;
                this.label5ModifiProd.Visible=true;
                this.panellModifiProd.Visible = true;
                MessageBox.Show("Introdueix els camps a modificar");
            }            

            DSNorthwind dsNd = new DSNorthwind();
            dsNd = producteController.cbDistribuidors();            
            this.cbDistribuidors.DataSource = dsNd.Suppliers;
            this.cbDistribuidors.DisplayMember = "CompanyName";
            this.cbDistribuidors.ValueMember = "SupplierID";
            this.cbDistribuidors.SelectedIndex = 0;

            DSNorthwind dsNdis2 = new DSNorthwind();
            dsNdis2 = producteController.cbDistribuidors();
            this.cbDistri2.DataSource = dsNdis2.Suppliers;
            this.cbDistri2.DisplayMember = "CompanyName";
            this.cbDistri2.ValueMember = "SupplierID";
            this.cbDistri2.SelectedIndex = 0;

            DSNorthwind dsN = new DSNorthwind();
            dsN=producteController.cbCategories();
            this.cbCategorias.DataSource = dsN.Categories;
            this.cbCategorias.DisplayMember = "CategoryName";
            this.cbCategorias.ValueMember = "CategoryID";
            this.cbCategorias.SelectedIndex = 0;

            DSNorthwind dsNCat2 = new DSNorthwind();
            dsNCat2 = producteController.cbCategories();
            this.cbCateg2.DataSource = dsNCat2.Categories;
            this.cbCateg2.DisplayMember = "CategoryName";
            this.cbCateg2.ValueMember = "CategoryID";
            this.cbCateg2.SelectedIndex = 0;
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
                    this.cbDistribuidors.SelectedValue = ds.Products[0].SupplierID.ToString();                                       
                    this.cbCategorias.SelectedValue = ds.Products[0].CategoryID.ToString();                  
                    this.textBoxQxU.Text = ds.Products[0].QuantityPerUnit;
                    this.textBoxPrice.Text = $" {ds.Products[0].UnitPrice.ToString()} €";
                }
                ds.Products.Clear();
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
                string prod = this.textBoxProductID.Text;

                if (!this.textBoxNombre.Text.Equals(string.Empty))
                {
                    string nom = this.textBoxNombre.Text;
                    string distriID = ds.Products[0].SupplierID.ToString();
                    string categoria = ds.Products[0].CategoryID.ToString();
                    string quantitat = this.textBoxQxU.Text;
                    string preu = this.textBoxPrice.Text;

                    string message = "Vol confirmar l'Alta?";
                    string caption = "Alta Producte";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        nRows = producteController.altaProducte(nom, distriID, categoria, quantitat, preu);

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
                    this.cbDistribuidors.Text = string.Empty;
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void botoMidifiProd_Click(object sender, EventArgs e)
        {
            int nRows;
            int id =int.Parse(this.textBoxProductID.Text);
            string mNOm = this.tModifiNom.Text;
            int mdistri = int.Parse(this.cbDistri2.SelectedValue.ToString());
            int mCateg =int.Parse(this.cbCateg2.SelectedValue.ToString());
            int mQuantitat =int.Parse( this.tModifiQuant.Text);
            decimal mPreu =decimal.Parse( this.tModifiPvp.Text);

            nRows = producteController.modifiClient(id, mNOm, mdistri, mCateg, mQuantitat, mPreu);

            if (nRows > 0)
            {
                MessageBox.Show("S'ha modificat el producte correctament");
            }
            string idprod=id.ToString();

            ds = producteController.consultaProducte(idprod);
            this.textBoxProductID.Text = ds.Products[0].ProductID.ToString();
            this.textBoxNombre.Text = ds.Products[0].ProductName;
            this.cbDistribuidors.SelectedValue = ds.Products[0].SupplierID.ToString();
            this.cbCategorias.SelectedValue = ds.Products[0].CategoryID.ToString();
            this.textBoxQxU.Text = ds.Products[0].QuantityPerUnit;
            this.textBoxPrice.Text = ds.Products[0].UnitPrice.ToString();   
            ds.Products.Clear();
            this.panellModifiProd.Visible = false;           

        }

      
    }
}

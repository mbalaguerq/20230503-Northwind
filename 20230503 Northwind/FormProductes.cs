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

namespace _20230503_Northwind
{
    public partial class FormProductes : Form
    {
        SqlConnection connection;
        public FormProductes(SqlConnection pconection)
        {
            InitializeComponent();
            connection = pconection;
        }
        private void FormProductes_Load(object sender, EventArgs e)
        {
            this.btAlta.Visible = false;
            this.btCancelar.Visible = false;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {
            string productes = $"select * from Products where ProductID = {this.textBoxProductID.Text}";
            SqlCommand comando = new SqlCommand(productes, connection);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DSNorthwind ds = new DSNorthwind();
            adaptador.Fill(ds.Products);

            if (ds.Products.Rows.Count == 0)
            {
                MessageBox.Show("El producte no existeix");
                this.btAlta.Visible = true;
                this.btCancelar.Visible = true;
                this.btconsultar.Enabled = false;
                this.label2.Visible = false;
                this.label3.Visible = true;

                string query = "SELECT CategoryID, CategoryName FROM Categories;";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DSNorthwind dsN = new DSNorthwind();
                DataRow row = dsN.Categories.NewRow();
                row[0] = 0;
                row[1] = "Tria categoria";
                dsN.Categories.Rows.InsertAt(row, 0);
                adapter.Fill(dsN.Categories);

                this.cbCategorias.DataSource = dsN.Categories;
                this.cbCategorias.DisplayMember = "CategoryName";
                this.cbCategorias.ValueMember = "CategoryID";
                this.cbCategorias.SelectedIndex = 0;
                this.textBoxCategoryID.Text = string.Empty;
                this.textBoxCategoryName.Text = string.Empty;
                this.textBoxCategoryID.Visible = true;
                this.textBoxCategoryName.Visible = true;
            }
            else
            {
                this.textBoxProductID.Text = ds.Products[0].ProductID.ToString();
                this.textBoxNombre.Text = ds.Products[0].ProductName;
                this.textBoxSupplierID.Text = ds.Products[0].SupplierID.ToString();
                this.cbCategorias.Text = ds.Products[0].CategoryID.ToString();
                this.textBoxQxU.Text = ds.Products[0].QuantityPerUnit;
                this.textBoxPrice.Text = $" {ds.Products[0].UnitPrice.ToString()} €";
            }
        }
        private void btEsborrar_Click(object sender, EventArgs e)
        {
            this.textBoxProductID.Text = string.Empty;
            this.textBoxNombre.Text = string.Empty;
            this.textBoxSupplierID.Text = string.Empty;
            this.cbCategorias.Text = string.Empty;
            this.textBoxQxU.Text = string.Empty;
            this.textBoxPrice.Text = string.Empty;
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
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int rows;
                if(!this.textBoxNombre.Text.Equals(string.Empty))
                {
                    string query = $"Insert into Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,Discontinued) VALUES(";
                    query+= $"'{this.textBoxNombre.Text}',{this.textBoxSupplierID.Text},{this.textBoxCategoryID.Text},";
                    query += $"'{this.textBoxQxU.Text}',{this.textBoxPrice.Text},0);";
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Producte gravat correctament");
                    }
                    this.textBoxProductID.Text = string.Empty;
                    this.textBoxNombre.Text = string.Empty;
                    this.textBoxSupplierID.Text = string.Empty;
                    this.cbCategorias.Text = string.Empty;
                    this.textBoxQxU.Text = string.Empty;
                    this.textBoxPrice.Text = string.Empty;
                    this.textBoxCategoryID.Text = string.Empty;
                    this.textBoxCategoryName.Text = string.Empty;
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
    }
}

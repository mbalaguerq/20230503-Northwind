using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                
            }
            else
            {
                this.textBoxProductID.Text = ds.Products[0].ProductID.ToString();
                this.textBoxNombre.Text = ds.Products[0].ProductName;

            }


        }
    }
}

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
using _20230503_Northwind.Model;



namespace _20230503_Northwind.Vista
{
    public partial class MenuView : Form
    {
        SqlConnection conection;
        ProgramaController programaController;
        DSNorthwind ds;
        public MenuView(SqlConnection pconection, Object controlador, DSNorthwind pds)
        {
            InitializeComponent();
            conection = pconection;
            ds = pds;
            programaController = (ProgramaController) controlador;
        }
        private void MenuView_Load(object sender, EventArgs e)
        {
            this.botoAltaCli.Visible = false;
            this.botoConsultaCli.Visible = false;
            this.botoDeleteCli.Visible = false;
            this.botoModifiCli.Visible = false;
            this.botoConsultaProd.Visible = false;
            this.botoConsultaProd.Visible = false;
            this.botoElimiProd.Visible = false;
            this.botoModifiProd.Visible = false;
            this.botoNouProd.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.botoAltaCli.Visible = false;
            this.botoConsultaCli.Visible = false;
            this.botoDeleteCli.Visible = false;
            this.botoModifiCli.Visible = false;
            this.botoConsultaProd.Visible = false;
            this.botoConsultaProd.Visible = false;
            this.botoElimiProd.Visible = false;
            this.botoModifiProd.Visible = false;
        }
        private void botoClients_Click(object sender, EventArgs e)
        {
            this.botoAltaCli.Visible = true;
            this.botoConsultaCli.Visible = true;
            this.botoDeleteCli.Visible = true;
            this.botoModifiCli.Visible = true;
            this.botoConsultaProd.Visible = false;
            this.botoConsultaProd.Visible = false;
            this.botoElimiProd.Visible = false;
            this.botoModifiProd.Visible = false;
        }
        private void botoProductes_Click(object sender, EventArgs e)
        {           
            this.botoConsultaCli.Visible = true;
            this.botoDeleteCli.Visible = true;
            this.botoModifiCli.Visible = true;
            this.botoNouProd.Visible = true;
            this.botoConsultaProd.Visible = true;
            this.botoElimiProd.Visible = true;
            this.botoModifiProd.Visible = true;           
            this.botoAltaCli.Visible=false;
        }
        private void botoConsultaCli_Click(object sender, EventArgs e)
        {
            int consulta = 1;
            programaController.menuClients(consulta);
        }
        private void botoAltaCli_Click(object sender, EventArgs e)
        {
            int alta = 2;
            programaController.menuClients(alta);
        }
        private void botoDeleteCli_Click(object sender, EventArgs e)
        {
            int delete = 3;
            programaController.menuClients(delete);
        }
        private void botoModifiCli_Click(object sender, EventArgs e)
        {
            int modifi = 4;
            programaController.menuClients(modifi);

        }
        private void botoConsultaProd_Click(object sender, EventArgs e)
        {
            int consulta = 1;
            programaController.menuProductes(consulta);           
        }

        private void botoNouProd_Click(object sender, EventArgs e)
        {
            int alta = 2;
            programaController.menuProductes(alta);
        }

        private void botoElimiProd_Click(object sender, EventArgs e)
        {
            int delete = 3;
            programaController.menuProductes(delete);
        }

        private void botoModifiProd_Click(object sender, EventArgs e)
        {
            int modifi = 4;
            programaController.menuProductes(modifi);
        }
        private void botoComandes_Click(object sender, EventArgs e)
        {
            programaController.menuComandes();
        }

        private void MenuView_FormClosed(object sender, FormClosedEventArgs e)
        {
            programaController.cerrarForm();
        }
    }
}

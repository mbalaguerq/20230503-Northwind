namespace _20230503_Northwind.Vista
{
    partial class FormComandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxNorthwind = new System.Windows.Forms.GroupBox();
            this.textBoxVenedorCognom = new System.Windows.Forms.TextBox();
            this.buttonBuscarVenedor = new System.Windows.Forms.Button();
            this.textBoxVenedorNom = new System.Windows.Forms.TextBox();
            this.labelNVenedor = new System.Windows.Forms.Label();
            this.textBoxNVenedor = new System.Windows.Forms.TextBox();
            this.labelNComanda = new System.Windows.Forms.Label();
            this.textNcomanda = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxBuscadorProd = new System.Windows.Forms.GroupBox();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.cBoxUnitats = new System.Windows.Forms.ComboBox();
            this.labelUnitats = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelUnitDispo = new System.Windows.Forms.Label();
            this.buttonEsborrar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelEuros = new System.Windows.Forms.Label();
            this.textBoxPreuUnit = new System.Windows.Forms.TextBox();
            this.textBoxDescripProdu = new System.Windows.Forms.TextBox();
            this.labelPreu = new System.Windows.Forms.Label();
            this.textBoxCodiProdu = new System.Windows.Forms.TextBox();
            this.labelDescripció = new System.Windows.Forms.Label();
            this.labelCodiProducte = new System.Windows.Forms.Label();
            this.textBoxPreuFinal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFinalComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxNorthwind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBuscadorProd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::_20230503_Northwind.Properties.Resources.northwind_logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxNorthwind
            // 
            this.groupBoxNorthwind.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxNorthwind.Controls.Add(this.textBoxVenedorCognom);
            this.groupBoxNorthwind.Controls.Add(this.buttonBuscarVenedor);
            this.groupBoxNorthwind.Controls.Add(this.textBoxVenedorNom);
            this.groupBoxNorthwind.Controls.Add(this.labelNVenedor);
            this.groupBoxNorthwind.Controls.Add(this.textBoxNVenedor);
            this.groupBoxNorthwind.Controls.Add(this.labelNComanda);
            this.groupBoxNorthwind.Controls.Add(this.textNcomanda);
            this.groupBoxNorthwind.Controls.Add(this.textBoxData);
            this.groupBoxNorthwind.Controls.Add(this.labelData);
            this.groupBoxNorthwind.Location = new System.Drawing.Point(462, 18);
            this.groupBoxNorthwind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNorthwind.Name = "groupBoxNorthwind";
            this.groupBoxNorthwind.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNorthwind.Size = new System.Drawing.Size(1032, 205);
            this.groupBoxNorthwind.TabIndex = 2;
            this.groupBoxNorthwind.TabStop = false;
            this.groupBoxNorthwind.Text = "NorthWind DataBase";
            // 
            // textBoxVenedorCognom
            // 
            this.textBoxVenedorCognom.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxVenedorCognom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVenedorCognom.Enabled = false;
            this.textBoxVenedorCognom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVenedorCognom.Location = new System.Drawing.Point(766, 152);
            this.textBoxVenedorCognom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVenedorCognom.Name = "textBoxVenedorCognom";
            this.textBoxVenedorCognom.ReadOnly = true;
            this.textBoxVenedorCognom.Size = new System.Drawing.Size(242, 23);
            this.textBoxVenedorCognom.TabIndex = 17;
            // 
            // buttonBuscarVenedor
            // 
            this.buttonBuscarVenedor.Location = new System.Drawing.Point(896, 94);
            this.buttonBuscarVenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuscarVenedor.Name = "buttonBuscarVenedor";
            this.buttonBuscarVenedor.Size = new System.Drawing.Size(112, 35);
            this.buttonBuscarVenedor.TabIndex = 16;
            this.buttonBuscarVenedor.Text = "Buscar";
            this.buttonBuscarVenedor.UseVisualStyleBackColor = true;
            this.buttonBuscarVenedor.Click += new System.EventHandler(this.buttonBuscarVenedor_Click);
            this.buttonBuscarVenedor.Enter += new System.EventHandler(this.buttonBuscarVenedor_Click);
            // 
            // textBoxVenedorNom
            // 
            this.textBoxVenedorNom.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxVenedorNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVenedorNom.Enabled = false;
            this.textBoxVenedorNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVenedorNom.Location = new System.Drawing.Point(612, 152);
            this.textBoxVenedorNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVenedorNom.Name = "textBoxVenedorNom";
            this.textBoxVenedorNom.ReadOnly = true;
            this.textBoxVenedorNom.Size = new System.Drawing.Size(147, 23);
            this.textBoxVenedorNom.TabIndex = 5;
            this.textBoxVenedorNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNVenedor
            // 
            this.labelNVenedor.AutoSize = true;
            this.labelNVenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNVenedor.Location = new System.Drawing.Point(592, 102);
            this.labelNVenedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNVenedor.Name = "labelNVenedor";
            this.labelNVenedor.Size = new System.Drawing.Size(130, 25);
            this.labelNVenedor.TabIndex = 4;
            this.labelNVenedor.Text = "Nº Vendedor:";
            // 
            // textBoxNVenedor
            // 
            this.textBoxNVenedor.AcceptsReturn = true;
            this.textBoxNVenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNVenedor.Location = new System.Drawing.Point(736, 95);
            this.textBoxNVenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNVenedor.Name = "textBoxNVenedor";
            this.textBoxNVenedor.Size = new System.Drawing.Size(148, 30);
            this.textBoxNVenedor.TabIndex = 3;
            this.textBoxNVenedor.Text = "1";
            this.textBoxNVenedor.MouseLeave += new System.EventHandler(this.textBoxNVenedor_MouseLeave);
            this.textBoxNVenedor.MouseHover += new System.EventHandler(this.textBoxNVenedor_MouseHover);
            // 
            // labelNComanda
            // 
            this.labelNComanda.AutoSize = true;
            this.labelNComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNComanda.Location = new System.Drawing.Point(592, 55);
            this.labelNComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNComanda.Name = "labelNComanda";
            this.labelNComanda.Size = new System.Drawing.Size(136, 25);
            this.labelNComanda.TabIndex = 3;
            this.labelNComanda.Text = "Nº Comanda::";
            // 
            // textNcomanda
            // 
            this.textNcomanda.BackColor = System.Drawing.Color.FloralWhite;
            this.textNcomanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNcomanda.Enabled = false;
            this.textNcomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNcomanda.Location = new System.Drawing.Point(736, 58);
            this.textNcomanda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNcomanda.Name = "textNcomanda";
            this.textNcomanda.ReadOnly = true;
            this.textNcomanda.Size = new System.Drawing.Size(150, 23);
            this.textNcomanda.TabIndex = 2;
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData.Enabled = false;
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(736, 25);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(150, 23);
            this.textBoxData.TabIndex = 1;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(656, 22);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(59, 25);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 272);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBoxBuscadorProd
            // 
            this.groupBoxBuscadorProd.Controls.Add(this.buttonAfegir);
            this.groupBoxBuscadorProd.Controls.Add(this.cBoxUnitats);
            this.groupBoxBuscadorProd.Controls.Add(this.labelUnitats);
            this.groupBoxBuscadorProd.Controls.Add(this.textBoxStock);
            this.groupBoxBuscadorProd.Controls.Add(this.labelUnitDispo);
            this.groupBoxBuscadorProd.Controls.Add(this.buttonEsborrar);
            this.groupBoxBuscadorProd.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscadorProd.Controls.Add(this.labelEuros);
            this.groupBoxBuscadorProd.Controls.Add(this.textBoxPreuUnit);
            this.groupBoxBuscadorProd.Controls.Add(this.textBoxDescripProdu);
            this.groupBoxBuscadorProd.Controls.Add(this.labelPreu);
            this.groupBoxBuscadorProd.Controls.Add(this.textBoxCodiProdu);
            this.groupBoxBuscadorProd.Controls.Add(this.labelDescripció);
            this.groupBoxBuscadorProd.Controls.Add(this.labelCodiProducte);
            this.groupBoxBuscadorProd.Location = new System.Drawing.Point(18, 232);
            this.groupBoxBuscadorProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBuscadorProd.Name = "groupBoxBuscadorProd";
            this.groupBoxBuscadorProd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBuscadorProd.Size = new System.Drawing.Size(1476, 189);
            this.groupBoxBuscadorProd.TabIndex = 6;
            this.groupBoxBuscadorProd.TabStop = false;
            this.groupBoxBuscadorProd.Text = "Cercador de Productes";
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegir.Location = new System.Drawing.Point(1232, 74);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(156, 51);
            this.buttonAfegir.TabIndex = 15;
            this.buttonAfegir.Text = "Afegir Article";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            this.buttonAfegir.Enter += new System.EventHandler(this.buttonBuscarVenedor_Click);
            this.buttonAfegir.MouseLeave += new System.EventHandler(this.buttonAfegir_MouseLeave);
            this.buttonAfegir.MouseHover += new System.EventHandler(this.buttonAfegir_MouseHover);
            // 
            // cBoxUnitats
            // 
            this.cBoxUnitats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUnitats.FormattingEnabled = true;
            this.cBoxUnitats.Location = new System.Drawing.Point(204, 132);
            this.cBoxUnitats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxUnitats.Name = "cBoxUnitats";
            this.cBoxUnitats.Size = new System.Drawing.Size(148, 28);
            this.cBoxUnitats.TabIndex = 14;
            // 
            // labelUnitats
            // 
            this.labelUnitats.AutoSize = true;
            this.labelUnitats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitats.Location = new System.Drawing.Point(44, 140);
            this.labelUnitats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitats.Name = "labelUnitats";
            this.labelUnitats.Size = new System.Drawing.Size(78, 25);
            this.labelUnitats.TabIndex = 13;
            this.labelUnitats.Text = "Unitats:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.AcceptsReturn = true;
            this.textBoxStock.Enabled = false;
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(687, 86);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(148, 30);
            this.textBoxStock.TabIndex = 12;
            // 
            // labelUnitDispo
            // 
            this.labelUnitDispo.AutoSize = true;
            this.labelUnitDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitDispo.Location = new System.Drawing.Point(612, 91);
            this.labelUnitDispo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitDispo.Name = "labelUnitDispo";
            this.labelUnitDispo.Size = new System.Drawing.Size(68, 25);
            this.labelUnitDispo.TabIndex = 11;
            this.labelUnitDispo.Text = "Stock:";
            // 
            // buttonEsborrar
            // 
            this.buttonEsborrar.Location = new System.Drawing.Point(534, 32);
            this.buttonEsborrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEsborrar.Name = "buttonEsborrar";
            this.buttonEsborrar.Size = new System.Drawing.Size(112, 35);
            this.buttonEsborrar.TabIndex = 10;
            this.buttonEsborrar.Text = "Esborrar";
            this.buttonEsborrar.UseVisualStyleBackColor = true;
            this.buttonEsborrar.Click += new System.EventHandler(this.buttonEsborrar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(399, 32);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 35);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            this.buttonBuscar.Enter += new System.EventHandler(this.buttonBuscarVenedor_Click);
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuros.Location = new System.Drawing.Point(1144, 94);
            this.labelEuros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(26, 29);
            this.labelEuros.TabIndex = 8;
            this.labelEuros.Text = "€";
            // 
            // textBoxPreuUnit
            // 
            this.textBoxPreuUnit.AcceptsReturn = true;
            this.textBoxPreuUnit.Enabled = false;
            this.textBoxPreuUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreuUnit.Location = new System.Drawing.Point(978, 91);
            this.textBoxPreuUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPreuUnit.Name = "textBoxPreuUnit";
            this.textBoxPreuUnit.Size = new System.Drawing.Size(148, 30);
            this.textBoxPreuUnit.TabIndex = 7;
            // 
            // textBoxDescripProdu
            // 
            this.textBoxDescripProdu.AcceptsReturn = true;
            this.textBoxDescripProdu.Enabled = false;
            this.textBoxDescripProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripProdu.Location = new System.Drawing.Point(204, 82);
            this.textBoxDescripProdu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescripProdu.Name = "textBoxDescripProdu";
            this.textBoxDescripProdu.Size = new System.Drawing.Size(378, 30);
            this.textBoxDescripProdu.TabIndex = 6;
            // 
            // labelPreu
            // 
            this.labelPreu.AutoSize = true;
            this.labelPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreu.Location = new System.Drawing.Point(872, 95);
            this.labelPreu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreu.Name = "labelPreu";
            this.labelPreu.Size = new System.Drawing.Size(99, 25);
            this.labelPreu.TabIndex = 4;
            this.labelPreu.Text = "Preu/Unit:";
            // 
            // textBoxCodiProdu
            // 
            this.textBoxCodiProdu.AcceptsReturn = true;
            this.textBoxCodiProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodiProdu.Location = new System.Drawing.Point(204, 32);
            this.textBoxCodiProdu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodiProdu.Name = "textBoxCodiProdu";
            this.textBoxCodiProdu.Size = new System.Drawing.Size(148, 30);
            this.textBoxCodiProdu.TabIndex = 3;
            // 
            // labelDescripció
            // 
            this.labelDescripció.AutoSize = true;
            this.labelDescripció.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripció.Location = new System.Drawing.Point(44, 91);
            this.labelDescripció.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripció.Name = "labelDescripció";
            this.labelDescripció.Size = new System.Drawing.Size(109, 25);
            this.labelDescripció.TabIndex = 3;
            this.labelDescripció.Text = "Descripció:";
            // 
            // labelCodiProducte
            // 
            this.labelCodiProducte.AutoSize = true;
            this.labelCodiProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodiProducte.Location = new System.Drawing.Point(44, 42);
            this.labelCodiProducte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodiProducte.Name = "labelCodiProducte";
            this.labelCodiProducte.Size = new System.Drawing.Size(142, 25);
            this.labelCodiProducte.TabIndex = 0;
            this.labelCodiProducte.Text = "Codi Producte:";
            // 
            // textBoxPreuFinal
            // 
            this.textBoxPreuFinal.AcceptsReturn = true;
            this.textBoxPreuFinal.Enabled = false;
            this.textBoxPreuFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreuFinal.Location = new System.Drawing.Point(651, 286);
            this.textBoxPreuFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPreuFinal.Name = "textBoxPreuFinal";
            this.textBoxPreuFinal.Size = new System.Drawing.Size(148, 35);
            this.textBoxPreuFinal.TabIndex = 16;
            this.textBoxPreuFinal.TextChanged += new System.EventHandler(this.textBoxPreuFinal_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(538, 295);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(105, 25);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "PVP Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "€";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFinalComanda);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPreuFinal);
            this.panel1.Location = new System.Drawing.Point(18, 431);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 329);
            this.panel1.TabIndex = 17;
            // 
            // buttonFinalComanda
            // 
            this.buttonFinalComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalComanda.Location = new System.Drawing.Point(891, 226);
            this.buttonFinalComanda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFinalComanda.Name = "buttonFinalComanda";
            this.buttonFinalComanda.Size = new System.Drawing.Size(218, 51);
            this.buttonFinalComanda.TabIndex = 16;
            this.buttonFinalComanda.Text = "Finalitzar Comanda";
            this.buttonFinalComanda.UseVisualStyleBackColor = true;
            this.buttonFinalComanda.Click += new System.EventHandler(this.buttonFinalComanda_Click);
            // 
            // FormComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1752, 922);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxBuscadorProd);
            this.Controls.Add(this.groupBoxNorthwind);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormComandes";
            this.Text = "FormComandes";
            this.Load += new System.EventHandler(this.FormComandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxNorthwind.ResumeLayout(false);
            this.groupBoxNorthwind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBuscadorProd.ResumeLayout(false);
            this.groupBoxBuscadorProd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxNorthwind;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelNVenedor;
        private System.Windows.Forms.TextBox textBoxNVenedor;
        private System.Windows.Forms.Label labelNComanda;
        private System.Windows.Forms.TextBox textNcomanda;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxVenedorNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxBuscadorProd;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.ComboBox cBoxUnitats;
        private System.Windows.Forms.Label labelUnitats;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelUnitDispo;
        private System.Windows.Forms.Button buttonEsborrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelEuros;
        private System.Windows.Forms.TextBox textBoxPreuUnit;
        private System.Windows.Forms.TextBox textBoxDescripProdu;
        private System.Windows.Forms.Label labelPreu;
        private System.Windows.Forms.TextBox textBoxCodiProdu;
        private System.Windows.Forms.Label labelDescripció;
        private System.Windows.Forms.Label labelCodiProducte;
        private System.Windows.Forms.Button buttonBuscarVenedor;
        private System.Windows.Forms.TextBox textBoxVenedorCognom;
        private System.Windows.Forms.TextBox textBoxPreuFinal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFinalComanda;
    }
}
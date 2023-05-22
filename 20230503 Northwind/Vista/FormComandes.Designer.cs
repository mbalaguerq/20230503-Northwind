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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxNorthwind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBuscadorProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::_20230503_Northwind.Properties.Resources.northwind_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxNorthwind
            // 
            this.groupBoxNorthwind.Controls.Add(this.textBoxVenedorCognom);
            this.groupBoxNorthwind.Controls.Add(this.buttonBuscarVenedor);
            this.groupBoxNorthwind.Controls.Add(this.textBoxVenedorNom);
            this.groupBoxNorthwind.Controls.Add(this.labelNVenedor);
            this.groupBoxNorthwind.Controls.Add(this.textBoxNVenedor);
            this.groupBoxNorthwind.Controls.Add(this.labelNComanda);
            this.groupBoxNorthwind.Controls.Add(this.textNcomanda);
            this.groupBoxNorthwind.Controls.Add(this.textBoxData);
            this.groupBoxNorthwind.Controls.Add(this.labelData);
            this.groupBoxNorthwind.Location = new System.Drawing.Point(308, 12);
            this.groupBoxNorthwind.Name = "groupBoxNorthwind";
            this.groupBoxNorthwind.Size = new System.Drawing.Size(688, 133);
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
            this.textBoxVenedorCognom.Location = new System.Drawing.Point(511, 99);
            this.textBoxVenedorCognom.Name = "textBoxVenedorCognom";
            this.textBoxVenedorCognom.ReadOnly = true;
            this.textBoxVenedorCognom.Size = new System.Drawing.Size(161, 15);
            this.textBoxVenedorCognom.TabIndex = 17;
            // 
            // buttonBuscarVenedor
            // 
            this.buttonBuscarVenedor.Location = new System.Drawing.Point(597, 61);
            this.buttonBuscarVenedor.Name = "buttonBuscarVenedor";
            this.buttonBuscarVenedor.Size = new System.Drawing.Size(75, 23);
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
            this.textBoxVenedorNom.Location = new System.Drawing.Point(408, 99);
            this.textBoxVenedorNom.Name = "textBoxVenedorNom";
            this.textBoxVenedorNom.ReadOnly = true;
            this.textBoxVenedorNom.Size = new System.Drawing.Size(98, 15);
            this.textBoxVenedorNom.TabIndex = 5;
            this.textBoxVenedorNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNVenedor
            // 
            this.labelNVenedor.AutoSize = true;
            this.labelNVenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNVenedor.Location = new System.Drawing.Point(395, 66);
            this.labelNVenedor.Name = "labelNVenedor";
            this.labelNVenedor.Size = new System.Drawing.Size(88, 16);
            this.labelNVenedor.TabIndex = 4;
            this.labelNVenedor.Text = "Nº Vendedor:";
            // 
            // textBoxNVenedor
            // 
            this.textBoxNVenedor.AcceptsReturn = true;
            this.textBoxNVenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNVenedor.Location = new System.Drawing.Point(491, 62);
            this.textBoxNVenedor.Name = "textBoxNVenedor";
            this.textBoxNVenedor.Size = new System.Drawing.Size(100, 22);
            this.textBoxNVenedor.TabIndex = 3;
            this.textBoxNVenedor.Text = "1";
            this.textBoxNVenedor.MouseLeave += new System.EventHandler(this.textBoxNVenedor_MouseLeave);
            this.textBoxNVenedor.MouseHover += new System.EventHandler(this.textBoxNVenedor_MouseHover);
            // 
            // labelNComanda
            // 
            this.labelNComanda.AutoSize = true;
            this.labelNComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNComanda.Location = new System.Drawing.Point(395, 36);
            this.labelNComanda.Name = "labelNComanda";
            this.labelNComanda.Size = new System.Drawing.Size(90, 16);
            this.labelNComanda.TabIndex = 3;
            this.labelNComanda.Text = "Nº Comanda::";
            // 
            // textNcomanda
            // 
            this.textNcomanda.BackColor = System.Drawing.Color.FloralWhite;
            this.textNcomanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNcomanda.Enabled = false;
            this.textNcomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNcomanda.Location = new System.Drawing.Point(491, 38);
            this.textNcomanda.Name = "textNcomanda";
            this.textNcomanda.ReadOnly = true;
            this.textNcomanda.Size = new System.Drawing.Size(100, 15);
            this.textNcomanda.TabIndex = 2;
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData.Enabled = false;
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(491, 16);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(100, 15);
            this.textBoxData.TabIndex = 1;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(437, 14);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(39, 16);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 164);
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
            this.groupBoxBuscadorProd.Location = new System.Drawing.Point(12, 151);
            this.groupBoxBuscadorProd.Name = "groupBoxBuscadorProd";
            this.groupBoxBuscadorProd.Size = new System.Drawing.Size(984, 123);
            this.groupBoxBuscadorProd.TabIndex = 6;
            this.groupBoxBuscadorProd.TabStop = false;
            this.groupBoxBuscadorProd.Text = "Cercador de Productes";
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegir.Location = new System.Drawing.Point(821, 48);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(104, 33);
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
            this.cBoxUnitats.FormattingEnabled = true;
            this.cBoxUnitats.Location = new System.Drawing.Point(136, 86);
            this.cBoxUnitats.Name = "cBoxUnitats";
            this.cBoxUnitats.Size = new System.Drawing.Size(100, 21);
            this.cBoxUnitats.TabIndex = 14;
            // 
            // labelUnitats
            // 
            this.labelUnitats.AutoSize = true;
            this.labelUnitats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitats.Location = new System.Drawing.Point(29, 91);
            this.labelUnitats.Name = "labelUnitats";
            this.labelUnitats.Size = new System.Drawing.Size(51, 16);
            this.labelUnitats.TabIndex = 13;
            this.labelUnitats.Text = "Unitats:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.AcceptsReturn = true;
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(458, 56);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 22);
            this.textBoxStock.TabIndex = 12;
            // 
            // labelUnitDispo
            // 
            this.labelUnitDispo.AutoSize = true;
            this.labelUnitDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitDispo.Location = new System.Drawing.Point(408, 59);
            this.labelUnitDispo.Name = "labelUnitDispo";
            this.labelUnitDispo.Size = new System.Drawing.Size(44, 16);
            this.labelUnitDispo.TabIndex = 11;
            this.labelUnitDispo.Text = "Stock:";
            // 
            // buttonEsborrar
            // 
            this.buttonEsborrar.Location = new System.Drawing.Point(356, 21);
            this.buttonEsborrar.Name = "buttonEsborrar";
            this.buttonEsborrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEsborrar.TabIndex = 10;
            this.buttonEsborrar.Text = "Esborrar";
            this.buttonEsborrar.UseVisualStyleBackColor = true;
            this.buttonEsborrar.Click += new System.EventHandler(this.buttonEsborrar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(266, 21);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
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
            this.labelEuros.Location = new System.Drawing.Point(763, 61);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(18, 20);
            this.labelEuros.TabIndex = 8;
            this.labelEuros.Text = "€";
            // 
            // textBoxPreuUnit
            // 
            this.textBoxPreuUnit.AcceptsReturn = true;
            this.textBoxPreuUnit.Enabled = false;
            this.textBoxPreuUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreuUnit.Location = new System.Drawing.Point(652, 59);
            this.textBoxPreuUnit.Name = "textBoxPreuUnit";
            this.textBoxPreuUnit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPreuUnit.TabIndex = 7;
            // 
            // textBoxDescripProdu
            // 
            this.textBoxDescripProdu.AcceptsReturn = true;
            this.textBoxDescripProdu.Enabled = false;
            this.textBoxDescripProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripProdu.Location = new System.Drawing.Point(136, 53);
            this.textBoxDescripProdu.Name = "textBoxDescripProdu";
            this.textBoxDescripProdu.Size = new System.Drawing.Size(253, 22);
            this.textBoxDescripProdu.TabIndex = 6;
            // 
            // labelPreu
            // 
            this.labelPreu.AutoSize = true;
            this.labelPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreu.Location = new System.Drawing.Point(581, 62);
            this.labelPreu.Name = "labelPreu";
            this.labelPreu.Size = new System.Drawing.Size(65, 16);
            this.labelPreu.TabIndex = 4;
            this.labelPreu.Text = "Preu/Unit:";
            // 
            // textBoxCodiProdu
            // 
            this.textBoxCodiProdu.AcceptsReturn = true;
            this.textBoxCodiProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodiProdu.Location = new System.Drawing.Point(136, 21);
            this.textBoxCodiProdu.Name = "textBoxCodiProdu";
            this.textBoxCodiProdu.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodiProdu.TabIndex = 3;
            // 
            // labelDescripció
            // 
            this.labelDescripció.AutoSize = true;
            this.labelDescripció.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripció.Location = new System.Drawing.Point(29, 59);
            this.labelDescripció.Name = "labelDescripció";
            this.labelDescripció.Size = new System.Drawing.Size(75, 16);
            this.labelDescripció.TabIndex = 3;
            this.labelDescripció.Text = "Descripció:";
            // 
            // labelCodiProducte
            // 
            this.labelCodiProducte.AutoSize = true;
            this.labelCodiProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodiProducte.Location = new System.Drawing.Point(29, 27);
            this.labelCodiProducte.Name = "labelCodiProducte";
            this.labelCodiProducte.Size = new System.Drawing.Size(95, 16);
            this.labelCodiProducte.TabIndex = 0;
            this.labelCodiProducte.Text = "Codi Producte:";
            // 
            // FormComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1168, 599);
            this.Controls.Add(this.groupBoxBuscadorProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxNorthwind);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormComandes";
            this.Text = "FormComandes";
            this.Load += new System.EventHandler(this.FormComandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxNorthwind.ResumeLayout(false);
            this.groupBoxNorthwind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBuscadorProd.ResumeLayout(false);
            this.groupBoxBuscadorProd.PerformLayout();
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
    }
}
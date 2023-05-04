namespace _20230503_Northwind
{
    partial class FormProductes
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.LbProductId = new System.Windows.Forms.Label();
            this.btEsborrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btconsultar = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbclient = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSupplierID = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(75, 391);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(70, 16);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "Preu/unitat";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(194, 387);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(248, 20);
            this.textBoxCompany.TabIndex = 32;
            // 
            // LbProductId
            // 
            this.LbProductId.AutoSize = true;
            this.LbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductId.Location = new System.Drawing.Point(79, 122);
            this.LbProductId.Name = "LbProductId";
            this.LbProductId.Size = new System.Drawing.Size(75, 16);
            this.LbProductId.TabIndex = 31;
            this.LbProductId.Text = "Id Producte";
            // 
            // btEsborrar
            // 
            this.btEsborrar.Location = new System.Drawing.Point(482, 112);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(69, 26);
            this.btEsborrar.TabIndex = 30;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(535, 68);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(156, 26);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(351, 68);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(156, 26);
            this.btAlta.TabIndex = 28;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(393, 112);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(72, 26);
            this.btconsultar.TabIndex = 27;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = true;
            this.btconsultar.Click += new System.EventHandler(this.btconsultar_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(75, 346);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(105, 16);
            this.lbQuantity.TabIndex = 26;
            this.lbQuantity.Text = "Quantitat x Unitat";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryID.Location = new System.Drawing.Point(79, 271);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(66, 16);
            this.lbCategoryID.TabIndex = 25;
            this.lbCategoryID.Text = "Categoria";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.Location = new System.Drawing.Point(79, 223);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(75, 16);
            this.lbSupplier.TabIndex = 24;
            this.lbSupplier.Text = "Distribuidor";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(79, 171);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(39, 16);
            this.lbProductName.TabIndex = 23;
            this.lbProductName.Text = "Nom:";
            // 
            // lbclient
            // 
            this.lbclient.AutoSize = true;
            this.lbclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclient.Location = new System.Drawing.Point(112, 122);
            this.lbclient.Name = "lbclient";
            this.lbclient.Size = new System.Drawing.Size(59, 16);
            this.lbclient.TabIndex = 22;
            this.lbclient.Text = "Client ID;";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(194, 167);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 21;
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Location = new System.Drawing.Point(194, 219);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.Size = new System.Drawing.Size(248, 20);
            this.textBoxSupplierID.TabIndex = 20;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(194, 342);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(248, 20);
            this.textBoxPais.TabIndex = 18;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(194, 118);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(174, 20);
            this.textBoxProductID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Northwind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Libre", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cercador de productes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.Enabled = false;
            this.textBoxCategoryID.Location = new System.Drawing.Point(194, 307);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(73, 20);
            this.textBoxCategoryID.TabIndex = 37;
            this.textBoxCategoryID.Visible = false;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Enabled = false;
            this.textBoxCategoryName.Location = new System.Drawing.Point(273, 307);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(169, 20);
            this.textBoxCategoryName.TabIndex = 38;
            // 
            // FormProductes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.textBoxCategoryID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.LbProductId);
            this.Controls.Add(this.btEsborrar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbclient);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxSupplierID);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxProductID);
            this.Name = "FormProductes";
            this.Text = "FormProductes";
            this.Load += new System.EventHandler(this.FormProductes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label LbProductId;
        private System.Windows.Forms.Button btEsborrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btconsultar;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbclient;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSupplierID;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.TextBox textBoxCategoryName;
    }
}
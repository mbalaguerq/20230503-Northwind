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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
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
            this.textBoxQxU = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botoEliminarProd = new System.Windows.Forms.Button();
            this.botoMidifiProd = new System.Windows.Forms.Button();
            this.cbDistribuidors = new System.Windows.Forms.ComboBox();
            this.label4ElimiProd = new System.Windows.Forms.Label();
            this.label5ModifiProd = new System.Windows.Forms.Label();
            this.panellModifiProd = new System.Windows.Forms.Panel();
            this.tModifiPvp = new System.Windows.Forms.TextBox();
            this.tModifiQuant = new System.Windows.Forms.TextBox();
            this.tModifiNom = new System.Windows.Forms.TextBox();
            this.cbDistri2 = new System.Windows.Forms.ComboBox();
            this.cbCateg2 = new System.Windows.Forms.ComboBox();
            this.panellModifiProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(79, 348);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(70, 16);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "Preu/unitat";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(194, 344);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(248, 20);
            this.textBoxPrice.TabIndex = 32;
            // 
            // LbProductId
            // 
            this.LbProductId.AutoSize = true;
            this.LbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductId.Location = new System.Drawing.Point(79, 107);
            this.LbProductId.Name = "LbProductId";
            this.LbProductId.Size = new System.Drawing.Size(75, 16);
            this.LbProductId.TabIndex = 31;
            this.LbProductId.Text = "Id Producte";
            // 
            // btEsborrar
            // 
            this.btEsborrar.Location = new System.Drawing.Point(484, 94);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(69, 26);
            this.btEsborrar.TabIndex = 30;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = true;
            this.btEsborrar.Click += new System.EventHandler(this.btEsborrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(535, 49);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(156, 26);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(351, 49);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(156, 26);
            this.btAlta.TabIndex = 28;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(393, 94);
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
            this.lbQuantity.Location = new System.Drawing.Point(79, 298);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(105, 16);
            this.lbQuantity.TabIndex = 26;
            this.lbQuantity.Text = "Quantitat x Unitat";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryID.Location = new System.Drawing.Point(79, 247);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(66, 16);
            this.lbCategoryID.TabIndex = 25;
            this.lbCategoryID.Text = "Categoria";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.Location = new System.Drawing.Point(79, 198);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(75, 16);
            this.lbSupplier.TabIndex = 24;
            this.lbSupplier.Text = "Distribuidor";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(79, 153);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(39, 16);
            this.lbProductName.TabIndex = 23;
            this.lbProductName.Text = "Nom:";
            // 
            // lbclient
            // 
            this.lbclient.AutoSize = true;
            this.lbclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclient.Location = new System.Drawing.Point(95, 107);
            this.lbclient.Name = "lbclient";
            this.lbclient.Size = new System.Drawing.Size(59, 16);
            this.lbclient.TabIndex = 22;
            this.lbclient.Text = "Client ID;";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(194, 149);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 21;
            // 
            // textBoxQxU
            // 
            this.textBoxQxU.Location = new System.Drawing.Point(194, 294);
            this.textBoxQxU.Name = "textBoxQxU";
            this.textBoxQxU.Size = new System.Drawing.Size(248, 20);
            this.textBoxQxU.TabIndex = 18;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(194, 104);
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
            this.label2.Visible = false;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(194, 242);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(248, 21);
            this.cbCategorias.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Libre", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Alta nou producte";
            this.label3.Visible = false;
            // 
            // botoEliminarProd
            // 
            this.botoEliminarProd.Location = new System.Drawing.Point(351, 383);
            this.botoEliminarProd.Name = "botoEliminarProd";
            this.botoEliminarProd.Size = new System.Drawing.Size(156, 26);
            this.botoEliminarProd.TabIndex = 51;
            this.botoEliminarProd.Text = "Eliminar Producte";
            this.botoEliminarProd.UseVisualStyleBackColor = true;
            this.botoEliminarProd.Click += new System.EventHandler(this.botoEliminarProd_Click);
            // 
            // botoMidifiProd
            // 
            this.botoMidifiProd.Location = new System.Drawing.Point(535, 383);
            this.botoMidifiProd.Name = "botoMidifiProd";
            this.botoMidifiProd.Size = new System.Drawing.Size(156, 26);
            this.botoMidifiProd.TabIndex = 52;
            this.botoMidifiProd.Text = "Modificar Producte";
            this.botoMidifiProd.UseVisualStyleBackColor = true;
            this.botoMidifiProd.Click += new System.EventHandler(this.botoMidifiProd_Click);
            // 
            // cbDistribuidors
            // 
            this.cbDistribuidors.FormattingEnabled = true;
            this.cbDistribuidors.Location = new System.Drawing.Point(194, 193);
            this.cbDistribuidors.Name = "cbDistribuidors";
            this.cbDistribuidors.Size = new System.Drawing.Size(248, 21);
            this.cbDistribuidors.TabIndex = 53;
            // 
            // label4ElimiProd
            // 
            this.label4ElimiProd.AutoSize = true;
            this.label4ElimiProd.Font = new System.Drawing.Font("Miriam Libre", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4ElimiProd.Location = new System.Drawing.Point(45, 49);
            this.label4ElimiProd.Name = "label4ElimiProd";
            this.label4ElimiProd.Size = new System.Drawing.Size(203, 28);
            this.label4ElimiProd.TabIndex = 56;
            this.label4ElimiProd.Text = "Eliminar producte";
            this.label4ElimiProd.Visible = false;
            // 
            // label5ModifiProd
            // 
            this.label5ModifiProd.AutoSize = true;
            this.label5ModifiProd.Font = new System.Drawing.Font("Miriam Libre", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5ModifiProd.Location = new System.Drawing.Point(45, 49);
            this.label5ModifiProd.Name = "label5ModifiProd";
            this.label5ModifiProd.Size = new System.Drawing.Size(215, 28);
            this.label5ModifiProd.TabIndex = 57;
            this.label5ModifiProd.Text = "Modificar producte";
            this.label5ModifiProd.Visible = false;
            // 
            // panellModifiProd
            // 
            this.panellModifiProd.Controls.Add(this.cbCateg2);
            this.panellModifiProd.Controls.Add(this.cbDistri2);
            this.panellModifiProd.Controls.Add(this.tModifiPvp);
            this.panellModifiProd.Controls.Add(this.tModifiQuant);
            this.panellModifiProd.Controls.Add(this.tModifiNom);
            this.panellModifiProd.Location = new System.Drawing.Point(508, 149);
            this.panellModifiProd.Name = "panellModifiProd";
            this.panellModifiProd.Size = new System.Drawing.Size(249, 215);
            this.panellModifiProd.TabIndex = 58;
            this.panellModifiProd.Visible = false;
            // 
            // tModifiPvp
            // 
            this.tModifiPvp.Location = new System.Drawing.Point(3, 195);
            this.tModifiPvp.Name = "tModifiPvp";
            this.tModifiPvp.Size = new System.Drawing.Size(248, 20);
            this.tModifiPvp.TabIndex = 63;
            // 
            // tModifiQuant
            // 
            this.tModifiQuant.Location = new System.Drawing.Point(3, 148);
            this.tModifiQuant.Name = "tModifiQuant";
            this.tModifiQuant.Size = new System.Drawing.Size(248, 20);
            this.tModifiQuant.TabIndex = 62;
            // 
            // tModifiNom
            // 
            this.tModifiNom.Location = new System.Drawing.Point(0, 0);
            this.tModifiNom.Name = "tModifiNom";
            this.tModifiNom.Size = new System.Drawing.Size(248, 20);
            this.tModifiNom.TabIndex = 59;
            // 
            // cbDistri2
            // 
            this.cbDistri2.FormattingEnabled = true;
            this.cbDistri2.Location = new System.Drawing.Point(-2, 44);
            this.cbDistri2.Name = "cbDistri2";
            this.cbDistri2.Size = new System.Drawing.Size(248, 21);
            this.cbDistri2.TabIndex = 59;
            // 
            // cbCateg2
            // 
            this.cbCateg2.FormattingEnabled = true;
            this.cbCateg2.Location = new System.Drawing.Point(0, 93);
            this.cbCateg2.Name = "cbCateg2";
            this.cbCateg2.Size = new System.Drawing.Size(248, 21);
            this.cbCateg2.TabIndex = 59;
            // 
            // FormProductes
            // 
            this.AcceptButton = this.btconsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 461);
            this.Controls.Add(this.panellModifiProd);
            this.Controls.Add(this.label5ModifiProd);
            this.Controls.Add(this.label4ElimiProd);
            this.Controls.Add(this.cbDistribuidors);
            this.Controls.Add(this.botoMidifiProd);
            this.Controls.Add(this.botoEliminarProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.textBoxPrice);
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
            this.Controls.Add(this.textBoxQxU);
            this.Controls.Add(this.textBoxProductID);
            this.Name = "FormProductes";
            this.Text = "FormProductes";            
            this.Load += new System.EventHandler(this.FormProductes_Load);
            this.panellModifiProd.ResumeLayout(false);
            this.panellModifiProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
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
        private System.Windows.Forms.TextBox textBoxQxU;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botoEliminarProd;
        private System.Windows.Forms.Button botoMidifiProd;
        private System.Windows.Forms.ComboBox cbDistribuidors;
        private System.Windows.Forms.Label label4ElimiProd;
        private System.Windows.Forms.Label label5ModifiProd;
        private System.Windows.Forms.Panel panellModifiProd;
        private System.Windows.Forms.TextBox tModifiPvp;
        private System.Windows.Forms.TextBox tModifiQuant;
        private System.Windows.Forms.TextBox tModifiNom;
        private System.Windows.Forms.ComboBox cbCateg2;
        private System.Windows.Forms.ComboBox cbDistri2;
    }
}
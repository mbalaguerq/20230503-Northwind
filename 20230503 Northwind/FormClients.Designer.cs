namespace _20230503_Northwind
{
    partial class FormClients
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
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lbclient = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAdreça = new System.Windows.Forms.Label();
            this.lbCiutat = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.btconsultar = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEsborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(139, 76);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(174, 20);
            this.textBoxCustomer.TabIndex = 0;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(139, 275);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(248, 20);
            this.textBoxPais.TabIndex = 1;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(139, 225);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(248, 20);
            this.textBoxCiudad.TabIndex = 2;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(139, 177);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(248, 20);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(139, 125);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // lbclient
            // 
            this.lbclient.AutoSize = true;
            this.lbclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclient.Location = new System.Drawing.Point(57, 80);
            this.lbclient.Name = "lbclient";
            this.lbclient.Size = new System.Drawing.Size(59, 16);
            this.lbclient.TabIndex = 5;
            this.lbclient.Text = "Client ID;";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(57, 132);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(39, 16);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom:";
            // 
            // lbAdreça
            // 
            this.lbAdreça.AutoSize = true;
            this.lbAdreça.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdreça.Location = new System.Drawing.Point(57, 184);
            this.lbAdreça.Name = "lbAdreça";
            this.lbAdreça.Size = new System.Drawing.Size(54, 16);
            this.lbAdreça.TabIndex = 7;
            this.lbAdreça.Text = "Adreça:";
            // 
            // lbCiutat
            // 
            this.lbCiutat.AutoSize = true;
            this.lbCiutat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiutat.Location = new System.Drawing.Point(57, 232);
            this.lbCiutat.Name = "lbCiutat";
            this.lbCiutat.Size = new System.Drawing.Size(43, 16);
            this.lbCiutat.TabIndex = 8;
            this.lbCiutat.Text = "Ciutat:";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(57, 282);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(37, 16);
            this.lbPais.TabIndex = 9;
            this.lbPais.Text = "País:";
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(338, 70);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(72, 26);
            this.btconsultar.TabIndex = 10;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = true;
            this.btconsultar.Click += new System.EventHandler(this.btconsultar_Click);
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(296, 26);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(156, 26);
            this.btAlta.TabIndex = 11;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(480, 26);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(156, 26);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btEsborrar
            // 
            this.btEsborrar.Location = new System.Drawing.Point(427, 70);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(69, 26);
            this.btEsborrar.TabIndex = 13;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = true;
            this.btEsborrar.Click += new System.EventHandler(this.btEsborrar_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEsborrar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbCiutat);
            this.Controls.Add(this.lbAdreça);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbclient);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxCustomer);
            this.Name = "FormClients";
            this.Text = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lbclient;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAdreça;
        private System.Windows.Forms.Label lbCiutat;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Button btconsultar;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEsborrar;
    }
}
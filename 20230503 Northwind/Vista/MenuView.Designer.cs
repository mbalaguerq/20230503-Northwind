namespace _20230503_Northwind.Vista
{
    partial class MenuView
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
            this.botoClients = new System.Windows.Forms.Button();
            this.botoProductes = new System.Windows.Forms.Button();
            this.botoComandes = new System.Windows.Forms.Button();
            this.botoConsultaCli = new System.Windows.Forms.Button();
            this.botoAltaCli = new System.Windows.Forms.Button();
            this.botoDeleteCli = new System.Windows.Forms.Button();
            this.botoModifiCli = new System.Windows.Forms.Button();
            this.botoConsultaProd = new System.Windows.Forms.Button();
            this.botoNouProd = new System.Windows.Forms.Button();
            this.botoElimiProd = new System.Windows.Forms.Button();
            this.botoModifiProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::_20230503_Northwind.Properties.Resources.northwind_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botoClients
            // 
            this.botoClients.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoClients.Location = new System.Drawing.Point(12, 196);
            this.botoClients.Name = "botoClients";
            this.botoClients.Size = new System.Drawing.Size(254, 45);
            this.botoClients.TabIndex = 1;
            this.botoClients.Text = "Gestió Clients";
            this.botoClients.UseVisualStyleBackColor = true;
            this.botoClients.Click += new System.EventHandler(this.botoClients_Click);
            // 
            // botoProductes
            // 
            this.botoProductes.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoProductes.Location = new System.Drawing.Point(12, 259);
            this.botoProductes.Name = "botoProductes";
            this.botoProductes.Size = new System.Drawing.Size(254, 45);
            this.botoProductes.TabIndex = 2;
            this.botoProductes.Text = "Gestió Productes";
            this.botoProductes.UseVisualStyleBackColor = true;
            this.botoProductes.Click += new System.EventHandler(this.botoProductes_Click);
            // 
            // botoComandes
            // 
            this.botoComandes.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoComandes.Location = new System.Drawing.Point(12, 319);
            this.botoComandes.Name = "botoComandes";
            this.botoComandes.Size = new System.Drawing.Size(254, 45);
            this.botoComandes.TabIndex = 3;
            this.botoComandes.Text = "Gestió Comandes";
            this.botoComandes.UseVisualStyleBackColor = true;
            this.botoComandes.Click += new System.EventHandler(this.botoComandes_Click);
            // 
            // botoConsultaCli
            // 
            this.botoConsultaCli.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoConsultaCli.Location = new System.Drawing.Point(365, 147);
            this.botoConsultaCli.Name = "botoConsultaCli";
            this.botoConsultaCli.Size = new System.Drawing.Size(254, 45);
            this.botoConsultaCli.TabIndex = 4;
            this.botoConsultaCli.Text = "Consultar Client";
            this.botoConsultaCli.UseVisualStyleBackColor = true;
            this.botoConsultaCli.Click += new System.EventHandler(this.botoConsultaCli_Click);
            // 
            // botoAltaCli
            // 
            this.botoAltaCli.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoAltaCli.Location = new System.Drawing.Point(365, 215);
            this.botoAltaCli.Name = "botoAltaCli";
            this.botoAltaCli.Size = new System.Drawing.Size(254, 45);
            this.botoAltaCli.TabIndex = 5;
            this.botoAltaCli.Text = "Alta Nou Client";
            this.botoAltaCli.UseVisualStyleBackColor = true;
            this.botoAltaCli.Click += new System.EventHandler(this.botoAltaCli_Click);
            // 
            // botoDeleteCli
            // 
            this.botoDeleteCli.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoDeleteCli.Location = new System.Drawing.Point(365, 284);
            this.botoDeleteCli.Name = "botoDeleteCli";
            this.botoDeleteCli.Size = new System.Drawing.Size(254, 45);
            this.botoDeleteCli.TabIndex = 6;
            this.botoDeleteCli.Text = "Eliminar Client";
            this.botoDeleteCli.UseVisualStyleBackColor = true;
            this.botoDeleteCli.Click += new System.EventHandler(this.botoDeleteCli_Click);
            // 
            // botoModifiCli
            // 
            this.botoModifiCli.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoModifiCli.Location = new System.Drawing.Point(365, 351);
            this.botoModifiCli.Name = "botoModifiCli";
            this.botoModifiCli.Size = new System.Drawing.Size(254, 45);
            this.botoModifiCli.TabIndex = 7;
            this.botoModifiCli.Text = "Modificar Client";
            this.botoModifiCli.UseVisualStyleBackColor = true;
            this.botoModifiCli.Click += new System.EventHandler(this.botoModifiCli_Click);
            // 
            // botoConsultaProd
            // 
            this.botoConsultaProd.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoConsultaProd.Location = new System.Drawing.Point(365, 147);
            this.botoConsultaProd.Name = "botoConsultaProd";
            this.botoConsultaProd.Size = new System.Drawing.Size(254, 45);
            this.botoConsultaProd.TabIndex = 8;
            this.botoConsultaProd.Text = "Consultar Producte";
            this.botoConsultaProd.UseVisualStyleBackColor = true;
            this.botoConsultaProd.Click += new System.EventHandler(this.botoConsultaProd_Click);
            // 
            // botoNouProd
            // 
            this.botoNouProd.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoNouProd.Location = new System.Drawing.Point(365, 215);
            this.botoNouProd.Name = "botoNouProd";
            this.botoNouProd.Size = new System.Drawing.Size(254, 45);
            this.botoNouProd.TabIndex = 9;
            this.botoNouProd.Text = "Alta Nou Producte";
            this.botoNouProd.UseVisualStyleBackColor = true;
            this.botoNouProd.Click += new System.EventHandler(this.botoNouProd_Click);
            // 
            // botoElimiProd
            // 
            this.botoElimiProd.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoElimiProd.Location = new System.Drawing.Point(365, 284);
            this.botoElimiProd.Name = "botoElimiProd";
            this.botoElimiProd.Size = new System.Drawing.Size(254, 45);
            this.botoElimiProd.TabIndex = 10;
            this.botoElimiProd.Text = "Eliminar Producte";
            this.botoElimiProd.UseVisualStyleBackColor = true;
            this.botoElimiProd.Click += new System.EventHandler(this.botoElimiProd_Click);
            // 
            // botoModifiProd
            // 
            this.botoModifiProd.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.botoModifiProd.Location = new System.Drawing.Point(365, 351);
            this.botoModifiProd.Name = "botoModifiProd";
            this.botoModifiProd.Size = new System.Drawing.Size(254, 45);
            this.botoModifiProd.TabIndex = 11;
            this.botoModifiProd.Text = "Modificar Producte";
            this.botoModifiProd.UseVisualStyleBackColor = true;
            this.botoModifiProd.Click += new System.EventHandler(this.botoModifiProd_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botoModifiProd);
            this.Controls.Add(this.botoElimiProd);
            this.Controls.Add(this.botoNouProd);
            this.Controls.Add(this.botoConsultaProd);
            this.Controls.Add(this.botoModifiCli);
            this.Controls.Add(this.botoDeleteCli);
            this.Controls.Add(this.botoAltaCli);
            this.Controls.Add(this.botoConsultaCli);
            this.Controls.Add(this.botoComandes);
            this.Controls.Add(this.botoProductes);
            this.Controls.Add(this.botoClients);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.Load += new System.EventHandler(this.MenuView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botoClients;
        private System.Windows.Forms.Button botoProductes;
        private System.Windows.Forms.Button botoComandes;
        private System.Windows.Forms.Button botoConsultaCli;
        private System.Windows.Forms.Button botoAltaCli;
        private System.Windows.Forms.Button botoDeleteCli;
        private System.Windows.Forms.Button botoModifiCli;
        private System.Windows.Forms.Button botoConsultaProd;
        private System.Windows.Forms.Button botoNouProd;
        private System.Windows.Forms.Button botoElimiProd;
        private System.Windows.Forms.Button botoModifiProd;
    }
}
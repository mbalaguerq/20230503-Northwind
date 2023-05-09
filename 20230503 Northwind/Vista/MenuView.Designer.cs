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
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botoComandes);
            this.Controls.Add(this.botoProductes);
            this.Controls.Add(this.botoClients);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuView";
            this.Text = "MenuView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botoClients;
        private System.Windows.Forms.Button botoProductes;
        private System.Windows.Forms.Button botoComandes;
    }
}
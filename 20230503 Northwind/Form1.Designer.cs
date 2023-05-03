namespace _20230503_Northwind
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbCiutat = new System.Windows.Forms.Label();
            this.tbCiutat = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbCiutat
            // 
            this.lbCiutat.AutoSize = true;
            this.lbCiutat.Location = new System.Drawing.Point(77, 78);
            this.lbCiutat.Name = "lbCiutat";
            this.lbCiutat.Size = new System.Drawing.Size(34, 13);
            this.lbCiutat.TabIndex = 1;
            this.lbCiutat.Text = "Ciutat";
            // 
            // tbCiutat
            // 
            this.tbCiutat.Location = new System.Drawing.Point(187, 70);
            this.tbCiutat.Name = "tbCiutat";
            this.tbCiutat.Size = new System.Drawing.Size(178, 20);
            this.tbCiutat.TabIndex = 2;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(490, 67);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(96, 23);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Consultar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbCiutat);
            this.Controls.Add(this.lbCiutat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbCiutat;
        private System.Windows.Forms.TextBox tbCiutat;
        private System.Windows.Forms.Button bt1;
    }
}


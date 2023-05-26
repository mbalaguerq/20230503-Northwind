namespace _20230503_Northwind.Vista
{
    partial class FormConexio
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
            this.buttonCasa = new System.Windows.Forms.Button();
            this.buttonIlerna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCasa
            // 
            this.buttonCasa.Location = new System.Drawing.Point(261, 184);
            this.buttonCasa.Name = "buttonCasa";
            this.buttonCasa.Size = new System.Drawing.Size(104, 57);
            this.buttonCasa.TabIndex = 0;
            this.buttonCasa.Text = "casa";
            this.buttonCasa.UseVisualStyleBackColor = true;
            this.buttonCasa.Click += new System.EventHandler(this.buttonCasa_Click);
            // 
            // buttonIlerna
            // 
            this.buttonIlerna.Location = new System.Drawing.Point(428, 184);
            this.buttonIlerna.Name = "buttonIlerna";
            this.buttonIlerna.Size = new System.Drawing.Size(100, 57);
            this.buttonIlerna.TabIndex = 1;
            this.buttonIlerna.Text = "Ilerna";
            this.buttonIlerna.UseVisualStyleBackColor = true;
            this.buttonIlerna.Click += new System.EventHandler(this.buttonIlerna_Click);
            // 
            // FormConexio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIlerna);
            this.Controls.Add(this.buttonCasa);
            this.Name = "FormConexio";
            this.Text = "FormConexio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCasa;
        private System.Windows.Forms.Button buttonIlerna;
    }
}
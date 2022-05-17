namespace Catalog
{
    partial class ter_profesor
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
            this.eticheta_nume = new System.Windows.Forms.Label();
            this.Clase = new System.Windows.Forms.Button();
            this.setari = new System.Windows.Forms.Button();
            this.catalog = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eticheta_nume
            // 
            this.eticheta_nume.BackColor = System.Drawing.Color.SlateBlue;
            this.eticheta_nume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eticheta_nume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eticheta_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eticheta_nume.Location = new System.Drawing.Point(12, 9);
            this.eticheta_nume.Name = "eticheta_nume";
            this.eticheta_nume.Size = new System.Drawing.Size(157, 44);
            this.eticheta_nume.TabIndex = 0;
            // 
            // Clase
            // 
            this.Clase.BackColor = System.Drawing.Color.SlateBlue;
            this.Clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clase.Location = new System.Drawing.Point(12, 183);
            this.Clase.Name = "Clase";
            this.Clase.Size = new System.Drawing.Size(157, 56);
            this.Clase.TabIndex = 1;
            this.Clase.Text = "CLASE";
            this.Clase.UseVisualStyleBackColor = false;
            // 
            // setari
            // 
            this.setari.BackColor = System.Drawing.Color.SlateBlue;
            this.setari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setari.Location = new System.Drawing.Point(12, 245);
            this.setari.Name = "setari";
            this.setari.Size = new System.Drawing.Size(157, 56);
            this.setari.TabIndex = 2;
            this.setari.Text = "SETARI";
            this.setari.UseVisualStyleBackColor = false;
            // 
            // catalog
            // 
            this.catalog.BackColor = System.Drawing.Color.SlateBlue;
            this.catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalog.Location = new System.Drawing.Point(12, 307);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(157, 56);
            this.catalog.TabIndex = 3;
            this.catalog.Text = "CATALOG";
            this.catalog.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Turquoise;
            this.Back.Location = new System.Drawing.Point(-2, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 564);
            this.Back.TabIndex = 0;
            // 
            // ter_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.setari);
            this.Controls.Add(this.Clase);
            this.Controls.Add(this.eticheta_nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ter_profesor";
            this.Text = "ter_profesor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eticheta_nume;
        private System.Windows.Forms.Button Clase;
        private System.Windows.Forms.Button setari;
        private System.Windows.Forms.Button catalog;
        private System.Windows.Forms.Label Back;
    }
}
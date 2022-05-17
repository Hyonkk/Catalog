
namespace Catalog
{
    partial class login
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
            this.d1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d1.Dock = System.Windows.Forms.DockStyle.Top;
            this.d1.Location = new System.Drawing.Point(0, 0);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(1045, 207);
            this.d1.TabIndex = 0;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.d1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.Text = "Log-in";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label d1;
    }
}


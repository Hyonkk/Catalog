
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.d1 = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.login_elev = new System.Windows.Forms.Button();
            this.login_prof = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_final = new System.Windows.Forms.Button();
            this.inapoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desktop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d1.Dock = System.Windows.Forms.DockStyle.Top;
            this.d1.Location = new System.Drawing.Point(0, 0);
            this.d1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(784, 168);
            this.d1.TabIndex = 0;
            // 
            // titlu
            // 
            this.titlu.BackColor = System.Drawing.Color.RoyalBlue;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(2, 0);
            this.titlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(782, 168);
            this.titlu.TabIndex = 1;
            this.titlu.Text = "TITLU";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_elev
            // 
            this.login_elev.BackColor = System.Drawing.SystemColors.Control;
            this.login_elev.FlatAppearance.BorderSize = 0;
            this.login_elev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_elev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_elev.Location = new System.Drawing.Point(194, 353);
            this.login_elev.Name = "login_elev";
            this.login_elev.Size = new System.Drawing.Size(123, 56);
            this.login_elev.TabIndex = 2;
            this.login_elev.TabStop = false;
            this.login_elev.Text = "ELEV";
            this.login_elev.UseVisualStyleBackColor = false;
            this.login_elev.Click += new System.EventHandler(this.login_elev_click);
            // 
            // login_prof
            // 
            this.login_prof.BackColor = System.Drawing.SystemColors.Control;
            this.login_prof.FlatAppearance.BorderSize = 0;
            this.login_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_prof.Location = new System.Drawing.Point(467, 353);
            this.login_prof.Name = "login_prof";
            this.login_prof.Size = new System.Drawing.Size(123, 56);
            this.login_prof.TabIndex = 3;
            this.login_prof.TabStop = false;
            this.login_prof.Text = "PROFESOR";
            this.login_prof.UseVisualStyleBackColor = false;
            this.login_prof.Click += new System.EventHandler(this.login_prof_click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(152, 214);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(154, 29);
            this.user.TabIndex = 4;
            this.user.Text = "USERNAME:";
            this.user.Visible = false;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(152, 269);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(157, 29);
            this.pass.TabIndex = 5;
            this.pass.Text = "PASSWORD:";
            this.pass.Visible = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(352, 214);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(172, 20);
            this.username.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(352, 269);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(172, 20);
            this.password.TabIndex = 7;
            // 
            // login_final
            // 
            this.login_final.BackColor = System.Drawing.SystemColors.Control;
            this.login_final.FlatAppearance.BorderSize = 0;
            this.login_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_final.Location = new System.Drawing.Point(467, 353);
            this.login_final.Name = "login_final";
            this.login_final.Size = new System.Drawing.Size(123, 56);
            this.login_final.TabIndex = 8;
            this.login_final.TabStop = false;
            this.login_final.Text = "LOGIN";
            this.login_final.UseVisualStyleBackColor = false;
            this.login_final.Click += new System.EventHandler(this.login_final_click);
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.SystemColors.Control;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoi.Location = new System.Drawing.Point(194, 353);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(123, 56);
            this.inapoi.TabIndex = 9;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "INAPOI";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Visible = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::Catalog.Properties.Resources.output_onlinepngtools_8_;
            this.pictureBox1.Location = new System.Drawing.Point(684, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // desktop
            // 
            this.desktop.BackColor = System.Drawing.SystemColors.Control;
            this.desktop.FlatAppearance.BorderSize = 0;
            this.desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktop.Location = new System.Drawing.Point(331, 493);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(123, 56);
            this.desktop.TabIndex = 11;
            this.desktop.TabStop = false;
            this.desktop.Text = "Iesire catre Desktop";
            this.desktop.UseVisualStyleBackColor = false;
            this.desktop.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.desktop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.login_prof);
            this.Controls.Add(this.login_elev);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.login_final);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "Log-in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button login_elev;
        private System.Windows.Forms.Button login_prof;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login_final;
        private System.Windows.Forms.Button inapoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button desktop;
    }
}


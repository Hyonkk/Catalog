
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
            this.titlu = new System.Windows.Forms.Label();
            this.login_elev = new System.Windows.Forms.Button();
            this.login_prof = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_final = new System.Windows.Forms.Button();
            this.inapoi = new System.Windows.Forms.Button();
            this.desktop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tip_logare_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.titlu.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Italic);
            this.titlu.Location = new System.Drawing.Point(-618, 0);
            this.titlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(1920, 168);
            this.titlu.TabIndex = 1;
            this.titlu.Text = "TITLU";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_elev
            // 
            this.login_elev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_elev.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_elev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_elev.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.login_elev.FlatAppearance.BorderSize = 0;
            this.login_elev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_elev.Font = new System.Drawing.Font("Georgia", 15F);
            this.login_elev.Location = new System.Drawing.Point(144, 371);
            this.login_elev.Margin = new System.Windows.Forms.Padding(50);
            this.login_elev.Name = "login_elev";
            this.login_elev.Size = new System.Drawing.Size(125, 50);
            this.login_elev.TabIndex = 2;
            this.login_elev.TabStop = false;
            this.login_elev.Text = "Elev";
            this.login_elev.UseVisualStyleBackColor = false;
            this.login_elev.Click += new System.EventHandler(this.login_elev_click);
            // 
            // login_prof
            // 
            this.login_prof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_prof.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_prof.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_prof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_prof.FlatAppearance.BorderSize = 0;
            this.login_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_prof.Font = new System.Drawing.Font("Georgia", 15F);
            this.login_prof.Location = new System.Drawing.Point(417, 371);
            this.login_prof.Margin = new System.Windows.Forms.Padding(50);
            this.login_prof.Name = "login_prof";
            this.login_prof.Size = new System.Drawing.Size(125, 50);
            this.login_prof.TabIndex = 3;
            this.login_prof.TabStop = false;
            this.login_prof.Text = "Profesor";
            this.login_prof.UseVisualStyleBackColor = false;
            this.login_prof.Click += new System.EventHandler(this.login_prof_click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Georgia", 18F);
            this.user.Location = new System.Drawing.Point(68, 220);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(237, 35);
            this.user.TabIndex = 4;
            this.user.Text = "Nume de utilizator:";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user.Visible = false;
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Georgia", 18F);
            this.pass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pass.Location = new System.Drawing.Point(73, 274);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(232, 35);
            this.pass.TabIndex = 5;
            this.pass.Text = "Parolă:";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pass.Visible = false;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.Color.Wheat;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Georgia", 18F);
            this.username.Location = new System.Drawing.Point(309, 220);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(172, 35);
            this.username.TabIndex = 6;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.Color.Wheat;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Georgia", 18F);
            this.password.Location = new System.Drawing.Point(309, 275);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(172, 35);
            this.password.TabIndex = 7;
            // 
            // login_final
            // 
            this.login_final.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_final.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_final.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_final.FlatAppearance.BorderSize = 0;
            this.login_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_final.Font = new System.Drawing.Font("Georgia", 15F);
            this.login_final.Location = new System.Drawing.Point(417, 371);
            this.login_final.Name = "login_final";
            this.login_final.Size = new System.Drawing.Size(125, 50);
            this.login_final.TabIndex = 8;
            this.login_final.TabStop = false;
            this.login_final.Text = "Conectare";
            this.login_final.UseVisualStyleBackColor = false;
            this.login_final.Click += new System.EventHandler(this.login_final_clickAsync);
            // 
            // inapoi
            // 
            this.inapoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inapoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inapoi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Georgia", 15F);
            this.inapoi.Location = new System.Drawing.Point(144, 371);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(125, 50);
            this.inapoi.TabIndex = 9;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "Înapoi";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Visible = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // desktop
            // 
            this.desktop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.desktop.BackgroundImage = global::Catalog.Properties.Resources.output_onlinepngtools__28_;
            this.desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.desktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desktop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.desktop.FlatAppearance.BorderSize = 0;
            this.desktop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.desktop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desktop.Font = new System.Drawing.Font("Georgia", 30F);
            this.desktop.Location = new System.Drawing.Point(622, 399);
            this.desktop.Margin = new System.Windows.Forms.Padding(50);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(50, 50);
            this.desktop.TabIndex = 11;
            this.desktop.TabStop = false;
            this.desktop.UseVisualStyleBackColor = false;
            this.desktop.Visible = false;
            this.desktop.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = global::Catalog.Properties.Resources.output_onlinepngtools_8_;
            this.pictureBox1.Location = new System.Drawing.Point(584, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F);
            this.label3.Location = new System.Drawing.Point(549, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Designed by Freepik";
            // 
            // tip_logare_label
            // 
            this.tip_logare_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tip_logare_label.BackColor = System.Drawing.Color.Transparent;
            this.tip_logare_label.Font = new System.Drawing.Font("Georgia", 25F);
            this.tip_logare_label.Location = new System.Drawing.Point(224, 234);
            this.tip_logare_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tip_logare_label.Name = "tip_logare_label";
            this.tip_logare_label.Size = new System.Drawing.Size(237, 108);
            this.tip_logare_label.TabIndex = 22;
            this.tip_logare_label.Text = "Alege tipul de logare";
            this.tip_logare_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::Catalog.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tip_logare_label);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.login_final);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "login";
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.login_Load);
            this.Resize += new System.EventHandler(this.login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tip_logare_label;
    }
}


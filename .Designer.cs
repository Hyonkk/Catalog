namespace Catalog
{
    partial class Setari_profesor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setari_profesor));
            this.schimba_username = new System.Windows.Forms.Button();
            this.schimba_parola = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataBaseDataSet = new Catalog.DataBaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Catalog.DataBaseDataSetTableAdapters.UsersTableAdapter();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inapoi = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Label();
            this.vezi1 = new System.Windows.Forms.Label();
            this.vezi2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schimba_username
            // 
            this.schimba_username.BackColor = System.Drawing.Color.RoyalBlue;
            this.schimba_username.FlatAppearance.BorderSize = 0;
            this.schimba_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schimba_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schimba_username.ForeColor = System.Drawing.SystemColors.Control;
            this.schimba_username.Location = new System.Drawing.Point(83, 68);
            this.schimba_username.Name = "schimba_username";
            this.schimba_username.Size = new System.Drawing.Size(156, 79);
            this.schimba_username.TabIndex = 0;
            this.schimba_username.TabStop = false;
            this.schimba_username.Text = "Schimba username-ul";
            this.schimba_username.UseVisualStyleBackColor = false;
            this.schimba_username.Click += new System.EventHandler(this.schimba_username_Click);
            // 
            // schimba_parola
            // 
            this.schimba_parola.BackColor = System.Drawing.Color.RoyalBlue;
            this.schimba_parola.FlatAppearance.BorderSize = 0;
            this.schimba_parola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schimba_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schimba_parola.ForeColor = System.Drawing.SystemColors.Control;
            this.schimba_parola.Location = new System.Drawing.Point(386, 68);
            this.schimba_parola.Name = "schimba_parola";
            this.schimba_parola.Size = new System.Drawing.Size(156, 79);
            this.schimba_parola.TabIndex = 1;
            this.schimba_parola.TabStop = false;
            this.schimba_parola.Text = "Schimba parola";
            this.schimba_parola.UseVisualStyleBackColor = false;
            this.schimba_parola.Click += new System.EventHandler(this.schimba_parola_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(245, 362);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 69);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(275, 206);
            this.tx1.Margin = new System.Windows.Forms.Padding(2);
            this.tx1.Name = "tx1";
            this.tx1.PasswordChar = '*';
            this.tx1.Size = new System.Drawing.Size(230, 20);
            this.tx1.TabIndex = 3;
            this.tx1.Visible = false;
            this.tx1.TextChanged += new System.EventHandler(this.tx2_TextChanged);
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(275, 250);
            this.tx2.Margin = new System.Windows.Forms.Padding(2);
            this.tx2.Name = "tx2";
            this.tx2.PasswordChar = '*';
            this.tx2.Size = new System.Drawing.Size(230, 20);
            this.tx2.TabIndex = 4;
            this.tx2.Visible = false;
            this.tx2.TextChanged += new System.EventHandler(this.tx2_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmare parola noua";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parola noua";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.RoyalBlue;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoi.ForeColor = System.Drawing.SystemColors.Control;
            this.inapoi.Location = new System.Drawing.Point(105, 362);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(134, 69);
            this.inapoi.TabIndex = 8;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "Inapoi";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Visible = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // titlu
            // 
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(0, 0);
            this.titlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(625, 148);
            this.titlu.TabIndex = 9;
            this.titlu.Text = "Parola noua";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlu.Visible = false;
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.RoyalBlue;
            this.finish.FlatAppearance.BorderSize = 0;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.ForeColor = System.Drawing.SystemColors.Control;
            this.finish.Location = new System.Drawing.Point(385, 362);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(134, 69);
            this.finish.TabIndex = 10;
            this.finish.TabStop = false;
            this.finish.Text = "Confirmare";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Visible = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(485, 285);
            this.check.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 12;
            this.check.Visible = false;
            // 
            // vezi1
            // 
            this.vezi1.BackColor = System.Drawing.Color.Gray;
            this.vezi1.Image = global::Catalog.Properties.Resources.output_onlinepngtools__15_;
            this.vezi1.Location = new System.Drawing.Point(526, 206);
            this.vezi1.Name = "vezi1";
            this.vezi1.Size = new System.Drawing.Size(20, 20);
            this.vezi1.TabIndex = 13;
            this.vezi1.Visible = false;
            this.vezi1.Click += new System.EventHandler(this.vezi1_Click);
            // 
            // vezi2
            // 
            this.vezi2.BackColor = System.Drawing.Color.Gray;
            this.vezi2.Image = global::Catalog.Properties.Resources.output_onlinepngtools__15_;
            this.vezi2.Location = new System.Drawing.Point(526, 250);
            this.vezi2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.vezi2.Name = "vezi2";
            this.vezi2.Size = new System.Drawing.Size(20, 20);
            this.vezi2.TabIndex = 14;
            this.vezi2.Visible = false;
            this.vezi2.Click += new System.EventHandler(this.vezi2_Click);
            // 
            // Setari_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(625, 442);
            this.Controls.Add(this.vezi2);
            this.Controls.Add(this.vezi1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.schimba_parola);
            this.Controls.Add(this.schimba_username);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.titlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setari_profesor";
            this.Text = "Setari";
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button schimba_username;
        private System.Windows.Forms.Button schimba_parola;
        private System.Windows.Forms.Button exit;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataBaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inapoi;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Label vezi1;
        private System.Windows.Forms.Label vezi2;
    }
}
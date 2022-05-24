namespace Catalog
{
    partial class catalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalog));
            this.CB_materii = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inapoi = new System.Windows.Forms.Button();
            this.afis_note = new System.Windows.Forms.Button();
            this.afis_absente = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.data_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenta_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivat_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afis_media = new System.Windows.Forms.Button();
            this.medie = new System.Windows.Forms.Label();
            this.data_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_materii
            // 
            this.CB_materii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_materii.FormattingEnabled = true;
            this.CB_materii.Location = new System.Drawing.Point(11, 10);
            this.CB_materii.Margin = new System.Windows.Forms.Padding(2);
            this.CB_materii.Name = "CB_materii";
            this.CB_materii.Size = new System.Drawing.Size(429, 28);
            this.CB_materii.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_note,
            this.nota_note});
            this.dataGridView1.Location = new System.Drawing.Point(11, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoi.Location = new System.Drawing.Point(721, 10);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(123, 56);
            this.inapoi.TabIndex = 10;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "Inapoi la terminal";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // afis_note
            // 
            this.afis_note.BackColor = System.Drawing.Color.CornflowerBlue;
            this.afis_note.FlatAppearance.BorderSize = 0;
            this.afis_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afis_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afis_note.Location = new System.Drawing.Point(463, 10);
            this.afis_note.Name = "afis_note";
            this.afis_note.Size = new System.Drawing.Size(123, 56);
            this.afis_note.TabIndex = 11;
            this.afis_note.TabStop = false;
            this.afis_note.Text = "Afiseaza note";
            this.afis_note.UseVisualStyleBackColor = false;
            this.afis_note.Click += new System.EventHandler(this.afis_note_Click);
            // 
            // afis_absente
            // 
            this.afis_absente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.afis_absente.FlatAppearance.BorderSize = 0;
            this.afis_absente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afis_absente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afis_absente.Location = new System.Drawing.Point(592, 10);
            this.afis_absente.Name = "afis_absente";
            this.afis_absente.Size = new System.Drawing.Size(123, 56);
            this.afis_absente.TabIndex = 12;
            this.afis_absente.TabStop = false;
            this.afis_absente.Text = "Afiseaza absentele";
            this.afis_absente.UseVisualStyleBackColor = false;
            this.afis_absente.Click += new System.EventHandler(this.afis_absente_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_absente,
            this.absenta_absente,
            this.motivat_absente});
            this.dataGridView2.Location = new System.Drawing.Point(446, 71);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(429, 611);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // data_absente
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.data_absente.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_absente.HeaderText = "Data";
            this.data_absente.MinimumWidth = 6;
            this.data_absente.Name = "data_absente";
            this.data_absente.ReadOnly = true;
            // 
            // absenta_absente
            // 
            this.absenta_absente.HeaderText = "Absente";
            this.absenta_absente.MinimumWidth = 6;
            this.absenta_absente.Name = "absenta_absente";
            this.absenta_absente.ReadOnly = true;
            // 
            // motivat_absente
            // 
            this.motivat_absente.HeaderText = "Motivat";
            this.motivat_absente.Name = "motivat_absente";
            this.motivat_absente.ReadOnly = true;
            // 
            // afis_media
            // 
            this.afis_media.BackColor = System.Drawing.Color.CornflowerBlue;
            this.afis_media.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.afis_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afis_media.Location = new System.Drawing.Point(39, 416);
            this.afis_media.Name = "afis_media";
            this.afis_media.Size = new System.Drawing.Size(123, 56);
            this.afis_media.TabIndex = 14;
            this.afis_media.Text = "Calculeaza media";
            this.afis_media.UseVisualStyleBackColor = false;
            this.afis_media.Click += new System.EventHandler(this.afis_media_Click);
            // 
            // medie
            // 
            this.medie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medie.Location = new System.Drawing.Point(245, 416);
            this.medie.Name = "medie";
            this.medie.Size = new System.Drawing.Size(123, 56);
            this.medie.TabIndex = 15;
            this.medie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_note
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data_note.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_note.HeaderText = "Data";
            this.data_note.MinimumWidth = 6;
            this.data_note.Name = "data_note";
            this.data_note.ReadOnly = true;
            this.data_note.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nota_note
            // 
            this.nota_note.HeaderText = "Nota";
            this.nota_note.MinimumWidth = 6;
            this.nota_note.Name = "nota_note";
            this.nota_note.ReadOnly = true;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(886, 693);
            this.Controls.Add(this.medie);
            this.Controls.Add(this.afis_media);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.afis_absente);
            this.Controls.Add(this.afis_note);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_materii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "catalog";
            this.Text = "Catalog ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_materii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inapoi;
        private System.Windows.Forms.Button afis_note;
        private System.Windows.Forms.Button afis_absente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_absente;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenta_absente;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivat_absente;
        private System.Windows.Forms.Button afis_media;
        private System.Windows.Forms.Label medie;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_note;
    }
}
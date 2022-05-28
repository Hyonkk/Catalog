namespace Catalog
{
    partial class catalog_profesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_clase = new System.Windows.Forms.ComboBox();
            this.dgv_elevi = new System.Windows.Forms.DataGridView();
            this.nr_elev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume_elev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_note = new System.Windows.Forms.DataGridView();
            this.data_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_absente = new System.Windows.Forms.DataGridView();
            this.data_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenta_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivat_absente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clasa = new System.Windows.Forms.Label();
            this.inapoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_absente)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_clase
            // 
            this.CB_clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_clase.FormattingEnabled = true;
            this.CB_clase.Location = new System.Drawing.Point(11, 53);
            this.CB_clase.Margin = new System.Windows.Forms.Padding(2);
            this.CB_clase.Name = "CB_clase";
            this.CB_clase.Size = new System.Drawing.Size(475, 28);
            this.CB_clase.TabIndex = 1;
            this.CB_clase.TabStop = false;
            this.CB_clase.SelectedIndexChanged += new System.EventHandler(this.CB_clase_SelectedIndexChanged);
            // 
            // dgv_elevi
            // 
            this.dgv_elevi.AllowUserToAddRows = false;
            this.dgv_elevi.AllowUserToDeleteRows = false;
            this.dgv_elevi.AllowUserToResizeColumns = false;
            this.dgv_elevi.AllowUserToResizeRows = false;
            this.dgv_elevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_elevi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_elevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_elevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_elev,
            this.nume_elev});
            this.dgv_elevi.Location = new System.Drawing.Point(12, 97);
            this.dgv_elevi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_elevi.Name = "dgv_elevi";
            this.dgv_elevi.ReadOnly = true;
            this.dgv_elevi.RowHeadersVisible = false;
            this.dgv_elevi.RowHeadersWidth = 51;
            this.dgv_elevi.RowTemplate.Height = 24;
            this.dgv_elevi.Size = new System.Drawing.Size(475, 450);
            this.dgv_elevi.TabIndex = 3;
            this.dgv_elevi.TabStop = false;
            this.dgv_elevi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_elevi_CellClick);
            // 
            // nr_elev
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.nr_elev.DefaultCellStyle = dataGridViewCellStyle1;
            this.nr_elev.FillWeight = 4F;
            this.nr_elev.HeaderText = "Nr.";
            this.nr_elev.MinimumWidth = 6;
            this.nr_elev.Name = "nr_elev";
            this.nr_elev.ReadOnly = true;
            this.nr_elev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nume_elev
            // 
            this.nume_elev.FillWeight = 50.76142F;
            this.nume_elev.HeaderText = "Nume";
            this.nume_elev.MinimumWidth = 6;
            this.nume_elev.Name = "nume_elev";
            this.nume_elev.ReadOnly = true;
            // 
            // dgv_note
            // 
            this.dgv_note.AllowUserToAddRows = false;
            this.dgv_note.AllowUserToDeleteRows = false;
            this.dgv_note.AllowUserToResizeColumns = false;
            this.dgv_note.AllowUserToResizeRows = false;
            this.dgv_note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_note.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_note.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_note,
            this.nota_note});
            this.dgv_note.Location = new System.Drawing.Point(498, 97);
            this.dgv_note.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_note.Name = "dgv_note";
            this.dgv_note.ReadOnly = true;
            this.dgv_note.RowHeadersVisible = false;
            this.dgv_note.RowHeadersWidth = 51;
            this.dgv_note.RowTemplate.Height = 24;
            this.dgv_note.Size = new System.Drawing.Size(475, 200);
            this.dgv_note.TabIndex = 4;
            this.dgv_note.TabStop = false;
            this.dgv_note.SelectionChanged += new System.EventHandler(this.dgv_note_SelectionChanged);
            // 
            // data_note
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.data_note.DefaultCellStyle = dataGridViewCellStyle2;
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
            // dgv_absente
            // 
            this.dgv_absente.AllowUserToAddRows = false;
            this.dgv_absente.AllowUserToDeleteRows = false;
            this.dgv_absente.AllowUserToResizeColumns = false;
            this.dgv_absente.AllowUserToResizeRows = false;
            this.dgv_absente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_absente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_absente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_absente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_absente,
            this.absenta_absente,
            this.motivat_absente});
            this.dgv_absente.Location = new System.Drawing.Point(498, 347);
            this.dgv_absente.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_absente.Name = "dgv_absente";
            this.dgv_absente.ReadOnly = true;
            this.dgv_absente.RowHeadersVisible = false;
            this.dgv_absente.RowHeadersWidth = 51;
            this.dgv_absente.RowTemplate.Height = 24;
            this.dgv_absente.Size = new System.Drawing.Size(475, 200);
            this.dgv_absente.TabIndex = 14;
            this.dgv_absente.TabStop = false;
            this.dgv_absente.SelectionChanged += new System.EventHandler(this.dgv_absente_SelectionChanged);
            // 
            // data_absente
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.data_absente.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.motivat_absente.MinimumWidth = 6;
            this.motivat_absente.Name = "motivat_absente";
            this.motivat_absente.ReadOnly = true;
            this.motivat_absente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.motivat_absente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clasa
            // 
            this.clasa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasa.ForeColor = System.Drawing.Color.Black;
            this.clasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clasa.Location = new System.Drawing.Point(12, 15);
            this.clasa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.clasa.Name = "clasa";
            this.clasa.Size = new System.Drawing.Size(200, 30);
            this.clasa.TabIndex = 19;
            this.clasa.Text = "Clasa";
            this.clasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inapoi.Location = new System.Drawing.Point(12, 619);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(202, 56);
            this.inapoi.TabIndex = 21;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "Inapoi la terminal";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // catalog_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.clasa);
            this.Controls.Add(this.dgv_absente);
            this.Controls.Add(this.dgv_note);
            this.Controls.Add(this.dgv_elevi);
            this.Controls.Add(this.CB_clase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "catalog_profesor";
            this.Text = "catalog_profesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_absente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox CB_clase;
        public System.Windows.Forms.DataGridView dgv_elevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_elev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume_elev;
        public System.Windows.Forms.DataGridView dgv_note;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_note;
        public System.Windows.Forms.DataGridViewTextBoxColumn nota_note;
        public System.Windows.Forms.DataGridView dgv_absente;
        private System.Windows.Forms.Label clasa;
        public System.Windows.Forms.Button inapoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_absente;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenta_absente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn motivat_absente;
    }
}
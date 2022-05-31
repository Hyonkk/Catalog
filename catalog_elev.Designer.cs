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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalog));
            this.CB_materii = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inapoi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.data_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenta_absente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivat_absente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medie = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.denumire_note_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_note_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_note_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.denumire_absente_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_absente_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenta_absente_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivat_absente_total = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clasa = new System.Windows.Forms.Label();
            this.lb_med = new System.Windows.Forms.Label();
            this.lb_medie = new System.Windows.Forms.Label();
            this.lb_abs = new System.Windows.Forms.Label();
            this.lb_absente = new System.Windows.Forms.Label();
            this.lb_abs_motivate = new System.Windows.Forms.Label();
            this.lb_absente_motivate = new System.Windows.Forms.Label();
            this.lb_abs_nemotivate = new System.Windows.Forms.Label();
            this.lb_absente_nemotivate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_materii
            // 
            this.CB_materii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_materii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_materii.FormattingEnabled = true;
            this.CB_materii.Location = new System.Drawing.Point(11, 53);
            this.CB_materii.Margin = new System.Windows.Forms.Padding(2);
            this.CB_materii.Name = "CB_materii";
            this.CB_materii.Size = new System.Drawing.Size(475, 28);
            this.CB_materii.TabIndex = 0;
            this.CB_materii.TabStop = false;
            this.CB_materii.SelectedIndexChanged += new System.EventHandler(this.CB_materii_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_note,
            this.nota_note});
            this.dataGridView1.Location = new System.Drawing.Point(11, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inapoi.Location = new System.Drawing.Point(634, 25);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(202, 56);
            this.inapoi.TabIndex = 10;
            this.inapoi.TabStop = false;
            this.inapoi.Text = "Inapoi la terminal";
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_absente,
            this.absenta_absente,
            this.motivat_absente});
            this.dataGridView2.Location = new System.Drawing.Point(498, 144);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(475, 256);
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
            this.motivat_absente.MinimumWidth = 6;
            this.motivat_absente.Name = "motivat_absente";
            this.motivat_absente.ReadOnly = true;
            this.motivat_absente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.motivat_absente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // medie
            // 
            this.medie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medie.Location = new System.Drawing.Point(363, 424);
            this.medie.Name = "medie";
            this.medie.Size = new System.Drawing.Size(123, 56);
            this.medie.TabIndex = 15;
            this.medie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumire_note_total,
            this.data_note_total,
            this.nota_note_total});
            this.dataGridView3.Location = new System.Drawing.Point(11, 144);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(475, 256);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.TabStop = false;
            this.dataGridView3.Visible = false;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // denumire_note_total
            // 
            this.denumire_note_total.HeaderText = "Disciplina";
            this.denumire_note_total.MinimumWidth = 6;
            this.denumire_note_total.Name = "denumire_note_total";
            this.denumire_note_total.ReadOnly = true;
            // 
            // data_note_total
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.data_note_total.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_note_total.HeaderText = "Data";
            this.data_note_total.MinimumWidth = 6;
            this.data_note_total.Name = "data_note_total";
            this.data_note_total.ReadOnly = true;
            this.data_note_total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nota_note_total
            // 
            this.nota_note_total.HeaderText = "Nota";
            this.nota_note_total.MinimumWidth = 6;
            this.nota_note_total.Name = "nota_note_total";
            this.nota_note_total.ReadOnly = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumire_absente_total,
            this.data_absente_total,
            this.absenta_absente_total,
            this.motivat_absente_total});
            this.dataGridView4.Location = new System.Drawing.Point(498, 144);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(475, 256);
            this.dataGridView4.TabIndex = 17;
            this.dataGridView4.TabStop = false;
            this.dataGridView4.Visible = false;
            this.dataGridView4.SelectionChanged += new System.EventHandler(this.dataGridView4_SelectionChanged);
            // 
            // denumire_absente_total
            // 
            this.denumire_absente_total.HeaderText = "Disciplina";
            this.denumire_absente_total.Name = "denumire_absente_total";
            this.denumire_absente_total.ReadOnly = true;
            // 
            // data_absente_total
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.data_absente_total.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_absente_total.HeaderText = "Data";
            this.data_absente_total.MinimumWidth = 6;
            this.data_absente_total.Name = "data_absente_total";
            this.data_absente_total.ReadOnly = true;
            // 
            // absenta_absente_total
            // 
            this.absenta_absente_total.HeaderText = "Absente";
            this.absenta_absente_total.MinimumWidth = 6;
            this.absenta_absente_total.Name = "absenta_absente_total";
            this.absenta_absente_total.ReadOnly = true;
            // 
            // motivat_absente_total
            // 
            this.motivat_absente_total.HeaderText = "Motivat";
            this.motivat_absente_total.MinimumWidth = 6;
            this.motivat_absente_total.Name = "motivat_absente_total";
            this.motivat_absente_total.ReadOnly = true;
            this.motivat_absente_total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.motivat_absente_total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.clasa.TabIndex = 18;
            this.clasa.Text = "Materia";
            this.clasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_med
            // 
            this.lb_med.AutoSize = true;
            this.lb_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_med.Location = new System.Drawing.Point(109, 449);
            this.lb_med.Name = "lb_med";
            this.lb_med.Size = new System.Drawing.Size(0, 31);
            this.lb_med.TabIndex = 39;
            this.lb_med.Visible = false;
            // 
            // lb_medie
            // 
            this.lb_medie.AutoSize = true;
            this.lb_medie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medie.Location = new System.Drawing.Point(12, 449);
            this.lb_medie.Name = "lb_medie";
            this.lb_medie.Size = new System.Drawing.Size(102, 31);
            this.lb_medie.TabIndex = 38;
            this.lb_medie.Text = "Media: ";
            this.lb_medie.Visible = false;
            // 
            // lb_abs
            // 
            this.lb_abs.AutoSize = true;
            this.lb_abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_abs.Location = new System.Drawing.Point(702, 449);
            this.lb_abs.Name = "lb_abs";
            this.lb_abs.Size = new System.Drawing.Size(0, 31);
            this.lb_abs.TabIndex = 41;
            this.lb_abs.Visible = false;
            // 
            // lb_absente
            // 
            this.lb_absente.AutoSize = true;
            this.lb_absente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_absente.Location = new System.Drawing.Point(492, 449);
            this.lb_absente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lb_absente.Name = "lb_absente";
            this.lb_absente.Size = new System.Drawing.Size(210, 31);
            this.lb_absente.TabIndex = 40;
            this.lb_absente.Text = "Numar Absente:";
            this.lb_absente.Visible = false;
            // 
            // lb_abs_motivate
            // 
            this.lb_abs_motivate.AutoSize = true;
            this.lb_abs_motivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_abs_motivate.Location = new System.Drawing.Point(812, 490);
            this.lb_abs_motivate.Name = "lb_abs_motivate";
            this.lb_abs_motivate.Size = new System.Drawing.Size(0, 31);
            this.lb_abs_motivate.TabIndex = 43;
            this.lb_abs_motivate.Visible = false;
            // 
            // lb_absente_motivate
            // 
            this.lb_absente_motivate.AutoSize = true;
            this.lb_absente_motivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_absente_motivate.Location = new System.Drawing.Point(492, 490);
            this.lb_absente_motivate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lb_absente_motivate.Name = "lb_absente_motivate";
            this.lb_absente_motivate.Size = new System.Drawing.Size(320, 31);
            this.lb_absente_motivate.TabIndex = 42;
            this.lb_absente_motivate.Text = "Numar Absente Motivate:";
            this.lb_absente_motivate.Visible = false;
            // 
            // lb_abs_nemotivate
            // 
            this.lb_abs_nemotivate.AutoSize = true;
            this.lb_abs_nemotivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_abs_nemotivate.Location = new System.Drawing.Point(847, 531);
            this.lb_abs_nemotivate.Name = "lb_abs_nemotivate";
            this.lb_abs_nemotivate.Size = new System.Drawing.Size(0, 31);
            this.lb_abs_nemotivate.TabIndex = 45;
            this.lb_abs_nemotivate.Visible = false;
            // 
            // lb_absente_nemotivate
            // 
            this.lb_absente_nemotivate.AutoSize = true;
            this.lb_absente_nemotivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_absente_nemotivate.Location = new System.Drawing.Point(492, 531);
            this.lb_absente_nemotivate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lb_absente_nemotivate.Name = "lb_absente_nemotivate";
            this.lb_absente_nemotivate.Size = new System.Drawing.Size(355, 31);
            this.lb_absente_nemotivate.TabIndex = 44;
            this.lb_absente_nemotivate.Text = "Numar Absente Nemotivate:";
            this.lb_absente_nemotivate.Visible = false;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.lb_abs_nemotivate);
            this.Controls.Add(this.lb_absente_nemotivate);
            this.Controls.Add(this.lb_abs_motivate);
            this.Controls.Add(this.lb_absente_motivate);
            this.Controls.Add(this.lb_abs);
            this.Controls.Add(this.lb_absente);
            this.Controls.Add(this.lb_med);
            this.Controls.Add(this.lb_medie);
            this.Controls.Add(this.clasa);
            this.Controls.Add(this.medie);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_materii);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "catalog";
            this.Text = "Catalog ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CB_materii;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button inapoi;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label medie;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_note;
        public System.Windows.Forms.DataGridViewTextBoxColumn nota_note;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridViewTextBoxColumn denumire_note_total;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_note_total;
        public System.Windows.Forms.DataGridViewTextBoxColumn nota_note_total;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label clasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumire_absente_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_absente_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenta_absente_total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn motivat_absente_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_absente;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenta_absente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn motivat_absente;
        private System.Windows.Forms.Label lb_med;
        private System.Windows.Forms.Label lb_medie;
        private System.Windows.Forms.Label lb_abs;
        private System.Windows.Forms.Label lb_absente;
        private System.Windows.Forms.Label lb_abs_motivate;
        private System.Windows.Forms.Label lb_absente_motivate;
        private System.Windows.Forms.Label lb_abs_nemotivate;
        private System.Windows.Forms.Label lb_absente_nemotivate;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class ter_elev : Form
    {
        private Button setari = new Button();
        private Button catalog=new Button();
        public static Label eticheta_nume=new Label();
        public ter_elev()
        {
            InitializeComponent();
            global.F_curent = this;
            global.F_curent.Select();
            global.F_curent.BackColor = System.Drawing.Color.LightGray;
            this.CenterToScreen();
            creare_butoane();
        }
        private void creare_butoane()
        {
            //setari
            setari.Text = "Setari";
            setari.TextAlign = ContentAlignment.MiddleCenter;
            setari.Size = new Size(150, 50);
            setari.Location = new Point(30, 150);
            setari.FlatStyle = FlatStyle.Flat;
            setari.Font= new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            global.F_curent.Controls.Add(setari);
            setari.Click += new System.EventHandler(setari_Click);
            setari.BackColor = Color.LightSkyBlue;

            //nume
            eticheta_nume.Text=global.nume_curent.ToString();
            eticheta_nume.Location = new Point(30, 50);
            eticheta_nume.FlatStyle = FlatStyle.Flat;
            //eticheta_nume.Size = new Size(300, 50);
            eticheta_nume.TextAlign = ContentAlignment.MiddleCenter;
            eticheta_nume.Font= new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eticheta_nume.AutoSize = true;
            eticheta_nume.BorderStyle = BorderStyle.FixedSingle;
            global.F_curent.Controls.Add(eticheta_nume);
            eticheta_nume.BackColor= Color.LightSkyBlue;

            //catalog `button`
            catalog.Text = "Catalog";
            catalog.TextAlign = ContentAlignment.MiddleCenter;
            catalog.Location = new Point(30, 250);
            catalog.Size = new Size(150, 50);
            catalog.FlatStyle = FlatStyle.Flat;
            catalog.Font= new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            global.F_curent.Controls.Add(catalog);
            catalog.BackColor= Color.LightSkyBlue;
        }

        private void setari_Click(object sender, EventArgs e)
        {
            setari f = new setari();
            f.Show();
        }
    }
}

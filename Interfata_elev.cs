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
        public ter_elev()
        {
            InitializeComponent();
            global.F_curent = this;
            global.F_curent.Select();
            this.CenterToScreen();
            creare_butoane();
            clasa.Text = "Clasa "+global.clasa_curenta;
        }
        private void creare_butoane()
        {
            eticheta_nume.Text = global.nume_default;
        }

        private void setari_Click(object sender, EventArgs e)
        {
            setari f = new setari();
            f.Show();
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            global.F_curent = new catalog();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            global.F_curent = new login();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
            global.ctr_log = 0;
        }
    }
}

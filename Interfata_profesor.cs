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
    public partial class ter_profesor : Form
    {
        public ter_profesor()
        {
            InitializeComponent();
            creare_nume();
            this.CenterToScreen();
        }

        private void creare_nume()
        {
            eticheta_nume.Text = global.nume_default;
        }

        private void setari_Click(object sender, EventArgs e)
        {
            Setari_profesor f = new Setari_profesor();
            f.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            global.F_curent = new login();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
            global.ctr_log = 0;
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            global.F_curent = new catalog_profesor();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }
    }
}

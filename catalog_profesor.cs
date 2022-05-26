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
    public partial class catalog_profesor : Form
    {
        public catalog_profesor()
        {
            InitializeComponent();
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            global.F_curent = new ter_profesor();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }
    }
}

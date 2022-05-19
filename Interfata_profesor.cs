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
            Back.SendToBack();
        }

        private void creare_nume()
        {
            eticheta_nume.Text = global.nume_curent;
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}

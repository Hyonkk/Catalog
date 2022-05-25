using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Catalog
{
    public partial class catalog : Form
    {
        int ctr;
        public catalog()
        {
            global.F_curent = this;
            InitializeComponent();
            this.CenterToScreen();
            Server.combobox_materii();
            CB_materii = Server.CB_materii;
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            global.F_curent = new ter_elev();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }

        private void afis_note_Click(object sender, EventArgs e)
        {
            global.materie_curenta_elev = CB_materii.Text;
            if(String.Equals(global.materie_curenta_elev,"Toate"))
            {
                ctr = 1;
                dataGridView1.Visible = false;
                dataGridView3.Visible = true;
                Server.afis_note_total_();
                afis_media.Visible = false;
                medie.Visible = false;
            }
            else
            {
                ctr = 2;
                dataGridView1.Visible = true;
                dataGridView3.Visible = false;
                Server.afis_note_();
                afis_media.Visible = true;
                medie.Visible = true;
            }
        }

        private void afis_absente_Click(object sender, EventArgs e)
        {
            global.materie_curenta_elev = CB_materii.Text;
            Server.afis_absente_();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = null;
        }

        private void afis_media_Click(object sender, EventArgs e)
        {
            Server.calc_media();
        }
    }
}

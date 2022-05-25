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
            CB_materii.Items.AddRange(Server.CB_materii.Items.Cast<Object>().ToArray());
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            global.F_curent = new ter_elev();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView3.CurrentCell = null;
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView4.CurrentCell = null;
        }

        private void afis_media_Click(object sender, EventArgs e)
        {
            Server.calc_media();
            medie.Text=Server.medie.Text;
        }

        private void CB_materii_SelectedIndexChanged(object sender, EventArgs e)
        {
            medie.Text = "";
            global.materie_curenta_elev = CB_materii.Text;
            if (String.Equals(global.materie_curenta_elev, "Toate"))
            {
                ctr = 1;

                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
                afis_media.Visible = false;
                medie.Visible = false;

                Server.afis_note_total_();
                Server.afis_absente_total_();

                dataGridView3.Rows.Clear();
                dataGridView4.Rows.Clear();

                for (int i = 0; i < Server.dataGridView3.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView3.Rows[i];
                    dataGridView3.Rows.Add();
                    DataGridViewRow row1 = dataGridView3.Rows[i];
                    row1.Cells["denumire_note_total"].Value = row.Cells["denumire_note_total"].Value;
                    row1.Cells["data_note_total"].Value = row.Cells["data_note_total"].Value;
                    row1.Cells["nota_note_total"].Value = row.Cells["nota_note_total"].Value;
                }

                for (int i = 0; i < Server.dataGridView4.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView4.Rows[i];
                    dataGridView4.Rows.Add();
                    DataGridViewRow row1 = dataGridView4.Rows[i];
                    row1.Cells["denumire_absente_total"].Value = row.Cells["denumire_absente_total"].Value;
                    row1.Cells["data_absente_total"].Value = row.Cells["data_absente_total"].Value;
                    row1.Cells["absenta_absente_total"].Value = row.Cells["absenta_absente_total"].Value;
                    row1.Cells["motivat_absente_total"].Value = row.Cells["motivat_absente_total"].Value;
                }
            }
            else
            {
                ctr = 2;

                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                afis_media.Visible = true;
                medie.Visible = true;

                Server.afis_note_();
                Server.afis_absente_();

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                for (int i = 0; i < Server.dataGridView1.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView1.Rows[i];
                    dataGridView1.Rows.Add();
                    DataGridViewRow row1 = dataGridView1.Rows[i];
                    row1.Cells["data_note"].Value = row.Cells["data_note"].Value;
                    row1.Cells["nota_note"].Value = row.Cells["nota_note"].Value;
                }

                for (int i = 0; i < Server.dataGridView2.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView2.Rows[i];
                    dataGridView2.Rows.Add();
                    DataGridViewRow row1 = dataGridView2.Rows[i];
                    row1.Cells["data_absente"].Value = row.Cells["data_absente"].Value;
                    row1.Cells["absenta_absente"].Value = row.Cells["absenta_absente"].Value;
                    row1.Cells["motivat_absente"].Value = row.Cells["motivat_absente"].Value;
                }
            }
        }
    }
}

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


        private void CB_materii_SelectedIndexChanged(object sender, EventArgs e)
        {
            inapoi.Focus();
            medie.Text = "";
            global.materie_curenta_elev = CB_materii.Text;
            if (String.Equals(global.materie_curenta_elev, "Toate"))
            {

                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
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

                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                medie.Visible = false;

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
            if(!String.Equals(CB_materii.Text,"Toate"))
            {
                global.medie = -1;
                global.nrabsente = -1;
                Server.afis_media_elev();
                Server.afis_nr_absente();
                Server.afis_nr_absente_motivate();
                lb_med.Text = "Nu se poate calcula media";
                if (global.medie != -1)
                {
                    lb_med.Text = global.medie.ToString("0.00");
                }

                lb_abs.Text = global.nrabsente.ToString();
                lb_abs_motivate.Text = global.nrabsentemotivate.ToString();
                lb_abs_nemotivate.Text = (global.nrabsente - global.nrabsentemotivate).ToString();
                lb_medie.Visible = true;
                lb_med.Visible = true;
                lb_abs.Visible = true;
                lb_absente.Visible = true;
                lb_absente_motivate.Visible = true;
                lb_abs_motivate.Visible = true;
                lb_abs_nemotivate.Visible = true;
                lb_absente_nemotivate.Visible = true;
            }
            else
            {
                lb_medie.Visible = false;
                lb_med.Visible = false;
                lb_abs.Visible = false;
                lb_absente.Visible = false;
                lb_abs_motivate.Visible = false;
                lb_absente_motivate.Visible = false;
                lb_abs_nemotivate.Visible = false;
                lb_absente_nemotivate.Visible = false;
            }
        }
    }
}

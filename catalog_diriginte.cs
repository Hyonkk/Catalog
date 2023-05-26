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
    public partial class catalog_diriginte : Form
    {
        private int ctrl = 0;
        public catalog_diriginte()
        {
            InitializeComponent();
            this.CenterToScreen();
            Server.combobox_materii();
            CB_disciplina.Items.AddRange(Server.CB_materii.Items.Cast<Object>().ToArray());
            global.clasa_input = global.diriginte;
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            global.F_curent = new ter_profesor();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }

        private void dgv_elevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ctrl == 1)
                {
                    global.elev_selectat = dgv_elevi.CurrentCell.Value.ToString();
                    global.medie = -1;
                    lb_med.Text = "Nu se poate calcula media";
                    Server.afis_absente_profesori_();
                    Server.afis_note_profesori_();
                    Server.nume_to_id();
                    Server.afis_media();
                    lb_medie.Visible = true;
                    lb_med.Visible = true;
                    if (global.medie != -1)
                    {
                        lb_med.Text = global.medie.ToString("0.00");
                    }

                    dgv_absente.Rows.Clear();
                    dgv_note.Rows.Clear();

                    for (int i = 0; i < Server.dataGridView1.RowCount - 1; i++)
                    {
                        DataGridViewRow row = Server.dataGridView1.Rows[i];
                        dgv_note.Rows.Add();
                        DataGridViewRow row1 = dgv_note.Rows[i];
                        row1.Cells["data_note"].Value = row.Cells["data_note"].Value;
                        row1.Cells["nota_note"].Value = row.Cells["nota_note"].Value;
                    }

                    for (int i = 0; i < Server.dataGridView2.RowCount - 1; i++)
                    {
                        DataGridViewRow row = Server.dataGridView2.Rows[i];
                        dgv_absente.Rows.Add();
                        DataGridViewRow row1 = dgv_absente.Rows[i];
                        row1.Cells["data_absente"].Value = row.Cells["data_absente"].Value;
                        row1.Cells["absenta_absente"].Value = row.Cells["absenta_absente"].Value;
                        row1.Cells["motivat_absente"].Value = row.Cells["motivat_absente"].Value;
                    }
                    dgv_note.CurrentCell = null;
                    dgv_absente.CurrentCell = null;
                }
                else MessageBox.Show("Selectati o clasa!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { };
        }

        private void CB_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.materie_selectata = CB_disciplina.Text;
            Server.disciplina_to_id();
            Server.get_elevi_from_clase();
            ctrl = 1;
            dgv_elevi.Rows.Clear();
            dgv_absente.Rows.Clear();
            dgv_note.Rows.Clear();
            Server.get_elevi_from_clase();
            for (int i = 0; i < Server.get_elvcls.RowCount - 1; i++)
            {
                DataGridViewRow row = Server.get_elvcls.Rows[i];
                dgv_elevi.Rows.Add();
                DataGridViewRow row1 = dgv_elevi.Rows[i];
                row1.Cells["nr_elev"].Value = Convert.ToString(i + 1);
                row1.Cells["nume_elev"].Value = row.Cells["nume_elev"].Value;
            }
            dgv_elevi.CurrentCell = null;
        }

        private void b_ab_Click(object sender, EventArgs e)
        {
            if (String.Equals(lb_data.Text, "") || String.Equals(lb_noab.Text, "")) MessageBox.Show("Introduceti o data sau o nota/absenta valida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                global.data_selectat = Convert.ToDateTime(lb_data.Text);
                global.noab = Convert.ToInt32(lb_noab.Text);

                Server.ab_incarc();
                Server.afis_absente_profesori_();

                dgv_absente.Rows.Clear();

                for (int i = 0; i < Server.dataGridView2.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView2.Rows[i];
                    dgv_absente.Rows.Add();
                    DataGridViewRow row1 = dgv_absente.Rows[i];
                    row1.Cells["data_absente"].Value = row.Cells["data_absente"].Value;
                    row1.Cells["absenta_absente"].Value = row.Cells["absenta_absente"].Value;
                    row1.Cells["motivat_absente"].Value = row.Cells["motivat_absente"].Value;
                }

                lb_data.Text = "";
                lb_noab.Text = "";
                dateTimePicker1.Text = "";
                CB_noab.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lb_data.Text = dateTimePicker1.Text;
            global.data_selectat = Convert.ToDateTime(lb_data.Text);
        }

        private void CB_noab_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_noab.Text = CB_noab.Text;
            global.noab = Convert.ToInt32(lb_noab.Text);
        }

        private void sterg_ab_Click(object sender, EventArgs e)
        {
            dgv_note.CurrentCell = null;
            dgv_absente.CurrentCell = null;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            global.data_de_sters = Convert.ToDateTime(dgv_absente.SelectedCells[0].Value);
            Server.absenta_delete();
            Server.afis_absente_profesori_();

            dgv_absente.Rows.Clear();

            for (int i = 0; i < Server.dataGridView2.RowCount - 1; i++)
            {
                DataGridViewRow row = Server.dataGridView2.Rows[i];
                dgv_absente.Rows.Add();
                DataGridViewRow row1 = dgv_absente.Rows[i];
                row1.Cells["data_absente"].Value = row.Cells["data_absente"].Value;
                row1.Cells["absenta_absente"].Value = row.Cells["absenta_absente"].Value;
                row1.Cells["motivat_absente"].Value = row.Cells["motivat_absente"].Value;
            }
        }

        private void dgv_absente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                global.motivat = Convert.ToBoolean(dgv_absente.SelectedCells[2].Value);
                global.data_de_sters = Convert.ToDateTime(dgv_absente.SelectedCells[0].Value);
                Server.absenta_motivat();
                Server.afis_absente_profesori_();

                dgv_absente.Rows.Clear();

                for (int i = 0; i < Server.dataGridView2.RowCount - 1; i++)
                {
                    DataGridViewRow row = Server.dataGridView2.Rows[i];
                    dgv_absente.Rows.Add();
                    DataGridViewRow row1 = dgv_absente.Rows[i];
                    row1.Cells["data_absente"].Value = row.Cells["data_absente"].Value;
                    row1.Cells["absenta_absente"].Value = row.Cells["absenta_absente"].Value;
                    row1.Cells["motivat_absente"].Value = row.Cells["motivat_absente"].Value;
                }
            }
            catch { }
        }
    }
}

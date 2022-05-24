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
            InitializeComponent();
            this.CenterToScreen();
            combobox_materii();
        }

        private void combobox_materii()
        {
            using(SqlConnection sqlCon = new SqlConnection(Server.connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select distinct d.denumire from Discipline d",sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    CB_materii.Items.Add(dt.Rows[i]["denumire"].ToString());
                }
            }
        }

        private void afis_note_()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(Server.connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("AfisNote", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(dt.Rows[i]["note"].ToString());
                    if (!DBNull.Value.Equals(dt.Rows[i]["note"]))
                    {
                        int rowId = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowId];
                        string data_corecta = dt.Rows[i]["data"].ToString().Substring(0, dt.Rows[i]["data"].ToString().IndexOf(" "));
                        row.Cells["data_note"].Value = data_corecta;
                        row.Cells["nota_note"].Value = dt.Rows[i]["note"].ToString();
                    }
                }
            }
        }

        private void afis_absente_()
        {
            dataGridView2.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(Server.connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("AfisAbsente", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                sqlDa1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt1.Rows[i]["absente"])!=0)
                    {
                        int rowId = dataGridView2.Rows.Add();
                        DataGridViewRow row = dataGridView2.Rows[rowId];
                        string data_corecta = dt1.Rows[i]["data"].ToString().Substring(0, dt1.Rows[i]["data"].ToString().IndexOf(" "));
                        row.Cells["data_absente"].Value = data_corecta;
                        row.Cells["absenta_absente"].Value = dt1.Rows[i]["absente"].ToString();
                    }
                }
            }
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
            afis_note_();
        }

        private void afis_absente_Click(object sender, EventArgs e)
        {
            global.materie_curenta_elev = CB_materii.Text;
            afis_absente_();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = null;
        }
    }
}

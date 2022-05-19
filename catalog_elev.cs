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

        private void ienfkewfnwefnpwef()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(Server.connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select distinct n.data,d.denumire, n.note from Elevi e, Note_Absente n,Discipline d where e.id=n.id_elev and n.id_disciplina = d.id_disciplina and e.id=1 and denumire = 'Limba Si Literatura Romana' Group By d.denumire, n.data, n.note", sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    // Add the data
                    row.Cells["data"].Value = dt.Rows[i]["data"].ToString();
                    row.Cells["denumire"].Value = dt.Rows[i]["denumire"].ToString();
                    row.Cells["nota"].Value = dt.Rows[i]["note"].ToString();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ienfkewfnwefnpwef();
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            global.F_curent = new ter_elev();
            this.Hide();
            global.F_curent.ShowDialog();
            this.Close();
        }
    }
}

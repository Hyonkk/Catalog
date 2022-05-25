using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Catalog
{
    public static class Server
    {
        public static int ctr = 0;
        public static string connectionString = @"Data Source=serveratestatinfo.tplinkdns.com,1435;Initial Catalog=DataBase;Persist Security Info=True;User ID=admin;Password=sebastian2004";
        public static SqlConnection sqlCon = new SqlConnection(connectionString);

        public static void conectare_elev()
        {
            ctr = 0;

                SqlCommand cmd = new SqlCommand("UserSearchElev", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                             
                cmd.Parameters.Add("@Nume",SqlDbType.VarChar,50).Value = global.nume_curent;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 50).Value = global.parola_curenta;

                SqlParameter retval = cmd.Parameters.Add("@exist", SqlDbType.Int);
                SqlParameter retval1 = cmd.Parameters.Add("@nume_default", SqlDbType.VarChar,50);
                SqlParameter retval2 = cmd.Parameters.Add("@clasa", SqlDbType.VarChar, 50);
                retval.Direction = ParameterDirection.Output;
                retval1.Direction = ParameterDirection.Output;
                retval2.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                                
                int returnvalue = Convert.ToInt32(cmd.Parameters["@exist"].Value);
                if (returnvalue == 1)
                {
                    ctr = 1;
                    global.nume_default = Convert.ToString(cmd.Parameters["@nume_default"].Value);
                    global.clasa_curenta = Convert.ToString(cmd.Parameters["@clasa"].Value);
                }
                else ctr = 0;
            
        }

        public static void conectare_profesor()
        {
            ctr = 0;
            {
                SqlCommand cmd = new SqlCommand("UserSearchProfesor", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

                cmd.Parameters.Add("@Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 50).Value = global.parola_curenta;

                SqlParameter retval = cmd.Parameters.Add("@exist", SqlDbType.Int);
                SqlParameter retval1 = cmd.Parameters.Add("@nume_default", SqlDbType.VarChar, 50);
                retval.Direction = ParameterDirection.Output;
                retval1.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                int returnvalue = Convert.ToInt32(cmd.Parameters["@exist"].Value);
                if (returnvalue == 1)
                {
                    ctr = 1;
                    global.nume_default = Convert.ToString(cmd.Parameters["@nume_default"].Value);
                }
                else ctr = 0;
            }
        }

        public static void schimbare_user_elev()
        {
            {
                SqlCommand cmd = new SqlCommand("SchimbareUsernameElev",sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("NumeNou", SqlDbType.VarChar, 50).Value = global.nume_nou;

                cmd.ExecuteNonQuery();
            }
        }

        public static void schimbare_user_profesor()
        {
            {
                SqlCommand cmd = new SqlCommand("SchimbareUsernameProfesor", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("NumeNou", SqlDbType.VarChar, 50).Value = global.nume_nou;

                cmd.ExecuteNonQuery();
            }
        }

        public static void schimbare_parola_elev()
        {
            {
                SqlCommand cmd = new SqlCommand("SchimbareParolaElev", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("ParolaNoua", SqlDbType.VarChar, 50).Value = global.parola_noua;

                cmd.ExecuteNonQuery();
            }
        }

        public static void schimbare_parola_profesor()
        {
            {
                SqlCommand cmd = new SqlCommand("SchimbareParolaProfesor", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("ParolaNoua", SqlDbType.VarChar, 50).Value = global.parola_noua;

                cmd.ExecuteNonQuery();
            }
        }

        public static int verif_username_elev()
        {
            {
                SqlCommand cmd = new SqlCommand("ElevDefault", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("nume", SqlDbType.VarChar, 50).Value = global.nume_nou;
                cmd.Parameters.Add("nume_curent", SqlDbType.VarChar, 50).Value = global.nume_curent;

                SqlParameter retval = cmd.Parameters.Add("@out", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int rv = Convert.ToInt32(cmd.Parameters["@out"].Value);

                return rv;
            }
        }

        public static int verif_username_profesor()
        {
            {
                SqlCommand cmd = new SqlCommand("ProfesorDefault", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("nume", SqlDbType.VarChar, 50).Value = global.nume_nou;
                cmd.Parameters.Add("nume_curent", SqlDbType.VarChar, 50).Value = global.nume_curent;

                SqlParameter retval = cmd.Parameters.Add("@out", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int rv = Convert.ToInt32(cmd.Parameters["@out"].Value);

                return rv;
            }
        }

        public static void combobox_materii()
        {
                SqlCommand cmd = new SqlCommand("select distinct d.denumire from Discipline d", sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CB_materii.Items.Add(dt.Rows[i]["denumire"].ToString());
                }
            
            CB_materii.Items.Add("Toate");
        }

        public static void afis_note_()
        {
            dataGridView1.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisNote", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    string data_corecta = dt.Rows[i]["data"].ToString().Substring(0, dt.Rows[i]["data"].ToString().IndexOf(" "));
                    row.Cells["data_note"].Value = data_corecta;
                    row.Cells["nota_note"].Value = dt.Rows[i]["note"].ToString();

                }
            }
        }

        public static void afis_note_total_()
        {
            dataGridView3.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisToateNotele", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa3 = new SqlDataAdapter(cmd);
                DataTable dt3 = new DataTable();
                sqlDa3.Fill(dt3);
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    int rowId = dataGridView3.Rows.Add();
                    DataGridViewRow row = dataGridView3.Rows[rowId];
                    string data_corecta = dt3.Rows[i]["data"].ToString().Substring(0, dt3.Rows[i]["data"].ToString().IndexOf(" "));
                    row.Cells["denumire_note_total"].Value = dt3.Rows[i]["denumire"].ToString();
                    row.Cells["data_note_total"].Value = data_corecta;
                    row.Cells["nota_note_total"].Value = dt3.Rows[i]["note"].ToString();

                }
            }
        }

        public static void afis_absente_()
        {
            dataGridView2.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisAbsente", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                sqlDa1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    int rowId = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[rowId];
                    string data_corecta = dt1.Rows[i]["data"].ToString().Substring(0, dt1.Rows[i]["data"].ToString().IndexOf(" "));
                    row.Cells["data_absente"].Value = data_corecta;
                    row.Cells["absenta_absente"].Value = dt1.Rows[i]["absente"].ToString();
                    row.Cells["motivat_absente"].Value = dt1.Rows[i]["motivat"].ToString();
                }
            }
        }

        public static void calc_media()
        {
            {
                SqlCommand cmd = new SqlCommand("AfisMedie", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                sqlDa2.Fill(dt2);
                medie.Text = dt2.Rows[0]["Medie"].ToString();

            }
        }

        public static System.Windows.Forms.ComboBox CB_materii;
        public static System.Windows.Forms.DataGridView dataGridView1;
        public static System.Windows.Forms.Button inapoi;
        public static System.Windows.Forms.Button afis_note;
        public static System.Windows.Forms.Button afis_absente;
        public static System.Windows.Forms.DataGridView dataGridView2;
        public static System.Windows.Forms.DataGridViewTextBoxColumn data_absente;
        public static System.Windows.Forms.DataGridViewTextBoxColumn absenta_absente;
        public static System.Windows.Forms.DataGridViewTextBoxColumn motivat_absente;
        public static System.Windows.Forms.Button afis_media;
        public static System.Windows.Forms.Label medie;
        public static System.Windows.Forms.DataGridViewTextBoxColumn data_note;
        public static System.Windows.Forms.DataGridViewTextBoxColumn nota_note;
        public static System.Windows.Forms.DataGridView dataGridView3;
        public static System.Windows.Forms.DataGridViewTextBoxColumn denumire_note_total;
        public static System.Windows.Forms.DataGridViewTextBoxColumn data_note_total;
        public static System.Windows.Forms.DataGridViewTextBoxColumn nota_note_total;
    }
}

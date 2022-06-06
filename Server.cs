using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

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
            CB_materii = new ComboBox();
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
            dataGridView1=new DataGridView();
            DataGridViewTextBoxColumn data_note = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nota_note = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            data_note,
            nota_note});            
            data_note.Name = "data_note";
            nota_note.Name = "nota_note";
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
            dataGridView3 = new DataGridView();
            DataGridViewTextBoxColumn denumire_note_total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn data_note_total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nota_note_total = new DataGridViewTextBoxColumn();
            dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            denumire_note_total,
            data_note_total,
            nota_note_total});
            denumire_note_total.Name = "denumire_note_total";
            data_note_total.Name = "data_note_total";
            nota_note_total.Name = "nota_note_total";
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
            dataGridView2 = new DataGridView();
            DataGridViewTextBoxColumn data_absente = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn absenta_absente = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn motivat_absente = new DataGridViewTextBoxColumn();
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            data_absente,
            absenta_absente,
            motivat_absente});
            data_absente.Name = "data_absente";
            absenta_absente.Name = "absenta_absente";
            motivat_absente.Name = "motivat_absente";
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

        public static void afis_absente_total_()
        {
            dataGridView4 = new DataGridView();
            DataGridViewTextBoxColumn denumire_absente_total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn data_absente_total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn absenta_absente_total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn motivat_absente_total = new DataGridViewTextBoxColumn();
            dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            denumire_absente_total, data_absente_total, absenta_absente_total, motivat_absente_total });
            denumire_absente_total.Name = "denumire_absente_total";
            data_absente_total.Name = "data_absente_total";
            absenta_absente_total.Name = "absenta_absente_total";
            motivat_absente_total.Name = "motivat_absente_total";
            dataGridView4.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisToateAbsentele", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.nume_default;
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                sqlDa1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    int rowId = dataGridView4.Rows.Add();
                    DataGridViewRow row = dataGridView4.Rows[rowId];
                    string data_corecta = dt1.Rows[i]["data"].ToString().Substring(0, dt1.Rows[i]["data"].ToString().IndexOf(" "));
                    row.Cells["denumire_absente_total"].Value = dt1.Rows[i]["denumire"].ToString();
                    row.Cells["data_absente_total"].Value = data_corecta;
                    row.Cells["absenta_absente_total"].Value = dt1.Rows[i]["absente"].ToString();
                    row.Cells["motivat_absente_total"].Value = dt1.Rows[i]["motivat"];
                }
            }
        }

        public static void calc_media()
        {
            medie = new Label();
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

        public static void get_clase()
        {
            CB_clase = new ComboBox();
            SqlCommand cmd = new SqlCommand("GetClase", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("prof", SqlDbType.VarChar, 50).Value = global.nume_default;
            cmd.Parameters.Add("disciplina", SqlDbType.VarChar, 50).Value = global.disciplina_input;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            DataView dv = dt.DefaultView;
            dv.Sort = "Clasa ASC";
            dt = dv.ToTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CB_clase.Items.Add(dt.Rows[i]["Clasa"].ToString());
            }
        }

        public static void get_elevi_from_clase()
        {
            get_elvcls = new DataGridView();
            nume_elev = new DataGridViewTextBoxColumn();
            nume_elev.Name = "nume_elev";
            get_elvcls.Columns.Add(nume_elev);
            get_elvcls.Rows.Clear();
            SqlCommand cmd = new SqlCommand("GetEleviFromClase",sqlCon);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@clasa_input", SqlDbType.VarChar, 50).Value = global.clasa_input;
            SqlDataAdapter cmdDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmdDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int rowId = get_elvcls.Rows.Add();
                DataGridViewRow row = get_elvcls.Rows[rowId];
                row.Cells["nume_elev"].Value = dt.Rows[i]["Nume_Default"].ToString();
            }
        }

        public static void get_materie_for_prof()
        {
            SqlCommand cmd = new SqlCommand("GetMaterieForProf", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.materie_selectata = dt.Rows[i]["denumire"].ToString();
                global.materie_selectata_id = Convert.ToInt32(dt.Rows[i]["id_disciplina"]);
            }
        }

        public static void afis_note_profesori_()
        {
            dataGridView1 = new DataGridView();
            DataGridViewTextBoxColumn data_note = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nota_note = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            data_note,
            nota_note});
            data_note.Name = "data_note";
            nota_note.Name = "nota_note";
            dataGridView1.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisNote", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_selectata;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.elev_selectat;
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

        public static void afis_absente_profesori_()
        {
            dataGridView2 = new DataGridView();
            DataGridViewTextBoxColumn data_absente = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn absenta_absente = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn motivat_absente = new DataGridViewTextBoxColumn();
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            data_absente,
            absenta_absente,
            motivat_absente});
            data_absente.Name = "data_absente";
            absenta_absente.Name = "absenta_absente";
            motivat_absente.Name = "motivat_absente";
            dataGridView2.Rows.Clear();
            {
                SqlCommand cmd = new SqlCommand("AfisAbsente", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@materia", SqlDbType.VarChar, 50).Value = global.materie_selectata;
                cmd.Parameters.Add("@elev", SqlDbType.VarChar, 50).Value = global.elev_selectat;
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

        public static void nume_to_id()
        {
            SqlCommand cmd = new SqlCommand("NumeToId",sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nume", SqlDbType.VarChar, 50).Value = global.elev_selectat;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.id_nume = Convert.ToInt32(dt.Rows[i]["id"]);
            }
        }

        public static void no_incarc()
        {
                SqlCommand cmd = new SqlCommand("AdaugaNota", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@data", SqlDbType.VarChar, 50).Value = global.data_selectat;
                cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
                cmd.Parameters.Add("@id_disciplina", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
                cmd.Parameters.Add("@nota", SqlDbType.VarChar, 50).Value = global.noab;
                cmd.ExecuteNonQuery();
        }

        public static void ab_incarc()
        {

            SqlCommand cmd = new SqlCommand("AdaugaAbsenta", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@data", SqlDbType.VarChar, 50).Value = global.data_selectat;
            cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
            cmd.Parameters.Add("@id_disciplina", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
            cmd.Parameters.Add("@absenta", SqlDbType.VarChar, 50).Value = global.noab;
            cmd.ExecuteNonQuery();

        }

        public static void nota_delete()
        {
            SqlCommand cmd = new SqlCommand("deletenota", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@data", SqlDbType.VarChar, 50).Value = global.data_de_sters;
            cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
            cmd.Parameters.Add("@id_disc", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
            cmd.ExecuteNonQuery();
        }
        public static void absenta_delete()
        {
            SqlCommand cmd = new SqlCommand("deleteabsenta", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@data", SqlDbType.VarChar, 50).Value = global.data_de_sters;
            cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
            cmd.Parameters.Add("@id_disc", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
            cmd.ExecuteNonQuery();
        }

        public static void absenta_motivat()
        {
            SqlCommand cmd = new SqlCommand("motivatabsenta", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@data", SqlDbType.VarChar, 50).Value = global.data_de_sters;
            cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
            cmd.Parameters.Add("@id_disc", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
            cmd.Parameters.Add("@motivat", SqlDbType.VarChar, 50).Value = global.motivat;
            cmd.ExecuteNonQuery();
        }

        public static void afis_media()
        {
            SqlCommand cmd = new SqlCommand("AfisMedie", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_elev", SqlDbType.VarChar, 50).Value = global.id_nume;
            cmd.Parameters.Add("@id_disc", SqlDbType.VarChar, 50).Value = global.materie_selectata_id;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.medie = Convert.ToDouble(dt.Rows[i]["Medie"]);
            }
        }

        public static void afis_media_elev()
        {
            SqlCommand cmd = new SqlCommand("AfisMedieElev", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nume", SqlDbType.VarChar, 50).Value = global.nume_default;
            cmd.Parameters.Add("disciplina", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.medie = Convert.ToDouble(dt.Rows[i]["Medie"]);
            }
        }

        public static void afis_nr_absente()
        {
            SqlCommand cmd = new SqlCommand("numarabsente", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nume", SqlDbType.VarChar, 50).Value = global.nume_default;
            cmd.Parameters.Add("disciplina", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.nrabsente = Convert.ToInt32(dt.Rows[i]["Numar"]);
            }
        }

        public static void afis_nr_absente_motivate()
        {
            SqlCommand cmd = new SqlCommand("numarabsentemotivate", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nume", SqlDbType.VarChar, 50).Value = global.nume_default;
            cmd.Parameters.Add("disciplina", SqlDbType.VarChar, 50).Value = global.materie_curenta_elev;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                global.nrabsentemotivate = Convert.ToInt32(dt.Rows[i]["Numar"]);
            }
        }

        public static void get_disc_id_prof()
        {
            CB_discipline = new ComboBox();
            SqlCommand cmd = new SqlCommand("DisciplineProfesor", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prof", SqlDbType.VarChar, 50).Value = global.nume_default;
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CB_discipline.Items.Add(Convert.ToString(dt.Rows[i]["denumire"]));
            }
        }

        public static void disciplina_to_id()
        {
            SqlCommand cmd = new SqlCommand("DisciplinaToId", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nume", SqlDbType.VarChar, 50).Value = global.materie_selectata;
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            for(int i=0;i< dt.Rows.Count;i++)
            {
                global.materie_selectata_id = Convert.ToInt32(dt.Rows[i]["id_disciplina"]);
            }
        }

        public static ComboBox CB_materii;
        public static ComboBox CB_clase;
        public static ComboBox CB_discipline;
        public static DataGridView dataGridView1;
        public static Button inapoi;
        public static Button afis_note;
        public static Button afis_absente;
        public static DataGridView dataGridView2;
        public static DataGridViewTextBoxColumn data_absente;
        public static DataGridViewTextBoxColumn absenta_absente;
        public static DataGridViewTextBoxColumn motivat_absente;
        public static DataGridView get_elvcls;
        public static DataGridViewTextBoxColumn nume_elev;
        public static Label medie;
        public static DataGridViewTextBoxColumn data_note;
        public static DataGridViewTextBoxColumn nota_note;
        public static DataGridView dataGridView3;
        public static DataGridViewTextBoxColumn denumire_note_total;
        public static DataGridViewTextBoxColumn data_note_total;
        public static DataGridViewTextBoxColumn nota_note_total;
        public static DataGridView dataGridView4;
        public static DataGridViewTextBoxColumn data_absente_total;
        public static DataGridViewTextBoxColumn absenta_absente_total;
        public static DataGridViewTextBoxColumn motivat_absente_total;
    }
}

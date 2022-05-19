using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Catalog
{
    public static class Server
    {
        public static int ctr = 0;
        public static string connectionString = @"Data Source=serveratestatinfo.tplinkdns.com,1435;Initial Catalog=DataBase;Persist Security Info=True;User ID=admin;Password=sebastian2004";

        public static void conectare_elev()
        {
            ctr = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserSearchElev", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                             
                cmd.Parameters.Add("@Nume",SqlDbType.VarChar,50).Value = global.nume_curent;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 50).Value = global.parola_curenta;

                SqlParameter retval = cmd.Parameters.Add("@exist", SqlDbType.Int);
                SqlParameter retval1 = cmd.Parameters.Add("@nume_default", SqlDbType.VarChar,50);
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
                sqlCon.Close();
            }
        }

        public static void conectare_profesor()
        {
            ctr = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
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

                Console.WriteLine(retval);

                int returnvalue = Convert.ToInt32(cmd.Parameters["@exist"].Value);
                if (returnvalue == 1)
                {
                    ctr = 1;
                    global.nume_default = Convert.ToString(cmd.Parameters["@nume_default"].Value);
                }
                else ctr = 0;
                sqlCon.Close();
            }
        }

        public static void schimbare_user_elev()
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SchimbareUsernameElev",sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("NumeNou", SqlDbType.VarChar, 50).Value = global.nume_nou;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public static void schimbare_user_profesor()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SchimbareUsernameProfesor", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("NumeNou", SqlDbType.VarChar, 50).Value = global.nume_nou;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public static void schimbare_parola_elev()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SchimbareParolaElev", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("ParolaNoua", SqlDbType.VarChar, 50).Value = global.parola_noua;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public static void schimbare_parola_profesor()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SchimbareParolaProfesor", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Nume", SqlDbType.VarChar, 50).Value = global.nume_curent;
                cmd.Parameters.Add("ParolaNoua", SqlDbType.VarChar, 50).Value = global.parola_noua;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public static int verif_username_elev()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("ElevDefault", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("nume", SqlDbType.VarChar, 50).Value = global.nume_nou;
                cmd.Parameters.Add("nume_curent", SqlDbType.VarChar, 50).Value = global.nume_curent;

                SqlParameter retval = cmd.Parameters.Add("@out", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int rv = Convert.ToInt32(cmd.Parameters["@out"].Value);
                Console.WriteLine(rv.ToString());

                sqlCon.Close();
                return rv;
            }
        }

        public static int verif_username_profesor()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("ProfesorDefault", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("nume", SqlDbType.VarChar, 50).Value = global.nume_nou;
                cmd.Parameters.Add("nume_curent", SqlDbType.VarChar, 50).Value = global.nume_curent;

                SqlParameter retval = cmd.Parameters.Add("@out", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int rv = Convert.ToInt32(cmd.Parameters["@out"].Value);
                Console.WriteLine(rv.ToString());

                sqlCon.Close();
                return rv;
            }
        }

        public static void combobox_materii()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

            }
        }
    }
}

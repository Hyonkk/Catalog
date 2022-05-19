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
        static string connectionString = @"Data Source=serveratestatinfo.tplinkdns.com,1435;Initial Catalog=DataBase;Persist Security Info=True;User ID=admin;Password=sebastian2004";

        public static void conectare()
        { 
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserSearch", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                             
                cmd.Parameters.Add("@Nume",SqlDbType.VarChar,50).Value = global.nume_curent;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 50).Value = global.parola_curenta;

                SqlParameter retval = cmd.Parameters.Add("@exist", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                                
                int returnvalue = Convert.ToInt32(cmd.Parameters["@exist"].Value);
                if (returnvalue == 1)
                {
                    ctr = 1;
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
    }
}

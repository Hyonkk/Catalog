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
        public static void conectare()
        { 
            string connectionString = @"Data Source=serveratestatinfo.tplinkdns.com,1435;Initial Catalog=DataBase;Persist Security Info=True;User ID=admin;Password=sebastian2004";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserSearch", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                             
                cmd.Parameters.Add("@Nume",SqlDbType.VarChar,50).Value = global.nume_curent;

                SqlParameter retval = cmd.Parameters.Add("@exist", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                                
                int returnvalue = (int)cmd.Parameters["@exist"].Value;
                Console.WriteLine(returnvalue.ToString());
            }
        }
    }
}
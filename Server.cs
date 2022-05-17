using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Catalog
{
    public static class Server
    {
        public static void conectare()
        { 
            public string ConnectionString = @"Data Source=serveratestatinfo.tplinkdns.com,1435;Initial Catalog=DataBase;Persist Security Info=True;User ID=admin;Password=sebastian2004";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlCommanc cmd = new SqlCommand(UserSearch,sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nume",SqlDbType.VarChar).Value = global.nume_curent;
                cmd.ExecuteNonQuery();
            }
        }
    }
}

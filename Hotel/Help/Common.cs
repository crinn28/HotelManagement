using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Multi_Login.Models;

namespace Multi_Login
{
    public class Common
    {
        SqlConnection sqlCon = null;
        String SqlconString = ConfigurationManager.ConnectionStrings["GestiuneaUnuiHotel"].ConnectionString;
        public void Test(User user)
        {
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();
                SqlCommand sql_cmnd = new SqlCommand("AddUserss", sqlCon);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = user.Name;
                sql_cmnd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = user.Password;
                sql_cmnd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = user.Type;
                //sql_cmnd.Parameters.AddWithValue("@userID", SqlDbType.BigInt).Value = 4;
                sql_cmnd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
    }
}
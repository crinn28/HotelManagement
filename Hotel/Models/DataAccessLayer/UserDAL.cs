using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models.DataAccessLayer
{
    public class UserDAL
    {
        public ObservableCollection<User> GetAllUsers()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = (int)(reader[0]);//reader.GetInt(0);
                    user.Name = reader.GetString(1);//reader[1].ToString();
                    user.Password = reader.GetString(2);
                    user.Type = reader.GetString(3);
                    //p.Address = reader.IsDBNull(2) ? null : reader[2].ToString();
                    result.Add(user);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        //public ObservableCollection<User> GetAllPersonsWithNoPhone()
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("GetAllPersonsWithNoPhone", con);
        //        ObservableCollection<User> result = new ObservableCollection<User>();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            result.Add(
        //                new User()
        //                {
        //                    ID = reader["ID"] as int?,
        //                    Password = reader["Password"].ToString(),
        //                    Name = reader["Name"].ToString()
        //                }
        //            );
        //        }
        //        reader.Close();
        //        return result;
        //    }
        //}

        public void AddUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramNume = new SqlParameter("@username", user.Name);
                SqlParameter paramPass = new SqlParameter("@password", user.Password);
                SqlParameter paramType = new SqlParameter("@type", user.Type);
                SqlParameter paramActiv = new SqlParameter("@activ", user.Activ);
                SqlParameter paramIdUser = new SqlParameter("@userID", SqlDbType.Int);
                paramIdUser.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramPass);
                cmd.Parameters.Add(paramType);
                cmd.Parameters.Add(paramActiv);
                cmd.Parameters.Add(paramIdUser);
                con.Open();
                cmd.ExecuteNonQuery();
                user.ID = paramIdUser.Value as int?;
            }
        }

        //public void DeletePerson(User persoana)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("DeletePerson", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter paramIdPersoana = new SqlParameter("@id", persoana.ID);
        //        cmd.Parameters.Add(paramIdPersoana);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void ModifyPerson(User persoana)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("ModifyPerson", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        SqlParameter paramIdPersoana = new SqlParameter("@persID", persoana.ID);
        //        SqlParameter paramNume = new SqlParameter("@name", persoana.Name);
        //        SqlParameter paramAdresa = new SqlParameter();
        //        paramAdresa.ParameterName = "@address";
        //        if (String.IsNullOrEmpty(persoana.Password))
        //        {
        //            paramAdresa.Value = DBNull.Value;
        //        }
        //        else
        //        {
        //            paramAdresa.Value = persoana.Password;
        //        }
        //        cmd.Parameters.Add(paramIdPersoana);
        //        cmd.Parameters.Add(paramNume);
        //        cmd.Parameters.Add(paramAdresa);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}
    }
}

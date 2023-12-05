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
    public class RoomDAL
    {
        public ObservableCollection<Room> GetAllRooms()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllRooms", con);
                ObservableCollection<Room> result = new ObservableCollection<Room>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.ID = (int)(reader[0]);
                    int tip= (int)reader[1];
                    if(tip==1)
                        room.Tipul = tip.ToString() + " persoana";
                    else
                        room.Tipul = tip.ToString() + " persoane";
                    tip= (int)reader[2];
                    room.PretID = tip.ToString() + "$";
                    room.NrCamere = (int)reader[3];
                    room.ImagesPath = reader.GetString(4);
                    room.TV= (bool)reader[5];
                    room.Balcon = (bool)reader[6];
                    room.MiniBar = (bool)reader[7];
                    room.AerConditionat = (bool)reader[8];
                    result.Add(room);
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

        //public void AddRoom(Room room)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("AddUser", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter paramNume = new SqlParameter("@username", user.Name);
        //        SqlParameter paramPass = new SqlParameter("@password", user.Password);
        //        SqlParameter paramType = new SqlParameter("@type", user.Type);
        //        SqlParameter paramActiv = new SqlParameter("@activ", user.Activ);
        //        SqlParameter paramIdUser = new SqlParameter("@userID", SqlDbType.Int);
        //        paramIdUser.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(paramNume);
        //        cmd.Parameters.Add(paramPass);
        //        cmd.Parameters.Add(paramType);
        //        cmd.Parameters.Add(paramActiv);
        //        cmd.Parameters.Add(paramIdUser);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        user.ID = paramIdUser.Value as int?;
        //    }
        //}
    }
}

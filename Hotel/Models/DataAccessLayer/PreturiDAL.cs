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
    public class PreturiDAL
    {
        public ObservableCollection<Preturi> GetAllPreturi()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllPreturi", con);
                ObservableCollection<Preturi> result = new ObservableCollection<Preturi>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Preturi preturi = new Preturi();
                    preturi.ID = (int)(reader[0]);//reader.GetInt(0);
                    preturi.Valoare = (int)(reader[1]);//reader[1].ToString();
                    preturi.DataInceput = reader.GetDateTime(2);
                    preturi.DataFinal = reader.GetDateTime(3);
                    preturi.CameraID= (int)(reader[4]);
                    //p.Address = reader.IsDBNull(2) ? null : reader[2].ToString();
                    result.Add(preturi);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

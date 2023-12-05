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
    public class ClientiDAL
    {
        public ObservableCollection<Clienti> GetAllClienti()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllClienti", con);
                ObservableCollection<Clienti> result = new ObservableCollection<Clienti>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Clienti clienti = new Clienti();
                    clienti.ID = (int)(reader[0]);//reader.GetInt(0);
                    clienti.Name = reader.GetString(1);//reader[1].ToString();
                    clienti.Email = reader.GetString(2);
                    clienti.Activ = true;
                    //p.Address = reader.IsDBNull(2) ? null : reader[2].ToString();
                    result.Add(clienti);
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

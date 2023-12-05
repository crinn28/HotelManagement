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
    public class OfertaDAL
    {
        public ObservableCollection<Oferta> GetAllOferta()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllOferta", con);
                ObservableCollection<Oferta> result = new ObservableCollection<Oferta>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Oferta oferta = new Oferta();
                    oferta.ID = (int)(reader[0]);
                    oferta.TipCamera = (int)(reader[1]);
                    oferta.DataInceput = reader.GetDateTime(2);
                    oferta.DataFinal = reader.GetDateTime(3);
                    int pret = (int)(reader[4]);
                    oferta.Pret = pret.ToString() + " $";
                    oferta.Nume = reader.GetString(5);
                    oferta.Activ = reader.GetBoolean(6);
                    oferta.Spa = reader.GetBoolean(7);
                    oferta.AccesAqua = reader.GetBoolean(8);
                    oferta.MicDejun = reader.GetBoolean(9);

                    if(oferta.Activ==true)
                        result.Add(oferta);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddOferta(Oferta oferta, string numeClient, string email)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddOferta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramNume = new SqlParameter("@clientID", numeClient);
                string pret = "";
                foreach (var ch in oferta.Pret)
                {
                    if (ch != ' ' && ch != '$')
                        pret += ch;
                }
                
                SqlParameter paramPret = new SqlParameter("@pret", Int32.Parse(pret));
                SqlParameter paramDataInceput = new SqlParameter("@dataInceput", oferta.DataInceput);
                SqlParameter paramDataFinal = new SqlParameter("@dataFinal", oferta.DataFinal);
                SqlParameter paramActiv = new SqlParameter("@activ", true);
                SqlParameter paramOferta = new SqlParameter("@oferta", true);
                SqlParameter paramIdOferta = new SqlParameter("@rezervareID", SqlDbType.Int);
                paramIdOferta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramPret);
                cmd.Parameters.Add(paramDataInceput);
                cmd.Parameters.Add(paramDataFinal);
                cmd.Parameters.Add(paramActiv);
                cmd.Parameters.Add(paramOferta);
                cmd.Parameters.Add(paramIdOferta);
                con.Open();
                cmd.ExecuteNonQuery();
                oferta.ID = paramIdOferta.Value as int?;
            }
        }

        public void AddOfertaNoua(Oferta oferta)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddOfertaNoua", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string pret = "";
                foreach (var ch in oferta.Pret)
                {
                    if (ch != ' ' && ch != '$')
                        pret += ch;
                }
                SqlParameter paramNume = new SqlParameter("@nume", oferta.Nume);
                SqlParameter paramTip = new SqlParameter("@tipCamera", oferta.TipCamera);
                SqlParameter paramPret = new SqlParameter("@pret", Int32.Parse(pret));
                SqlParameter paramDataInceput = new SqlParameter("@dataInceput", oferta.DataInceput);
                SqlParameter paramDataFinal = new SqlParameter("@dataFinal", oferta.DataFinal);
                SqlParameter paramActiv = new SqlParameter("@activ", true);
                SqlParameter paramAccesAqua = new SqlParameter("@accesAqua", oferta.AccesAqua);
                SqlParameter paramSpa = new SqlParameter("@spa", oferta.Spa);
                SqlParameter paramMicDejun = new SqlParameter("@micDejun", oferta.MicDejun);
                SqlParameter paramIdOferta = new SqlParameter("@ofertaID", SqlDbType.Int);
                paramIdOferta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramPret);
                cmd.Parameters.Add(paramDataInceput);
                cmd.Parameters.Add(paramDataFinal);
                cmd.Parameters.Add(paramActiv);
                cmd.Parameters.Add(paramTip);
                cmd.Parameters.Add(paramAccesAqua);
                cmd.Parameters.Add(paramSpa);
                cmd.Parameters.Add(paramMicDejun);
                cmd.Parameters.Add(paramIdOferta);
                con.Open();
                cmd.ExecuteNonQuery();
                oferta.ID = paramIdOferta.Value as int?;
            }
        }

        public void DeleteOferta(Oferta oferta)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteOferta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramIdOferta = new SqlParameter("@ofertaID", oferta.ID);
                cmd.Parameters.Add(paramIdOferta);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ModifyOferta(Oferta oferta)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("UpdateOferta", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramNume = new SqlParameter("@nume", oferta.Nume);
                SqlParameter paramTip = new SqlParameter("@tipCamera", oferta.TipCamera);
                string pret = "";
                foreach (var ch in oferta.Pret)
                {
                    if (ch != ' ' && ch != '$')
                        pret += ch;
                }
                SqlParameter paramPret = new SqlParameter("@pret", Int32.Parse(pret));
                SqlParameter paramDataInceput = new SqlParameter("@dataInceput", oferta.DataInceput);
                SqlParameter paramDataFinal = new SqlParameter("@dataFinal", oferta.DataFinal);
                SqlParameter paramActiv = new SqlParameter("@activ", true);
                SqlParameter paramAccesAqua = new SqlParameter("@accesAqua", oferta.AccesAqua);
                SqlParameter paramSpa = new SqlParameter("@spa", oferta.Spa);
                SqlParameter paramMicDejun = new SqlParameter("@micDejun", oferta.MicDejun);
                SqlParameter paramIdOferta = new SqlParameter("@ofertaID", SqlDbType.Int);
                paramIdOferta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNume);
                cmd.Parameters.Add(paramPret);
                cmd.Parameters.Add(paramDataInceput);
                cmd.Parameters.Add(paramDataFinal);
                cmd.Parameters.Add(paramActiv);
                cmd.Parameters.Add(paramTip);
                cmd.Parameters.Add(paramAccesAqua);
                cmd.Parameters.Add(paramSpa);
                cmd.Parameters.Add(paramMicDejun);
                cmd.Parameters.Add(paramIdOferta);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

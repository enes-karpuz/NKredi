using NKredi.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKredi.DataAccessLayer
{
    public class EKrediOranlari
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EKrediOranlari()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<KrediOranlari> GetirKrediOrani()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirKrediOrani", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<KrediOranlari> krediOranlari = new List<KrediOranlari>();
            foreach (DataRow satir in dt.Rows)
            {
                krediOranlari.Add(new()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    Oranlar = Convert.ToInt32(satir["Oranlar"])
                });
            }
            return krediOranlari;
        }

        public KrediOranlari OkuKrediOrani(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuKrediOrani", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            KrediOranlari okunanKrediOrani = new KrediOranlari()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Oranlar = Convert.ToInt32(dt.Rows[0]["Oranlari"]),
            };
            return okunanKrediOrani;
        }

        //TODO : Return id olacak.
        public bool EkleKrediOrani(KrediOranlari krediOranlari)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleKrediOrani", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", krediOranlari.Id);
            sqlCommand.Parameters.AddWithValue("@p_KisaAdi", krediOranlari.Oranlar);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleKrediOrani(KrediOranlari krediOranlari)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleKrediOrani", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Oranlar", krediOranlari.Oranlar);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilKrediOrani(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilKrediOrani", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", Id);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }
    }
}

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
    public class EKurTablosu
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EKurTablosu()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<KurTablosu> GetirKur()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirKur", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<KurTablosu> kurTablosu = new List<KurTablosu>();
            foreach (DataRow satir in dt.Rows)
            {
                kurTablosu.Add(new KurTablosu()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    DovizKodu = satir["Tipi"].ToString(),
                    Birim = Convert.ToInt32(satir["Ad"]),
                    DovizCinsi = satir["Soyad"].ToString(),
                    DovizAlis = Convert.ToInt32(satir["DovizAlis"]),
                    DovizSatis = Convert.ToInt32(satir["DovizSatis"]),
                    EfektifAlis = Convert.ToInt32(satir["EfektifAlis"]),
                    EfektifSatis = Convert.ToInt32(satir["EfektifSatis"]),
                });
            }
            return kurTablosu;
        }

        public KurTablosu OkuKur(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuKur", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            KurTablosu kurTablosu = new KurTablosu()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                DovizKodu = dt.Rows[0]["DovizKodu"].ToString(),
                Birim = Convert.ToInt32(dt.Rows[0]["Birim"]),
                DovizCinsi = dt.Rows[0]["DovizCinsi"].ToString(),
                DovizAlis = Convert.ToInt32(dt.Rows[0]["DovizAlis"]),
                DovizSatis = Convert.ToInt32(dt.Rows[0]["DovizSatis"]),
                EfektifAlis = Convert.ToInt32(dt.Rows[0]["EfetifAlis"]),
                EfektifSatis = Convert.ToInt32(dt.Rows[0]["EfethisSatis"])
            };
            return kurTablosu;
        }

        //TODO : Return id olacak.
        public bool EkleKur(KurTablosu kurTablosu)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleKur", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_DovizKodu", kurTablosu.DovizKodu);
            sqlCommand.Parameters.AddWithValue("@p_Birim", kurTablosu.Birim);
            sqlCommand.Parameters.AddWithValue("@p_DovizCinsi", kurTablosu.DovizCinsi);
            sqlCommand.Parameters.AddWithValue("@p_DovizAlis", kurTablosu.DovizAlis);
            sqlCommand.Parameters.AddWithValue("@p_DovizSatis", kurTablosu.DovizSatis);
            sqlCommand.Parameters.AddWithValue("@p_EfektifAlis", kurTablosu.EfektifAlis);
            sqlCommand.Parameters.AddWithValue("@p_EfektifSatis", kurTablosu.EfektifSatis);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleKur(KurTablosu kurTablosu)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleKur", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_DovizKodu", kurTablosu.DovizKodu);
            sqlCommand.Parameters.AddWithValue("@p_Birim", kurTablosu.Birim);
            sqlCommand.Parameters.AddWithValue("@p_DovizCinsi", kurTablosu.DovizCinsi);
            sqlCommand.Parameters.AddWithValue("@p_DovizAlis", kurTablosu.DovizAlis);
            sqlCommand.Parameters.AddWithValue("@p_DovizSatis", kurTablosu.DovizSatis);
            sqlCommand.Parameters.AddWithValue("@p_EfektifAlis", kurTablosu.EfektifAlis);
            sqlCommand.Parameters.AddWithValue("@p_EfektifSatis", kurTablosu.EfektifSatis);

            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilKur(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilKur", sqlConnection);
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

        public string ReadPasswordByEmail(string email)
        {
            SqlCommand sqlCommand = new SqlCommand("ReadByEmail", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_email", email);
            database.OpenConnetion(sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
            }
            string sifre = "";
            if (dt.Rows.Count > 0)
            {
                sifre = dt.Rows[0]["Sifre"].ToString();
            }
            return sifre;
        }
    }
}

﻿using NKredi.DataAccessLayer.Entities;
using System.Data;
using System.Data.SqlClient;

namespace NKredi.DataAccessLayer
{
    public class EKullanici
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EKullanici()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<Kullanici> GetirKullanici()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirKullanici", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<Kullanici> kullanicilar = new List<Kullanici>();
            foreach (DataRow satir in dt.Rows)
            {
                kullanicilar.Add(new Kullanici()
                {
                    Id = satir["Id"] == DBNull.Value ? 0 : Convert.ToInt32(satir["Id"]),
                    Tipi = satir["Tipi"] == DBNull.Value ? 0 : Convert.ToInt32(satir["Tipi"]),
                    Ad = satir["Ad"].ToString(),
                    Soyad = satir["Soyad"].ToString(),
                    email = satir["email"].ToString(),
                    Sifre = satir["Sifre"].ToString(),
                    DogumTarihi = satir["DogumTarihi"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(satir["DogumTarihi"])
                });
            }
            return kullanicilar;
        }

        public Kullanici OkuKullanici(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuKullanici", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            Kullanici okunanKullanici = new Kullanici()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Tipi = Convert.ToInt32(dt.Rows[0]["Tipi"]),
                Ad = dt.Rows[0]["Ad"].ToString(),
                Soyad = dt.Rows[0]["Soyad"].ToString(),
                email = dt.Rows[0]["email"].ToString(),
                Sifre = dt.Rows[0]["Sifre"].ToString(),
                DogumTarihi = Convert.ToDateTime(dt.Rows[0]["DogumTarihi"])

            };
            return okunanKullanici;
        }

        //TODO : Return id olacak.
        public bool EkleKullanici(Kullanici kullanici)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleKullanici", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Tipi", kullanici.Tipi);
            sqlCommand.Parameters.AddWithValue("@p_Ad", kullanici.Ad);
            sqlCommand.Parameters.AddWithValue("@p_Soyad", kullanici.Soyad);
            sqlCommand.Parameters.AddWithValue("@p_email", kullanici.email);
            sqlCommand.Parameters.AddWithValue("@p_sifre", kullanici.Sifre);
            sqlCommand.Parameters.AddWithValue("@p_dogumTarihi", kullanici.DogumTarihi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleKullanici(Kullanici kullanici)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleKullanici", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Tipi", kullanici.Tipi);
            sqlCommand.Parameters.AddWithValue("@p_Ad", kullanici.Ad);
            sqlCommand.Parameters.AddWithValue("@p_Soyad", kullanici.Soyad);
            sqlCommand.Parameters.AddWithValue("@p_email", kullanici.email);
            sqlCommand.Parameters.AddWithValue("@p_sifre", kullanici.Sifre);
            sqlCommand.Parameters.AddWithValue("@p_dogumTarihi", kullanici.DogumTarihi);

            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilKullanici(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilKullanici", sqlConnection);
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

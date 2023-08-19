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
    public class EDovizCinsi
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EDovizCinsi()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<DovizCinsi> GetirDoviz()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirDoviz", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<DovizCinsi> dovizCinsi = new List<DovizCinsi>();
            foreach (DataRow satir in dt.Rows)
            {
                dovizCinsi.Add(new()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    KisaAdi = (satir["KisaAdi"].ToString()),
                    Adi = (satir["Adi"].ToString())
                });
            }
            return dovizCinsi;
        }

        public DovizCinsi OkuDoviz(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuDoviz", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            DovizCinsi dovizCinsi = new DovizCinsi()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                KisaAdi = (dt.Rows[0]["KisaAdi"].ToString()),
                Adi = (dt.Rows[0]["Adi"].ToString())
            };
            return dovizCinsi;
        }

        //TODO : Return id olacak.
        public bool EkleDoviz(DovizCinsi dovizCinsi)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleDoviz", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", dovizCinsi.Id);
            sqlCommand.Parameters.AddWithValue("@p_KisaAdi", dovizCinsi.KisaAdi);
            sqlCommand.Parameters.AddWithValue("@p_Adi", dovizCinsi.Adi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleDoviz(DovizCinsi dovizCinsi)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleDoviz", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_KisaAdi", dovizCinsi.KisaAdi);
            sqlCommand.Parameters.AddWithValue("@p_Adi", dovizCinsi.Adi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilDoviz(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilDoviz", sqlConnection);
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

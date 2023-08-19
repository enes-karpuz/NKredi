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
    public class EKullaniciTipi
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EKullaniciTipi()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<KullaniciTipi> GetirKullaniciTipi()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirKullaniciTipi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<KullaniciTipi> kullaniciTipleri = new List<KullaniciTipi>();
            foreach (DataRow satir in dt.Rows)
            {
                kullaniciTipleri.Add(new ()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    Tipi = (satir["Tipi"].ToString())
                });
            }
            return kullaniciTipleri;
        }

        public KullaniciTipi OkuKullaniciTipi(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuKullaniciTipi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);
            KullaniciTipi okunanKullaniciTipi = new KullaniciTipi();
            if (dt.Rows.Count > 0)
            {
                okunanKullaniciTipi = new KullaniciTipi()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Tipi = dt.Rows[0]["Tipi"].ToString()
                };
            }
            return okunanKullaniciTipi;
        }

        //TODO : Return id olacak.
        public bool EkleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleKullaniciTipi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Tipi", kullaniciTipi.Tipi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleKullaniciTipi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Tipi", kullaniciTipi.Tipi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilKullaniciTipi(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilKullaniciTipi", sqlConnection);
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

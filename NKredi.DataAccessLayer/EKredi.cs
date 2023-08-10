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
    public class EKredi
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EKredi()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<Kredi> GetirKredi()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirKredi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<Kredi> kredi = new List<Kredi>();
            foreach (DataRow satir in dt.Rows)
            {
                kredi.Add(new()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    Turu = (satir["Turu"].ToString())
                });
            }
            return kredi;
        }

        public Kredi OkuKredi(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuKredi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            Kredi okunanKredi = new Kredi()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Turu = (dt.Rows[0]["Turu"].ToString())
            };
            return okunanKredi;
        }

        //TODO : Return id olacak.
        public bool EkleKredi(Kredi kredi)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleKredi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", kredi.Id);
            sqlCommand.Parameters.AddWithValue("@p_Turu", kredi.Turu);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleKredi(Kredi kredi)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleKredi", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Tipi", kredi.Turu);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilKredi(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilKredi", sqlConnection);
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

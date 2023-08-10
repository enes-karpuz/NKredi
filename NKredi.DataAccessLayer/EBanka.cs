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
    public class EBanka
    {
        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        Database database { get; set; }

        public string connetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";

        public EBanka()
        {
            database = new Database();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connetionString;
        }

        public List<Banka> GetirBanka()
        {
            SqlCommand sqlCommand = new SqlCommand("GetirBanka", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            List<Banka> bankalar = new List<Banka>();
            foreach (DataRow satir in dt.Rows)
            {
                bankalar.Add(new()
                {
                    Id = Convert.ToInt32(satir["Id"]),
                    KisaAdi = (satir["KisaAdi"].ToString()),
                    Adi = (satir["Adi"].ToString())
                });
            }
            return bankalar;
        }

        public Banka OkuBanka(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("OkuBanka", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            database.OpenConnetion(sqlConnection);
            sqlDataAdapter.Fill(dt);

            Banka okunanBanka = new Banka()
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                KisaAdi = (dt.Rows[0]["KisaAdi"].ToString()),
                Adi = (dt.Rows[0]["Adi"].ToString())
            };
            return okunanBanka;
        }

        //TODO : Return id olacak.
        public bool EkleBanka(Banka banka)
        {
            SqlCommand sqlCommand = new SqlCommand("EkleBanka", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_Id", banka.Id);
            sqlCommand.Parameters.AddWithValue("@p_KisaAdi", banka.KisaAdi);
            sqlCommand.Parameters.AddWithValue("@p_Adi", banka.Adi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool GuncelleBanka(Banka banka)
        {
            SqlCommand sqlCommand = new SqlCommand("GuncelleBanka", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@p_KisaAdi", banka.KisaAdi);
            sqlCommand.Parameters.AddWithValue("@p_Adi", banka.Adi);
            database.OpenConnetion(sqlConnection);
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        //TODO : Return id olacak.
        public bool SilBanka(int Id)
        {
            SqlCommand sqlCommand = new SqlCommand("SilBanka", sqlConnection);
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

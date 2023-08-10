using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NKredi.DataAccessLayer
{
    public class Database
    {

        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand { get; set; }
        public string ConnetionString = "Data Source=ENES-THINKPAD;Initial Catalog=Nkredi;Integrated Security=True";
        public Database()
        {
            sqlConnection = new SqlConnection(ConnetionString);
            sqlCommand = sqlConnection.CreateCommand();
        }

        public bool OpenConnetion(SqlConnection connetion)
        {
            if (connetion.State != System.Data.ConnectionState.Closed)
            {
                connetion.Close();
            }
            connetion.Open();
            return true;
        }
    }
}

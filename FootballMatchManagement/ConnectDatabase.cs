using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FootballMatchManagement
{
    internal class ConnectDatabase
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public SqlConnection Connection { get; internal set; }

        public void Connect_Data()
        {
            string strConnect = @"Data Source= LAPTOP-N5TTVA9R;Initial Catalog=FootballMatchManagement;Integrated Security=True";
            cnn = new SqlConnection(strConnect);
            cnn.Open();
        }

        public void Cancle_Connect()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public DataTable Get_table(string Sql)
        {
            Connect_Data();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Execute_Data(string sql)
        {
            Connect_Data();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            Cancle_Connect();

        }
    }
}

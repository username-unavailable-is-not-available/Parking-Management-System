using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Parking_Management
{
    public class DataConnection
    {
        public SqlConnection connection;

        public DataConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pmsDB3"].ConnectionString);
            connection.Open();
        }

        public SqlCommand Sqlcom { get; set; }

        public SqlDataAdapter Sda { get; set; }

        public DataSet Ds { get; set; }

        private void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, connection);
        }

        public DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            QueryText(sql);
            var u = Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
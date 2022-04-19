using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Parking_Management_System
{
    class DataConnection
    {
        public SqlConnection connection;

        public DataConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pmsDB"].ConnectionString);
        }
    }
}

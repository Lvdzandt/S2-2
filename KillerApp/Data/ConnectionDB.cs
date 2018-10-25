using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data
{
    public class ConnectionDB
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString.CreateConString());
        }
    }
}

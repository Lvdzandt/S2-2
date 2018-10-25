using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data
{
    public static class ConnectionDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString.CreateConString());
        }
    }
}

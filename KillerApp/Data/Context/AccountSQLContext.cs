using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class AccountSQLContext : IAccountContext
    {
        private string query;
        private SqlCommand command;

        public List<User> GetAllAccounts()
        {
            List<User> output = new List<User>();
                try
                {
                    using (SqlConnection Conn = ConnectionDB.GetConnection())
                    {
                        Conn.Open();
                        query = "SELECT * FROM dbo.Account";
                        command = new SqlCommand(query, Conn);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int UserID = Convert.ToInt32(reader["ID"]);
                                    string Name = Convert.ToString(reader["UserName"]);
                                    string Password = Convert.ToString(reader["Password"]);
                                    output.Add(new User() {ID = UserID, Username = Name, Password = Password});
                                }
                            }
                        Conn.Close();
                        }

                    }
                }
                catch (Exception)
                {
                    throw;
                }
            
                return output;
            
        }
    }
}

using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class AccountSQLContext : IAccountContext
    {
        private string query;
        private SqlCommand command;

        public User GetAccount(string username)
        {
            User CurrUser = new User();
                try
                {
                    using (SqlConnection Conn = ConnectionDB.GetConnection())
                    {
                        Conn.Open();
                        query = "SELECT * FROM dbo.Account WHERE UserName = @username";
                        SqlParameter param1 = new SqlParameter();
                        param1.ParameterName = "@username";
                        param1.Value = username;
                    
                        command = new SqlCommand(query, Conn);
                        command.Parameters.Add(param1);
                        command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int UserID = Convert.ToInt32(reader["ID"]);
                                    string Name = Convert.ToString(reader["UserName"]);
                                    string Password = Convert.ToString(reader["Password"]);
                                    CurrUser = new User(UserID, Name);
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
            
                return CurrUser;
            
        }

        public bool CheckLogin(string username, string password)
        {
            int ExcistingAccount;
            using (SqlConnection Conn = ConnectionDB.GetConnection())
            {
                Conn.Open();
                query = "Select count(*) FROM dbo.Account WHERE UserName = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@username";
                    param1.Value = username;

                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@password";
                    param2.Value = password;

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    ExcistingAccount = Convert.ToInt32(cmd.ExecuteScalar());
                }
                Conn.Close();
            }
            if (ExcistingAccount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

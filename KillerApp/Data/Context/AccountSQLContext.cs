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

        public User GetAccount(string email)
        {
            User CurrUser = new User();
                try
                {
                    using (SqlConnection Conn = ConnectionDB.GetConnection())
                    {
                        Conn.Open();
                        query = "SELECT * FROM dbo.Account WHERE Email = @email";
                        SqlParameter param1 = new SqlParameter();
                        param1.ParameterName = "@email";
                        param1.Value = email;
                    
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
                                    string Email = Convert.ToString(reader["Email"]);
                                    string Country = Convert.ToString(reader["Country"]);
                                    DateTime date = Convert.ToDateTime(reader["Birthdate"]);
                                CurrUser = new User(UserID, Name,Email,Country,date);
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

        public bool CheckLogin(string email, string password)
        {
            int ExcistingAccount;
            using (SqlConnection Conn = ConnectionDB.GetConnection())
            {
                Conn.Open();
                query = "Select count(*) FROM dbo.Account WHERE Email = @email AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@email";
                    param1.Value = email;

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

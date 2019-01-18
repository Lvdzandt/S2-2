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

        public void RegisterAccount(User newacc)
        {

        }

        public User GetAccount(string email)
        {
            User CurrUser = new User();
                try
                {
                    using (SqlConnection Conn = ConnectionDB.GetConnection())
                    {
                        Conn.Open();

                    
                        command = new SqlCommand("GetAccount", Conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@param1",SqlDbType.NVarChar).Value = email;
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

        //TODO Fix Login StoredProcedure
        public bool CheckLogin(string email, string password)
        {
            int ExcistingAccount;
            using (SqlConnection Conn = ConnectionDB.GetConnection())
            {
                Conn.Open();

                command = new SqlCommand("CheckLogin", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@param2", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@param1", SqlDbType.NVarChar).Value = password;

                ExcistingAccount = (int)command.ExecuteScalar();
                

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

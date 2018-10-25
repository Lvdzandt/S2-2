using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class GameSQLContext : IGameContext
    {
        public string query;
        public SqlCommand command;

        public List<Game> GetAllGames()
        {
            List<Game> output = new List<Game>();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    query = "SELECT * FROM dbo.Game";
                    command = new SqlCommand(query, Conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int GameID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["Name"]);
                                string Description = Convert.ToString(reader["Description"]);
                                output.Add(new Game() { ID = GameID, Description = Description, Name = Name });
                            }
                        }
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }

            return output;
        }

        public void AddGame(Game game)
        {

        }
    }
}

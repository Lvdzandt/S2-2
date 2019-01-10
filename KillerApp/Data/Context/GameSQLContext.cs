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
        private string query;
        private SqlCommand command;

        public List<Speedrun> GetAllSpeedruns(int id)
        {
            List<Speedrun> output = new List<Speedrun>();

            return output;
        }

        public Game GetGame(int id)
        {
            Game output = new Game();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    query = "SELECT * FROM dbo.Game WHERE ID = @id";
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@id";
                    param1.Value = id;

                    command = new SqlCommand(query, Conn);
                    command.Parameters.Add(param1);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int GameID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["Name"]);
                                string Description = Convert.ToString(reader["Description"]);
                                output.ID = GameID;
                                output.Name = Name;
                                output.Description = Description;
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

        public void AddGame(Game game)
        {
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    query = "INSERT INTO dbo.Game (Name,Description) VALUES(@name,@description)";
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@name";
                    param1.Value = game.Name;

                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@description";
                    param2.Value = game.Description;

                    command = new SqlCommand(query, Conn);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //TODO: fix query
        public Leaderbord GetLeaderbord(int id)
        {
            Leaderbord output = new Leaderbord();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    query = "SELECT dbo.Leaderboard.ID " +
                        "FROM dbo.Leaderboard " +
                        "INNER JOIN dbo.Game on dbo.Leaderboard.GameID = dbo.Game.ID " +
                        "WHERE dbo.Game.ID = @id";
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@id";
                    param1.Value = id;
                    command = new SqlCommand(query, Conn);
                    command.Parameters.Add(param1);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int IDleader = Convert.ToInt32(reader["ID"]);
                                //int GameID = Convert.ToInt32(reader["GameID"]);
                                output.ID = IDleader;
                                output.GameID = id;
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

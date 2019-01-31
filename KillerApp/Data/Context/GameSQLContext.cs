using KillerApp.Data.Interface;
using KillerApp.Objects;
using Objects.Enumeration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class GameSQLContext : IGameContext
    {
        private SqlCommand command;

        public List<Speedrun> GetUserSpeedruns(int id)
        {
            List<Speedrun> output = new List<Speedrun>();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    command = new SqlCommand("GetUserSpeedruns", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int _ID = Convert.ToInt32(reader["ID"]);
                                string _name = Convert.ToString(reader["Name"]);
                                int _playerid = Convert.ToInt32(reader["PlayerID"]);
                                DateTime _date = Convert.ToDateTime(reader["Date"]);
                                int _hours = Convert.ToInt32(reader["Hours"]);
                                int _minutes = Convert.ToInt32(reader["Minutes"]);
                                GameCategory.Categorie _category = (GameCategory.Categorie)Enum.ToObject(typeof(GameCategory.Categorie), reader.GetInt32(7));
                                //int _seconds = Convert.ToInt32(reader["Seconds"]);
                                output.Add(new Speedrun() { ID = _ID, Player = _name, Date = _date, Hours = _hours, Minutes = _minutes, Category = _category });
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

        public List<Speedrun> GetAllSpeedruns(int id)
        {
            List<Speedrun> output = new List<Speedrun>();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    command = new SqlCommand("GetAllSpeedruns", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ID",SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int _ID = Convert.ToInt32(reader["ID"]);
                                string _name = Convert.ToString(reader["Name"]);
                                int _playerid = Convert.ToInt32(reader["PlayerID"]);
                                DateTime _date = Convert.ToDateTime(reader["Date"]);
                                int _hours = Convert.ToInt32(reader["Hours"]);
                                int _minutes = Convert.ToInt32(reader["Minutes"]);
                                int test = reader.GetInt32(7);
                                GameCategory.Categorie _category = (GameCategory.Categorie)Enum.ToObject(typeof(GameCategory.Categorie), reader.GetInt32(7));
                                //int _seconds = Convert.ToInt32(reader["Seconds"]);
                                output.Add(new Speedrun() { ID = _ID, Player = _name, Date = _date, Hours = _hours, Minutes = _minutes, Category = _category});
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

        public int GetRunID(string name)
        {
            int output = 0;
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    
                    command = new SqlCommand("GetRunID", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@param1", SqlDbType.VarChar).Value = name;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int runID = Convert.ToInt32(reader["ID"]);
                                output = runID;
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

        public Game GetGame(int id)
        {
            Game output = new Game();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    
                    command = new SqlCommand("GetGame", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id",SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int GameID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["Name"]);
                                string Description = Convert.ToString(reader["Description"]);
                                DateTime Release = Convert.ToDateTime(reader["ReleaseYear"]);
                                string console = Convert.ToString(reader["Console"]);

                                output.ID = GameID;
                                output.Name = Name;
                                output.Description = Description;
                                output.ReleaseDate = Release;
                                output.Console = console;
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
                    
                    command = new SqlCommand("GetAllGames", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int GameID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["Name"]);
                                string Description = Convert.ToString(reader["Description"]);
                                DateTime Release = Convert.ToDateTime(reader["ReleaseYear"]);
                                string console = Convert.ToString(reader["Console"]);
                                output.Add(new Game() { ID = GameID, Description = Description, Name = Name,ReleaseDate = Release,Console= console });
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
                    command = new SqlCommand("AddGame", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@name",SqlDbType.NVarChar).Value = game.Name;
                    command.Parameters.Add("@description",SqlDbType.NVarChar).Value = game.Description;
                    command.Parameters.Add("@release", SqlDbType.VarChar).Value = game.ReleaseDate;
                    command.Parameters.Add("@console", SqlDbType.VarChar).Value = game.Console;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddRun(Speedrun run)
        {
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    
                    SqlCommand comand = new SqlCommand("AddRun", Conn);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.Add("@name", SqlDbType.VarChar).Value = run.Player;
                    comand.Parameters.Add("@playerid", SqlDbType.Int).Value = run.PlayerID;
                    comand.Parameters.Add("@date", SqlDbType.Date).Value = run.Date;
                    comand.Parameters.Add("@hours", SqlDbType.Int).Value = run.Hours;
                    comand.Parameters.Add("@minutes", SqlDbType.Int).Value = run.Minutes;
                    comand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddLeaderBoardRun(int id, int id2)
        {
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    command = new SqlCommand("AddLBR", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@lbid", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@runid", SqlDbType.Int).Value = id2;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Leaderbord GetLeaderbord(int id)
        {
            Leaderbord output = new Leaderbord();
            try
            {
                using (SqlConnection Conn = ConnectionDB.GetConnection())
                {
                    Conn.Open();
                    command = new SqlCommand("GetLeaderboard", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id",SqlDbType.Int).Value = id;
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

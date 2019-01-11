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
    public class GameSQLContext : IGameContext
    {
        private string query;
        private SqlCommand command;

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
                                int _seconds = Convert.ToInt32(reader["Seconds"]);
                                output.Add(new Speedrun() { ID = _ID, Player = _name, Date = _date, Hours = _hours, Minutes = _minutes, Secondes = _seconds });
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

                    command = new SqlCommand("AddGame", Conn);
                    command.Parameters.Add("@name",SqlDbType.NVarChar).Value = game.Name;
                    command.Parameters.Add("@description",SqlDbType.NVarChar).Value = game.Description;
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

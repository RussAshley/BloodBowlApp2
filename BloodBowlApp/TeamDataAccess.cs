using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace BloodBowlApp
{
    class TeamDataAccess
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public TeamDataAccess (string connectionString)
        {
            ConnectionString = connectionString;
        }

        //passin team name return associted details
        public Teams ReadTeamData(string teamName)
        {
            Teams result = new Teams(0, "", "", "", 0, "", "", 0);
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT* FROM BloodBowlTeamData WHERE TeamName=@TeamName " ;
                command.Parameters.AddWithValue("@TeamName", teamName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.ID1 = reader.GetInt32(0);
                        result.TeamName1 = reader.GetString(1);
                        result.Examples1 = reader.GetString(2);
                        result.STYLE1 = reader.GetString(3);
                        result.ReRoll1 = reader.GetInt32(4); 
                        result.Appo1 = reader.GetString(5);
                        result.SpecialRules1 = reader.GetString(6);
                        result.Tier1 = reader.GetInt32(7);
                    }
                }
            }
            return result;
        }

        public Positions ReadPositionsData(string teamName)
        {
            Positions result = new Positions(0,0,0,"",0,0,0,0,0,0,"","","");
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT* FROM teamdetails WHERE teamdetailsID= 
                command.Parameters.AddWithValue("@TeamName", teamName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.ID1 = reader.GetInt32(0);
                        result.TeamdetailsID = reader.GetInt32(1);
                        result.Qty = reader.GetInt32(2);
                        result.Position = reader.GetString(3);
                        result.Cost = reader.GetInt32(4);
                        result.Ma1 = reader.GetInt32(5);
                        result.St = reader.GetInt32(6);
                        result.Ag= reader.GetInt32(7);
                        result.Pa = reader.GetInt32(8);
                        result.Av = reader.GetInt32(9);
                        result.Skills = reader.GetString(10);
                        result.Primary = reader.GetString(11);
                        result.Secondary = reader.GetString(12);
                    }
                }
            }
            return result;
        }


    }

}

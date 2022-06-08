using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
    public class LeaderboardDAL : ILeaderBoardDAL
    {
        public DataSet getLeaderboard(int tournamentId)
        {
            MySqlCommand command = new MySqlCommand();
            //For getting the score if the player is player1
            command.CommandText = "SELECT  a.AccountID, a.FirstName,a.LastName,a.Email, p.TeamName, COUNT(TournamentID) " +
                 "FROM ds_match " +
                 "INNER JOIN ds_player as p on Player1 = p.AccountID " + 
                 "INNER JOIN ds_account as a on p.AccountID = a.AccountID " +
                "where score1> score2 AND TournamentID=@tourId " +
                "GROUP BY p.TeamName; ";
            //For getting the score if the player is player2
            command.CommandText += "SELECT a.AccountID, a.FirstName,a.LastName,a.Email, p.TeamName, COUNT(TournamentID) " +
                "FROM ds_match " +
                "INNER JOIN ds_player as p on Player2 = p.AccountID " +
                "INNER JOIN ds_account as a on p.AccountID = a.AccountID " +
                "where score1<score2 AND TournamentID = @tourId " +
                "GROUP BY p.TeamName";
            command.Parameters.AddWithValue("@tourId",tournamentId);

           DataSet data =  DBExecuter.ExecuteReader(command);
            if (data.Tables.Count > 0)
                if (data.Tables[0].Rows.Count > 0)
                {
                    for (int i = 1; i <= data.Tables.Count - 1; i++)
                        data.Tables[0].Merge(data.Tables[i]);
                    return data;
                }

            //if there is no value inside
            data = null;
            return data;

        }
    }
}

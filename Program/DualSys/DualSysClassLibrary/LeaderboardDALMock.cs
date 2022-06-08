using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
    public class LeaderboardDALMock : ILeaderBoardDAL
    {
        public DataSet getLeaderboard(int tournamentId)
        {
            
            //For getting the score if the player is player1
           //"a.AccountID, a.FirstName,a.LastName,a.Email, p.TeamName, COUNT(TournamentID) " +
           //      "FROM ds_match " +
           //      "INNER JOIN ds_player as p on Player1 = p.AccountID " + 
           //      "INNER JOIN ds_account as a on p.AccountID = a.AccountID " +
           //     "where score1> score2 AND TournamentID=@tourId " +
           //     "GROUP BY p.TeamName; ";
            
           DataSet data =  new DataSet();
            if (tournamentId == 3)
            {
                DataTable table = new DataTable();
                DataColumn column =
                    table.Columns.Add("AccountID", typeof(Int32));
                table.Columns.Add("Fname", typeof(string));
                table.Columns.Add("Lname", typeof(string));
                table.Columns.Add("email", typeof(string));
                table.Columns.Add("teamName", typeof(string));
                table.Columns.Add("count", typeof(Int64));

                DataRow row = table.NewRow();
                row[0] = 4;
                row[1] = "Lenny";
                row[2] = "Fizzy";
                row[3] = "lenny@gmail.com";
                row[4] = "Fizzy colly";
                row[5] = 10;

                table.Rows.Add(row);

                data.Tables.Add(table);
                return data;
            } 
            data = null;
            return data;
        }
    }
}

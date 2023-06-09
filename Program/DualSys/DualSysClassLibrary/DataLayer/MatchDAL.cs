using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class MatchDAL : IMatchDAL
	{
		private bool CheckSingleResult(MySqlCommand command)
		{
            if (DBExecuter.ExecuteNoNQuery(command) > 0) return true;
            else return false;
        }

		private bool CheckMultipleResults(MySqlCommand command, out DataSet data)
		{
            data = DBExecuter.ExecuteReader(command);
            if (data.Tables.Count > 0)
            {
                if (data.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    data = null;
                    return false;
                }
            }
            else
            {
                data = null;
                return false;
            }
        }

        public bool CreateMatch(int tournamentId, int playerId1, int playerId2)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMatch(int tournamentId,int player1,int player2, int score1, int score2)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "UPDATE ds_match SET score1=@s1, score2=@s2 where tournamentID=@tourId AND player1=@p1 AND player2=@p2";
            command.Parameters.AddWithValue("@tourId",tournamentId);
            command.Parameters.AddWithValue("@p1",player1);
            command.Parameters.AddWithValue("@p2",player2);
            command.Parameters.AddWithValue("@s1",score1);
            command.Parameters.AddWithValue("@s2",score2);
            return CheckSingleResult(command);
        }

        public DataSet GetMatches(int tournamentId)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `ds_match`.*, " +
                "a1.`AccountID`,  a1.`FirstName`,  a1.`LastName`,  a1.`Email`, p1.teamName, " +
                "a2.`AccountID`,  a2.`FirstName`,  a2.`LastName`,  a2.`Email`, p2.teamName " +
                "FROM `ds_match` " +
                "LEFT JOIN `ds_player` as p1 ON `ds_match`.`Player1` = p1.`AccountID` " +
                "LEFT JOIN `ds_account` as a1 ON p1.AccountID = a1.`AccountID` " +
                "LEFT JOIN `ds_player` as p2 ON `ds_match`.`Player2` = p2.`AccountID` " +
                "LEFT JOIN `ds_account` as a2 ON p2.AccountID = a2.`AccountID` " +
                "WHERE ds_match.TournamentID = @tournamentID";
            command.Parameters.AddWithValue("@tournamentID", tournamentId);
            if (CheckMultipleResults(command, out DataSet data))
                return data;
            else return null;
        }
    }
}

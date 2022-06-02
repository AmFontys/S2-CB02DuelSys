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

        public bool CreateMatcht(int tournamentId, int playerId1, int playerId2)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMatch(int tournamentId, int score1, int score2)
        {
            throw new NotImplementedException();
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

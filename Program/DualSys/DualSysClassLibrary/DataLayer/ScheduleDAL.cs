using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class ScheduleDAL : IScheduleDAL
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
                else return false;
            }
            else
            {
                return false;
            }
        }

        public bool StartTournament(List<string> matches,int tourId)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT m.TournamentID from ds_match as m where m.TournamentID=@tournamentID;";
            command.Parameters.AddWithValue("@tournamentID", tourId);
            if (CheckMultipleResults(command,out _)) 
                return false;
            command.CommandText = "";

            foreach (string match in matches)
                command.CommandText += match;
            return CheckSingleResult(command);
        }

        public bool NextRound(List<string> matches,int tourId)
        {
            throw new NotImplementedException();
        }

        
    }
}

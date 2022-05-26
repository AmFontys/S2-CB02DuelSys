using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class TournamentDAL : ITournamentDAL
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

        public bool CreateTournament(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTournament(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTournament(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet GetTournaments(string status)
        {
            throw new NotImplementedException();
        }

        public DataSet GetTournament(string name)
        {
            throw new NotImplementedException();
        }

        public DataSet GetTournament(int id)
        {
            throw new NotImplementedException();
        }
    }
}

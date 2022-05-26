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
			throw new NotImplementedException();
		}

		private bool CheckMultipleResults(MySqlCommand command, out DataSet data)
		{
			throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}

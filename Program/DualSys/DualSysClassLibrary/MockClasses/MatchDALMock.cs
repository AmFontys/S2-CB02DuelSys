using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class MatchDALMock : IMatchDAL
	{
		
        public bool CreateMatch(int tournamentId, int playerId1, int playerId2)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMatch(int tournamentId,int player,int player2, int score1, int score2)
        {
            throw new NotImplementedException();
        }

        public DataSet GetMatches(int tournamentId)
        {
            throw new NotImplementedException();
        }
    }
}

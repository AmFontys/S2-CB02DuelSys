using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSync.Tournament
{
	public class MatchManager
	{
		public MatchManager(IMatchtDAL dal)
		{
			throw new NotImplementedException();
		}

		public bool CreateMatch(int tournamentId, int playerId1, int playerId2)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMatcht(int tournamentid, int score1, int score2)
		{
			throw new NotImplementedException();
		}

		public List<Match> GetMatches(int tournamentId)
		{
			throw new NotImplementedException();
		}
	}
}

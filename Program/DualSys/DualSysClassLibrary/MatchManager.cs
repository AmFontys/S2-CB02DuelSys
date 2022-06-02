using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class MatchManager
	{
		private IMatchDAL _dal;
		public MatchManager(IMatchDAL dal)
		{
			_dal=dal;
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

using System;
using System.Collections.Generic;
using System.Data;
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
			if(tournamentId <= 0) return null;

			DataSet data = _dal.GetMatches(tournamentId);
			if(data == null) return null;
            else
            {
				List<Match> matches = new List<Match>();

				foreach(DataRow r in data.Tables[0].Rows)
                {
					Player p1 = new Player((int)r[5],(string)r[6], (string)r[7], (string)r[8], (string)r[9]);
					Player p2 = new Player((int)r[10], (string)r[11], (string)r[12], (string)r[13], (string)r[14]);
					Match newMatch;
					if (r[3].ToString().Length > 0)
						newMatch = new Match((int)r[0], p1, p2, (int)r[3], (int)r[4]);
					else
						newMatch = new Match((int)r[0], p1, p2, 0, 0);
					matches.Add(newMatch);
                }

				return matches;
            }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class MatchManager
	{
		private IMatchDAL _dal;
		private TournamentManager _tourMan;
		public MatchManager(IMatchDAL dal, TournamentManager tournamentMan)
		{
			_dal=dal;
			_tourMan = tournamentMan;
		}

		public bool CreateMatch(int tournamentId, int playerId1, int playerId2)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMatch(int tournamentid,int player,int player2, int score1, int score2,out string error)
		{
			error = "";
			if (tournamentid <= 0 | score1 < 0 | score2 < 0) return false;
			if (player <= 0 | player2 < 0 ) return false;
			Tournament tournament = _tourMan.GetTournament(tournamentid);
			Sport sport = tournament.getSport();
			if (sport == null) return false;

            if (sport.getWinConditionOne().Length > 0)
            {
				int dashIndex = sport.getWinConditionOne().IndexOf("-");
				string losingString = sport.getWinConditionOne().Substring(0, dashIndex);
				string winString = sport.getWinConditionOne().Substring(dashIndex+1);
				int losingScore = Convert.ToInt32(losingString);
				int winScore = Convert.ToInt32(winString);
				if (score1 < winScore & score2 < winScore)
					error = $"The score isn't high enough. the score to win needs to be {winScore}";
				else if (score1 == winScore & score2 <= losingScore | score2 == winScore & score1 <= losingScore)
				{
					//win condition 1
					return _dal.UpdateMatch(tournamentid,player,player2, score1, score2);
				}
				else if (score1 >= winScore & score2 > losingScore | score2 >= winScore & score1 > losingScore)
				{
					//win condition 2
					
					dashIndex = sport.getWinConditionTwo().IndexOf("-");
					losingString = sport.getWinConditionTwo().Substring(0, dashIndex);
					winString = sport.getWinConditionTwo().Substring(dashIndex+1);
					losingScore = Convert.ToInt32(losingString);
					winScore = Convert.ToInt32(winString);
					int diffrence = winScore - losingScore;

					//For win condition 3
					string lastWinString = sport.getWinConditionThree().Substring(0);
					int lastWinScore;
					if (lastWinString.Length > 0)
						lastWinScore = Convert.ToInt32(lastWinString);
					else lastWinScore = 0;

					if (lastWinScore ==0 & (score2+diffrence==score1) | lastWinScore == 0 & (score1 + diffrence == score2) )
					{
						return _dal.UpdateMatch(tournamentid, player, player2, score1, score2);
					}
					else if (lastWinScore > score1 & (score2 + diffrence == score1) | lastWinScore >score2 & (score1 + diffrence == score2))
					{
						return _dal.UpdateMatch(tournamentid, player, player2, score1, score2);
					}
					else if (lastWinScore !=0)
                    {
						//wincondition 3						
						if (score1==lastWinScore | score2==lastWinScore)
							return _dal.UpdateMatch(tournamentid, player, player2, score1, score2);
					}
					error = $"Nobody hasn't won yet or a score is too high/low to win";
					return false;

				}
				error = $"Nobody hasn't won yet";
				return false;
			}
			error = $"The tournament wasn't loaded correctly pleae try again at a later time";

			return false;
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

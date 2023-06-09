using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface IMatchDAL
	{
		bool CreateMatch(int tournamentId, int playerId1, int playerId2);

		bool UpdateMatch(int tournamentId,int player,int player2, int score1, int score2);

		DataSet GetMatches(int tournamentId);
	}
}

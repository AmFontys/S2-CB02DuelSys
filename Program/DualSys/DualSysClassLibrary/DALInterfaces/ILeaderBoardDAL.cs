using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface ILeaderBoardDAL
	{
		DataSet getLeaderboard(int tournamentId);
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class LeaderBoardManager
	{
		private ILeaderBoardDAL _dal;
		public LeaderBoardManager(ILeaderBoardDAL dal)
        {
			_dal = dal;
        }

		public List<LeaderBoard> getLeaderboard(int tournamentId)
		{
			if (tournamentId < 1) return null;

			DataSet data = _dal.getLeaderboard(tournamentId);
			if (data == null) return null;
            else
            {
				List<LeaderBoard> list = new List<LeaderBoard>();

				foreach(DataRow row in data.Tables[0].Rows)
                {
					//makes a player instance in the way of id, first name, last name, email and team
					Player player = new Player((int)row[0],(string)row[1], (string)row[2], (string)row[3], (string)row[4]);
					//makes a leaderBoard instance in the way of player instance and the score
					LeaderBoard board = new LeaderBoard(player, Convert.ToInt64( row[5]));
					list.Add(board);
                }
				list = list.OrderByDescending(x => x.GetScore()).ToList();
				return list;
            }
		}
	}
}

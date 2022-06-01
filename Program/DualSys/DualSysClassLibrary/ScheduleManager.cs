using DuelSysClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class ScheduleManager
	{
		IScheduleDAL _sDal;
		IMatchDAL _mDal;
		public ScheduleManager(IScheduleDAL dal, IMatchDAL matchDal)
		{
			_sDal = dal;
			_mDal = matchDal;
		}

		public bool StartTournament(Tournament tournamentId,int[] players)
		{
			if(players.Length == 0)return false;
			if (tournamentId == null || tournamentId.getID() <= 0) return false;

			ITournamentType type = tournamentId.getSportType();

			List<string> list = type.StartRound(players);
			if(list.Count <= 0 | list.Count ==null) return false;
			return _sDal.StartTournament(list,tournamentId.getID());
		}

		public bool NextRound(Tournament tournemntId)
		{
			throw new NotImplementedException();
		}

		
	}
}

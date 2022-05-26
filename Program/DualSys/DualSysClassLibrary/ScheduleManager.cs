using DuelSysClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class ScheduleManager
	{
		public ScheduleManager(IScheduleDAL dal, IMatchDAL matchDal)
		{
			throw new NotImplementedException();
		}

		public bool StartTournament(ITournamentType type, List<Player> players)
		{
			throw new NotImplementedException();
		}

		public bool NextRound(ITournamentType type, int players)
		{
			throw new NotImplementedException();
		}

		public List<Schedule> GetSchedule(int tournamentId)
		{
			throw new NotImplementedException();
		}
	}
}

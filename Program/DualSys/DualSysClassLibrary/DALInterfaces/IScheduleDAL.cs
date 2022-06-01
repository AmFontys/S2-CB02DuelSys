using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface IScheduleDAL
	{
		bool StartTournament(List<string> matches,int tourId);

		bool NextRound(List<string> matches,int tourId);

	}
}

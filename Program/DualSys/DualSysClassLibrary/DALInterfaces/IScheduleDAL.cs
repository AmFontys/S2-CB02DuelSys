using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface IScheduleDAL
	{
		bool StartTournament(List<string> matches);

		bool NextRound(List<string> matches);

	}
}

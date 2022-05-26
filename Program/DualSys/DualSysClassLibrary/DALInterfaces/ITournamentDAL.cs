using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface ITournamentDAL
	{
		bool CreateTournament(Tournament tournament);

		bool UpdateTournament(Tournament tournament);

		bool DeleteTournament(int id);

		DataSet GetTournaments(string status);

		DataSet GetTournament(string name);

		DataSet GetTournament(int id);
	}
}

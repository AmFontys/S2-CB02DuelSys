using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class TournamentManager
	{
		public TournamentManager(ITournamentDAL dal)
		{
			throw new NotImplementedException();
		}

		public bool CreateTournament(string name, string description, int min, int max, DateTime startDate, DateTime endDate, ITournamentType type)
		{
			throw new NotImplementedException();
		}

		public void UpdateTournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end)
		{
			throw new NotImplementedException();
		}

		public bool DeleteTournament(int id)
		{
			throw new NotImplementedException();
		}

		public List<Tournament> GetTournaments(string status)
		{
			throw new NotImplementedException();
		}

		public Tournament GetTournament(string name)
		{
			throw new NotImplementedException();
		}

		public Tournament GetTournament(int id)
		{
			throw new NotImplementedException();
		}
	}
}

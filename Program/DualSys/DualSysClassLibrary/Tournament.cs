using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSync.Tournament
{
	public class Tournament
	{
		int _tournamentID;
		string _tournamentName;
		string _tournamantDescription;
		int _minPlayers;
		int _maxPlayers;
		string _currentStatus;
		DateTime _startDate;
		DateTime _endDate;

		public Tournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end)
		{
			throw new NotImplementedException();
		}

		public Tournament(int id, string name, string description, int min, int max, DateTime startDate, DateTime endDate, ITournamentType type)
		{
			throw new NotImplementedException();
		}

		public Tournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end, List<Match> matches, Sport sport, ITournamentType type)
		{
			throw new NotImplementedException();
		}
	}
}

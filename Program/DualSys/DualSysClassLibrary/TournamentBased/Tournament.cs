using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
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
		ITournamentType _sportType;
		List<Match> _matches;
		Sport _sport;


		public Tournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end)
		{
			_tournamentID = id;
			_tournamentName = name;
			_tournamantDescription = description;
			_minPlayers = min;
			_maxPlayers = max;
			_currentStatus = status;
			_startDate = start;
			_endDate = end;
		}

		public Tournament(int id, string name, string description, int min, int max, DateTime startDate, DateTime endDate, ITournamentType type,Sport sport)
		{
			_tournamentID = id;
			_tournamentName = name;
			_tournamantDescription = description;
			_minPlayers = min;
			_maxPlayers = max;
			_startDate = startDate;
			_endDate = endDate;
            _sportType = type;
			_sport = sport;
        }

        public Tournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end, List<Match> matches, Sport sport, ITournamentType type)
		{
			_tournamentID = id;
			_tournamentName = name;
			_tournamantDescription = description;
			_minPlayers = min;
			_maxPlayers = max;
			_currentStatus = status;
			_startDate = start;
			_endDate = end;
			_matches= matches;
			_sport= sport;
			_sportType= type;
		}

        public int getID()
        {
			return _tournamentID;
        }

		public string getTournamentName()
        {
			return _tournamentName;
        }

        public string getTournamentDescription()
        {
			return _tournamantDescription;
        }

		public int getMinPlayers()
        {
			return _minPlayers;
        }
		public int getMaxPlayers()
        {
			return _maxPlayers;
        }

		public string getStatus()
        {
			return _currentStatus;
        }

		public DateTime getStartDate()
        {
			return _startDate;
        }
		public DateTime getEndDate()
        {
			return _endDate;
        }

		public ITournamentType getSportType()
        {
			return _sportType;
        }

		public List<Match> getMatches()
        {
			return _matches;
        }

		public Sport getSport()
        {
			return _sport;
        }

        public override string ToString()
        {
			return $"{_tournamentName} from {_startDate} till {_endDate}";
        }

    }
}
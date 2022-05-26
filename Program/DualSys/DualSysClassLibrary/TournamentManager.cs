using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace DuelSysClassLibrary
{
	public class TournamentManager
	{
		private ITournamentDAL _dal;
		public TournamentManager(ITournamentDAL dal)
		{
			_dal = dal;
		}
		private bool ValidateInput(string input, string matchOn)
		{
			Regex regex = new Regex(matchOn);
			return regex.IsMatch(input);
		}

		public bool CreateTournament(string name, string description, int min, int max, DateTime startDate, DateTime endDate, ITournamentType type,Sport sport)
		{
			if (ValidateInput(name, @"^[a-zA-Z]*$") & ValidateInput(description, @"^[a-zA-Z0-9\s\-]*$") & min <= max & startDate >= DateTime.UtcNow.AddDays(7) & endDate >= startDate)
			{
				Tournament tournament = new Tournament(0, name, description, min, max, startDate, endDate, type,sport);
				return _dal.CreateTournament(tournament);
			}
			else return false;
		}

		public bool UpdateTournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end)
		{
			if (ValidateInput(name, @"^[a-zA-Z]*$") & ValidateInput(description, @"^[a-zA-Z0-9\s\-]*$") & min <= max & start >= DateTime.UtcNow.AddDays(7) & end >= start & status !=null & status !="")
			{
				Tournament tournament = new Tournament(id, name, description, min, max,status, start, end);
				return _dal.UpdateTournament(tournament);
			}
			else return false;
		}

		public bool DeleteTournament(int id)
		{
			if (id <= 0) return false;
			else return _dal.DeleteTournament(id);
		}

		public List<Tournament> GetTournaments(string status)
		{
			DataSet data = _dal.GetTournaments(status);
			if (data != null)
			{
				List<Tournament> list = new List<Tournament>();
				foreach(DataRow l in data.Tables[0].Rows)
                {
					ITournamentType type = new RoundRobin();
					Sport sport = new Sport((int)l[9],(string) l[10], (string)l[11]);
					list.Add(new Tournament((int)l[0], (string)l[2], (string)l[3], (int)l[4], (int)l[5],(string)l[8], (DateTime)l[6], (DateTime)l[7],null,sport, type ));
                }
				return list;
			}
			else return null;
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

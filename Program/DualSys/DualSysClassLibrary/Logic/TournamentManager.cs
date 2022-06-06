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
			//checks if the input is valid for the name no spaces is allowed only letters in the description there are spaces,letters,numbers and the - valid input
			//The min player count can't also be higher or equal to the max player count.
			//The start date needs to start atleast 7 days later then the date following the UTC in the world. The end date needs to be higher or equal to the startdate
			if (ValidateInput(name, @"^[a-zA-Z]*$") & ValidateInput(description, @"^[a-zA-Z0-9\s\-]*$") & min <= max & startDate >= DateTime.UtcNow.AddDays(7) & endDate >= startDate)
			{
				Tournament tournament = new Tournament(0, name, description, min, max, startDate, endDate, type,sport);
				return _dal.CreateTournament(tournament);
			}
			else return false;
		}

		public bool UpdateTournament(int id, string name, string description, int min, int max, string status, DateTime start, DateTime end)
		{
			//checks if the input is valid for the name no spaces is allowed only letters in the description there are spaces,letters,numbers and the - valid input
			//The min player count can't also be higher or equal to the max player count.
			//The start date needs to start atleast 7 days later then the date following the UTC in the world. The end date needs to be higher or equal to the startdate
			if (ValidateInput(name, @"^[a-zA-Z]*$") & ValidateInput(description, @"^[a-zA-Z0-9\s\-]*$") & min <= max & start >= DateTime.UtcNow.AddDays(7) & end >= start & status !=null & status !="")
			{
				Tournament tournament = new Tournament(id, name, description, min, max,status, start, end);
				return _dal.UpdateTournament(tournament);
			}
			else return false;
		}
		public bool UpdateTournament(int id, string status)
		{
			//checks if the input is valid for the id 			
			//also checks if the status is empty
			if (id >0 & status !=null & status !="")
			{				
				return _dal.UpdateTournament(id,status);
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
			DataSet data = _dal.GetTournaments(status);//This gets all the tournaments based on the status of them
			if (data != null & data.Tables.Count>0)//to check if there is data in the DataSet
			{
				List<Tournament> list = new List<Tournament>();
				foreach(DataRow l in data.Tables[0].Rows)
                {
					ITournamentType type = new RoundRobin();
					Sport sport = new Sport((int)l[9],(string) l[10], (string)l[11]);//make an instance of the sport 
					//An instance of the tournament is made by the id, the name, the description, the min amount of players, the max amount of players, the status of the tournament
					//the start date, the end date, the list of matches which is null because it's not needed, the instance of the sport class and the type of system the tournament is using in class form
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
			DataSet data = _dal.GetTournament(id);
			if (data != null & data.Tables.Count > 0)//to check if there is data in the DataSet
			{
				Tournament list;
				DataRow l = data.Tables[0].Rows[0];

				ITournamentType type = new RoundRobin();
				Sport sport;
				if (l[12] == DBNull.Value)
					sport = new Sport((int)l[9], (string)l[10], (string)l[11]);//make an instance of the sport 
				else sport = new Sport((int)l[9], (string)l[10], (string)l[11],(string)l[12],(string)l[13]);//make an instance of the sport  
				//An instance of the tournament is made by the id, the name, the description, the min amount of players, the max amount of players, the status of the tournament
				//the start date, the end date, the list of matches which is null because it's not needed, the instance of the sport class and the type of system the tournament is using in class form
				list = new Tournament((int)l[0], (string)l[2], (string)l[3], (int)l[4], (int)l[5], (string)l[8], (DateTime)l[6], (DateTime)l[7], null, sport, type);

				return list;
			}
			else return null;
		}

		public int[] GetSignUps(int tourId)
        {
			List<int>players = new List<int>();
			DataSet set = _dal.GetSignUps(tourId);
			if(set.Tables.Count>0)
			{
                if (set.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in set.Tables[0].Rows)
                    {					
						players.Add(Convert.ToInt32( r[0]));
                    }
                }
				
			}
			return players.ToArray();
        }

	}
}

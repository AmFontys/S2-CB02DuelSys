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

		//this method makes the first instance of the first round of a tournament
		public bool StartTournament(Tournament tournamentId,int[] players)
		{
			//first it check if there is even players and that the player array is long enough
			//Then it checks the tournamentId with if it's empty and the ID is enough
			if (players == null) return false;
			else if ( players.Length <= 0  )return false;
			else if (tournamentId == null || tournamentId.getID() <= 0) return false;

			//gets the type of tournament it is
			ITournamentType type = tournamentId.getSportType();

			//gets the match strings from the the type of tournament
			List<string> list = type.StartRound(players);
			//checks if the list of matches is long enough and if it's not null
			if(list.Count < tournamentId.getMinPlayers() | list.Count ==null) return false;
			//return a bool if the tournament can be succesfully created
			return _sDal.StartTournament(list,tournamentId.getID());
		}

		public bool NextRound(Tournament tournemntId)
		{
			throw new NotImplementedException();
		}

		
	}
}

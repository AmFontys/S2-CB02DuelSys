using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSync.Tournament
{
	public interface ITournamentType
	{
		static List<string> StartRound(int playerCount);

		static List<string> NextRound(int amountOfPlayers);
	}
}

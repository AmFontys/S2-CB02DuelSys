using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public interface ITournamentType
	{
		List<string> StartRound(int[] playerCount);

		List<string> NextRound(int[] amountOfPlayers);
	}
}

using DuelSysClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class Match
	{
		int _tournamentId;
		Player _player1;
		Player _player2;
		int _scorePlayer1;
		int _scorePlayer2;

		public Match(int id, Player player1, Player player2, int score1, int score2)
		{
			_tournamentId = id;
			_player1 = player1;
			_player2 = player2;
			_scorePlayer1 = score1;
			_scorePlayer2 = score2;
		}
	}
}

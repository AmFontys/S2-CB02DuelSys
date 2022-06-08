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

		public int GetTourId()
		{
			return _tournamentId;
		}
		public Player GetPlayer1()
        {
			return _player1;
        }
		
		public Player GetPlayer2()
        {
			return _player2;
        }

		public int GetScore1()
        {
			return _scorePlayer1;
        }

		public int GetScore2()
        {
			return _scorePlayer2;
        }

		public Match(int id, Player player1, Player player2, int score1, int score2)
		{
			_tournamentId = id;
			_player1 = player1;
			_player2 = player2;
			_scorePlayer1 = score1;
			_scorePlayer2 = score2;
		}

        public override string ToString()
        {
			return $"{_player1.getFname()}{_player1.getLname()}  vs  {_player2.getFname()} {_player2.getLname()}  ({_scorePlayer1}:{_scorePlayer2})";
        }

    }
}

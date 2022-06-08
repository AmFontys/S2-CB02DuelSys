using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class LeaderBoard
	{
		private Player _player;
		private long _score;

		public long GetScore()
        {
			return _score;
        } 
		public LeaderBoard(Player player, long score)
		{
			_player = player;
			_score = score;
		}

        public override string ToString()
        {
			return $"{_player.getFname()} {_player.getLname()}: {_score} ";
        }
    }
}

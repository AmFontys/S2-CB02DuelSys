using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Player : Account
	{
		private string _team;

		public Player(string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password) : base(fname, lname, email,team, birthdate, gender, address, town, password)
		{
			_team = team;
		}

        public Player(int id,string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password, string keyword) : base(id, fname, lname, email, birthdate, gender, address, town, password, keyword)
        {
			_team = team;
        }

        public string getTeam()
        {
			return _team;
        }
    }
}

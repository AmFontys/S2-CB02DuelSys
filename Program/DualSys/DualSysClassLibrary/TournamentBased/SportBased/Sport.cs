using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
	public class Sport
	{
		int _sportId;
		string _sportName;
		string _winCondition1;
		string _winCondition2;
		string _winCondition3;

		public int getID()
        {
			return _sportId;
        }

		public string getName()
        {
			return _sportName;
        }

		public string getWinConditionOne()
        {
			return _winCondition1;
        }
		public string getWinConditionTwo()
        {
			return _winCondition2;
        }
		public string getWinConditionThree()
        {
			return _winCondition3;
        }

		public Sport(int id, string name, string condition1)
		{
			_sportId = id;
			_sportName = name;
			_winCondition1 = condition1;
		}

		public Sport(int id, string name, string win1, string win2, string win3)
		{
			_sportId = id;
			_sportName = name;
			_winCondition1 = win1;
			_winCondition2 = win2;
			_winCondition3 = win3;
		}

        public override string ToString()
        {
			return $"{_sportName}";
        }

    }
}

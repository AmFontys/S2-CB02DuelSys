using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class company
	{
		private int _id;
		private string _companyName;
		private string _companyLocation;

		public int getId()
        {
			return _id;
        }

		public company(string name, string location)
		{
			_companyName = name;
			_companyLocation = location;
		}
		public company(int id,string name, string location)
		{
			_id= id;
			_companyName = name;
			_companyLocation = location;
		}

		public override string ToString()
        {
            return $"{_companyName}({_companyLocation})";
        }
    }
}

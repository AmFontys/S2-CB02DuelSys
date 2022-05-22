using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Staff : Account
	{
		private string _employeeKey;
		private company _company;

        public Staff(string fname,string lname, string email, DateTime birthdate, char gender, string address, string town, string password,string key, string employeeKey) : base(0,fname, lname, email, birthdate, gender, address, town, password,key)
		{
			_employeeKey = employeeKey;
		}

		public Staff(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password,string keyword, string employeeKey, company company) : base(0,fname, lname, email, birthdate, gender, address, town, password,keyword)
		{
			_employeeKey= employeeKey;
			_company = company;
		}

		public static void GenerateEmployeeKey(string dateUTCNow, string name, string email, string birthdate)
		{
			throw new NotImplementedException();
		}
	}
}

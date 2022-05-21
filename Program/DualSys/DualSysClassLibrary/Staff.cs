using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Staff : Account
	{
		private string _employeeKey;
		private company _company;

        public Staff(string fname,string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey) : base(fname, lname, email, birthdate, gender, address, town, password)
		{
			_employeeKey = employeeKey;
		}

		public Staff(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey, company company) : base(fname, lname, email, birthdate, gender, address, town, password)
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

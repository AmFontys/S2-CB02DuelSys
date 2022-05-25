using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Staff : Account
	{		
		private company _company;
		
		public company getCompany()
        {
			return _company;
        }

		public Staff(int id,string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password,string keyword, company company) : base(id,fname, lname, email, birthdate, gender, address, town, password,keyword)
		{
			
			_company = company;
		}
				
	}
}

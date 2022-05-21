using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Account
	{
		private string _fname;
		private string _lname;
		private string _email;
		private DateTime _birthdate;
		private char _gender;
		private string _address;
		private string _town;
		private string _password;
		private string _keyword;

		public Account(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password)
		{
			_fname = fname;
			_lname = lname;
			_email = email;
			_birthdate = birthdate;
			_gender = gender;
			_address = address;
			_town = town;
			_password = password;
		}

		public Account(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password,string keyword)
		{
			_fname = fname;
			_lname = lname;
			_email = email;
			_birthdate = birthdate;
			_gender = gender;
			_address = address;
			_town = town;
			_password = password;
			_keyword = keyword;
		}

		public static string EncryptPassword(string password,out string keyword)
		{
			byte[] bytes = GenerateKeyword();
			keyword = Convert.ToBase64String(bytes);
			return GeneratePassword(password,bytes);		
		}

		private static byte[] GenerateKeyword()
		{
			throw new NotImplementedException();
		}

		private static string GeneratePassword(string password, byte[] key)
		{
			throw new NotImplementedException();
		}
	}
}

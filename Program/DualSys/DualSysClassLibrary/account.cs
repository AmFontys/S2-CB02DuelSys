using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class Account
	{
		private int _id;
		private string _fname;
		private string _lname;
		private string _email;
		private DateTime _birthdate;
		private char _gender;
		private string _address;
		private string _town;
		private string _password;
		private string _keyword;

		public int getID()
		{
			return _id;
		}

		public string getFname()
		{
			return _fname;
		}

		public string getEmail()
		{
			return _email;
		}

		public string getAddress()
		{
			return _address;
		}

		public string getTown()
		{
			return _town;
		}

		public string getGender()
		{
			return Convert.ToString(_gender);
		}

		public string getKey()
        {
			return _keyword;
        }

		public string getLname()
		{
			return _lname;
		}

		public DateTime getBirthDate()
        {
			return _birthdate;
        }

		public string getPassword()
        {
			return _password;
        }

		public Account(string fname, string lname, string email,string team, DateTime birthdate, char gender, string address, string town, string password)
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

		public Account(int id,string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password,string keyword)
		{
			_id = id;
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
		public static string EncryptPassword(string password, string keyword)
		{
			return GeneratePassword(password, Convert.FromBase64String(keyword));
		}

		private static byte[] GenerateKeyword()
		{
			byte[] salt = new byte[128 / 8];
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetNonZeroBytes(salt);
			}
			return salt;
		}

		private static string GeneratePassword(string password, byte[] key)
		{
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
			password: password,
			salt: key,
			prf: KeyDerivationPrf.HMACSHA256,
			iterationCount: 100000,
			numBytesRequested: 256 / 8));
			return hashed;
		}

       

	}
}

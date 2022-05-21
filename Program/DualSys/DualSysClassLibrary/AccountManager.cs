using System;
using System.Collections.Generic;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class AccountManager
	{
		private static IAccountDAL _dAL;
		public AccountManager(IAccountDAL dal)
        {
			_dAL = dal;
        }
		public bool AddAccount(string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password)
		{
			string encrytptPassword= Player.EncryptPassword(password, out string keyword);
			Player player = new Player(fname, lname, email, team, birthdate, gender, address, town, encrytptPassword,keyword);
			
			return _dAL.AddAccount(player);
		}

		public bool AddAccount(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey)
		{
			throw new NotImplementedException();
		}

		public bool AddAccount(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey, company company)
		{
			throw new NotImplementedException();
		}

		public bool UpdateAccount(int id, string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password)
		{
			throw new NotImplementedException();
		}

		public bool UpdateAccount(int id, string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey)
		{
			throw new NotImplementedException();
		}

		public bool UpdateAccount(int id, string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, string employeeKey, company company)
		{
			throw new NotImplementedException();
		}

		public List<Player> GetPlayers()
		{
			throw new NotImplementedException();
		}

		public List<Account> GetAccounts()
		{
			throw new NotImplementedException();
		}

		public List<Staff> GetStaff()
		{
			throw new NotImplementedException();
		}

		public bool DeleteAccount(int id)
		{
			throw new NotImplementedException();
		}

		public bool tournamentSignup(int playerId, int tournamentId)
		{
			throw new NotImplementedException();
		}

		public Player GetAccount(string email)
		{
			throw new NotImplementedException();
		}

		public Staff GetAccount(string email, string employeeKey)
		{
			throw new NotImplementedException();
		}

		public bool Login(string email, string password)
		{
			throw new NotImplementedException();
		}

		public bool Login(string email, string password, string employeeKey)
		{
			throw new NotImplementedException();
		}

		private bool CheckValidEmail(string email, out string key)
		{
			throw new NotImplementedException();
		}

		private bool CheckValidPassword(string email, string password)
		{
			throw new NotImplementedException();
		}

		private bool CheckEmployeeKey(string email, string password, string key)
		{
			throw new NotImplementedException();
		}
	}
}

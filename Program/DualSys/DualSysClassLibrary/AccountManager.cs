using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace  DuelSysClassLibrary
{
	public class AccountManager
	{
		private static IAccountDAL _dAL;
		public AccountManager(IAccountDAL dal)
        {
			_dAL = dal;
        }

        private bool ValidateInput(string input,string matchOn)
        {
			Regex regex = new Regex(matchOn);
			return regex.IsMatch(input);
        }

		public bool AddAccount(string fname, string lname, string email, string team, DateTime birthdate, char gender, string address,string town, string password)
		{
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") & ValidateInput(team, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string encrytptPassword = Player.EncryptPassword(password, out string keyword);
				Player player = new Player(0, fname, lname, email, team, birthdate, gender, address, town, encrytptPassword, keyword);

				return _dAL.AddAccount(player);
			}
			else return false;
		}

		public bool AddAccount(string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, company company)
		{
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string encrytptPassword = Player.EncryptPassword(password, out string keyword);
				Player player = new Player(0, fname, lname, email,"", birthdate, gender, address, town, encrytptPassword, keyword);

				return _dAL.AddAccount(player);
			}
			else return false;
		}

		public bool UpdateAccount(int id, string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password)
		{
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") & ValidateInput(team, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string keyword = "";
				if(password !="" & password!=null)
				password = Player.EncryptPassword(password, out keyword);
				Player player = new Player(id, fname, lname, email, team, birthdate, gender, address, town, password, keyword);

				return _dAL.UpdateAccount(player);
			}
			else return false;

		}
		
		public bool UpdateAccount(int id, string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, company company)
		{
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string keyword = "";
				if (password != "" & password != null)
					password = Staff.EncryptPassword(password, out keyword);
				Staff player = new Staff(id,fname, lname, email, birthdate, gender, address, town,password,keyword, company);

				return _dAL.UpdateAccount(player);
			}
			else return false;

		}

		public List<Player> GetPlayers()
		{
			DataSet data = _dAL.GetPlayers();
			List<Player> list = new List<Player>();
			if (data.Tables.Count > 0)
			{
				if (data.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow row in data.Tables[0].Rows)
					{
						list.Add(new Player(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]), Convert.ToString(row[3])
							, Convert.ToString(row[10]), Convert.ToDateTime(row[4]), Convert.ToChar(row[5]), Convert.ToString(row[6]), Convert.ToString(row[7]), Convert.ToString(row[8]),""));
					}
				}
			}
			return list;
		}

		public List<Account> GetAccounts()
		{
			DataSet data = _dAL.GetAccounts();
			List<Account> list = new List<Account>();
			if (data.Tables.Count > 0)
			{
				if (data.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow row in data.Tables[0].Rows)
                    {
						list.Add(new Account(Convert.ToInt32(row[0]),Convert.ToString( row[1]), Convert.ToString(row[2]), Convert.ToString(row[3])
							, Convert.ToDateTime(row[4]), Convert.ToChar(row[5]), Convert.ToString(row[6]), Convert.ToString(row[7]), Convert.ToString(row[8]),""));
                    }
				}
			}
			return list;
		}

		public List<Staff> GetStaff()
		{
			DataSet data = _dAL.GetStaff();
			List<Staff> list = new List<Staff>();
			if (data.Tables.Count > 0)
			{
				if (data.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow row in data.Tables[0].Rows)
					{
						company comp = new(Convert.ToInt32(row[11]), Convert.ToString(row[10]), Convert.ToString(12));
						list.Add(new Staff(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]), Convert.ToString(row[3])
							, Convert.ToDateTime(row[4]), Convert.ToChar(row[5]), 
							Convert.ToString(row[6]), Convert.ToString(row[7]), Convert.ToString(row[8]),
							"" ,comp));
					}
				}
			}
			return list;
		}

		public bool DeleteAccount(int id)
		{
			if (id > 0)
				return _dAL.DeleteAccount(id);
			else return false;
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
			if (ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				if(CheckValidEmail(email,out string keyword))
                {
					password = Account.EncryptPassword(password,keyword);
					if (CheckValidPassword(email, password))
                    {
						return true;
                    }
                }
				return false;
			}
			else return false;
		}

		public bool Login(string email, string password, string employeeKey)
		{
			if (ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				if (CheckValidEmail(email, out string keyword))
				{
					password = Account.EncryptPassword(password, keyword);
					if (CheckValidPassword(email, password))
					{
						if (CheckEmployeeKey(email, password))
							return true;
					}
				}
				return false;
			}
			else return false;
		}

		private bool CheckValidEmail(string email, out string key)
		{
			return _dAL.CheckValidEmail(email,out key);
		}

		private bool CheckValidPassword(string email, string password)
		{
			return _dAL.CheckValidPassword(email, password);
		}

		private bool CheckEmployeeKey(string email, string password)
		{
			return _dAL.CheckEmployeeKey(email, password);
		}
	}
}

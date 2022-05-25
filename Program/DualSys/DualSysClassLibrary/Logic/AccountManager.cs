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
			//first it validates the entered data on their respective input validation
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				//this makes the given password hashed/encrypt for security purpuses and returns the needed keyword/salt
				//to make the same hashed password again to be saved
				string encrytptPassword = Player.EncryptPassword(password, out string keyword);
				Staff player = new Staff(0, fname, lname, email, birthdate, gender, address, town, encrytptPassword, keyword,company);

				//at last it sends it to the database if there are errors it returns a false
				//and if succesfull it returns a true
				return _dAL.AddAccount(player);
			}
			else return false;
		}

		public bool UpdateAccount(int id, string fname, string lname, string email, string team, DateTime birthdate, char gender, string address, string town, string password)
		{
			//first it validates the entered data on their respective input validation
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") & ValidateInput(team, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string keyword = "";
				//if the password is not filled in then do nothing but if filled in then
				//it encrypts the given password and the keyword/salt that is needed to be saved
				if (password !="" & password!=null)
				password = Player.EncryptPassword(password, out keyword);
				//then it makes an instance of the player class
				Player player = new Player(id, fname, lname, email, team, birthdate, gender, address, town, password, keyword);

				//at last it sends it to the database if there are errors it returns a false
				//and if succesfull it returns a true
				return _dAL.UpdateAccount(player);
			}
			else return false;

		}
		
		public bool UpdateAccount(int id, string fname, string lname, string email, DateTime birthdate, char gender, string address, string town, string password, company company)
		{
			//first it validates the entered data on their respective input validation
			if (ValidateInput(fname, @"^[a-zA-Z]*$") & ValidateInput(lname, @"^[a-zA-Z]*$")
				& ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
				& ValidateInput(Convert.ToString(gender), @"^[a-zA-Z]*$") & ValidateInput(address, @"^[a-zA-Z0-9_\-\s]*$")
				& ValidateInput(town, @"^[a-zA-Z0-9_\-\s]*$"))
			{
				string keyword = "";
				//if the password is not filled in then do nothing but if filled in then
				//it encrypts the given password and the keyword/salt that is needed to be saved
				if (password != "" & password != null)
					password = Staff.EncryptPassword(password, out keyword);
				//then it makes an instance of the staff class
				Staff staff = new Staff(id,fname, lname, email, birthdate, gender, address, town,password,keyword, company);
				//at last it sends it to the database if there are errors it returns a false
				//and if succesfull it returns a true
				return _dAL.UpdateAccount(staff);
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
						//this makes an instance of the player class and adds it to the list
						//the given format for the info:
						//id,first name, last name, email, team, birthdate, gender, address,
						//town, password, keyword
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
						//this makes an instance of the account class and adds it to the list
						//the given format for the info:
						//id,first name, last name, email, birthdate, gender, address,
						//town, password, keyword 
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
						//Making a new company instance with the given info in format of id,name,location
						company comp = new(Convert.ToInt32(row[10]), Convert.ToString(row[11]), Convert.ToString(row[12]));
						
						//Making a new instance of the staff class with the info given by the row
						//the format of this is:
						//id,first name, last name, email, birthdate, gender, address,
						//town, password, keyword, company
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
			//first it checks if there is given a valid email address
			if (ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				//secondly it checks if there is any data in the database with the given email and if there is give the keyword for it back
				if(CheckValidEmail(email,out string keyword))
                {
					//after checking the email it encrypts the password that is given with the keyword that was given by checking the email
					password = Account.EncryptPassword(password,keyword);
					//Lastly it checks if the email and password are correct and that there is an account with the given email and password
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
			//first it checks if there is given a valid email address
			if (ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				//secondly it checks if there is any data in the database with the given email and if there is give the keyword for it back
				if (CheckValidEmail(email, out string keyword))
				{
					//after checking the email it encrypts the password that is given with the keyword that was given by checking the email
					password = Account.EncryptPassword(password, keyword);
					//then it checks if the email and password are correct and that there is an account with the given email and password
					if (CheckValidPassword(email, password))
					{
						//Lastly it checks for is the account actualy an employee one but
						if (CheckEmployeeKey(email, password))
							return true;
						else return false;
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

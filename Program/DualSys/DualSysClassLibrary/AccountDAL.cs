using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class AccountDAL : IAccountDAL
	{
		private bool CheckSingleResult(MySqlCommand command)
		{
			if( DBExecuter.ExecuteNoNQuery(command) >0)return true;
            else return false;
		}

		private DataSet CheckMultipleResults(MySqlCommand command)
		{
			throw new NotImplementedException();
		}

        public bool AddAccount(Player account)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO `ds_account`(`FirstName`, `LastName`, `Email`, `BirthDate`, `gender`, `address`, `town`, `password`, `keyword`) " +
                "VALUES (@fName,@lName,@mail,@birth,@gender,@address,@town,@pass,@key);" +
                "INSERT INTO `ds_player`(`AccountID`,`TeamName`) VALUES (LAST_INSERT_ID(),@team)";
            command.Parameters.AddWithValue("@fName", account.getFname());
            command.Parameters.AddWithValue("@lName",account.getLname());
            command.Parameters.AddWithValue("@mail",account.getEmail());
            command.Parameters.AddWithValue("@birth",account.getBirthDate());
            command.Parameters.AddWithValue("@gender",account.getGender());
            command.Parameters.AddWithValue("@address",account.getAddress());
            command.Parameters.AddWithValue("@town",account.getTown());
            command.Parameters.AddWithValue("@pass",account.getPassword());
            command.Parameters.AddWithValue("@key", account.getKey());
            command.Parameters.AddWithValue("@team", account.getTeam());

            return CheckSingleResult(command);
        }

        public bool AddAccount(Staff staff)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(Player player)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(Staff staff)
        {
            throw new NotImplementedException();
        }

        public DataSet GetPlayers()
        {
            throw new NotImplementedException();
        }

        public DataSet GetAccounts()
        {
            throw new NotImplementedException();
        }

        public DataSet GetStaff()
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

        public DataSet GetAccount(string email)
        {
            throw new NotImplementedException();
        }

        public DataSet GetAccount(string email, string employeeKey)
        {
            throw new NotImplementedException();
        }

        public bool CheckValidEmail(string email, out string key)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select Keyword From ds_account where Email=@mail";
            cmd.Parameters.Add(new MySqlParameter("@mail", email));
            DataSet set = DBExecuter.ExecuteReader(cmd);
            key = "";

            if (set.Tables.Count <= 0) return false;
            if (set.Tables[0].Rows.Count > 0)
            {
                key = set.Tables[0].Rows[0][0].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValidPassword(string email, string password)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select AccountID From ds_account where Email=@mail and Password=@pass";
            cmd.Parameters.Add(new MySqlParameter("@mail", email));
            cmd.Parameters.Add(new MySqlParameter("@pass", password));
            //Checks if there is any rows that can be returned with the command
            DataSet set = DBExecuter.ExecuteReader(cmd);
            if (set.Tables.Count > 0)
            {
                if (set.Tables[0].Rows.Count > 0)
                {                    
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public bool CheckEmployeeKey(string email, string password, string key)
        {
            throw new NotImplementedException();
        }
    }
}

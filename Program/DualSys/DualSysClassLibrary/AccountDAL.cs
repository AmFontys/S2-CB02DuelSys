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
			throw new NotImplementedException();
		}

		private DataSet CheckMultipleResults(MySqlCommand command)
		{
			throw new NotImplementedException();
		}

        public bool AddAccount(Player account)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool CheckValidPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckEmployeeKey(string email, string password, string key)
        {
            throw new NotImplementedException();
        }
    }
}

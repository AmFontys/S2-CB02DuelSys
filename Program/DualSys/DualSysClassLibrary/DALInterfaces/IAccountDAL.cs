using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace  DuelSysClassLibrary
{
	public interface IAccountDAL
	{
		bool AddAccount(Player account);

		bool AddAccount(Staff staff);

		bool UpdateAccount(Player player);

		bool UpdateAccount(Staff staff);

		DataSet GetPlayers();

		DataSet GetAccounts();

		DataSet GetStaff();

		bool DeleteAccount(int id);

		bool tournamentSignup(string playerEmail, int tournamentId);

		DataSet GetAccount(string email);

		DataSet GetAccount(string email, company company);

		bool CheckValidEmail(string email, out string key);

		bool CheckValidPassword(string email, string password);

		bool CheckEmployeeKey(string email, string password);
	}
}

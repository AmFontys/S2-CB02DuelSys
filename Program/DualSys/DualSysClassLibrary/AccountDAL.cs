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
            DataSet ds = DBExecuter.ExecuteReader(command);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                ds = null;
                return ds;
            }
        }

        public bool AddAccount(Player account)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", account.getEmail());
            if (CheckSingleResult(command)) return false;

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

        public bool Updateplayer(Player player)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", player.getEmail());
            if (CheckSingleResult(command)) return false;

            command.CommandText = "UPDATE `ds_account` SET `FirstName`=@fName,`LastName`=@lName," +
                "`Email`=@mail,`BirthDate`=@birth,`gender`=@gender,`address`=@address," +
                "`town`=@town ";
                if(player.getPassword().Length > 0)
            {
                command.CommandText += ",`password`= @pass,`keyword`=@key ";
            }
            command.CommandText += "WHERE AccountID=@id; ";
            command.CommandText += "UPDATE `ds_player`SET`TeamName`=@team where `playerID`=@id,";
            command.Parameters.AddWithValue("@id", player.getID());
            command.Parameters.AddWithValue("@fName", player.getFname());
            command.Parameters.AddWithValue("@lName", player.getLname());
            command.Parameters.AddWithValue("@mail", player.getEmail());
            command.Parameters.AddWithValue("@birth", player.getBirthDate());
            command.Parameters.AddWithValue("@gender", player.getGender());
            command.Parameters.AddWithValue("@address", player.getAddress());
            command.Parameters.AddWithValue("@town", player.getTown());
            command.Parameters.AddWithValue("@pass", player.getPassword());
            command.Parameters.AddWithValue("@key", player.getKey());
            command.Parameters.AddWithValue("@team", player.getTeam());

            return CheckSingleResult(command);
        }

        public bool UpdateAccount(Staff staff)
        {
            throw new NotImplementedException();
        }

        public DataSet GetPlayers()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `ds_account`.*, `ds_player`.`TeamName` " +
                "FROM `ds_account` RIGHT JOIN `ds_player` ON `ds_player`.`AccountID` = `ds_account`.`AccountID`; ";
            return CheckMultipleResults(command);
        }

        public DataSet GetAccounts()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText =" SELECT `ds_account`.* FROM `ds_account`";
            return CheckMultipleResults(command);
        }

        public DataSet GetStaff()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `a`.*, `s`.`staffKey`, `c`.`CompanyName`, `c`.`CompanyLocation`" +
                "FROM `ds_account` AS `a` RIGHT JOIN `ds_staff` AS `s` ON `s`.`AccountID` = `a`.`AccountID` " +
                "LEFT JOIN `ds_company` AS `c` ON `s`.`CompanyID` = `c`.`CompanyID`;";
            return CheckMultipleResults(command);
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
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select a.AccountID From ds_account  as aRIGHT JOIN ds_staff as s on a.AccountID=s.AccountID where Email=@mail and Password=@pass and EmployeeKey=@key";
            cmd.Parameters.Add(new MySqlParameter("@mail", email));
            cmd.Parameters.Add(new MySqlParameter("@pass", password));
            cmd.Parameters.Add(new MySqlParameter("@key", key));
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

        public bool UpdateAccount(Player player)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", player.getEmail());
            if (CheckSingleResult(command)) return false;

            command.CommandText = "UPDATE `ds_account` SET `FirstName`=@fName,`LastName`=@lName," +
                "`Email`=@mail,`BirthDate`=@birth,`gender`=@gender,`address`=@address," +
                "`town`=@town ";
            if (player.getPassword().Length > 0)
            {
                command.CommandText += ",`password`= @pass,`keyword`=@key ";
                command.Parameters.AddWithValue("@pass", player.getPassword());
                command.Parameters.AddWithValue("@key", player.getKey());
            }
            command.CommandText += "WHERE AccountID=@id; ";
            command.CommandText += "UPDATE `ds_player` SET `TeamName`=@team WHERE AccountID=@id; ";
            command.CommandText += "INSERT IGNORE INTO  `ds_player` (`TeamName`,`AccountID`) values(@team,@id)";
            command.Parameters.AddWithValue("@id", player.getID());
            command.Parameters.AddWithValue("@fName", player.getFname());
            command.Parameters.AddWithValue("@lName", player.getLname());
            command.Parameters.AddWithValue("@mail", player.getEmail());
            command.Parameters.AddWithValue("@birth", player.getBirthDate());
            command.Parameters.AddWithValue("@gender", player.getGender());
            command.Parameters.AddWithValue("@address", player.getAddress());
            command.Parameters.AddWithValue("@town", player.getTown());
            command.Parameters.AddWithValue("@team", player.getTeam());

            return CheckSingleResult(command);
        }
    }
}

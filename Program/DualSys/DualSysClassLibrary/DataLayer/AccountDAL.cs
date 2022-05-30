using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace  DuelSysClassLibrary
{
	public class AccountDAL : IAccountDAL
	{
        //the method below checks if there are any affected rows while executing the command
		private bool CheckSingleResult(MySqlCommand command)
		{
			if( DBExecuter.ExecuteNoNQuery(command) >0)return true;
            else return false;
		}
        //the method below checks to see for true or false on mutiple read entries
        private DataSet CheckMultipleResults(MySqlCommand command)
        {
            DataSet ds = DBExecuter.ExecuteReader(command);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds;
                }
                else return ds;
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
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", staff.getEmail());
            if (CheckSingleResult(command)) return false;

            command.CommandText = "INSERT INTO `ds_account`(`FirstName`, `LastName`, `Email`, `BirthDate`, `gender`, `address`, `town`, `password`, `keyword`) " +
                "VALUES (@fName,@lName,@mail,@birth,@gender,@address,@town,@pass,@key);" +
                "INSERT INTO `ds_staff`(`AccountID`,`CompanyID`) VALUES (LAST_INSERT_ID(),@company)";
            command.Parameters.AddWithValue("@fName", staff.getFname());
            command.Parameters.AddWithValue("@lName", staff.getLname());
            command.Parameters.AddWithValue("@birth", staff.getBirthDate());
            command.Parameters.AddWithValue("@gender", staff.getGender());
            command.Parameters.AddWithValue("@address", staff.getAddress());
            command.Parameters.AddWithValue("@town", staff.getTown());
            command.Parameters.AddWithValue("@pass", staff.getPassword());
            command.Parameters.AddWithValue("@key", staff.getKey());
            command.Parameters.AddWithValue("@company", staff.getCompany().getId());

            return CheckSingleResult(command);
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
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", staff.getEmail());
            if (CheckSingleResult(command)) return false;

            command.CommandText = "UPDATE `ds_account` SET `FirstName`=@fName,`LastName`=@lName," +
                "`Email`=@mail,`BirthDate`=@birth,`gender`=@gender,`address`=@address," +
                "`town`=@town ";
            if (staff.getPassword().Length > 0)
            {
                command.CommandText += ",`password`= @pass,`keyword`=@key ";
            }
            command.CommandText += "WHERE AccountID=@id; ";
            command.CommandText += "UPDATE `ds_staff` SET `CompanyID`=@company WHERE AccountID=@id; ";
            command.CommandText += "INSERT IGNORE INTO  `ds_staff` (`CompanyID`,`AccountID`) values(@company,@id)";
            command.Parameters.AddWithValue("@id", staff.getID());
            command.Parameters.AddWithValue("@fName", staff.getFname());
            command.Parameters.AddWithValue("@lName", staff.getLname());
            command.Parameters.AddWithValue("@birth", staff.getBirthDate());
            command.Parameters.AddWithValue("@gender", staff.getGender());
            command.Parameters.AddWithValue("@address", staff.getAddress());
            command.Parameters.AddWithValue("@town", staff.getTown());
            command.Parameters.AddWithValue("@pass", staff.getPassword());
            command.Parameters.AddWithValue("@key", staff.getKey());
            command.Parameters.AddWithValue("@company", staff.getCompany().getId());

            return CheckSingleResult(command);
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
            command.CommandText = "SELECT `a`.*, `c`.`CompanyID`, `c`.`CompanyName`,`c`.`CompanyLocation`" +
                "FROM `ds_account` AS `a` RIGHT JOIN `ds_staff` AS `s` ON `s`.`AccountID` = `a`.`AccountID` " +
                "LEFT JOIN `ds_company` AS `c` ON `s`.`CompanyID` = `c`.`CompanyID`;";
            return CheckMultipleResults(command);
        }

        public bool DeleteAccount(int id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE  From `ds_staff` where AccountID=@id;" +
                "DELETE FROM `ds_player` where AccountID=@id;" +
                "DELETE FROM `ds_account` where AccountID=@id";
            command.Parameters.AddWithValue("@id", id);
                return CheckSingleResult(command);
        }

        public bool tournamentSignup(string playerEmail, int tournamentId)
        {
            //also check on amount of signups
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select AccountID from `ds_account` where `Email`=@mail";
            command.Parameters.AddWithValue("@mail", playerEmail);
            if (CheckMultipleResults(command).Tables[0].Rows.Count<=0) return false;
            command.CommandText = "SELECT ds_tournament.maxPlayer from ds_tournament where ds_tournament.maxPlayer = (select COUNT(ds_signup.PlayerID) FROM ds_signup WHERE tournamentID = @tourId) AND tournamentID = @tourId";
            command.Parameters.AddWithValue("@tourID", tournamentId);
            if (CheckMultipleResults(command).Tables[0].Rows.Count > 0) 
                return false;

            command.CommandText = "INSERT IGNORE INTO `ds_signup` (tournamentID,PlayerID) " +
                " Values(@tourID, " +
                "(SELECT `AccountID` FROM `ds_player` WHERE `AccountID`= " +
                "(SELECT `AccountID` FROM `ds_account` WHERE `Email`= @mail)))";

            return CheckSingleResult(command);


        }

        public DataSet GetAccount(string email)
        {
            throw new NotImplementedException();
        }

        public DataSet GetAccount(string email, company company)
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

        public bool CheckEmployeeKey(string email, string password)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select a.AccountID From ds_account  as a RIGHT JOIN ds_staff as s on a.AccountID=s.AccountID where Email=@mail and Password=@pass";
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

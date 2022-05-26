using DuelSysClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
    public class SportDAL : ISportDAL
    {
        public DataSet GetSports()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from `ds_sport`";
            return DBExecuter.ExecuteReader(command);
        }
    }
}
